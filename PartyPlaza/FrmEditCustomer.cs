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
    public partial class FrmEditCustomer : Form
    {

        SqlDataAdapter daCustomer;
        DataSet partyPlaza = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;
        public FrmEditCustomer()
        {
            InitializeComponent();
        }
        private void butExitCust_Click(object sender, EventArgs e)
        {
            MyGlobals.frmClosing = true;
            Close();
        }
        private void butCancelCust_Click(object sender, EventArgs e)
        {
            MyGlobals.frmClosing = true;
            Close();
        }
        private void frmDisplayCust_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyGlobals.frmClosing = true;
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (btnEditEdit.Text == "Edit")
            {

                txtEditForename.Enabled = true;
                txtEditSurname.Enabled = true;
                txtEditStreet.Enabled = true;
                txtEditCounty.Enabled = true;
                txtEditPostcode.Enabled = true;
                txtEditTelNo.Enabled = true;
                txtEditEmail.Enabled = true;
                btnEditEdit.Text = "Save";
            }
            else
            {
                MyCustomer myCustomer = new MyCustomer();
                bool ok = true;
                errP.Clear();

                try
                {
                    myCustomer.IDNum = Convert.ToInt32(labCustomerNumEdit.Text.Trim());


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(labCustomerNumEdit, MyEx.toString());
                }
               
                try
                {
                    myCustomer.Surname = txtEditSurname.Text.ToUpper().Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSurname, MyEx.toString());
                }
                try
                {
                    myCustomer.Forename = txtEditForename.Text.ToUpper().Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditForename, MyEx.toString());
                }
                try
                {
                    myCustomer.Street = txtEditStreet.Text.ToUpper().Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditStreet, MyEx.toString());
                }
                try
                {
                    myCustomer.Town = txtEditCounty.Text.ToUpper().Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCounty, MyEx.toString());
                }
                try
                {
                    myCustomer.County = txtEditTown.Text.ToUpper().Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTown, MyEx.toString());
                }
                try
                {
                    myCustomer.Postcode = txtEditPostcode.Text.ToUpper().Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditPostcode, MyEx.toString());
                }
                try
                {
                    myCustomer.TelNum = txtEditTelNo.Text.Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTelNo, MyEx.toString());
                }
                try
                {
                    myCustomer.TelNum = txtEditEmail.Text.Trim();


                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditEmail, MyEx.toString());
                }
                try
                {
                    if (ok)
                    {
                        drCustomer.BeginEdit();
                        drCustomer["CustomerNo"] = myCustomer.IDNum;
                        drCustomer["Forename"] = myCustomer.Forename;
                        drCustomer["Surname"] = myCustomer.Surname;
                        drCustomer["Street"] = myCustomer.Street;
                        drCustomer["Town"] = myCustomer.Town;
                        drCustomer["County"] = myCustomer.County;
                        drCustomer["CustPostcode"] = myCustomer.Postcode;
                        drCustomer["TelNo"] = myCustomer.TelNum;
                        drCustomer["Email"] = myCustomer.Email;
                        drCustomer.EndEdit();
                        daCustomer.Update(partyPlaza, "Customer");
                        MessageBox.Show("Customer Details Updated", "Customer");


                        txtEditForename.Enabled = false;
                        txtEditSurname.Enabled = false;
                        txtEditStreet.Enabled = false;
                        txtEditCounty.Enabled = false;
                        txtEditTown.Enabled = false;
                        txtEditPostcode.Enabled = false;
                        txtEditTelNo.Enabled = false;
                        txtEditEmail.Enabled = false;
                        btnEditEdit.Text = "Edit";
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
        private void FrmEditCustomer_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = 286386-PC\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(partyPlaza, SchemaType.Source, "Customer");
            daCustomer.Fill(partyPlaza, "Customer");


            labCustomerNumEdit.Text = MyGlobals.selectedCustNo.ToString();
            drCustomer = partyPlaza.Tables["Customer"].Rows.Find(labCustomerNumEdit.Text);


            txtEditForename.Text = drCustomer["Forename"].ToString();
            txtEditSurname.Text = drCustomer["Surname"].ToString();
            txtEditStreet.Text = drCustomer["Street"].ToString();
            txtEditTown.Text = drCustomer["Town"].ToString();
            txtEditCounty.Text = drCustomer["County"].ToString();
            txtEditPostcode.Text = drCustomer["CustPostcode"].ToString();
            txtEditTelNo.Text = drCustomer["TelNo"].ToString();
            txtEditEmail.Text = drCustomer["Email"].ToString();

        }
    }
}
