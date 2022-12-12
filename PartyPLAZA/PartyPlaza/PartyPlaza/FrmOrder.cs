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
    public partial class FrmOrder : Form
    {
        SqlDataAdapter daSupplier, daOrders;
        DataSet dsPartyPlaza = new DataSet();
        SqlConnection conn;
        SqlCommandBuilder cmdBSupplier, cmdBOrders;
        String connStr, sqlSupplier, sqlOrders;
        public FrmOrder()
        {
            InitializeComponent();
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //Navigating the Order page to the AddOrderProduct Form
            MyGlobals.frmAddOrder = true;
            Close();
        }
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            //Set up dataAdapter for Orders details for the listbox
            sqlOrders = @"select * from Orders";
            daOrders = new SqlDataAdapter(sqlOrders, connStr);
            cmdBOrders = new SqlCommandBuilder(daOrders);
            daOrders.FillSchema(dsPartyPlaza, SchemaType.Source, "Orders");
            daOrders.Fill(dsPartyPlaza, "Orders");
            dgvOrder.DataSource = dsPartyPlaza.Tables["Orders"];
            dgvOrder.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);
        }
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            //Navigating the Order page to the Edit Order Form
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Order from the list provided", "Select Order");
            }
            else if (dgvOrder.SelectedRows.Count == 1)
            { 
                MyGlobals.selectedOrderNo = Convert.ToInt32(dgvOrder.SelectedRows[0].Cells[0].Value);
                MyGlobals.frmEditOrder = true;
                Close();
            }
        }
        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            //Navigating the page to the Main Form
            MyGlobals.frmMain = true;
            Close();
        }

    }
}
