﻿namespace Barroc_IT
{
    partial class frmAdmin
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
            this.pWelcome = new System.Windows.Forms.Panel();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdminDeactivatedUsers = new System.Windows.Forms.Button();
            this.btnAdminUserInfo = new System.Windows.Forms.Button();
            this.btnAdminAddUser = new System.Windows.Forms.Button();
            this.btnAdminHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbContr = new TablessControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.lblAdminWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxAdminDepartment = new System.Windows.Forms.ComboBox();
            this.txtAdminRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblAdminRepeatPassword = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.lblAdminDepartment = new System.Windows.Forms.Label();
            this.lblAdminRegister = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnProjectViewBack = new System.Windows.Forms.Button();
            this.dgvAdminUserInfo = new System.Windows.Forms.DataGridView();
            this.cUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDeactivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDeactivatedUsers = new System.Windows.Forms.Label();
            this.DGVDeactivatedUsers = new System.Windows.Forms.DataGridView();
            this.dUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dActivate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pWelcome.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbContr.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminUserInfo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDeactivatedUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pWelcome
            // 
            this.pWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.pWelcome.Controls.Add(this.lblAdminPanel);
            this.pWelcome.Location = new System.Drawing.Point(12, 12);
            this.pWelcome.Name = "pWelcome";
            this.pWelcome.Size = new System.Drawing.Size(984, 100);
            this.pWelcome.TabIndex = 0;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(305, 30);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(314, 39);
            this.lblAdminPanel.TabIndex = 0;
            this.lblAdminPanel.Text = "Administrator Panel";
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.SystemColors.Control;
            this.pButtons.Controls.Add(this.btnLogout);
            this.pButtons.Controls.Add(this.btnAdminDeactivatedUsers);
            this.pButtons.Controls.Add(this.btnAdminUserInfo);
            this.pButtons.Controls.Add(this.btnAdminAddUser);
            this.pButtons.Controls.Add(this.btnAdminHome);
            this.pButtons.Location = new System.Drawing.Point(12, 118);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(211, 600);
            this.pButtons.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(24, 533);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 43);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdminDeactivatedUsers
            // 
            this.btnAdminDeactivatedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDeactivatedUsers.Location = new System.Drawing.Point(24, 240);
            this.btnAdminDeactivatedUsers.Name = "btnAdminDeactivatedUsers";
            this.btnAdminDeactivatedUsers.Size = new System.Drawing.Size(165, 59);
            this.btnAdminDeactivatedUsers.TabIndex = 3;
            this.btnAdminDeactivatedUsers.Text = "Deactivated Users";
            this.btnAdminDeactivatedUsers.UseVisualStyleBackColor = true;
            this.btnAdminDeactivatedUsers.Click += new System.EventHandler(this.btnDeactivatedUsers_Click);
            // 
            // btnAdminUserInfo
            // 
            this.btnAdminUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUserInfo.Location = new System.Drawing.Point(24, 172);
            this.btnAdminUserInfo.Name = "btnAdminUserInfo";
            this.btnAdminUserInfo.Size = new System.Drawing.Size(165, 43);
            this.btnAdminUserInfo.TabIndex = 2;
            this.btnAdminUserInfo.Text = "User Information";
            this.btnAdminUserInfo.UseVisualStyleBackColor = true;
            this.btnAdminUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnAdminAddUser
            // 
            this.btnAdminAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAddUser.Location = new System.Drawing.Point(24, 104);
            this.btnAdminAddUser.Name = "btnAdminAddUser";
            this.btnAdminAddUser.Size = new System.Drawing.Size(165, 43);
            this.btnAdminAddUser.TabIndex = 1;
            this.btnAdminAddUser.Text = "Add User";
            this.btnAdminAddUser.UseVisualStyleBackColor = true;
            this.btnAdminAddUser.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAdminHome
            // 
            this.btnAdminHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminHome.Location = new System.Drawing.Point(24, 33);
            this.btnAdminHome.Name = "btnAdminHome";
            this.btnAdminHome.Size = new System.Drawing.Size(165, 43);
            this.btnAdminHome.TabIndex = 0;
            this.btnAdminHome.Text = "Home";
            this.btnAdminHome.UseVisualStyleBackColor = true;
            this.btnAdminHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbContr);
            this.panel1.Location = new System.Drawing.Point(229, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 600);
            this.panel1.TabIndex = 2;
            // 
            // tbContr
            // 
            this.tbContr.Controls.Add(this.tabPage1);
            this.tbContr.Controls.Add(this.tabPage2);
            this.tbContr.Controls.Add(this.tabPage3);
            this.tbContr.Controls.Add(this.tabPage4);
            this.tbContr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContr.Location = new System.Drawing.Point(0, 0);
            this.tbContr.Name = "tbContr";
            this.tbContr.SelectedIndex = 0;
            this.tbContr.Size = new System.Drawing.Size(767, 600);
            this.tbContr.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAdminHome);
            this.tabPage1.Controls.Add(this.lblAdminWelcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "startAdmin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.AutoSize = true;
            this.lblAdminHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.Location = new System.Drawing.Point(326, 39);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(90, 31);
            this.lblAdminHome.TabIndex = 32;
            this.lblAdminHome.Text = "Home";
            // 
            // lblAdminWelcome
            // 
            this.lblAdminWelcome.AutoSize = true;
            this.lblAdminWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminWelcome.Location = new System.Drawing.Point(104, 126);
            this.lblAdminWelcome.Name = "lblAdminWelcome";
            this.lblAdminWelcome.Size = new System.Drawing.Size(264, 25);
            this.lblAdminWelcome.TabIndex = 31;
            this.lblAdminWelcome.Text = "Welcome to the Admin Panel";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cBoxAdminDepartment);
            this.tabPage2.Controls.Add(this.txtAdminRepeatPassword);
            this.tabPage2.Controls.Add(this.lblAdminRepeatPassword);
            this.tabPage2.Controls.Add(this.txtAdminPassword);
            this.tabPage2.Controls.Add(this.lblAdminPassword);
            this.tabPage2.Controls.Add(this.txtAdminUsername);
            this.tabPage2.Controls.Add(this.lblAdminUsername);
            this.tabPage2.Controls.Add(this.lblAdminDepartment);
            this.tabPage2.Controls.Add(this.lblAdminRegister);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "addUser";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(672, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 60);
            this.button1.TabIndex = 189;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cBoxAdminDepartment
            // 
            this.cBoxAdminDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAdminDepartment.FormattingEnabled = true;
            this.cBoxAdminDepartment.Items.AddRange(new object[] {
            "Administrator",
            "Development",
            "Finance",
            "Sales"});
            this.cBoxAdminDepartment.Location = new System.Drawing.Point(423, 213);
            this.cBoxAdminDepartment.Name = "cBoxAdminDepartment";
            this.cBoxAdminDepartment.Size = new System.Drawing.Size(137, 21);
            this.cBoxAdminDepartment.Sorted = true;
            this.cBoxAdminDepartment.TabIndex = 35;
            // 
            // txtAdminRepeatPassword
            // 
            this.txtAdminRepeatPassword.Location = new System.Drawing.Point(423, 173);
            this.txtAdminRepeatPassword.Name = "txtAdminRepeatPassword";
            this.txtAdminRepeatPassword.Size = new System.Drawing.Size(137, 20);
            this.txtAdminRepeatPassword.TabIndex = 31;
            // 
            // lblAdminRepeatPassword
            // 
            this.lblAdminRepeatPassword.AutoSize = true;
            this.lblAdminRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRepeatPassword.Location = new System.Drawing.Point(215, 167);
            this.lblAdminRepeatPassword.Name = "lblAdminRepeatPassword";
            this.lblAdminRepeatPassword.Size = new System.Drawing.Size(171, 25);
            this.lblAdminRepeatPassword.TabIndex = 30;
            this.lblAdminRepeatPassword.Text = "Repeat Password:";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(423, 136);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(137, 20);
            this.txtAdminPassword.TabIndex = 29;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(215, 130);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(104, 25);
            this.lblAdminPassword.TabIndex = 28;
            this.lblAdminPassword.Text = "Password:";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Location = new System.Drawing.Point(423, 97);
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(137, 20);
            this.txtAdminUsername.TabIndex = 27;
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminUsername.Location = new System.Drawing.Point(215, 91);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(108, 25);
            this.lblAdminUsername.TabIndex = 26;
            this.lblAdminUsername.Text = "Username:";
            // 
            // lblAdminDepartment
            // 
            this.lblAdminDepartment.AutoSize = true;
            this.lblAdminDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDepartment.Location = new System.Drawing.Point(215, 207);
            this.lblAdminDepartment.Name = "lblAdminDepartment";
            this.lblAdminDepartment.Size = new System.Drawing.Size(119, 25);
            this.lblAdminDepartment.TabIndex = 24;
            this.lblAdminDepartment.Text = "Department:";
            // 
            // lblAdminRegister
            // 
            this.lblAdminRegister.AutoSize = true;
            this.lblAdminRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRegister.Location = new System.Drawing.Point(283, 14);
            this.lblAdminRegister.Name = "lblAdminRegister";
            this.lblAdminRegister.Size = new System.Drawing.Size(194, 31);
            this.lblAdminRegister.TabIndex = 19;
            this.lblAdminRegister.Text = "Register User";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnProjectViewBack);
            this.tabPage3.Controls.Add(this.dgvAdminUserInfo);
            this.tabPage3.Controls.Add(this.lblUserInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(759, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "userInfo";
            // 
            // btnProjectViewBack
            // 
            this.btnProjectViewBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectViewBack.Location = new System.Drawing.Point(669, 538);
            this.btnProjectViewBack.Name = "btnProjectViewBack";
            this.btnProjectViewBack.Size = new System.Drawing.Size(84, 60);
            this.btnProjectViewBack.TabIndex = 188;
            this.btnProjectViewBack.Text = "Back";
            this.btnProjectViewBack.UseVisualStyleBackColor = true;
            // 
            // dgvAdminUserInfo
            // 
            this.dgvAdminUserInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdminUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUserID,
            this.cUsername,
            this.cDepartment,
            this.cLastLogin,
            this.cDeactivated});
            this.dgvAdminUserInfo.Location = new System.Drawing.Point(6, 94);
            this.dgvAdminUserInfo.Name = "dgvAdminUserInfo";
            this.dgvAdminUserInfo.Size = new System.Drawing.Size(747, 439);
            this.dgvAdminUserInfo.TabIndex = 21;
            // 
            // cUserID
            // 
            this.cUserID.HeaderText = "UserID";
            this.cUserID.Name = "cUserID";
            this.cUserID.Visible = false;
            // 
            // cUsername
            // 
            this.cUsername.HeaderText = "Username";
            this.cUsername.Name = "cUsername";
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.Name = "cDepartment";
            // 
            // cLastLogin
            // 
            this.cLastLogin.HeaderText = "LastLogin";
            this.cLastLogin.Name = "cLastLogin";
            this.cLastLogin.ReadOnly = true;
            // 
            // cDeactivated
            // 
            this.cDeactivated.HeaderText = "Deactivated";
            this.cDeactivated.Name = "cDeactivated";
            this.cDeactivated.ReadOnly = true;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.Location = new System.Drawing.Point(273, 60);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(231, 31);
            this.lblUserInfo.TabIndex = 20;
            this.lblUserInfo.Text = "User Information";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.lblDeactivatedUsers);
            this.tabPage4.Controls.Add(this.DGVDeactivatedUsers);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(759, 574);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "deactivatedUsers";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(668, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 60);
            this.button2.TabIndex = 189;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblDeactivatedUsers
            // 
            this.lblDeactivatedUsers.AutoSize = true;
            this.lblDeactivatedUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeactivatedUsers.Location = new System.Drawing.Point(263, 56);
            this.lblDeactivatedUsers.Name = "lblDeactivatedUsers";
            this.lblDeactivatedUsers.Size = new System.Drawing.Size(255, 31);
            this.lblDeactivatedUsers.TabIndex = 23;
            this.lblDeactivatedUsers.Text = "Deactivated Users";
            // 
            // DGVDeactivatedUsers
            // 
            this.DGVDeactivatedUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVDeactivatedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDeactivatedUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dUserID,
            this.dUsername,
            this.dDepartment,
            this.dLastLogin,
            this.dActivate});
            this.DGVDeactivatedUsers.Location = new System.Drawing.Point(6, 90);
            this.DGVDeactivatedUsers.Name = "DGVDeactivatedUsers";
            this.DGVDeactivatedUsers.Size = new System.Drawing.Size(747, 435);
            this.DGVDeactivatedUsers.TabIndex = 22;
            // 
            // dUserID
            // 
            this.dUserID.HeaderText = "UserID";
            this.dUserID.Name = "dUserID";
            // 
            // dUsername
            // 
            this.dUsername.HeaderText = "Username";
            this.dUsername.Name = "dUsername";
            // 
            // dDepartment
            // 
            this.dDepartment.HeaderText = "Department";
            this.dDepartment.Name = "dDepartment";
            // 
            // dLastLogin
            // 
            this.dLastLogin.HeaderText = "Last Login";
            this.dLastLogin.Name = "dLastLogin";
            // 
            // dActivate
            // 
            this.dActivate.HeaderText = "Activate";
            this.dActivate.Name = "dActivate";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.pWelcome.ResumeLayout(false);
            this.pWelcome.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbContr.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminUserInfo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDeactivatedUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pWelcome;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnAdminDeactivatedUsers;
        private System.Windows.Forms.Button btnAdminUserInfo;
        private System.Windows.Forms.Button btnAdminAddUser;
        private System.Windows.Forms.Button btnAdminHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private TablessControl tbContr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAdminWelcome;
        private System.Windows.Forms.TextBox txtAdminRepeatPassword;
        private System.Windows.Forms.Label lblAdminRepeatPassword;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.Label lblAdminDepartment;
        private System.Windows.Forms.Label lblAdminRegister;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView DGVDeactivatedUsers;
        private System.Windows.Forms.Label lblDeactivatedUsers;
        private System.Windows.Forms.ComboBox cBoxAdminDepartment;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvAdminUserInfo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dActivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDeactivated;
        private System.Windows.Forms.Button btnProjectViewBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}