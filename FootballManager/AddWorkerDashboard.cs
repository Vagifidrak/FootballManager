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
    public partial class AddWorkerDashboard : Form
    {
        FootballManagerDB DB;
        public AddWorkerDashboard()
        {
            DB = new FootballManagerDB();
            InitializeComponent();
        }

        private void AddWorkerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = " New Worker add aplication";
            dtgEdit.DataSource = DB.Workers.Select(wr => new
            {
                wr.ID,
                wr.FullName,
                wr.Phone,
                wr.Password,
            }).ToList();
            dtgEdit.Columns[0].Visible = false; 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string lgn = txtLogin.Text;
            string phn = txtPhone.Text;
            string pass = txtPassword.Text;
            string ckpass = txtckPassword.Text;

            Worker newWorker;
            if (pass == ckpass)
            {
                newWorker = DB.Workers.Add(new Worker
                {
                    FullName = lgn,
                    Phone = phn,
                    Password = pass.HashMe(),
                });
                MessageBox.Show("Added New Worker");
            };
            DB.SaveChanges();
        }
    }
}
