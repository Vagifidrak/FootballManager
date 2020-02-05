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
    public partial class AdminDashboard : Form
    {
        FootballManagerDB DB;
        public AdminDashboard()
        {
            DB = new FootballManagerDB();
            InitializeComponent();
        }
        #region btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Visible = true;
        }
        #endregion

        private void btnAddWOrker_Click(object sender, EventArgs e)
        {
            AddWorkerDashboard adwdb=new AddWorkerDashboard();
            adwdb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterStationApp fma = new EnterStationApp();
            fma.ShowDialog();

        }
    }
}
