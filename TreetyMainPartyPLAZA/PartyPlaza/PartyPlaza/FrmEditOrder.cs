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
using System.Windows.Forms.Design.Behavior;

namespace PartyPlaza
{
    public partial class FrmEditOrder : Form
    {
        SqlDataAdapter daSupplier, daSupplierDet, daOrder, daProduct, daOrderDet, daBusinessName, daQty;
        DataSet dsPartyPlaza = new DataSet();
        DataRow drSupplier, drOrder;

        SqlConnection conn;
        SqlCommand cmdSupplierDet, cmdProduct, cmdProductDet, cmdQty;
        SqlCommandBuilder cmdBOrder, cmdBOrderDet, cmdBQty;
        String sqlBusinessName, sqlSupplier, sqlSupplierDet, sqlProduct,
            sqlProductDet, sqlOrder, sqlOrderDet, sqlQty;
        String connStr;
        public FrmEditOrder()
        {
            InitializeComponent();
        }
        private void btnEditExit_Click(object sender, EventArgs e)
        {
            //Navigating the page to the Main Form
            Close();
        }

        private void FrmEditOrder_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = InTheDogHouse; Integrated Security = true";
            conn = new SqlConnection(connStr);

            //Set up dataAdapter for Supplier details for the listbox
            sqlSupplierDet = @"select BusinessName, ContactForename, ContactSurname from Supplier";
            cmdSupplierDet = new SqlCommand(sqlSupplierDet, conn);
            cmdSupplierDet.Parameters.Add("BusinessName", SqlDbType.VarChar);
            daSupplier = new SqlDataAdapter(cmdSupplierDet);
            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            // daSupplier.Fill(lstSupplier, "BusinessName");

            //Set up dataAdapter for Product details for the listbox
            sqlProductDet = @"select ProductDesc, CostPrice from Product";
            cmdProductDet = new SqlCommand(sqlProductDet, conn);
            cmdProductDet.Parameters.Add("@BusinessName", SqlDbType.VarChar);
            daProduct = new SqlDataAdapter(cmdProductDet);
            daProduct.FillSchema(dsPartyPlaza, SchemaType.Source, "Product");

            //Set up dataAdapter for Order
            sqlOrder = @"Select * from Orders";
            daOrder = new SqlDataAdapter(sqlOrder, conn);
            cmdBOrder = new SqlCommandBuilder(daOrder);
            daOrder.FillSchema(dsPartyPlaza, SchemaType.Source, "Orders");
            daOrder.Fill(dsPartyPlaza, "Orders");

            //Set up dataAdapter for Order Details
            sqlOrderDet = @"Select * from ProductOrder";
            daOrderDet = new SqlDataAdapter(sqlOrderDet, conn);
            cmdBOrderDet = new SqlCommandBuilder(daOrderDet);
            daOrderDet.FillSchema(dsPartyPlaza, SchemaType.Source, "ProductOrder");
            daOrderDet.Fill(dsPartyPlaza, "ProductOrder");

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOP_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOP_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }
        private void btnEditEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
