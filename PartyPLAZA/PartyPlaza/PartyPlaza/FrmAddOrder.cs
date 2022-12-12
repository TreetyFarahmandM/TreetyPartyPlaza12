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
    public partial class FrmAddOrder : Form
    {
        SqlDataAdapter daSupplier, daSupplierDet, daOrder, daProduct, daOrderDet, daBusinessName, daQty;
        DataSet dsPartyPlaza = new DataSet();
        DataRow drSupplier, drOrder, drOrderDet;

        SqlConnection conn;
        SqlCommand cmdSupplierDet, cmdProduct, cmdProductDet, cmdQty;
        SqlCommandBuilder cmdBOrder, cmdBOrderDet, cmdBQty, cmdBSupplier;
        String sqlBusinessName, sqlSupplier, sqlSupplierDet, sqlProduct,
            sqlProductDet, sqlOrder, sqlOrderDet, sqlQty;

        String connStr;

        public FrmAddOrder()
        {
            InitializeComponent();
        }
        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            // pnlAddOrder.Enabled = false;
            connStr = @"Data Source = DESKTOP-5PH67NH\SQLEXPRESS01; Initial Catalog = PartyPlaza; 
                        Integrated Security = true";
            conn = new SqlConnection(connStr);

            //Set up dataAdapter for Supplier details for the listbox
            sqlSupplierDet = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplierDet, conn);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsPartyPlaza, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsPartyPlaza, "Supplier");

            //Set up dataAdapter for Product details for the listbox
            sqlProductDet = @"Select ProductNo,  ProductDesc, CostPrice from Product where SupplierNo LIKE @SupplierNo order by ProductDesc";
            cmdProductDet = new SqlCommand(sqlProductDet, conn);
            cmdProductDet.Parameters.Add("@SupplierNo", SqlDbType.Int);
            daProduct = new SqlDataAdapter(cmdProductDet);
            daProduct.FillSchema(dsPartyPlaza, SchemaType.Source, "Product");
            //daProduct.Fill(dsPartyPlaza, "ProductDet");

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

            fillListBoxSupplier();
        }
        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            pnlAddOrder.Enabled = false;
            lblOrderNO.Enabled = true;
            lblOrderDate.Enabled = true;

            fillListBoxSupplier();
        }

        private void fillListBoxSupplier()
        { 
            
            //get all Supplier Business Name for listbox - USE WILDCARD FOR PARAMETER???

            //fill listbox
            lstSupplier.DataSource = dsPartyPlaza.Tables["Supplier"];
            lstSupplier.DisplayMember = "BusinessName";
            lstSupplier.ValueMember = "SupplierNo";

        }
        private void lstSupplier_Click(object sender, EventArgs e)
        {
            dsPartyPlaza.Tables["Product"].Clear();
             //get ProductDesc, CostPrice, ProductNo for the listbox.
            cmdProductDet.Parameters["@SupplierNo"].Value = lstSupplier.SelectedValue;
            daProduct.Fill(dsPartyPlaza, "Product");

            // fill listbox
            lstProduct.DataSource = dsPartyPlaza.Tables["Product"];
            lstProduct.DisplayMember = "ProductDesc";
            lstProduct.ValueMember = "CostPrice";

            lstProduct.SelectedIndex = -1;

            drSupplier = dsPartyPlaza.Tables["Supplier"].Rows.Find(lstSupplier.SelectedValue);

            lblSupplierNo.Text = drSupplier["SupplierNo"].ToString();
            lblBusinessName.Text = drSupplier["BusinessName"].ToString();
            lblForename.Text = drSupplier["ContactForename"].ToString();
            lblSurname.Text = drSupplier["ContactSurname"].ToString();
            lblStreet.Text = drSupplier["Street"].ToString();
            lblCity.Text = drSupplier["Town"].ToString();
            lblCounty.Text = drSupplier["County"].ToString();
            // lblPostCode.Text = drSupplier["Street"].ToString();
            lblTelNo.Text = drSupplier["TelNo"].ToString();
            lblEmail.Text = drSupplier["Email"].ToString();

           
        }
        private void lstProduct_Click(object sender, EventArgs e)
        {
            if (lstProduct.Items.Count != 0)
            {
                pnlAddOrder.Enabled = true;
            }
        }
        private void btnAddAddOrder_Click(object sender, EventArgs e)
        {
            DataRow drBooking;
            int OrderNumber;
            int quantity = Int32.Parse(txtQty.Text);
            int noRows = dsPartyPlaza.Tables["Orders"].Rows.Count;

            drOrder = dsPartyPlaza.Tables["Orders"].Rows[noRows - 1];
            OrderNumber = (int.Parse(drOrder["OrderNo"].ToString()) + 1);

            if (lstSupplier.SelectedIndex == -1)
                MessageBox.Show("Pleases select a Supplier", "Supplier");
            else if (lstProduct.SelectedIndex == -1)
                MessageBox.Show("Please select a Product", "Product");
            else if (quantity == 0)
                MessageBox.Show("Please enter the quantity for this product", "Quantity");

            else if (lvwOrderDetails.Items.Count == 0)
                MessageBox.Show("Please add a Product and quantity to the order", "ProductOrder");
            else
            {
                drSupplier = dsPartyPlaza.Tables["ProductOrder"].NewRow();

                drSupplier["OrderNo"] = OrderNumber;
                drSupplier["SupplierNo"] = int.Parse(lblSupplierNo.Text);
                drSupplier["OrderDate"] = DateTime.Parse(lblOrderDate.Text.Trim());
                //drSupplier["ProductNo"] = int.Parse(lblSupplierNo.Text);
                drSupplier["Qty"] = int.Parse(Qty.Text);

                dsPartyPlaza.Tables["Orders"].Rows.Add(drOrder);
                daOrder.Update(dsPartyPlaza, "Orders");

                foreach (ListViewItem item in lvwOrderDetails.Items)
                {
                    drOrderDet = dsPartyPlaza.Tables["ProductOrder"].NewRow();
                    drOrderDet["OrderNo"] = drOrder["OrderNo"];
                    drOrderDet["SupplierNo"] = int.Parse(item.SubItems[0].Text);
                    drOrderDet["ProductNo"] = int.Parse(item.SubItems[1].Text);
                    drOrderDet["Qty"] = int.Parse(item.SubItems[2].Text);
                    dsPartyPlaza.Tables["ProductOrder"].Rows.Add(drOrderDet);
                    daOrderDet.Update(dsPartyPlaza, "Orders");
                }

                MessageBox.Show("Order No: " + drOrder["OrderNumber"].ToString() + " Added to system");

                pnlAddOrder.Enabled = false;
            }


        }
        private void btnAddExit_Click(object sender, EventArgs e)
        {
            MyGlobals.frmOrder = true;
            Dispose();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool ok = true;
            bool exits = false;
            int quantity = int.Parse(txtQty.Text);
          
            if (lstSupplier.SelectedIndex == -1)
                MessageBox.Show("Please select a Supplier", "Supplier");
            else if (lstProduct.SelectedIndex == -1)
                MessageBox.Show("Please select a Product", "Product");
            else if (quantity == 0)
            {
                MessageBox.Show("Please enter the quantity", "No of Products");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(lstSupplier.Text);
                item.SubItems.Add(lstProduct.Text);
                item.SubItems.Add(txtQty.Text);
                lvwOrderDetails.Items.Add(item);

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
