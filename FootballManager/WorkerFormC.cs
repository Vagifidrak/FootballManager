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
        public WorkerFormC()
        {
            InitializeComponent();
        }
        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Load WorkerForm
        private void WorkerFormC_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "İt's nice to work with you";
            lblWelcome.Visible = true;
        }

        #endregion

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string FrsName = txtFrsName.Text;
            string LstName = txtLastName.Text;
            string Phone = txtPhone.Text;
            string Std = cmbStadium.Text;
            string ChangeRoom = cmbChangeRoom.Text;

            string[] emp =
            {
                FrsName,
                LstName,
                Phone,
                Std,
                ChangeRoom
            };
            //01.28.2019  
        }
    }
}
