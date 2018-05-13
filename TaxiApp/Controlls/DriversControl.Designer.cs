namespace TaxiApp.Controlls
{
    partial class DriversControl
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
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new TaxiApp.TaxiDataSet();
            this.driversTableAdapter = new TaxiApp.TaxiDataSetTableAdapters.DriversTableAdapter();
            this.driversList = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Car = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversRefresh = new System.Windows.Forms.PictureBox();
            this.orderMainPanel = new System.Windows.Forms.Panel();
            this.newDriverNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newDriverColor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newDriverBrand = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newDriverSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newDriverName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.startTripButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.newDriverTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversRefresh)).BeginInit();
            this.orderMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // taxiDataSetBindingSource
            // 
            this.taxiDataSetBindingSource.DataSource = this.taxiDataSet;
            this.taxiDataSetBindingSource.Position = 0;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // driversList
            // 
            this.driversList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driversList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Surname,
            this.Car,
            this.Rating});
            this.driversList.Location = new System.Drawing.Point(22, 18);
            this.driversList.Name = "driversList";
            this.driversList.Size = new System.Drawing.Size(245, 344);
            this.driversList.TabIndex = 1;
            this.driversList.UseCompatibleStateImageBehavior = false;
            this.driversList.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            // 
            // Car
            // 
            this.Car.Text = "Car";
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            // 
            // driversRefresh
            // 
            this.driversRefresh.Image = global::TaxiApp.Properties.Resources.icons8_restart_filled_50;
            this.driversRefresh.Location = new System.Drawing.Point(284, 18);
            this.driversRefresh.Name = "driversRefresh";
            this.driversRefresh.Size = new System.Drawing.Size(20, 20);
            this.driversRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.driversRefresh.TabIndex = 2;
            this.driversRefresh.TabStop = false;
            this.driversRefresh.Click += new System.EventHandler(this.driversRefresh_Click);
            // 
            // orderMainPanel
            // 
            this.orderMainPanel.Controls.Add(this.newDriverNumber);
            this.orderMainPanel.Controls.Add(this.newDriverColor);
            this.orderMainPanel.Controls.Add(this.newDriverBrand);
            this.orderMainPanel.Controls.Add(this.newDriverSurname);
            this.orderMainPanel.Controls.Add(this.newDriverName);
            this.orderMainPanel.Controls.Add(this.startTripButton);
            this.orderMainPanel.Controls.Add(this.newDriverTitle);
            this.orderMainPanel.Location = new System.Drawing.Point(323, 18);
            this.orderMainPanel.Name = "orderMainPanel";
            this.orderMainPanel.Size = new System.Drawing.Size(350, 344);
            this.orderMainPanel.TabIndex = 3;
            // 
            // newDriverNumber
            // 
            this.newDriverNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newDriverNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newDriverNumber.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.newDriverNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newDriverNumber.HintForeColor = System.Drawing.Color.DimGray;
            this.newDriverNumber.HintText = "Registraition Number";
            this.newDriverNumber.isPassword = false;
            this.newDriverNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.newDriverNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverNumber.LineThickness = 2;
            this.newDriverNumber.Location = new System.Drawing.Point(4, 132);
            this.newDriverNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newDriverNumber.Name = "newDriverNumber";
            this.newDriverNumber.Size = new System.Drawing.Size(314, 27);
            this.newDriverNumber.TabIndex = 18;
            this.newDriverNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newDriverColor
            // 
            this.newDriverColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newDriverColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newDriverColor.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.newDriverColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newDriverColor.HintForeColor = System.Drawing.Color.DimGray;
            this.newDriverColor.HintText = "Car Color";
            this.newDriverColor.isPassword = false;
            this.newDriverColor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.newDriverColor.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverColor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverColor.LineThickness = 2;
            this.newDriverColor.Location = new System.Drawing.Point(165, 86);
            this.newDriverColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newDriverColor.Name = "newDriverColor";
            this.newDriverColor.Size = new System.Drawing.Size(153, 27);
            this.newDriverColor.TabIndex = 17;
            this.newDriverColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newDriverBrand
            // 
            this.newDriverBrand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newDriverBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newDriverBrand.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.newDriverBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newDriverBrand.HintForeColor = System.Drawing.Color.DimGray;
            this.newDriverBrand.HintText = "Car Brand";
            this.newDriverBrand.isPassword = false;
            this.newDriverBrand.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.newDriverBrand.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverBrand.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverBrand.LineThickness = 2;
            this.newDriverBrand.Location = new System.Drawing.Point(4, 86);
            this.newDriverBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newDriverBrand.Name = "newDriverBrand";
            this.newDriverBrand.Size = new System.Drawing.Size(153, 27);
            this.newDriverBrand.TabIndex = 16;
            this.newDriverBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newDriverSurname
            // 
            this.newDriverSurname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newDriverSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newDriverSurname.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.newDriverSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newDriverSurname.HintForeColor = System.Drawing.Color.DimGray;
            this.newDriverSurname.HintText = "Surname";
            this.newDriverSurname.isPassword = false;
            this.newDriverSurname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.newDriverSurname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverSurname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverSurname.LineThickness = 2;
            this.newDriverSurname.Location = new System.Drawing.Point(165, 41);
            this.newDriverSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newDriverSurname.Name = "newDriverSurname";
            this.newDriverSurname.Size = new System.Drawing.Size(153, 27);
            this.newDriverSurname.TabIndex = 15;
            this.newDriverSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newDriverName
            // 
            this.newDriverName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newDriverName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newDriverName.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.newDriverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newDriverName.HintForeColor = System.Drawing.Color.DimGray;
            this.newDriverName.HintText = "Name";
            this.newDriverName.isPassword = false;
            this.newDriverName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.newDriverName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.newDriverName.LineThickness = 2;
            this.newDriverName.Location = new System.Drawing.Point(4, 41);
            this.newDriverName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newDriverName.Name = "newDriverName";
            this.newDriverName.Size = new System.Drawing.Size(153, 27);
            this.newDriverName.TabIndex = 14;
            this.newDriverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // startTripButton
            // 
            this.startTripButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.startTripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.startTripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTripButton.BorderRadius = 7;
            this.startTripButton.ButtonText = "Add";
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
            this.startTripButton.Location = new System.Drawing.Point(87, 299);
            this.startTripButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTripButton.Name = "startTripButton";
            this.startTripButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.startTripButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.startTripButton.OnHoverTextColor = System.Drawing.Color.White;
            this.startTripButton.selected = false;
            this.startTripButton.Size = new System.Drawing.Size(164, 40);
            this.startTripButton.TabIndex = 13;
            this.startTripButton.Text = "Add";
            this.startTripButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startTripButton.Textcolor = System.Drawing.Color.White;
            this.startTripButton.TextFont = new System.Drawing.Font("Futura Md BT", 14F);
            this.startTripButton.Click += new System.EventHandler(this.startTripButton_Click);
            // 
            // newDriverTitle
            // 
            this.newDriverTitle.AutoSize = true;
            this.newDriverTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.newDriverTitle.Location = new System.Drawing.Point(3, 7);
            this.newDriverTitle.Name = "newDriverTitle";
            this.newDriverTitle.Size = new System.Drawing.Size(145, 17);
            this.newDriverTitle.TabIndex = 0;
            this.newDriverTitle.Text = "Connect driver";
            // 
            // DriversControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderMainPanel);
            this.Controls.Add(this.driversRefresh);
            this.Controls.Add(this.driversList);
            this.Size = new System.Drawing.Size(702, 384);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversRefresh)).EndInit();
            this.orderMainPanel.ResumeLayout(false);
            this.orderMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.BindingSource taxiDataSetBindingSource;
        private TaxiDataSet taxiDataSet;
        private TaxiDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.ListView driversList;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Car;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.PictureBox driversRefresh;
        private System.Windows.Forms.Panel orderMainPanel;
        private Bunifu.Framework.UI.BunifuFlatButton startTripButton;
        private Bunifu.Framework.UI.BunifuCustomLabel newDriverTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newDriverSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newDriverName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newDriverBrand;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newDriverColor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newDriverNumber;
    }
}
