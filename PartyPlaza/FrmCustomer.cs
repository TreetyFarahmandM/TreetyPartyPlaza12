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
    public partial class FrmCustomer : Form
    {
        SqlDataAdapter daCustomer, daBooking, daChkCustomer;
        DataSet partyPlaza = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBooking;
        SqlCommand cmdChkCustomer;
        SqlConnection conn;
        DataRow drCustomer, drBooking;
        String connStr, sqlCustomer, sqlBooking, sqlChkCustomer;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmdChkCustomer.Parameters["@CustNo"].Value = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
            daChkCustomer.Fill(partyPlaza, "ChkCustomer");

            if (partyPlaza.Tables["ChkCustomer"].Rows.Count > 0)
                MessageBox.Show("Can't delete");
            else
                 if (dgvCustomer.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select a customer from the list.", " Customer");
            }
            else
            {
                drCustomer = partyPlaza.Tables["Customer"].Rows.Find(dgvCustomer.SelectedRows[0].Cells[0].Value);
                string tempName = drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details? ", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(partyPlaza, "Customer");
                }
            }
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {

            connStr = @"Data Source = 286386-PC\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(partyPlaza, SchemaType.Source, "Customer");
            daCustomer.Fill(partyPlaza, "Customer");


            dgvCustomer.DataSource = partyPlaza.Tables["Customer"];
            dgvCustomer.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);

            connStr = @"Data Source = 286386-PC\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);

            sqlChkCustomer = @"Select * from Booking WHERE CustomerNo LIKE @CustNo";
            conn = new SqlConnection(connStr);
            cmdChkCustomer = new SqlCommand(sqlChkCustomer, conn);
            cmdChkCustomer.Parameters.Add("@CustNo", SqlDbType.Int);
            daChkCustomer = new SqlDataAdapter(cmdChkCustomer);
            daChkCustomer.FillSchema(partyPlaza, SchemaType.Source, "ChkCustomer");
        }

        private void butExitCust_Click(object sender, EventArgs e)
        {
            MyGlobals.frmClosing = true;
            Close();
        }
        private void frmDisplayCust_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyGlobals.frmClosing = true;
        }
        private void butAddCust_Click(object sender, EventArgs e)
        {

            MyGlobals.frmAddCustomer = true;
            Close();
        }
        private void butEditCust_Click(object sender, EventArgs e)
        {
            if(dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Customer", "Edit Customer");
            }
            else if(dgvCustomer.SelectedRows.Count ==1)
            {

                
                MyGlobals.selectedCustNo = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
                MyGlobals.frmEditCustomer = true;
              Close();
            }
        }

        private void btnDeleteDisplay_Click(object sender, EventArgs e)
        {
            
            if (dgvCustomer.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select a customer from the list.", " Customer");
            }
            else
            {
                drCustomer = partyPlaza.Tables["Customer"].Rows.Find(dgvCustomer.SelectedRows[0].Cells[0].Value);
                string tempName = drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details? ", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(partyPlaza, "Customer");
                }
            }
        }
    }
}
