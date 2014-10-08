﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class frmDevelopment : Form
    {
        private DatabaseHandler handler;
        private int selectedCustomer;
        public frmDevelopment(DatabaseHandler handler)
        {
            InitializeComponent();
            cBoxCustomerSearch.SelectedIndex = 0;
            this.handler = handler;           
        }

        private void btnDevSelectCustomer_Click(object sender, EventArgs e)
        {
            tbContr.SelectedIndex = 1;
            DGVUserInfo.Rows.Clear();
            GetCustomers(); 
        }

        private void GetCustomers()
        {
            string sqlQuery = "SELECT * FROM tbl_Customers ";
            SqlDataAdapter DA = new SqlDataAdapter(sqlQuery, handler.GetConnection());
            DataSet DS = new DataSet();            
            DA.Fill(DS);
            DataTable DT = DS.Tables[0];

            foreach (DataRow dr in DT.Rows)
            {
                DGVUserInfo.Rows.Add(dr.ItemArray);
            }          
        }       

        private void btnEditFields_Click(object sender, EventArgs e)
        {
            if (btnEditFields.Text == "Edit Fields")
            {
                txtMaintenance.ReadOnly = false;
                txtOpenProject.ReadOnly = false;
                txtApplications.ReadOnly = false;
                txtHardware.ReadOnly = false;
                txtSoftware.ReadOnly = false;
                txtAppointments.ReadOnly = false;
                txtInternalContact.ReadOnly = false;
                btnEditFields.Text = "Save Changes";
            }
            else if(btnEditFields.Text == "Save Changes")
            {
                txtMaintenance.ReadOnly = true;
                txtOpenProject.ReadOnly = true;
                txtApplications.ReadOnly = true;
                txtHardware.ReadOnly = true;
                txtSoftware.ReadOnly = true;
                txtAppointments.ReadOnly = true;
                txtInternalContact.ReadOnly = true;
                btnEditFields.Text = "Edit Fields";
                //Svae changes needs to be implemented
            }
        }

        private void LoadCustomerDetails()
        {
            string sqlQueryCus = "SELECT * FROM tbl_Customers WHERE CUSTOMER_ID='" + selectedCustomer + "'";
            SqlDataAdapter DACus = new SqlDataAdapter(sqlQueryCus, handler.GetConnection());
            DataSet DSCus = new DataSet();
            DACus.Fill(DSCus);
            DataTable DTCus = DSCus.Tables[0];
            DataRow DRCus = DTCus.Rows[0];


            txtCompanyName.Text = DRCus["COMPANYNAME"].ToString();
            txtAddress1.Text = DRCus["ADDRESS1"].ToString();
            txtPostalCode1.Text = DRCus["POSTALCODE1"].ToString();
            txtPhoneNumber1.Text = DRCus["PHONE_NR1"].ToString();
            txtFaxNumber.Text = DRCus["FAXNUMBER"].ToString();
            txtEmail.Text = DRCus["EMAIL"].ToString();
            txtContactPerson.Text = DRCus["CONTACTPERSON"].ToString();
            txtMaintenance.Text = DRCus["MAINT_CONTR"].ToString();
            txtOpenProject.Text = DRCus["OPEN_PROJ"].ToString();
            txtHardware.Text = DRCus["HARDWARE"].ToString();
            txtSoftware.Text = DRCus["SOFTWARE"].ToString();
        }

       /* private void LoadAppointmentDetails()
        {
            string sqlQueryApo = "SELECT * FROM tbl_Appointments";

            SqlDataAdapter DAApo = new SqlDataAdapter(sqlQueryApo, handler.GetConnection());
            DataSet DSApo = new DataSet();
            DAApo.Fill(DSApo);
            DataTable DTApo = DSApo.Tables[0];
            DataRow DRApo = DTApo.Rows[0];

            txtAppointments.Text = DRApo["APPOIN_DATE"].ToString();
            txtInternalContact.Text = DRApo["INT_CONTACT"].ToString();
        }*/

       /* private void LoadProjectDetails()
        {
            string sqlQuery = "SELECT * FROM tbl_Projects WHERE CUSTOMER_ID='" + selectedCustomer + "'";
            SqlDataAdapter DA = new SqlDataAdapter(sqlQuery, handler.GetConnection());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DataTable DT = DS.Tables[0];

            foreach (DataRow dr in DT.Rows)
            {
                DGVUserInfo.Rows.Add(dr.ItemArray);
            }            
        } */      
        
        private void DGVUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVUserInfo.Columns["cViewButton"].Index)
            {
                selectedCustomer = int.Parse(DGVUserInfo.Rows[e.RowIndex].Cells["cViewButton"].Value.ToString());
                LoadCustomerDetails();
                //LoadAppointmentDetails();
                //LoadProjectDetails();

                tbContr.SelectedIndex = 2;
            }
        }

        private void btnViewProjects_Click(object sender, EventArgs e)
        {
            //LoadProjectDetails();
            tbContr.SelectedIndex = 3;
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text.Length > 0)
            {
                if (cBoxCustomerSearch.SelectedItem.ToString() == "Company Name")
                {
                    string sqlQuery = "SELECT * FROM tbl_Customers WHERE COMPANYNAME='" + txtCustomerSearch.Text + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(sqlQuery, handler.GetConnection());
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    DataTable DT = DS.Tables[0];
                    DGVUserInfo.Rows.Clear();
                    foreach (DataRow dr in DT.Rows)
                    {
                        DGVUserInfo.Rows.Add(dr.ItemArray);
                    }
                }
            }
            else
            {
                string sqlQuery = "SELECT * FROM tbl_Customers";
                SqlDataAdapter DA = new SqlDataAdapter(sqlQuery, handler.GetConnection());
                DataSet DS = new DataSet();
                DA.Fill(DS);
                DataTable DT = DS.Tables[0];
                DGVUserInfo.Rows.Clear();
                foreach (DataRow dr in DT.Rows)
                {
                    DGVUserInfo.Rows.Add(dr.ItemArray);
                }
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            tbContr.SelectedIndex = 5;
        }
    }
}
