namespace TaxiApp.Forms
{
    partial class HomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ordersList = new System.Windows.Forms.ListView();
            this.Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LandingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderMainPanel = new System.Windows.Forms.Panel();
            this.startTripButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.orderDriversDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.orderDiscountLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.orderTargetLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderLandingLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.callPic = new System.Windows.Forms.PictureBox();
            this.orderPhoneLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderClientLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.orderIdLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersList
            // 
            this.ordersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order,
            this.Client,
            this.Phone,
            this.LandingAddress,
            this.TargerAddress});
            this.ordersList.Location = new System.Drawing.Point(22, 18);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(428, 344);
            this.ordersList.TabIndex = 0;
            this.ordersList.UseCompatibleStateImageBehavior = false;
            this.ordersList.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.Order.Text = "Order";
            this.Order.Width = 55;
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.Width = 66;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 89;
            // 
            // LandingAddress
            // 
            this.LandingAddress.Text = "Landing Address";
            this.LandingAddress.Width = 109;
            // 
            // TargerAddress
            // 
            this.TargerAddress.Text = "Targer Address";
            this.TargerAddress.Width = 104;
            // 
            // orderMainPanel
            // 
            this.orderMainPanel.Controls.Add(this.startTripButton);
            this.orderMainPanel.Controls.Add(this.orderDriversDropdown);
            this.orderMainPanel.Controls.Add(this.orderDiscountLabel);
            this.orderMainPanel.Controls.Add(this.pictureBox2);
            this.orderMainPanel.Controls.Add(this.orderTargetLabel);
            this.orderMainPanel.Controls.Add(this.orderLandingLabel);
            this.orderMainPanel.Controls.Add(this.callPic);
            this.orderMainPanel.Controls.Add(this.orderPhoneLabel);
            this.orderMainPanel.Controls.Add(this.orderClientLabel);
            this.orderMainPanel.Controls.Add(this.orderIdLabel);
            this.orderMainPanel.Location = new System.Drawing.Point(502, 18);
            this.orderMainPanel.Name = "orderMainPanel";
            this.orderMainPanel.Size = new System.Drawing.Size(178, 344);
            this.orderMainPanel.TabIndex = 2;
            // 
            // startTripButton
            // 
            this.startTripButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.startTripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.startTripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTripButton.BorderRadius = 7;
            this.startTripButton.ButtonText = "Accept";
            this.startTripButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTripButton.DisabledColor = System.Drawing.Color.Gray;
            this.startTripButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.startTripButton.Iconcolor = System.Drawing.Color.Transparent;
            this.startTripButton.Iconimage = null;
            this.startTripButton.Iconimage_right = null;
            this.startTripButton.Iconimage_right_Selected = null;
            this.startTripButton.Iconimage_Selected = null;
            this.startTripButton.IconMarginLeft = 0;
            this.startTripButton.IconMarginRight = 0;
            this.startTripButton.IconRightVisible = true;
            this.startTripButton.IconRightZoom = 0D;
            this.startTripButton.IconVisible = true;
            this.startTripButton.IconZoom = 90D;
            this.startTripButton.IsTab = false;
            this.startTripButton.Location = new System.Drawing.Point(6, 304);
            this.startTripButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTripButton.Name = "startTripButton";
            this.startTripButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.startTripButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.startTripButton.OnHoverTextColor = System.Drawing.Color.White;
            this.startTripButton.selected = false;
            this.startTripButton.Size = new System.Drawing.Size(164, 40);
            this.startTripButton.TabIndex = 13;
            this.startTripButton.Text = "Accept";
            this.startTripButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startTripButton.Textcolor = System.Drawing.Color.White;
            this.startTripButton.TextFont = new System.Drawing.Font("Futura Md BT", 14F);
            this.startTripButton.Click += new System.EventHandler(this.startTripButton_Click);
            // 
            // orderDriversDropdown
            // 
            this.orderDriversDropdown.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.orderDriversDropdown.BackColor = System.Drawing.Color.Transparent;
            this.orderDriversDropdown.BorderRadius = 10;
            this.orderDriversDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.orderDriversDropdown.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.orderDriversDropdown.ForeColor = System.Drawing.Color.White;
            this.orderDriversDropdown.Items = new string[] {
        "Drivers"};
            this.orderDriversDropdown.Location = new System.Drawing.Point(6, 187);
            this.orderDriversDropdown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderDriversDropdown.Name = "orderDriversDropdown";
            this.orderDriversDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.orderDriversDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.orderDriversDropdown.selectedIndex = -1;
            this.orderDriversDropdown.Size = new System.Drawing.Size(164, 33);
            this.orderDriversDropdown.TabIndex = 8;
            // 
            // orderDiscountLabel
            // 
            this.orderDiscountLabel.AutoSize = true;
            this.orderDiscountLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.orderDiscountLabel.Location = new System.Drawing.Point(3, 139);
            this.orderDiscountLabel.Name = "orderDiscountLabel";
            this.orderDiscountLabel.Size = new System.Drawing.Size(112, 15);
            this.orderDiscountLabel.TabIndex = 7;
            this.orderDiscountLabel.Text = "Discount: VIP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TaxiApp.Properties.Resources.icons8_map_64;
            this.pictureBox2.Location = new System.Drawing.Point(6, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // orderTargetLabel
            // 
            this.orderTargetLabel.AutoSize = true;
            this.orderTargetLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.orderTargetLabel.Location = new System.Drawing.Point(28, 106);
            this.orderTargetLabel.Name = "orderTargetLabel";
            this.orderTargetLabel.Size = new System.Drawing.Size(142, 15);
            this.orderTargetLabel.TabIndex = 5;
            this.orderTargetLabel.Text = "Timiryazevo, 87/a";
            // 
            // orderLandingLabel
            // 
            this.orderLandingLabel.AutoSize = true;
            this.orderLandingLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.orderLandingLabel.Location = new System.Drawing.Point(3, 86);
            this.orderLandingLabel.Name = "orderLandingLabel";
            this.orderLandingLabel.Size = new System.Drawing.Size(109, 15);
            this.orderLandingLabel.TabIndex = 4;
            this.orderLandingLabel.Text = "Suharevo, 68";
            // 
            // callPic
            // 
            this.callPic.Image = global::TaxiApp.Properties.Resources.ic_call;
            this.callPic.Location = new System.Drawing.Point(6, 55);
            this.callPic.Name = "callPic";
            this.callPic.Size = new System.Drawing.Size(15, 15);
            this.callPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.callPic.TabIndex = 3;
            this.callPic.TabStop = false;
            // 
            // orderPhoneLabel
            // 
            this.orderPhoneLabel.AutoSize = true;
            this.orderPhoneLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 8F);
            this.orderPhoneLabel.Location = new System.Drawing.Point(23, 57);
            this.orderPhoneLabel.Name = "orderPhoneLabel";
            this.orderPhoneLabel.Size = new System.Drawing.Size(89, 12);
            this.orderPhoneLabel.TabIndex = 2;
            this.orderPhoneLabel.Text = "345-234-6453";
            // 
            // orderClientLabel
            // 
            this.orderClientLabel.AutoSize = true;
            this.orderClientLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.orderClientLabel.Location = new System.Drawing.Point(3, 35);
            this.orderClientLabel.Name = "orderClientLabel";
            this.orderClientLabel.Size = new System.Drawing.Size(59, 17);
            this.orderClientLabel.TabIndex = 1;
            this.orderClientLabel.Text = "Paula";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.orderIdLabel.Location = new System.Drawing.Point(3, 7);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(120, 17);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Order: #234";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaxiApp.Properties.Resources.icons8_restart_filled_50;
            this.pictureBox1.Location = new System.Drawing.Point(466, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            // 
            // accountStatusBindingSource
            // 
            this.accountStatusBindingSource.DataMember = "AccountStatus";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderMainPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ordersList);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(702, 384);
            this.orderMainPanel.ResumeLayout(false);
            this.orderMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource accountStatusBindingSource;
        private System.Windows.Forms.ListView ordersList;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader LandingAddress;
        private System.Windows.Forms.ColumnHeader TargerAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.Panel orderMainPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel orderIdLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel orderPhoneLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel orderClientLabel;
        private System.Windows.Forms.PictureBox callPic;
        private Bunifu.Framework.UI.BunifuCustomLabel orderTargetLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel orderLandingLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDropdown orderDriversDropdown;
        private Bunifu.Framework.UI.BunifuCustomLabel orderDiscountLabel;
        private Bunifu.Framework.UI.BunifuFlatButton startTripButton;
    }
}
