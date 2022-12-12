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
    public partial class FrmEditBooking : Form
    {
        SqlDataAdapter daCustomers, daNames, daProduct, daKennels, daBooking, daBooking2,
          daBookingDet, daBookingDet2, daBookedKennels, daCust;
        DataSet dspartyPlaza = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBookingDet, cmdBBookedKennels, cmdBBooking2, cmdBBookingDet2;
        SqlCommand cmdBooking, cmdBookingDetails, cmdCustomerDetails, cmdProductDetails, cmdKennelDetails,
            cmdCustDets;

        public FrmEditBooking()
        {
            InitializeComponent();
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditBooking_Load(object sender, EventArgs e)
        {

        }
       

       
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxCust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn;
        DataRow drCustomer;
        String connStr;
        String sqlNames, sqlCustomerDetails, sqlProductDetails, sqlKennelDetails,
            sqlBooking, sqlBooking2, sqlBookingDet, sqlBookingDet2, sqlBookedKennels, sqlCustDets;


        private void FrmBooking_Load(object sender, EventArgs e)
        {
            int no;
            labBookingDate.Text = DateTime.Now.ToShortDateString();

            dtpStartDate.MinDate = DateTime.Now;


            connStr = @"Data Source = .\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";

            sqlNames = @"Select Surname from customer order by surname";
            daNames = new SqlDataAdapter(sqlNames, connStr);
            daNames.Fill(dspartyPlaza, "Names");


            sqlCustomerDetails = @"Select customerNo, surname, forename, surname + ', ' +
            Forename as name, street, town, county, custpostcode, telno, Email from customer order by surname, forename";
            conn = new SqlConnection(connStr);
            cmdCustomerDetails = new SqlCommand(sqlCustomerDetails, conn);
            daCustomers = new SqlDataAdapter(cmdCustomerDetails);
            daCustomers.FillSchema(dspartyPlaza, SchemaType.Source, "Customer");

            sqlBooking = @"SELECT * from Booking where  customerNo LIKE @CustNo order by BookingNo";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBooking = new SqlCommand(sqlBooking, conn);
            cmdBooking.Parameters.Add("@CustNo", SqlDbType.Int);
            daBooking = new SqlDataAdapter(cmdBooking);
            daBooking.FillSchema(dspartyPlaza, SchemaType.Source, "Booking");

            sqlBooking2 = @"SELECT * from Booking";
            daBooking2 = new SqlDataAdapter(sqlBooking2, conn);
            cmdBBooking2 = new SqlCommandBuilder(daBooking2);
            daBooking2.FillSchema(dspartyPlaza, SchemaType.Source, "Booking2");
            daBooking2.Fill(dspartyPlaza, "Booking2");

            //sqlBookingDet = @"select * bookingDet where BookingNo LIKE @BookingNo order by BookingNo";
            //daBookingDet = new SqlDataAdapter(sqlBookingDet, conn);
            //cmdBookingDet = new SqlCommand(sqlBookingDetails);
            //cmdBookingDet.Parameters.Add("@BookingNo", SqlDbType.Int);
            //daBookingDet = new SqlDataAdapter(cmdBookingDetails);
            //daBookingDet.FillSchema(dspartyPlaza, SchemaType.Source, "BookingDetails");


            sqlBookingDet2 = @"select * from bookingDet";
            daBookingDet2 = new SqlDataAdapter(sqlBookingDet2, conn);
            cmdBBookingDet2 = new SqlCommandBuilder(daBookingDet);
            daBookingDet2.FillSchema(dspartyPlaza, SchemaType.Source, "BookingDetails");
            daBookingDet2.Fill(dspartyPlaza, "BookingDetails");

            sqlProductDetails = @"Select productNo, supplierNo, ProductTypeNo,ProductDesc ,
            CostPrice ,SellingPrice,QtyStock from Product where productNo LIKE @BookingNo order by productNo";
            cmdProductDetails = new SqlCommand(sqlProductDetails, conn);
            cmdProductDetails.Parameters.Add("@BookingNo", SqlDbType.Int);
            daProduct = new SqlDataAdapter(cmdProductDetails);
            daProduct.FillSchema(dspartyPlaza, SchemaType.Source, "Product");





        }
        private void butEditBooking_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value >= DateTime.Now)
            {
                if (btnEditBooking.Text == "Edit Booking")
                {
                    pnlAddEdit.Enabled = true;
                    btnEditBooking.Text = "Save";

                  
                }
                else
                {
                    DataRow drBooking = dspartyPlaza.Tables["BookingDet2"].Rows.Find(listBoxBooking.Text);


                    drBooking.BeginEdit();

                    drBooking["DateStart"] = Convert.ToDateTime(dtpStartDate.Value);


                    drBooking.EndEdit();
                    daBooking2.Update(dspartyPlaza, "Booking2");

                    pnlAddEdit.Enabled = false;
                    btnEditBooking.Text = "Add Item";

                 
                }
            }

        }
        private void listBoxBooking_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            listViewBooking.Enabled = true;

            if (listViewBooking.Items.Count != 0)
            {
                DataRow drBooking = dspartyPlaza.Tables["Booking"].Rows.Find(listBoxBooking.SelectedValue);

                labBookingDate.Text = (Convert.ToDateTime(drBooking["DateBooked"].ToString())).ToShortTimeString();

                dtpStartDate.Value = Convert.ToDateTime(drBooking["DateStart"].ToString());


                if (dtpStartDate.Value < DateTime.Now)
                {
                    dtpStartDate.Enabled = false;

                    listViewBooking.Enabled = false;
                }

                dspartyPlaza.Tables["@BookingDet"].Clear();

                cmdBooking.Parameters["@BookingNo"].Value = listBoxBooking.SelectedValue;
                daBooking.Fill(dspartyPlaza, "BookingDet");

                foreach (DataRow dr in dspartyPlaza.Tables["BookingDet"].Rows)
                {
                    if (dr["BookingNo"].ToString() == listBoxBooking.Text)
                    {
                        ListViewItem item = new ListViewItem(dr["DogNo"].ToString());
                        item.SubItems.Add(dr["KennelNo"].ToString());
                        listViewBooking.Items.Add(item);

                    }
                }
            }
        }

        private void butDeleteItem_Click(object sender, EventArgs e)
        {
            if (listViewBooking.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the Booking details for Dog no: "
                    + listViewBooking.SelectedItems[0].SubItems[0].Text + "?", "Delete Dog Details",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    object[] primaryKey = new object[2];

                    ListViewItem currItem = listViewBooking.SelectedItems[0];

                    primaryKey[0] = Convert.ToInt32(listViewBooking);
                    primaryKey[1] = Convert.ToInt32(currItem.SubItems[0].Text);


                    DataRow drBookingDet = dspartyPlaza.Tables["BookingDet2"].Rows.Find(primaryKey);

                    listViewBooking.Items.Remove(currItem);

                    drBookingDet.Delete();
                    daBookingDet2.Update(dspartyPlaza, "BookingDet2");

                    if (listViewBooking.Items.Count != 0)
                    {
                        MessageBox.Show("As there are no booking details, Booking No " + primaryKey[0].ToString() +
                            " will now be deleted");

                        DataRow drBooking = dspartyPlaza.Tables["Booking2"].Rows.Find(primaryKey[0]);

                        drBooking.Delete();
                        daBooking2.Update(dspartyPlaza, "Booking2");

                        PopulateBookingListBox();
                    }
                }
            }
        }
        private void PopulateBookingListBox()
        {
            dspartyPlaza.Tables["Booking"].Clear();

            cmdBooking.Parameters["@CustNo"].Value = listBoxCust.SelectedValue;

            daBooking.Fill(dspartyPlaza, "Booking");

            listBoxBooking.DataSource = dspartyPlaza.Tables["Booking"];
            listBoxBooking.DisplayMember = "BookingNo";
            listBoxBooking.ValueMember = "BookingNo";
        }

        private void PopulateBookingDetListBox()
        {
            dspartyPlaza.Tables["Booking"].Clear();

            cmdBookingDetails.Parameters["@CustNo"].Value = listBoxCust.SelectedValue;

            daBooking.Fill(dspartyPlaza, "Booking");

            listBoxBookingDet.DataSource = dspartyPlaza.Tables["Booking"];
            listBoxBookingDet.DisplayMember = "BookingNo";
            listBoxBookingDet.ValueMember = "BookingNo";
        }


        private void butDeleteBooking_Click(object sender, EventArgs e)
        {
            if (listBoxBooking.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the Booking details for Dog no: "
                    + listViewBooking.SelectedItems[0].SubItems[0].Text + "?", "Delete Dog Details",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    object[] primaryKey = new object[2];

                    foreach (ListViewItem item in listViewBooking.Items)
                    {

                        primaryKey[0] = Convert.ToInt32(listViewBooking);
                        primaryKey[1] = Convert.ToInt32(item.SubItems[0].Text);

                        DataRow drBookingDet = dspartyPlaza.Tables["BookingDet2"].Rows.Find(primaryKey);

                        listViewBooking.Items.Remove(item);

                        drBookingDet.Delete();
                        daBookingDet2.Update(dspartyPlaza, "BookingDet2");

                    }


                    if (listViewBooking.Items.Count != 0)
                    {
                        DataRow drBookingDet = dspartyPlaza.Tables["BookingDet2"].Rows.Find(primaryKey[0]);
                        MessageBox.Show("As there are no booking details, Booking No " + primaryKey[0].ToString() +
                                " will now be deleted");

                        DataRow drBooking = dspartyPlaza.Tables["Booking2"].Rows.Find(primaryKey[0]);

                        drBooking.Delete();
                        daBooking2.Update(dspartyPlaza, "Booking2");

                        PopulateBookingListBox();


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
            if (listBoxBookingDet.SelectedIndex == -1)
                MessageBox.Show("Please select a dog", "dog");
            if (listBoxCustomer.SelectedIndex == -1)
                MessageBox.Show("Please select a kennel", "kennel");

            if (listViewBooking.Items.Count == 0)
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

                foreach (ListViewItem item in listViewBooking.Items)
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
        

        private void butEditItem_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Enabled = true;

        }

        private void butRemoveItem_Click(object sender, EventArgs e)
        {
            if (listViewBooking.SelectedItems.Count != 0)
            {
                var item = listViewBooking.SelectedItems[0];
                listViewBooking.Items.Remove(item);
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
