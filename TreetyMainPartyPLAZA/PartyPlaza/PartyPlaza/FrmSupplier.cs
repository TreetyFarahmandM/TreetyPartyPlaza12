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
    public partial class FrmSupplier : Form
    {

        SqlDataAdapter daSupplier, daProduct, daChkSupplier;
        DataSet dsPartyPlaza = new DataSet();
        SqlCommandBuilder cmdBSupplier;
        SqlCommand cmdChkSupplier, cmdProduct;
        SqlConnection conn;
        DataRow drSupplier;
        String connStr, sqlSupplier, sqlOrders, sqlProduct;

        public FrmSupplier()
        {
            InitializeComponent();
        }
        private void btnDisplayAddSupp_Click(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Add Supplier Form
            MyGlobals.frmAddSupplier = true;
            Close();
        }
        private void btnDisplayEditSupp_Click(object sender, EventArgs e)
        {
            //Navigating the Supplier page to the Edit Supplier Form
            if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier from the list provided", "Select Supplier");
            }
            else if (dgvSupplier.SelectedRows.Count == 1)
            {
                MyGlobals.selectedSupplierNo = Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells[0].Value);
                MyGlobals.frmEditSupplier = true;
                Close();
            }
        }
        private void btnDisplayDeleteSupp_Click(object sender, EventArgs e)
        {
            cmdChkSupplier.Parameters["@SuppNo"].Value = Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells[0].Value);
            daChkSupplier.Fill(dsPartyPlaza, "ChkSupplier");

            if (dsPartyPlaza.Tables["ChkSupplier"].Rows.Count > 0)

                MessageBox.Show("Can't delete");

            else if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Supplier from the list.", "Select Supplier");
            }
            else
            {
                drSupplier = dsPartyPlaza.Tables["Supplier"].Rows.Find(dgvSupplier.SelectedRows[0].Cells[0].Value);
                String tempName = drSupplier["BusinessName"].ToString();

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "Add Supplier",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drSupplier.Delete();
                    daSupplier.Update(dsPartyPlaza, "Supplier");
                }
            }
        }
        private void btnDisplayExitSupp_Click(object sender, EventArgs e)
        {
            //Navigating the page to the Main Form
            MyGlobals.frmMain = true;
            Close();
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");
            dgvSupplier.DataSource = dsPartyPlaza.Tables["Supplier"];
            dgvSupplier.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);

            sqlOrders = @"select * from Orders WHERE SupplierNo LIKE @SuppNo";
            conn = new SqlConnection(connStr);
            cmdChkSupplier = new SqlCommand(sqlOrders, conn);
            cmdChkSupplier.Parameters.Add("@SuppNo", SqlDbType.Int);
            daChkSupplier = new SqlDataAdapter(cmdChkSupplier);
            daChkSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "ChkSupplier");

            sqlProduct = @"select * from Product Where SupplierNo LIKE @SuppNo";
            conn = new SqlConnection(connStr);
            cmdProduct = new SqlCommand(sqlProduct, conn);
            cmdProduct.Parameters.Add("@SuppNo", SqlDbType.Int);
            daProduct = new SqlDataAdapter(cmdProduct);
            daProduct.FillSchema(dsPartyPlaza, SchemaType.Source, "ChkSupplier");

            //Resize the DataGridView colums to fit the newly loaded content.
            dgvSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
