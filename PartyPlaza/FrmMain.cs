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
        private void frmMain_Load(object sender, EventArgs e)
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
                    //c.Text = temp.ToString();
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
                        FrmDisplayBooking frmBook = new FrmDisplayBooking();
                        frmBook.TopLevel = false;
                        frmBook.FormBorderStyle = FormBorderStyle.None;
                        frmBook.WindowState = FormWindowState.Maximized;
                        pnlMain.Controls.Add(frmBook);
                        frmBook.Show();
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
                        //Order button
                        break;

                    case 4:

                        //FrmSupplier supplier = new FrmSupplier();
                        //supplier.TopLevel = false;
                        //supplier.FormBorderStyle = FormBorderStyle.None;
                        //supplier.WindowState = FormWindowState.Maximized;
                        //pnlMain.Controls.Add(supplier);
                        //supplier.Show();

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
        private void pnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (MyGlobals.frmEditCustomer)
            {
                FrmEditCustomer frmEditCust = new FrmEditCustomer();
              frmEditCust.TopLevel = false;
              frmEditCust.FormBorderStyle = FormBorderStyle.None;
              frmEditCust.WindowState = FormWindowState.Maximized;
              pnlMain.Controls.Add(frmEditCust);
              frmEditCust.Show();
            }
            if (MyGlobals.frmAddCustomer)
            {
                FrmAddCustomer frmAddCust = new FrmAddCustomer();
                frmAddCust.TopLevel = false;
                frmAddCust.FormBorderStyle = FormBorderStyle.None;
                frmAddCust.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmAddCust);
                frmAddCust.Show();
            }
            if (MyGlobals.frmEditBooking)
            {
                FrmEditBooking frmEditCust = new FrmEditBooking();
                frmEditCust.TopLevel = false;
                frmEditCust.FormBorderStyle = FormBorderStyle.None;
                frmEditCust.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmEditCust);
                frmEditCust.Show();
            }
            if (MyGlobals.frmBooking)
            {
                FrmBooking frmAddBook = new FrmBooking();
                frmAddBook.TopLevel = false;
                frmAddBook.FormBorderStyle = FormBorderStyle.None;
                frmAddBook.WindowState = FormWindowState.Maximized;
                pnlMain.Controls.Add(frmAddBook);
                frmAddBook.Show();
            }
            //if (MyGlobals.frmEditSupplier)
            //{
            //    FrmEditSupplier frmEditSupp = new FrmEditSupplier();
            //    frmEditSupp.TopLevel = false;
            //    frmEditSupp.FormBorderStyle = FormBorderStyle.None;
            //    frmEditSupp.WindowState = FormWindowState.Maximized;
            //    pnlMain.Controls.Add(frmEditSupp);
            //    frmEditSupp.Show();
            //}
            //else if (MyGlobals.frmAddSupplier)
            //{
            //    FrmAddSupplier frmAddSupp = new FrmAddSupplier();
            //    frmAddSupp.TopLevel = false;
            //    frmAddSupp.FormBorderStyle = FormBorderStyle.None;
            //    frmAddSupp.WindowState = FormWindowState.Maximized;
            //    pnlMain.Controls.Add(frmAddSupp);
            //    frmAddSupp.Show();
            //}
            //else if (MyGlobals.frmAddOrder)
            //{
            //    FrmAddOrder frmAddOrderProduct = new FrmAddOrder();
            //    frmAddOrderProduct.TopLevel = false;
            //    frmAddOrderProduct.FormBorderStyle = FormBorderStyle.None;
            //    frmAddOrderProduct.WindowState = FormWindowState.Maximized;
            //    pnlMain.Controls.Add(frmAddOrderProduct);
            //    frmAddOrderProduct.Show();
            //}
            //else if (MyGlobals.frmEditOrder)
            //{
            //    FrmEditOrder frmEditOrderProduct = new FrmEditOrder();
            //    frmEditOrderProduct.TopLevel = false;
            //    frmEditOrderProduct.FormBorderStyle = FormBorderStyle.None;
            //    frmEditOrderProduct.WindowState = FormWindowState.Maximized;
            //    pnlMain.Controls.Add(frmEditOrderProduct);
            //    frmEditOrderProduct.Show();
            // }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
            ButOrder.BackColor = Color.LightGray;
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ButSupplier.BackColor = Color.LightGray;
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
            ButOrder.BackColor = Color.Transparent;
        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            ButSupplier.BackColor = Color.Transparent;
        }
        private void ButBooking_Click(object sender, EventArgs e)
        {
          

            FrmDisplayBooking frmBook = new FrmDisplayBooking();
            frmBook.TopLevel = false;
            frmBook.FormBorderStyle = FormBorderStyle.None;
            frmBook.WindowState = FormWindowState.Maximized;
            pnlMain.Controls.Add(frmBook);
            frmBook.Show();



        }
        private void btnDisplayExit_Click(object sender, EventArgs e)
        {
           // MyGlobals.btnDisplayExit = false;
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
        private void ButOrder_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)

            //FrmBooking frmBook = new FrmBooking();
            //frmBook.TopLevel = false;
            //frmBook.FormBorderStyle = FormBorderStyle.None;
            //frmBook.WindowState = FormWindowState.Maximized;
            //pnlMain.Controls.Add(frmBook);
            //frmBook.Show();



        }
        private void ButSupplier_Click(object sender, EventArgs e)
        {
            //if (MyGlobals.frmEditForm)

            //FrmBooking frmBook = new FrmBooking();
            //frmBook.TopLevel = false;
            //frmBook.FormBorderStyle = FormBorderStyle.None;
            //frmBook.WindowState = FormWindowState.Maximized;
            //pnlMain.Controls.Add(frmBook);
            //frmBook.Show();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}