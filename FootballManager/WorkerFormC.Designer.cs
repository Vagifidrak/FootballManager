namespace FootballManager
{
    partial class WorkerFormC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtFrsName = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbStadium = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChangeRoom = new System.Windows.Forms.ComboBox();
            this.dtgStart = new System.Windows.Forms.DateTimePicker();
            this.dtgEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1128, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(299, 73);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Yellow;
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnter.Location = new System.Drawing.Point(535, 558);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(198, 72);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Registration";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtFrsName
            // 
            this.txtFrsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFrsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtFrsName.Location = new System.Drawing.Point(46, 137);
            this.txtFrsName.Name = "txtFrsName";
            this.txtFrsName.Size = new System.Drawing.Size(312, 37);
            this.txtFrsName.TabIndex = 11;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.lblLogin.Location = new System.Drawing.Point(41, 105);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(131, 29);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtLastName.Location = new System.Drawing.Point(46, 273);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(312, 37);
            this.txtLastName.TabIndex = 15;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblLastName.Location = new System.Drawing.Point(41, 241);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(128, 29);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPhone.Location = new System.Drawing.Point(46, 429);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(312, 37);
            this.txtPhone.TabIndex = 17;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPhone.Location = new System.Drawing.Point(41, 395);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 29);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone";
            // 
            // cmbStadium
            // 
            this.cmbStadium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbStadium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbStadium.FormattingEnabled = true;
            this.cmbStadium.Location = new System.Drawing.Point(578, 137);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(416, 38);
            this.cmbStadium.TabIndex = 18;
            this.cmbStadium.SelectedIndexChanged += new System.EventHandler(this.cmbStadium_SelectedIndexChanged);
            // 
            // lblStation
            // 
            this.lblStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStation.AutoSize = true;
            this.lblStation.BackColor = System.Drawing.Color.Transparent;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStation.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStation.Location = new System.Drawing.Point(573, 105);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(87, 29);
            this.lblStation.TabIndex = 19;
            this.lblStation.Text = "Station";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(573, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "ChangeRoom";
            // 
            // cmbChangeRoom
            // 
            this.cmbChangeRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbChangeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChangeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbChangeRoom.FormattingEnabled = true;
            this.cmbChangeRoom.Location = new System.Drawing.Point(578, 241);
            this.cmbChangeRoom.Name = "cmbChangeRoom";
            this.cmbChangeRoom.Size = new System.Drawing.Size(416, 38);
            this.cmbChangeRoom.TabIndex = 20;
            // 
            // dtgStart
            // 
            this.dtgStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtgStart.Location = new System.Drawing.Point(578, 345);
            this.dtgStart.Name = "dtgStart";
            this.dtgStart.Size = new System.Drawing.Size(416, 35);
            this.dtgStart.TabIndex = 22;
            // 
            // dtgEnd
            // 
            this.dtgEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtgEnd.Location = new System.Drawing.Point(578, 440);
            this.dtgEnd.Name = "dtgEnd";
            this.dtgEnd.Size = new System.Drawing.Size(416, 35);
            this.dtgEnd.TabIndex = 23;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStart.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStart.Location = new System.Drawing.Point(573, 313);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(196, 29);
            this.lblStart.TabIndex = 24;
            this.lblStart.Text = "Reservation Start";
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnd.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEnd.Location = new System.Drawing.Point(573, 408);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(190, 29);
            this.lblEnd.TabIndex = 25;
            this.lblEnd.Text = "Reservation End";
            // 
            // WorkerFormC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1258, 711);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtgEnd);
            this.Controls.Add(this.dtgStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbChangeRoom);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.cmbStadium);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtFrsName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerFormC";
            this.Text = "WorkerFormC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkerFormC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtFrsName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbStadium;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChangeRoom;
        private System.Windows.Forms.DateTimePicker dtgStart;
        private System.Windows.Forms.DateTimePicker dtgEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
    }
}