using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlaza
{
    public partial class FrmAddCustomer : Form
    {
        SqlDataAdapter daCustomer;
        DataSet partyPlaza = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(partyPlaza, SchemaType.Source, "Customer");
            daCustomer.Fill(partyPlaza, "Customer");

            int noRows = partyPlaza.Tables["Customer"].Rows.Count;

            if (noRows == 0)
                labCustomerNumAdd.Text = "10000";
            else
            {
                getNumber(noRows);
            }
            errP.Clear();
            clearAddForm();
        }
       

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyCustomer myCustomer = new MyCustomer();
            bool ok = true;
            errP.Clear();
            try
            {
                myCustomer.IDNum = Convert.ToInt32(labCustomerNumAdd.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(labCustomerNumAdd, MyEx.toString());
            }
            try
            {
                myCustomer.Surname = txtAddSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddSurname, MyEx.toString());
            }

            try
            {
                myCustomer.Forename = txtAddForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddForename, MyEx.toString());
            }

            try
            {
                myCustomer.Street = txtAddStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddStreet, MyEx.toString());
            }

            try
            {
                myCustomer.Town = txtAddTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTown, MyEx.toString());
            }

            try
            {
                myCustomer.County = txtAddCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddCounty, MyEx.toString());
            }
            try
            {
                myCustomer.Postcode = txtAddPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddPostcode, MyEx.toString());
            }
            try
            {
                myCustomer.TelNum = txtAddTelNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddTelNo, MyEx.toString());
            }
            try
            {
                myCustomer.Email = txtAddEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtAddEmail, MyEx.toString());
            }
            try
            {
                if (ok)
                {
                    drCustomer = partyPlaza.Tables["Customer"].NewRow();

                    drCustomer["CustomerNo"] = myCustomer.IDNum;
                   
                    drCustomer["Forename"] = myCustomer.Forename;
                    drCustomer["Surname"] = myCustomer.Surname;
                    drCustomer["Street"] = myCustomer.Street;
                    drCustomer["Town"] = myCustomer.Town;
                    drCustomer["County"] = myCustomer.County;
                    drCustomer["CustPostcode"] = myCustomer.Postcode;
                    drCustomer["TelNo"] = myCustomer.TelNum;
                    drCustomer["Email"] = myCustomer.Email;

                    partyPlaza.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(partyPlaza, "Customer");
                    MessageBox.Show("Customer Added");

                    if (MessageBox.Show("Do you want to add a new customer?",
                       "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddForm();
                        getNumber(partyPlaza.Tables["Customer"].Rows.Count);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void BtnAddCancel_Click(object sender, EventArgs e)
        {
          clearAddForm();
        }

        void clearAddForm()
        {
            
            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddStreet.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTelNo.Clear();
            txtAddEmail.Clear();    
        }

        private void BtnAddExit_Click(object sender, EventArgs e)
        {
            MyGlobals.frmClosing = true;
            Close();
        }

        private void FrmAddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyGlobals.frmClosing = true;
        }


        private void getNumber(int noRows)
        {
            drCustomer = partyPlaza.Tables["Customer"].Rows[noRows - 1];
            labCustomerNumAdd.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
        }
    }
}
