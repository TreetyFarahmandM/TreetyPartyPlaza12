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
    public partial class FrmEditSupplier : Form
    {
        SqlDataAdapter daSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        DataRow drSupplier;
        String connStr, sqlSupplier;
        public FrmEditSupplier()
        {
            InitializeComponent();
        }
        private void FrmEditSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");

            lblEditSuppNo.Text = MyGlobals.selectedSupplierNo.ToString();
            drSupplier = dsPartyPlaza.Tables["Supplier"].Rows.Find(lblEditSuppNo.Text);

            txtEditBusiName.Text = drSupplier["BusinessName"].ToString();
            txtEditForename.Text = drSupplier["ContactForename"].ToString();
            txtEditSurname.Text = drSupplier["ContactSurname"].ToString();
            txtEditStreet.Text = drSupplier["Street"].ToString();
            txtEditTown.Text = drSupplier["Town"].ToString();
            txtEditCounty.Text = drSupplier["County"].ToString();
            txtEditPostcode.Text = drSupplier["Postcode"].ToString();
            txtEditTelNo.Text = drSupplier["TelNo"].ToString();
            txtEditEmail.Text = drSupplier["Email"].ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Navigating back to the Main/Supplier Form
            MyGlobals.frmEditSupplier = false;
            Close();
        }
        private void frmEditSupplier_FormClosing(object sender, EventArgs e)
        {
            MyGlobals.frmClosing = true;
            Close();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the editing of Supplier details?",
                "Edit Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)

            MyGlobals.frmClosing = true;
            Close();
        }

        private void btnEditExit_Click(object sender, EventArgs e)
        {
            //Navigating back to the Main/Supplier Form
            MyGlobals.frmEditSupplier = false;
            Close();
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (lblEditSuppNo.Text == "Edit")
            {
                txtEditBusiName.Enabled = true;
                txtEditForename.Enabled = true;
                txtEditSurname.Enabled = true;
                txtEditStreet.Enabled = true;
                txtEditTown.Enabled = true;
                txtEditCounty.Enabled = true;
                txtEditPostcode.Enabled = true;
                txtEditTelNo.Enabled = true;

                lblEditSuppNo.Text = "Save";
            }
            else
            {
                MySupplier mySupplier = new MySupplier();
                bool ok = true;
                errP.Clear();

                //This set of codes is for
                try
                {
                    mySupplier.IDNum = Convert.ToInt32(lblEditSuppNo.Text.Trim());
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditSuppNo, MyEx.toString());
                }
                try
                {
                    mySupplier.BusinessName = txtEditBusiName.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditBusiName, MyEx.toString());
                }
                try
                {
                    mySupplier.ContactSurname = txtEditSurname.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSurname, MyEx.toString());
                }
                try
                {
                    mySupplier.ContactForename = txtEditForename.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditForename, MyEx.toString());
                }
                try
                {
                    mySupplier.Street = txtEditStreet.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditStreet, MyEx.toString());
                }
                try
                {
                    mySupplier.Town = txtEditTown.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTown, MyEx.toString());
                }
                try
                {
                    mySupplier.County = txtEditCounty.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCounty, MyEx.toString());
                }
                try
                {
                    mySupplier.Postcode = txtEditPostcode.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditPostcode, MyEx.toString());
                }
                try
                {
                    mySupplier.TelNum = txtEditTelNo.Text.Trim();
                    //passed to Supplier class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTelNo, MyEx.toString());
                }
                try
                {
                    mySupplier.Email = txtEditEmail.Text.Trim();
                    //passed to Supplier class to check
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
                        drSupplier.BeginEdit();

                        drSupplier["SupplierNo"] = mySupplier.IDNum;
                        drSupplier["BusinessName"] = mySupplier.BusinessName;
                        drSupplier["ContactForename"] = mySupplier.ContactForename;
                        drSupplier["ContactSurname"] = mySupplier.ContactSurname;
                        drSupplier["Street"] = mySupplier.Street;
                        drSupplier["Town"] = mySupplier.Town;
                        drSupplier["County"] = mySupplier.County;
                        drSupplier["Postcode"] = mySupplier.Postcode;
                        drSupplier["TelNo"] = mySupplier.TelNum;
                        drSupplier["Email"] = mySupplier.Email;

                        drSupplier.EndEdit();
                        daSupplier.Update(dsPartyPlaza, "Supplier");

                        MessageBox.Show("Supplier Details Updated", "Supplier");

                        txtEditBusiName.Enabled = false;
                        txtEditForename.Enabled = false;
                        txtEditSurname.Enabled = false;
                        txtEditStreet.Enabled = false;
                        txtEditTown.Enabled = false;
                        txtEditCounty.Enabled = false;
                        txtEditPostcode.Enabled = false;
                        txtEditTelNo.Enabled = false;
                        txtEditEmail.Enabled = false;

                        lblEditSuppNo.Text = "Edit";
                        //tabCustomer.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
    }
}
