﻿namespace Barroc_IT
{
    /// <summary>
    /// Class for getting the correct query.
    /// </summary>
    public class SqlQueryHandler
    {
        /// <summary>
        /// The default constructor
        /// </summary>
        public SqlQueryHandler()
        {

        }
        // Default OuterJoins
        string OuterJoinProCus =
        "FULL OUTER JOIN tbl_Projects ON tbl_Customers.CUSTOMER_ID=tbl_Projects.CUSTOMER_ID ";
        string OuterJoinInvPro =
        "FULL OUTER JOIN tbl_Invoices ON tbl_Projects.PROJECT_ID=tbl_Invoices.PROJECT_ID ";
        string OuterJoinApoCus =
        "FULL OUTER JOIN tbl_Appointments ON tbl_Customers.CUSTOMER_ID=tbl_Appointments.CUSTOMER_ID ";

        // Load Querys
        string loadCustomers = "SELECT * FROM tbl_Customers WHERE ARCHIVED = 'FALSE'";
        string loadUsers = "SELECT tbl_Users.USER_ID, tbl_Users.USER_NAME, tbl_Users.DEPARTMENT, tbl_Users.DEACTIVATED, tbl_Users.LAST_LOGIN FROM tbl_Users";
        string loadInvoiceDetails = "SELECT * FROM tbl_Customers {0}{1}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Projects.PROJECT_ID=@projectID AND tbl_Invoices.INVOICE_ID = @invoiceID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string loadProjectDetails = "SELECT * FROM tbl_Customers {0}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Projects.PROJECT_ID=@projectID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string loadAppointmentDetails = "SELECT * FROM tbl_Customers {0}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Appointments.APPOINTMENT_ID=@appointmentID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string loadCustomerDetails = "SELECT * FROM tbl_Customers WHERE CUSTOMER_ID=@customerID AND ARCHIVED = 'FALSE'";
        string loadProjects = "SELECT tbl_Projects.PROJECT_ID, tbl_Customers.COMPANYNAME, tbl_Projects.NAME, tbl_Projects.DEADLINE, " +
        "tbl_Projects.SUBJECT, tbl_Projects.VALUE, tbl_Projects.COMPLETED FROM tbl_Customers {0}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string loadInvoices = "SELECT tbl_Invoices.INVOICE_ID, tbl_Customers.COMPANYNAME, " +
        "tbl_Projects.NAME, tbl_Invoices.INVOICE_VALUE, tbl_Invoices.INVOICE_END_DATE, " +
        "tbl_Invoices.INVOICE_SEND, tbl_Invoices.PAID FROM tbl_Customers {0}{1}WHERE tbl_Projects.PROJECT_ID=@projectID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string loadAppointments = "SELECT tbl_Appointments.APPOINTMENT_ID, tbl_Customers.COMPANYNAME, tbl_Appointments.APPOIN_DATE, tbl_Appointments.SUBJECT, tbl_Appointments.INT_CONTACT, tbl_Appointments.ACCOMPLISHED FROM tbl_Customers {0}WHERE tbl_Appointments.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";

        //Insert querys
        string addInvoice = "INSERT INTO tbl_Invoices (PROJECT_ID, INVOICE_VALUE, INVOICE_END_DATE, INVOICE_SEND, PAID) " +
        "VALUES (@SelectedProject, @InvoiceVal, @InvoiceEndDate, @InvoiceSend, @Paid)";
        string addProject = "INSERT INTO tbl_Projects (CUSTOMER_ID, NAME, DEADLINE, SUBJECT, VALUE, COMPLETED) " +
        "VALUES (@SelectedCustomer, @Name, @Deadline, @Subject, @Value, @Completed)";
        string addUser = "INSERT INTO tbl_Users (USER_NAME, PASSWORD, DEPARTMENT, DEACTIVATED, LAST_LOGIN) " +
        "VALUES (@Username, @Password, @Department, @Deactivated, @Last_Login)";
        string addCustomer = "INSERT INTO tbl_Customers (COMPANYNAME, ADDRESS1, POSTALCODE1, RESIDENCE1, ADDRESS2, " +
        "POSTALCODE2, RESIDENCE2, CONTACTPERSON, INITIALS, PHONE_NR1, PHONE_NR2, FAXNUMBER, EMAIL, PROSPECT, ARCHIVED) " +
        "VALUES (@CompanyName, @Address1, @PostalCode1, @Residence1, @Address2, @PostalCode2, @Residence2, @ContactPerson, " +
        "@Initials, @PhoneNr1, @PhoneNr2, @FaxNumber, @Email, @Prospect, 'FALSE')";
        string addAppointment = "INSERT INTO tbl_Appointments (CUSTOMER_ID, APPOIN_DATE, SUBJECT, INT_CONTACT, ACCOMPLISHED) VALUES(@customerID, @appoinDate, @subject, @intContact, @accomplished);";

        
        // Count Querys
        string countPaidInvoices = "SELECT SUM (INVOICE_VALUE) FROM tbl_Customers {0}{1}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Invoices.PAID='True' AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countOpenInvoices = "SELECT COUNT (INVOICE_ID) FROM tbl_Customers {0}{1}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Projects.PROJECT_ID=@projectID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countAllInvoices = "SELECT COUNT (INVOICE_ID) FROM tbl_Customers {0}{1}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countInvoices = "SELECT SUM (INVOICE_VALUE) FROM tbl_Customers {0}{1}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countProjects = "SELECT COUNT (PROJECT_ID) FROM tbl_Customers {0}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countValues = "SELECT SUM (INVOICE_VALUE) FROM tbl_Invoices WHERE tbl_Invoices.PROJECT_ID=@customerID";
        string countAppointments = "SELECT COUNT (APPOINTMENT_ID) FROM tbl_Customers {0} WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countOffers = "SELECT COUNT (OFFER_NUMBERS) FROM tbl_Customers WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Customers.ARCHIVED = 'FALSE'";
        string countProjectsTable = "SELECT COUNT (PROJECT_ID) FROM tbl_Customers {0}WHERE tbl_Customers.CUSTOMER_ID=@customerID AND tbl_Projects.COMPLETED=@Completed AND tbl_Customers.ARCHIVED = 'FALSE'";

        //Update Querys        
        string updateFinCustomersInfo = "UPDATE tbl_Customers SET ACC_ID=@AccountID, " +
        "LIMIT=@Limit, LEDGER_ID=@LedgerID, BTW_CODE=@BTWcode, BKR=@Bkr WHERE CUSTOMER_ID=@customerID";
        string updateFinProjectInfo = "SELECT tbl_Projects.PROJECT_ID, tbl_Customers.COMPANYNAME, tbl_Projects.NAME, " +
        "tbl_Projects.DEADLINE, tbl_Projects.SUBJECT FROM tbl_Customers {0}WHERE tbl_Customers.CUSTOMER_ID=@customerID";
        string updateDevCustomerInfo = "UPDATE tbl_Customers SET HARDWARE=@Hardware, SOFTWARE=@Software WHERE CUSTOMER_ID=@customerID";
        string updateDevProjectInfo = "UPDATE tbl_Projects SET NAME=@ProjectName, DEADLINE=@Deadline, " +
        "SUBJECT=@Subject, VALUE=@Value WHERE PROJECT_ID=@ProjectID";
        string updateDevAppointmentInfo = "UPDATE tbl_Appointments SET INT_CONTACT=@InternalContact " +
        "WHERE CUSTOMER_ID=@customerID";
        string updateSalCustomerInfo = "UPDATE tbl_Customers SET COMPANYNAME=@CompanyName, ADDRESS1=@Address1, " +
        "POSTALCODE1=@PostalCode1, RESIDENCE1=@Residence1, PHONE_NR1=@PhoneNumber1, ADDRESS2=@Address2, " +
        "POSTALCODE2=@PostalCode2, RESIDENCE2=@Residence2, PHONE_NR2=@PhoneNumber2, CONTACTPERSON=@ContactPerson, " +
        "INITIALS=@Initials, OFFER_STAT=@OfferStatus, FAXNUMBER=@FaxNumber, EMAIL=@Email, PROSPECT=@Prospect, " +
        "DATE_OF_ACTION=@DateOfAction, LAST_CONTACT_DATE=@LastContactDate, NEXT_ACTION=@NextAction " +
        "WHERE CUSTOMER_ID=@customerID";
        string updateAdmActivate = "UPDATE tbl_Users SET DEACTIVATED=@Deactivated WHERE USER_ID=@userID";
        string updateLastLogin = "UPDATE tbl_Users SET LAST_LOGIN=@Last_Login WHERE USER_ID=@userID AND USER_NAME=@User_Name";
        string updateFinPayment = "UPDATE tbl_Invoices SET PAID=@Paid WHERE PROJECT_ID=@projectID AND INVOICE_ID=@invoiceID";
        string updateAppointment = "UPDATE tbl_Appointments SET INT_CONTACT=@Int_Contact, SUBJECT=@Subject, APPOIN_DATE=@Appoin_Date " +
        "WHERE CUSTOMER_ID=@customerID";
        string updateAccomplish = "UPDATE tbl_Appointments SET ACCOMPLISHED=@Accomplished WHERE CUSTOMER_ID=@customerID AND APPOINTMENT_ID=@AppointmentID";
        string copyCountInvoicesToBalance = "UPDATE tbl_Customers SET BALANCE=@Balance WHERE CUSTOMER_ID=@customerID";
        string archiveProject = "UPDATE tbl_Projects SET COMPLETED=@Completed WHERE PROJECT_ID = @projectID";
        string loadProjectStatus = "SELECT p.NAME, c.COMPANYNAME, p.DEADLINE FROM tbl_Projects p, tbl_Customers c WHERE p.CUSTOMER_ID = c.CUSTOMER_ID AND p.COMPLETED = 'FALSE' AND c.ARCHIVED = 'FALSE' ORDER BY p.DEADLINE;";
        string setCustomerArchived = "UPDATE tbl_Customers SET ARCHIVED=@Archived WHERE CUSTOMER_ID=@customerID";
        string selectArchivedCustomers = "SELECT * FROM tbl_Customers WHERE ARCHIVED = 'TRUE';";
        public string GetQuery(Query query)
        {
            // Default
            string sqlQuery = "";
            switch (query)
            {
                case Query.copyCountInvoicesToBalance:
                    sqlQuery = copyCountInvoicesToBalance;
                    break;

                case Query.loadCustomers:
                    sqlQuery = loadCustomers;
                    break;
                case Query.loadUsers:
                    sqlQuery = loadUsers;
                    break;
                case Query.loadProjects:
                    sqlQuery = loadProjects;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus);
                    break;
                case Query.loadInvoices:
                    sqlQuery = loadInvoices;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus, OuterJoinInvPro);
                    break;
                case Query.loadCustomerDetails:
                    sqlQuery = loadCustomerDetails;
                    break;
                case Query.loadAppointmentDetails:
                    sqlQuery = loadAppointmentDetails;
                    sqlQuery = string.Format(sqlQuery, OuterJoinApoCus);
                    break;
                case Query.loadAppointments:
                    sqlQuery = loadAppointments;
                    sqlQuery = string.Format(sqlQuery, OuterJoinApoCus);
                    break;
                case Query.loadProjectDetails:
                    sqlQuery = loadProjectDetails;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus);
                    break;
                case Query.loadInvoiceDetails:
                    sqlQuery = loadInvoiceDetails;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus, OuterJoinInvPro);
                    break;

                case Query.addCustomer:
                    sqlQuery = addCustomer;
                    break;
                case Query.addInvoice:
                    sqlQuery = addInvoice;
                    break;
                case Query.addProject:
                    sqlQuery = addProject;
                    break;
                case Query.addUser:
                    sqlQuery = addUser;
                    break;
                case Query.addAppointment:
                    sqlQuery = addAppointment;
                    break;

                case Query.updateFinCustomersInfo:
                    sqlQuery = updateFinCustomersInfo;
                    break;
                case Query.updateDevProjectInfo:
                    sqlQuery = updateDevProjectInfo;
                    break;
                case Query.updateSalCustomerInfo:
                    sqlQuery = updateSalCustomerInfo;
                    break;
                case Query.updateFinProjectInfo:
                    sqlQuery = updateFinProjectInfo;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus);
                    break;
                case Query.updateDevCustomerInfo:
                    sqlQuery = updateDevCustomerInfo;
                    break;
                case Query.updateDevAppointmentInfo:
                    sqlQuery = updateDevAppointmentInfo;
                    break;
                case Query.updateAdmActivate:
                    sqlQuery = updateAdmActivate;
                    break;
                case Query.updateLastLogin:
                    sqlQuery = updateLastLogin;
                    break;
                case Query.updateFinPayment:
                    sqlQuery = updateFinPayment;
                    break;
                case Query.updateAppointment:
                    sqlQuery = updateAppointment;
                    break;
                case Query.updateAccomplish:
                    sqlQuery = updateAccomplish;
                    break;

                case Query.countInvoices:
                    sqlQuery = countInvoices;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus, OuterJoinInvPro);
                    break;
                case Query.countOpenInvoices:
                    sqlQuery = countOpenInvoices;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus, OuterJoinInvPro);
                    break;
                case Query.countPaidInvoices:
                    sqlQuery = countPaidInvoices;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus, OuterJoinInvPro);
                    break;
                case Query.countAllInvoices:
                    sqlQuery = countAllInvoices;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus, OuterJoinInvPro);
                    break;
                case Query.countProjects:
                    sqlQuery = countProjects;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus);
                    break;
                case Query.countValues:
                    sqlQuery = countValues;
                    break;
                case Query.countAppointments:
                    sqlQuery = countAppointments;
                    sqlQuery = string.Format(sqlQuery, OuterJoinApoCus);
                    break;
                case Query.countOffers:
                    sqlQuery = countOffers;
                    break;
                case Query.countProjectsTable:
                    sqlQuery = countProjectsTable;
                    sqlQuery = string.Format(sqlQuery, OuterJoinProCus);
                    break;

                case Query.archiveProject:
                    sqlQuery = archiveProject;
                    break;
                case Query.loadProjectStatus:
                    sqlQuery = loadProjectStatus;
                    break;
                case Query.setCustomerArchived:
                    sqlQuery = setCustomerArchived;
                    break;
                case Query.selectArchivedCustomers:
                    sqlQuery = selectArchivedCustomers;
                    break;

                default:
                    sqlQuery = "";
                    break;
            }
            return sqlQuery;
        }
    }
}

