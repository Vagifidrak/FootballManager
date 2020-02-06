using FootballManager.modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager
{
    public partial class WorkerFormC : Form
    {
        Worker worky;
        FootballManagerDB DB;
        Station selectStat=null;
        User selectUser = null;

        public WorkerFormC(Worker saxta)
        {
            worky = saxta;
            DB = new FootballManagerDB();
            InitializeComponent();
        }
        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button Reservation-Edit-Delete
        private void BtnEdDel(string txt)
        {
            if (txt == "add")
            {

                btnEnter.Visible = true;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            else
            {
                btnEnter.Visible = false;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
            }
        }

        #endregion



        private void FillcmbStadium()
        {
          cmbStadium.Items.AddRange(DB.Stations.Select(st => st.StationNumber).ToArray());
        }

        private void FillcmbRoom()
        {
            cmbChangeRoom.Items.AddRange(DB.ChangeRooms.Select(ch => ch.RoomNumber).ToArray());

        }
        private void WorkerFormC_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to football manager";
            lblWelcome.Visible = true;

            dtgStat.DataSource = DB.RezervationStations.Select(rs => new
            {
                rs.ID,
                rs.User.FirstName,
                rs.User.LastName,
                rs.User.Phone,
                rs.Station.StationNumber,
                rs.Station.ChangeRooms.Count,
                rs.StartResDate,
                rs.EndResDate

            }).ToList();
            dtgStat.Columns[0].Visible = false;

            FillcmbStadium();
            FillcmbRoom();
        }
        #region IndexChanged Stadim
        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            int statId = DB.Stations.FirstOrDefault(st => st.StationNumber == cmbStadium.Text).ID;
            cmbChangeRoom.Items.Clear();
            cmbChangeRoom.Items.AddRange(DB.ChangeRooms.Where(ch => ch.StationID == statId).Select(cm => cm.RoomNumber).ToArray());
        }
        #endregion

        #region Enter CLick
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string frsName = txtFrsName.Text;
            string lstName = txtLastName.Text; 
            string phone = txtPhone.Text;
            string stati = cmbStadium.Text;
            string room = cmbChangeRoom.Text;
            DateTime StartDat = dtgStart.Value;
            DateTime EndDat = dtgEnd.Value;
            User newUser;
            if (!DB.Users.Any(us=>us.Phone==phone))
            {
               newUser= DB.Users.Add(new User
                {
                    FirstName = frsName,
                    LastName = lstName,
                    Phone = phone,
               });

                DB.SaveChanges();
            }
            else
            {
                newUser = DB.Users.FirstOrDefault(us => us.Phone == phone);
            }

            int StatID = DB.Stations.FirstOrDefault(st => st.StationNumber == stati).ID;
            int roomId = DB.ChangeRooms.FirstOrDefault(ch => ch.RoomNumber == room).ID;
            int workID = worky.ID;

            RezervationStation newReserv;
            if (!DB.RezervationStations.Any(rs => rs.StartResDate == StartDat))
            {
                newReserv = DB.RezervationStations.Add(new RezervationStation
                {

                    UserID = newUser.ID,
                    StationID = StatID,
                    WorkerID= workID,

                    StartResDate = StartDat,
                    EndResDate = EndDat
                });
            }
            else
            {
                newReserv = DB.RezervationStations.FirstOrDefault(rst => rst.StartResDate == StartDat);
            }
            MessageBox.Show("Add new Reservation success","sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DB.SaveChanges();
        }

        #endregion

        private void dtgStat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int statid = (int)dtgStat.Rows[e.RowIndex].Cells[3].Value;
            int userid = (int)dtgStat.Rows[e.RowIndex].Cells[0].Value;
            string dtid =Convert.ToString(dtgStat.Rows[e.RowIndex].Cells[5].Value);
            string selectDat = DB.RezervationStations.FirstOrDefault(dt => dt.StartResDate = dtid);// nese problem qalir bu hisseni duzeltmek
            selectUser = DB.Users.FirstOrDefault(us => us.ID == statid);
            selectStat = DB.Stations.FirstOrDefault(sst => sst.ID == statid);
            cmbStadium.Text = selectStat.StationNumber;
            cmbStadium.Text = Convert.ToString(selectStat.StationNumber);
            cmbChangeRoom.Text = Convert.ToString(selectStat.ChangeRooms.Count);
            txtFrsName.Text = selectUser.FirstName;
            txtLastName.Text = selectUser.LastName;
            txtPhone.Text = selectUser.Phone;

            BtnEdDel("xtx");
        }
    }

}
