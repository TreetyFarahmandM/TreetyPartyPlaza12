using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlaza
{
    public partial class FrmMain : Form
    {
        int noMenuItems = 0;
        Label[] mnuItems;

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            int temp = 0, top = 0;

            foreach (Control c in pnlMain.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    noMenuItems += 1;
                }
            }
            mnuItems = new Label[noMenuItems];
            foreach (Control c in pnlMain.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    mnuItems[temp] = (Label)c;
                    
                    if (c.Tag.Equals("M"))
                    {
                        
                        c.Location = new Point(0, top);
                        top += 50;
                        c.Visible = true;
                        c.Tag = c.Tag + "V";
                    }
                    else
                    {
                        c.Tag = c.Tag + "I";
                    }
                    c.Font = new Font(c.Font, FontStyle.Bold);
                    c.Tag = c.Tag + temp.ToString();
                    temp++;
                }
            }
        }
        private void lblMenu_Click(object sender, EventArgs e)
        {
            int startIndex = 0, top = 0;
            Label lbl = (Label)sender;

            MyGlobals.frmClosing = false;
            MyGlobals.frmEditForm = false;

            //lblTex.Font = new Font(FontFamily.GenericSanSerif, 12.0F, FontStyle,Bold);
            startIndex = Convert.ToInt32(lbl.Tag.ToString().Substring(2, lbl.Tag.ToString().Length - 2));

            if (lbl.Tag.ToString().Substring(0, 2).Equals("SV"))
            {
                pnlMain.BackgroundImage = null;

                foreach (Control c in pnlMain.Controls)
                {
                    pnlMain.Controls.Remove(c);
                }
                switch (startIndex)
                {
                    case 1:
                        //Booking button
                        break;

                    case 2:
                        FrmCustomer frmCust = new FrmCustomer();
                        frmCust.TopLevel = false;
                        frmCust.FormBorderStyle = FormBorderStyle.None;
                        frmCust.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frmCust);
                        frmCust.Show();
                        break;

                    case 3:
                       
                        FrmOrder frmOrder = new FrmOrder();
                        frmOrder.TopLevel = false;
                        frmOrder.FormBorderStyle = FormBorderStyle.None;
                        frmOrder.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frmOrder);
                        frmOrder.Show();
                        break;

                    case 4:

                        FrmSupplier frmSupplier = new FrmSupplier();
                        frmSupplier.TopLevel = false;
                        frmSupplier.FormBorderStyle = FormBorderStyle.None;
                        frmSupplier.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frmSupplier);
                        frmSupplier.Show();

                        break;

                    case 5:
                        //Exit button
                        break;
                }
            }
            else
            {
                //MessageBox.Show(startIndex.ToString());

                for (int i = startIndex + 1; i < noMenuItems; i++)
                {
                    if (!mnuItems[i].Tag.ToString().Substring(0, 1).Equals("M"))
                    {
                        if (mnuItems[i].Tag.ToString().Substring(1, 1).Equals("V"))
                            mnuItems[i].Tag = mnuItems[i].Tag.ToString().Replace("V", "I");
                        else
                        {
                            mnuItems[i].Tag = mnuItems[i].Tag.ToString().Replace("I", "V");
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = 0; i < noMenuItems; i++)
                {
                    mnuItems[i].Visible = false;
                }
                for (int i = 0; i < noMenuItems; i++)
                {
                    if (mnuItems[i].Tag.ToString().Substring(1, 1).Equals("V"))
                    {
                        if (mnuItems[i].Tag.ToString().Substring(0, 1).Equals("M"))
                        {
                            mnuItems[i].Location = new Point(0, top);
                            top = +50;
                            mnuItems[i].Visible = true;
                        }
                        else
                        {

                            mnuItems[i].Location = new Point(0, top);
                            top = +50;
                            mnuItems[i].Visible = true;
                        }
                        mnuItems[i].Font = new Font(mnuItems[i].Font, FontStyle.Bold);
                    }

                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            btnSupplier.BackColor = Color.Transparent;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            ButBooking.BackColor = Color.LightGray;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ButCustomer.BackColor = Color.LightGray;
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            btnOrder.BackColor = Color.LightGray;
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            btnSupplier.BackColor = Color.LightGray;
        }
        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            ButBooking.BackColor = Color.Transparent;
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            ButCustomer.BackColor = Color.Transparent;
        }
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            btnOrder.BackColor = Color.Transparent;
        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            btnSupplier.BackColor = Color.Transparent;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void ButBooking_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)

            //FrmBooking frmBook = new FrmBooking();
            //frmBook.TopLevel = false;
            //frmBook.FormBorderStyle = FormBorderStyle.None;
            //frmBook.WindowState = FormWindowState.Maximized;
            //pnlMain.Controls.Add(frmBook);
            //frmBook.Show();



        }
        private void btnMainExit_Click(object sender, EventArgs e)
        {
            MyGlobals.btnDisplayExit = false;
            Close();
        }


        private void ButCustomer_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)
            
                FrmCustomer frmCust = new FrmCustomer();
                frmCust.TopLevel = false;
                frmCust.FormBorderStyle= FormBorderStyle.None;
                frmCust.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmCust);
                frmCust.Show();


            
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            //Loading Supplier Display Form to the main form

            FrmSupplier frmSupp = new FrmSupplier();
            frmSupp.TopLevel = false;
            frmSupp.FormBorderStyle = FormBorderStyle.None;
            frmSupp.WindowState = FormWindowState.Maximized;
            pnlMain.Controls.Add(frmSupp);
            frmSupp.Show();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Loading Order Display Form to the main form

            FrmOrder frmOrder = new FrmOrder();
            frmOrder.TopLevel = false;
            frmOrder.FormBorderStyle = FormBorderStyle.None;
            frmOrder.WindowState = FormWindowState.Maximized;
            pnlMain.Controls.Add(frmOrder);
            frmOrder.Show();
        }
        private void pnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (MyGlobals.frmEditSupplier)
            {
                FrmEditSupplier frmEditSupp = new FrmEditSupplier();
                frmEditSupp.TopLevel = false;
                frmEditSupp.FormBorderStyle = FormBorderStyle.None;
                frmEditSupp.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmEditSupp);
                frmEditSupp.Show();
            }
            else if (MyGlobals.frmAddSupplier)
            {
                FrmAddSupplier frmAddSupp = new FrmAddSupplier();
                frmAddSupp.TopLevel = false;
                frmAddSupp.FormBorderStyle = FormBorderStyle.None;
                frmAddSupp.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmAddSupp);
                frmAddSupp.Show();
            }
            else if (MyGlobals.frmAddOrder)
            {
                FrmAddOrder frmAddOrder = new FrmAddOrder();
                frmAddOrder.TopLevel = false;
                frmAddOrder.FormBorderStyle = FormBorderStyle.None;
                frmAddOrder.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmAddOrder);
                frmAddOrder.Show();
            }
            else if (MyGlobals.frmEditOrder)
            {
                FrmEditOrder frmEditOrder = new FrmEditOrder();
                frmEditOrder.TopLevel = false;
                frmEditOrder.FormBorderStyle = FormBorderStyle.None;
                frmEditOrder.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmEditOrder);
                frmEditOrder.Show();
            }
        }

        private void btnMianExit_Click(object sender, EventArgs e)
        {
            MyGlobals.btnDisplayExit = false;
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}