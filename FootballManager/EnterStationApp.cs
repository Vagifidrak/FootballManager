﻿using FootballManager.modal;
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
    public partial class EnterStationApp : Form
    {
        FootballManagerDB DB;
        public EnterStationApp()
        {
            DB = new FootballManagerDB();
            InitializeComponent();
        }
        #region Exit Button
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        #region Admin Load
        private void Admin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to football \n manager";
            lblWelcome.Visible = true;
        }

        #endregion

        #region Enter Click
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            if (login != "" && password != "")
            {
                Admin selectAdm = DB.Admins.FirstOrDefault(sadm => sadm.Login == login && sadm.Password == password);
                if (selectAdm != null)
                {
                    if (selectAdm.Password == password)
                    {
                        AdminDashboard AdmForm = new AdminDashboard();
                        AdmForm.ShowDialog();
                    }
                };


                Worker selectWrk = DB.Workers.FirstOrDefault(swrk => swrk.FullName == login && swrk.Password == password);
                if (selectWrk != null)
                {
                    if (selectWrk.Password == password)
                    {
                        WorkerFormC Wrkform = new WorkerFormC(selectWrk);
                        Wrkform.ShowDialog();
                    }
                }
                else
                {
                    lblError.Text = "Parol sehfdir";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Butun xanalari doldurun";
                lblError.Visible = true;
            }
        }


        #endregion

        private void EnterStationApp_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome";
            lblWelcome.Visible = true;
        }


    }
}
