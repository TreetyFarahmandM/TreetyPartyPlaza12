namespace PartyPlaza
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplayExit = new System.Windows.Forms.PictureBox();
            this.ButBooking = new System.Windows.Forms.PictureBox();
            this.ButSupplier = new System.Windows.Forms.PictureBox();
            this.ButOrder = new System.Windows.Forms.PictureBox();
            this.ButCustomer = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisplayExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BackgroundImage = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__10_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnDisplayExit);
            this.panel1.Controls.Add(this.ButBooking);
            this.panel1.Controls.Add(this.ButSupplier);
            this.panel1.Controls.Add(this.ButOrder);
            this.panel1.Controls.Add(this.ButCustomer);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 520);
            this.panel1.TabIndex = 0;
            // 
            // btnDisplayExit
            // 
            this.btnDisplayExit.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplayExit.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__14_;
            this.btnDisplayExit.Location = new System.Drawing.Point(31, 398);
            this.btnDisplayExit.Name = "btnDisplayExit";
            this.btnDisplayExit.Size = new System.Drawing.Size(104, 89);
            this.btnDisplayExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDisplayExit.TabIndex = 9;
            this.btnDisplayExit.TabStop = false;
            this.btnDisplayExit.Click += new System.EventHandler(this.btnDisplayExit_Click);
            // 
            // ButBooking
            // 
            this.ButBooking.BackColor = System.Drawing.Color.Transparent;
            this.ButBooking.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__8_;
            this.ButBooking.Location = new System.Drawing.Point(31, 9);
            this.ButBooking.Name = "ButBooking";
            this.ButBooking.Size = new System.Drawing.Size(104, 89);
            this.ButBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButBooking.TabIndex = 8;
            this.ButBooking.TabStop = false;
            this.ButBooking.Click += new System.EventHandler(this.ButBooking_Click);
            this.ButBooking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseDown);
            this.ButBooking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseUp);
            // 
            // ButSupplier
            // 
            this.ButSupplier.BackColor = System.Drawing.Color.Transparent;
            this.ButSupplier.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__9_;
            this.ButSupplier.Location = new System.Drawing.Point(31, 293);
            this.ButSupplier.Name = "ButSupplier";
            this.ButSupplier.Size = new System.Drawing.Size(104, 89);
            this.ButSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButSupplier.TabIndex = 6;
            this.ButSupplier.TabStop = false;
            this.ButSupplier.Click += new System.EventHandler(this.pictureBox5_Click);
            this.ButSupplier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            this.ButSupplier.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseUp);
            // 
            // ButOrder
            // 
            this.ButOrder.BackColor = System.Drawing.Color.Transparent;
            this.ButOrder.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__1_;
            this.ButOrder.Location = new System.Drawing.Point(31, 199);
            this.ButOrder.Name = "ButOrder";
            this.ButOrder.Size = new System.Drawing.Size(104, 89);
            this.ButOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButOrder.TabIndex = 5;
            this.ButOrder.TabStop = false;
            this.ButOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.ButOrder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // ButCustomer
            // 
            this.ButCustomer.BackColor = System.Drawing.Color.Transparent;
            this.ButCustomer.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__7_;
            this.ButCustomer.Location = new System.Drawing.Point(31, 104);
            this.ButCustomer.Name = "ButCustomer";
            this.ButCustomer.Size = new System.Drawing.Size(104, 89);
            this.ButCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButCustomer.TabIndex = 4;
            this.ButCustomer.TabStop = false;
            this.ButCustomer.Click += new System.EventHandler(this.ButCustomer_Click);
            this.ButCustomer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.ButCustomer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(161, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(897, 517);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlMain_ControlRemoved);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PartyPlaza.Properties.Resources.MicrosoftTeams_image__13_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1075, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDisplayExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox ButBooking;
        private PictureBox ButSupplier;
        private PictureBox ButOrder;
        private PictureBox ButCustomer;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private PictureBox btnDisplayExit;
    }
}