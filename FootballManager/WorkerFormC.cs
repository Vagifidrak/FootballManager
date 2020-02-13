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
        User statSelect = null;
        RezervationStation ResStar = null;

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

        #region Button-Reservation-Edit-Delete
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


        #region Fill-cmb-Statium
        private void FillcmbStadium()
        {
          cmbStadium.Items.AddRange(DB.Stations.Select(st => st.StationNumber).ToArray());
        }
        #endregion

        #region Fill-cmb-Room
        private void FillcmbRoom()
        {
            cmbChangeRoom.Items.AddRange(DB.ChangeRooms.Select(ch => ch.RoomNumber).ToArray());

        }
        #endregion

        #region FilldtgStation

        private void FilldtgStation()
        {
         
            
            dtgStat.DataSource = DB.RezervationStations.Select(rs => new
            {
                rs.ID,
                rs.User.FirstName,
                rs.User.LastName,
                rs.User.Phone,
                rs.Station.StationNumber,
                rs.ChangeRoom.RoomNumber,
                rs.StartResDate,
                rs.EndResDate

            }).ToList();
            dtgStat.Columns[0].Visible = false;
        }
        #endregion

        #region WorkerForm Load
        private void WorkerFormC_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to football manager";
            lblWelcome.Visible = true;


            FilldtgStation();
            FillcmbStadium();
            FillcmbRoom();
        }
        #endregion

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
                    RoomID=roomId,
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


        #region doubleClick DataGridView
        private void dtgStat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnEdDel("dda");

            int resID = (int)dtgStat.Rows[e.RowIndex].Cells[0].Value;

             var selectRestor = DB.RezervationStations.FirstOrDefault(us => us.ID == resID);
             
             txtFrsName.Text = selectRestor.User.FirstName;
             txtLastName.Text = selectRestor.User.LastName;
             txtPhone.Text = selectRestor.User.Phone;
             cmbStadium.Text = selectRestor.Station.StationNumber;
             cmbChangeRoom.Text = selectRestor.ChangeRoom.RoomNumber;
             dtgStart.Value = selectRestor.StartResDate.Value;
             dtgEnd.Value = selectRestor.EndResDate.Value;
             FilldtgStation();
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string FirstName = txtFrsName.Text;
            string LastName = txtLastName.Text;
            string Phone = txtPhone.Text;
            string statNum = cmbStadium.Text;
            string rommNum = cmbChangeRoom.Text;
            DateTime stdt = dtgStart.Value;
            DateTime endt = dtgEnd.Value;

            int statId = DB.Stations.FirstOrDefault(st => st.StationNumber == statNum).ID;
            int chId = DB.ChangeRooms.FirstOrDefault(ch => ch.RoomNumber == rommNum).ID;
            
            string[] listStat ={
                FirstName,
                LastName,
                Phone,
                statNum,
                rommNum,
                endt.ToString(),
                stdt.ToString(),
            };
            if (MainExtansion.IsEmpty(listStat, ""))
            {
                statSelect.FirstName = FirstName;//Burda error cixir. 
                statSelect.LastName = LastName;
                statSelect.Phone = Phone;
                dtgStart.Value = stdt;
                dtgEnd.Value = endt;
                ResStar.StationID = statId;
                statSelect.ID = chId;
                DB.SaveChanges();
                FilldtgStation();
            }
        }
    }

}
