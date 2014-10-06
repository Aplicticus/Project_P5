﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{

    public partial class frmLogin : Form
    {
        private DatabaseHandler handler;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            handler = new DatabaseHandler();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtUsername.Text, txtPassword.Text);
        }

        public void Login(string username, string password)
        {
            string sqlQuery = "SELECT * FROM tbl_Users";
            string department = "";
            if ((username != null && username.Length > 0) && (password != null && password.Length > 0))
            {
                SqlDataAdapter dAdapter = new SqlDataAdapter(sqlQuery, handler.GetConnection());
                DataSet dSet = new DataSet();

                handler.OpenConnection();

                dAdapter.Fill(dSet);

                DataTable dTable = dSet.Tables[0];
                handler.CloseConnection();
                foreach (DataRow dRow in dTable.Rows)
                {
                    if (username == dRow["USER_NAME"].ToString() && password == dRow["PASSWORD"].ToString())
                    {
                        department = dRow["DEPARTMENT"].ToString();

                        switch (department)
                        {
                            case "Administrator":
                                this.Hide();
                                frmAdmin formAdmin = new frmAdmin();
                                formAdmin.Show();
                                break;
                            case "Sales":
                                this.Hide();
                                frmSales formSales = new frmSales();
                                formSales.Show();
                                break;
                            //case "Finance":
                            //    this.Hide();
                            //    frmFinance = new frmFinance();
                            //    formFinance.Show();
                            //    break;
                            case "Development":
                                this.Hide();
                                frmDevelopment formDevelopment = new frmDevelopment();
                                formDevelopment.Show();
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect username, password!");
            }
        }
    }
}




