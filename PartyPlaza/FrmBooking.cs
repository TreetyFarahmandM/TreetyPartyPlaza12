using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlaza
{
    public partial class FrmBooking : Form
    {
        SqlDataAdapter daCustomers, daNames, daProduct, daKennels, daBooking, daBooking2,
          daBookingDet, daBookingDet2, daBookedKennels, daCust, daProductType;
        DataSet dspartyPlaza = new DataSet();
        SqlCommandBuilder cmdBCutomerDetails, cmdBProductType, cmdBBooking, cmdBookingDet, cmdBBookedKennels, cmdBBooking2, cmdBBookingDet2;
        SqlCommand cmdBooking, cmdBookingDetails, cmdCustomerDetails, cmdProductDetails, cmdKennelDetails,
            cmdCustDets;

        SqlConnection conn;
        DataRow drCustomer;
        String connStr;
        String sqlNames, sqlCustomerDetails, sqlProductDetails, sqlKennelDetails,
            sqlBooking, sqlBooking2, sqlBookingDet, sqlBookingDet2, sqlBookedKennels, sqlCustDets, sqlProductType;

        public FrmBooking()
        {
            InitializeComponent();
        }

       
        private void listBoxCust_Click(object sender, EventArgs e)
        {
         
          

            drCustomer = dspartyPlaza.Tables["Customer"].Rows.Find(listBoxCust.SelectedValue);
            label4.Text = drCustomer["CustomerNo"].ToString();
            label5.Text = drCustomer["Forename"].ToString() + " " + drCustomer["Surname"].ToString();
            label6.Text = drCustomer["Street"].ToString();
            label7.Text = drCustomer["Town"].ToString();
            label8.Text = drCustomer["County"].ToString();
            label9.Text = drCustomer["Custpostcode"].ToString();

        }
        private void listBoxProdType_Click(object sender, EventArgs e)
        {

            dspartyPlaza.Tables["Product"].Clear();

            cmdProductDetails.Parameters["@ProductTypeNo"].Value = listBoxProdType.SelectedValue;
            daProduct.Fill(dspartyPlaza, "Product");

            listBoxProducts.DataSource = dspartyPlaza.Tables["Product"];
            listBoxProducts.DisplayMember = "ProductDesc";
            listBoxProducts.ValueMember = "ProductNo";
        }

        private void FrmBooking_Load(object sender, EventArgs e)
        {
            int no;
            labBookingDate.Text = DateTime.Now.ToShortDateString();

            dtpStartDate.MinDate = DateTime.Now;

           
            connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlNames = @"Select Surname from customer order by surname";
            daNames = new SqlDataAdapter(sqlNames, connStr);
            daNames.Fill(dspartyPlaza, "Names");

            
             conn = new SqlConnection(connStr);
           
            sqlCustomerDetails = @"Select customerNo, surname, forename, surname + ', ' +
            Forename as name, street, town, county, custpostcode, telno, Email from customer order by surname, forename";
            daCustomers = new SqlDataAdapter(sqlCustomerDetails, conn);
            cmdBCutomerDetails = new SqlCommandBuilder(daCustomers);
            daCustomers.FillSchema(dspartyPlaza, SchemaType.Source, "Customer");
            daCustomers.Fill(dspartyPlaza, "Customer");

            sqlBooking = @"SELECT * from Booking where  customerNo LIKE @CustNo order by BookingNo";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBooking = new SqlCommand(sqlBooking, conn);
            cmdBooking.Parameters.Add("@CustNo", SqlDbType.Int);
            daBooking = new SqlDataAdapter(cmdBooking);
            daBooking.FillSchema(dspartyPlaza, SchemaType.Source, "Booking");

          
            sqlProductType = @"SELECT * from ProductType";
            daProductType = new SqlDataAdapter(sqlProductType, conn);
            cmdBProductType = new SqlCommandBuilder(daProductType);
            daProductType.FillSchema(dspartyPlaza, SchemaType.Source, "ProductType");
            daProductType.Fill(dspartyPlaza, "ProductType");

            sqlBooking2 = @"SELECT * from Booking";
            daBooking2 = new SqlDataAdapter(sqlBooking2, conn);
            cmdBBooking2 = new SqlCommandBuilder(daBooking2);
            daBooking2.FillSchema(dspartyPlaza, SchemaType.Source, "Booking2");
            daBooking2.Fill(dspartyPlaza, "Booking2");

            sqlBookingDet2 = @"select * from bookingDet";
            daBookingDet2 = new SqlDataAdapter(sqlBookingDet2, conn);
            cmdBBookingDet2 = new SqlCommandBuilder(daBookingDet);
            daBookingDet2.FillSchema(dspartyPlaza, SchemaType.Source, "BookingDetails");
            daBookingDet2.Fill(dspartyPlaza, "BookingDetails");

            sqlProductDetails = @"Select productNo, supplierNo, ProductTypeNo,ProductDesc ,CostPrice
                       ,SellingPrice,QtyStock from Product where productNo LIKE @BookingNo order by productNo";
            cmdProductDetails = new SqlCommand(sqlProductDetails, conn);
            cmdProductDetails.Parameters.Add("@BookingNo", SqlDbType.Int);
            daProduct = new SqlDataAdapter(cmdProductDetails);
            daProduct.FillSchema(dspartyPlaza, SchemaType.Source, "Product");


            sqlProductDetails = @"Select productNo, supplierNo, ProductTypeNo,ProductDesc ,CostPrice
                       ,SellingPrice,QtyStock from Product where productNo LIKE @ProductTypeNo order by productNo";
            cmdProductDetails = new SqlCommand(sqlProductDetails, conn);
            cmdProductDetails.Parameters.Add("@ProductTypeNo", SqlDbType.Int);
            daProduct = new SqlDataAdapter(cmdProductDetails);
            daProduct.FillSchema(dspartyPlaza, SchemaType.Source, "Product");

            listBoxCust.DataSource = dspartyPlaza.Tables["Customer"];
            listBoxCust.DisplayMember = "Name";
            listBoxCust.ValueMember = "CustomerNo";

        }
        private void butEditBooking_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value >= DateTime.Now)
            {
                if (btnEditBooking.Text == "Edit Booking")
                {
                    pnlAddEdit.Enabled = true;
                    btnEditBooking.Text = "Save";

                    btnAddItem.Enabled = false;
                    btnEditItem.Enabled = false;
                    btnDeleteItem.Enabled = false;
                    btnDeleteBooking.Enabled = false;
                }
                else
                {
                    DataRow drBooking = dspartyPlaza.Tables["BookingDet2"].Rows.Find(listBoxProducts.Text);


                    drBooking.BeginEdit();

                    drBooking["DateStart"] = Convert.ToDateTime(dtpStartDate.Value);
                   

                    drBooking.EndEdit();
                    daBooking2.Update(dspartyPlaza, "Booking2");

                    pnlAddEdit.Enabled = false;
                    btnEditBooking.Text = "Add Item";

                    btnEditItem.Enabled = true;
                    btnDeleteItem.Enabled = true;
                    btnAddItem.Enabled = true;
                    btnDeleteBooking.Enabled = true;
                }
            }

        }
        private void listBoxBooking_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            listViewProduct.Enabled = true;

            if (listViewProduct.Items.Count != 0)
            {
                DataRow drBooking = dspartyPlaza.Tables["Booking"].Rows.Find(listBoxProducts.SelectedValue);

                labBookingDate.Text = (Convert.ToDateTime(drBooking["DateBooked"].ToString())).ToShortTimeString();

                dtpStartDate.Value = Convert.ToDateTime(drBooking["DateStart"].ToString());


                if (dtpStartDate.Value < DateTime.Now)
                {
                    dtpStartDate.Enabled = false;
                    
                    listViewProduct.Enabled = false;
                }

                dspartyPlaza.Tables["@BookingDet"].Clear();

                cmdBooking.Parameters["@BookingNo"].Value = listBoxProducts.SelectedValue;
                daBooking.Fill(dspartyPlaza, "BookingDet");

                foreach (DataRow dr in dspartyPlaza.Tables["BookingDet"].Rows)
                {
                    if (dr["ProductNo"].ToString() == listBoxProducts.Text)
                    {
                        ListViewItem item = new ListViewItem(dr["ProductNo"].ToString());
                        item.SubItems.Add(dr["ProductDesc"].ToString());
                        listViewProduct.Items.Add(item);

                    }
                }
            }
        }

        private void butDeleteItem_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the Booking details for Dog no: "
                    + listViewProduct.SelectedItems[0].SubItems[0].Text + "?", "Delete Dog Details",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    object[] primaryKey = new object[2];

                    ListViewItem currItem = listViewProduct.SelectedItems[0];

                    primaryKey[0] = Convert.ToInt32(listViewProduct);
                    primaryKey[1] = Convert.ToInt32(currItem.SubItems[0].Text);


                    DataRow drBookingDet = dspartyPlaza.Tables["BookingDet2"].Rows.Find(primaryKey);

                    listViewProduct.Items.Remove(currItem);

                    drBookingDet.Delete();
                    daBookingDet2.Update(dspartyPlaza, "BookingDet2");

                    if (listViewProduct.Items.Count != 0)
                    {
                        MessageBox.Show("As there are no booking details, Booking No " + primaryKey[0].ToString() +
                            " will now be deleted");

                        DataRow drBooking = dspartyPlaza.Tables["Booking2"].Rows.Find(primaryKey[0]);

                        drBooking.Delete();
                        daBooking2.Update(dspartyPlaza, "Booking2");

                        PopulateProductListBox();
                    }
                }
            }
        }
        private void PopulateProductListBox()
        {

           

          
        }
        
        


        private void butDeleteBooking_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the Booking details for Dog no: "
                    + listViewProduct.SelectedItems[0].SubItems[0].Text + "?", "Delete Dog Details",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    object[] primaryKey = new object[2];

                    foreach (ListViewItem item in listViewProduct.Items)
                    {

                        primaryKey[0] = Convert.ToInt32(listViewProduct);
                        primaryKey[1] = Convert.ToInt32(item.SubItems[0].Text);

                        DataRow drBookingDet = dspartyPlaza.Tables["BookingDet2"].Rows.Find(primaryKey);

                        listViewProduct.Items.Remove(item);

                        drBookingDet.Delete();
                        daBookingDet2.Update(dspartyPlaza, "BookingDet2");

                    }


                    if (listViewProduct.Items.Count != 0)
                    {
                        DataRow drBookingDet = dspartyPlaza.Tables["BookingDet2"].Rows.Find(primaryKey[0]);
                        MessageBox.Show("As there are no booking details, Booking No " + primaryKey[0].ToString() +
                                " will now be deleted");

                        DataRow drBooking = dspartyPlaza.Tables["Booking2"].Rows.Find(primaryKey[0]);

                        drBooking.Delete();
                        daBooking2.Update(dspartyPlaza, "Booking2");

                        PopulateProductListBox();


                    }
                }
            }
            else
                MessageBox.Show("Please select a booking from the list!", "Delete Booking");
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            DataRow drBooking, drBookingDets;
            int bookingNo;

            int noRows = dspartyPlaza.Tables["Booking"].Rows.Count;

            drBooking = dspartyPlaza.Tables["Booking"].Rows[noRows - 1];
            bookingNo = (int.Parse(drBooking["BookingNo"].ToString()));

            if (listBoxCust.SelectedIndex == -1)
                MessageBox.Show("Please select a customer", "customer");
            if (listBoxProdType.SelectedIndex == -1)
                MessageBox.Show("Please select a kennel", "kennel");
           
            if (listViewProduct.Items.Count == 0)
            {
                MessageBox.Show("Please input dog/kennel to the booking", "booking details");

            }

            else
            {
                drBooking = dspartyPlaza.Tables["Booking"].NewRow();

                drBooking["BookingNo"] = bookingNo;
                drBooking["customerNo"] = int.Parse(label5.Text);
                drBooking["dateBooked"] = DateTime.Parse(labBookingDate.Text.Trim());
                drBooking["dateStart"] = DateTime.Parse(dtpStartDate.Text.Trim());
                

                dspartyPlaza.Tables["Booking"].Rows.Add(drBooking);
                daBooking.Update(dspartyPlaza, "Booking");

                foreach (ListViewItem item in listViewProduct.Items)
                {
                    drBookingDets = dspartyPlaza.Tables["BookingDet"].NewRow();

                    drBookingDets["BookingNo"] = drBooking["BookingNo"];
                    drBookingDets["ProductNo"] = int.Parse(item.SubItems[0].Text);
                    drBookingDets["CustomerNo"] = int.Parse(item.SubItems[2].Text);
                    dspartyPlaza.Tables["BookingDetail"].Rows.Add(drBookingDets);
                    daBookingDet.Update(dspartyPlaza, "BookingDetail");
                }

                MessageBox.Show("Booking No:" + drBooking["bookingNo"].ToString() + " added to system");

              
            }
        }
        private void butAddItem_Click(object sender, EventArgs e)
        {
            if (btnAddItem.Text == "Add Item")
            {
                pnlAddEdit.Enabled = true;
                btnAddItem.Text = "Save";

                btnEditItem.Enabled = false;
                btnDeleteItem.Enabled = false;
                btnEditBooking.Enabled = false;
                btnDeleteBooking.Enabled = false;
            }
            else
            {
                pnlAddEdit.Enabled = false;
                btnAddItem.Text = "Add Item";

                btnEditItem.Enabled = true;
                btnDeleteItem.Enabled = true;
                btnEditBooking.Enabled = true;
                btnDeleteBooking.Enabled = true;
            }

        }

        private void butEditItem_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Enabled = true;
        }

        private void butRemoveItem_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count != 0)
            {
                var item = listViewProduct.SelectedItems[0];
                listViewProduct.Items.Remove(item);
            }
        }
        private void ClearCustomer()
        {
            listBoxCust.SelectedIndex = -1;


            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";

        }

    


    }
}
