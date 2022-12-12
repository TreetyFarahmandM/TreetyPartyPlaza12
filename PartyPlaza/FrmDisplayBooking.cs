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
    public partial class FrmDisplayBooking : Form
    {
        public FrmDisplayBooking()
        {
            InitializeComponent();
        }

       
            SqlDataAdapter daBooking, daBookingDet, daChkBooking;
            DataSet partyPlaza = new DataSet();
            SqlCommandBuilder cmdBBooking, cmdBBookingDet;
            SqlCommand cmdChkBooking;
            SqlConnection conn;
            DataRow drBooking, drBookingDet;
            String connStr, sqlBooking, sqlBookingDet, sqlChkBooking;
           

            private void btnDelete_Click(object sender, EventArgs e)
            {
            cmdChkBooking.Parameters["@BookNo"].Value = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells[0].Value);
            daChkBooking.Fill(partyPlaza, "ChkBooking");

                if (partyPlaza.Tables["ChkBooking"].Rows.Count > 0)
                    MessageBox.Show("Can't delete");
                else
                     if (dgvBooking.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Please select a booking from the list.", " Booking");
                }
                else
                {
                drBooking = partyPlaza.Tables["Booking"].Rows.Find(dgvBooking.SelectedRows[0].Cells[0].Value);
                   

                    if (MessageBox.Show("Are you sure you want to delete " + " details? ", "Add Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                    drBooking.Delete();
                    daBooking.Update(partyPlaza, "Booking");
                    }
                }
            }
        private void FrmDisplayBooking_Load(object sender, EventArgs e)
        {

            connStr = @"Data Source = 286386-PC\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";
            sqlBooking = @"select * from Booking";
                daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);
                daBooking.FillSchema(partyPlaza, SchemaType.Source, "Booking");
                daBooking.Fill(partyPlaza, "Booking");


                dgvBooking.DataSource = partyPlaza.Tables["Booking"];
            dgvBooking.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);

                connStr = @"Data Source = 286386-PC\SQLEXPRESS01; Initial Catalog = PartyPlaza; Integrated Security = true";
                sqlBookingDet = @"select * from BookingDet";
                daBookingDet = new SqlDataAdapter(sqlBooking, connStr);
                cmdBBookingDet = new SqlCommandBuilder(daBookingDet);

            sqlChkBooking = @"Select * from Booking WHERE BookingNo LIKE @BookNo";
                conn = new SqlConnection(connStr);
            cmdChkBooking = new SqlCommand(sqlChkBooking, conn);
            cmdChkBooking.Parameters.Add("@BookNo", SqlDbType.Int);
            daChkBooking = new SqlDataAdapter(cmdChkBooking);
            daChkBooking.FillSchema(partyPlaza, SchemaType.Source, "ChkBooking");
            }

            private void butExitBook_Click(object sender, EventArgs e)
            {
                MyGlobals.frmClosing = true;
                Close();
            }
            private void frmDisplayBook_FormClosing(object sender, FormClosingEventArgs e)
            {
                MyGlobals.frmClosing = true;
            }
            private void butAddBook_Click(object sender, EventArgs e)
            {

                MyGlobals.frmBooking = true;
                Close();
            }
            private void butEditBook_Click(object sender, EventArgs e)
            {
                if (dgvBooking.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Booking", "Edit Booking");
                }
                else if (dgvBooking.SelectedRows.Count == 1)
                {
                

                MyGlobals.selectedCustNo = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells[0].Value);
                MyGlobals.frmEditBooking = true;
                Close();
                }
            }

          
            
        }
}
