namespace TaxiApp
{
    partial class MainMenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.tabPointer = new System.Windows.Forms.Panel();
            this.FeedbackTab = new System.Windows.Forms.Button();
            this.DiscountsTab = new System.Windows.Forms.Button();
            this.ReviewsTab = new System.Windows.Forms.Button();
            this.DriversTab = new System.Windows.Forms.Button();
            this.ReportsTab = new System.Windows.Forms.Button();
            this.HomeTab = new System.Windows.Forms.Button();
            this.topUIPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.accountStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeControl = new TaxiApp.Forms.HomeControl();
            this.reportsControl = new TaxiApp.Controlls.ReportsControl();
            this.driverControl = new TaxiApp.Controlls.DriversControl();
            this.reviewsControl = new TaxiApp.Controlls.ReviewsControl();
            this.discountControl = new TaxiApp.Controlls.DiscountControl();
            this.feedbackControl = new TaxiApp.Controlls.FeedbackControl();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.menuPanel.Controls.Add(this.tabPointer);
            this.menuPanel.Controls.Add(this.FeedbackTab);
            this.menuPanel.Controls.Add(this.DiscountsTab);
            this.menuPanel.Controls.Add(this.ReviewsTab);
            this.menuPanel.Controls.Add(this.DriversTab);
            this.menuPanel.Controls.Add(this.ReportsTab);
            this.menuPanel.Controls.Add(this.HomeTab);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(176, 514);
            this.menuPanel.TabIndex = 0;
            // 
            // tabPointer
            // 
            this.tabPointer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.tabPointer.Location = new System.Drawing.Point(0, 60);
            this.tabPointer.Name = "tabPointer";
            this.tabPointer.Size = new System.Drawing.Size(5, 54);
            this.tabPointer.TabIndex = 6;
            // 
            // FeedbackTab
            // 
            this.FeedbackTab.FlatAppearance.BorderSize = 0;
            this.FeedbackTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedbackTab.Font = new System.Drawing.Font("Futura Md BT", 13.5F);
            this.FeedbackTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.FeedbackTab.Image = global::TaxiApp.Properties.Resources.ic_chat;
            this.FeedbackTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FeedbackTab.Location = new System.Drawing.Point(22, 360);
            this.FeedbackTab.Name = "FeedbackTab";
            this.FeedbackTab.Size = new System.Drawing.Size(136, 54);
            this.FeedbackTab.TabIndex = 5;
            this.FeedbackTab.Text = "Feedback";
            this.FeedbackTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FeedbackTab.UseVisualStyleBackColor = true;
            this.FeedbackTab.Click += new System.EventHandler(this.FeedbackTab_Click);
            // 
            // DiscountsTab
            // 
            this.DiscountsTab.FlatAppearance.BorderSize = 0;
            this.DiscountsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscountsTab.Font = new System.Drawing.Font("Futura Md BT", 13.5F);
            this.DiscountsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.DiscountsTab.Image = global::TaxiApp.Properties.Resources.ic_card;
            this.DiscountsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiscountsTab.Location = new System.Drawing.Point(22, 300);
            this.DiscountsTab.Name = "DiscountsTab";
            this.DiscountsTab.Size = new System.Drawing.Size(136, 54);
            this.DiscountsTab.TabIndex = 4;
            this.DiscountsTab.Text = "Discounts";
            this.DiscountsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiscountsTab.UseVisualStyleBackColor = true;
            this.DiscountsTab.Click += new System.EventHandler(this.DiscountsTab_Click);
            // 
            // ReviewsTab
            // 
            this.ReviewsTab.FlatAppearance.BorderSize = 0;
            this.ReviewsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewsTab.Font = new System.Drawing.Font("Futura Md BT", 13.5F);
            this.ReviewsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ReviewsTab.Image = global::TaxiApp.Properties.Resources.ic_humans;
            this.ReviewsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReviewsTab.Location = new System.Drawing.Point(22, 240);
            this.ReviewsTab.Name = "ReviewsTab";
            this.ReviewsTab.Size = new System.Drawing.Size(136, 54);
            this.ReviewsTab.TabIndex = 3;
            this.ReviewsTab.Text = "Reviews";
            this.ReviewsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReviewsTab.UseVisualStyleBackColor = true;
            this.ReviewsTab.Click += new System.EventHandler(this.ReviewsTab_Click);
            // 
            // DriversTab
            // 
            this.DriversTab.FlatAppearance.BorderSize = 0;
            this.DriversTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriversTab.Font = new System.Drawing.Font("Futura Md BT", 13.5F);
            this.DriversTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.DriversTab.Image = global::TaxiApp.Properties.Resources.ic_car;
            this.DriversTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DriversTab.Location = new System.Drawing.Point(22, 180);
            this.DriversTab.Name = "DriversTab";
            this.DriversTab.Size = new System.Drawing.Size(136, 54);
            this.DriversTab.TabIndex = 2;
            this.DriversTab.Text = "Drivers";
            this.DriversTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DriversTab.UseVisualStyleBackColor = true;
            this.DriversTab.Click += new System.EventHandler(this.DriversTab_Click);
            // 
            // ReportsTab
            // 
            this.ReportsTab.FlatAppearance.BorderSize = 0;
            this.ReportsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsTab.Font = new System.Drawing.Font("Futura Md BT", 13.5F);
            this.ReportsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ReportsTab.Image = ((System.Drawing.Image)(resources.GetObject("ReportsTab.Image")));
            this.ReportsTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportsTab.Location = new System.Drawing.Point(22, 120);
            this.ReportsTab.Name = "ReportsTab";
            this.ReportsTab.Size = new System.Drawing.Size(136, 54);
            this.ReportsTab.TabIndex = 1;
            this.ReportsTab.Text = "Reports";
            this.ReportsTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportsTab.UseVisualStyleBackColor = true;
            this.ReportsTab.Click += new System.EventHandler(this.ReportsTab_Click);
            // 
            // HomeTab
            // 
            this.HomeTab.FlatAppearance.BorderSize = 0;
            this.HomeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeTab.Font = new System.Drawing.Font("Futura Md BT", 13.5F);
            this.HomeTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.HomeTab.Image = global::TaxiApp.Properties.Resources.ic_home;
            this.HomeTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeTab.Location = new System.Drawing.Point(22, 60);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(136, 54);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeTab.UseVisualStyleBackColor = true;
            this.HomeTab.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // topUIPanel
            // 
            this.topUIPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.topUIPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topUIPanel.Location = new System.Drawing.Point(176, 0);
            this.topUIPanel.Name = "topUIPanel";
            this.topUIPanel.Size = new System.Drawing.Size(722, 5);
            this.topUIPanel.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.logoPanel.Controls.Add(this.logo);
            this.logoPanel.Location = new System.Drawing.Point(210, 5);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(104, 104);
            this.logoPanel.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Harlow Solid Italic", 42F, System.Drawing.FontStyle.Italic);
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.logo.Location = new System.Drawing.Point(-7, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(114, 71);
            this.logo.TabIndex = 0;
            this.logo.Text = "TL";
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::TaxiApp.Properties.Resources.icons8_shutdown_60;
            this.exitBtn.Location = new System.Drawing.Point(836, 18);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(25, 25);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 9;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = global::TaxiApp.Properties.Resources.ic_settings_64;
            this.settingsBtn.Location = new System.Drawing.Point(799, 18);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(25, 25);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBtn.TabIndex = 10;
            this.settingsBtn.TabStop = false;
            // 
            // accountStatusBindingSource
            // 
            this.accountStatusBindingSource.DataMember = "AccountStatus";
            // 
            // homeControl
            // 
            this.homeControl.Location = new System.Drawing.Point(176, 110);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(702, 384);
            this.homeControl.TabIndex = 3;
            // 
            // reportsControl
            // 
            this.reportsControl.Location = new System.Drawing.Point(176, 110);
            this.reportsControl.Name = "reportsControl";
            this.reportsControl.Size = new System.Drawing.Size(702, 384);
            this.reportsControl.TabIndex = 4;
            // 
            // driverControl
            // 
            this.driverControl.Location = new System.Drawing.Point(176, 110);
            this.driverControl.Name = "driverControl";
            this.driverControl.Size = new System.Drawing.Size(702, 384);
            this.driverControl.TabIndex = 11;
            // 
            // reviewsControl
            // 
            this.reviewsControl.Location = new System.Drawing.Point(176, 110);
            this.reviewsControl.Name = "reviewsControl";
            this.reviewsControl.Size = new System.Drawing.Size(702, 384);
            this.reviewsControl.TabIndex = 12;
            // 
            // discountControl
            // 
            this.discountControl.Location = new System.Drawing.Point(176, 110);
            this.discountControl.Name = "discountControl";
            this.discountControl.Size = new System.Drawing.Size(702, 384);
            this.discountControl.TabIndex = 13;
            // 
            // feedbackControl
            // 
            this.feedbackControl.Location = new System.Drawing.Point(176, 110);
            this.feedbackControl.Name = "feedbackControl";
            this.feedbackControl.Size = new System.Drawing.Size(702, 384);
            this.feedbackControl.TabIndex = 14;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(898, 514);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.reportsControl);
            this.Controls.Add(this.driverControl);
            this.Controls.Add(this.reviewsControl);
            this.Controls.Add(this.discountControl);
            this.Controls.Add(this.feedbackControl);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.topUIPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topUIPanel;
        private System.Windows.Forms.Panel logoPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel logo;
        private System.Windows.Forms.Button HomeTab;
        private System.Windows.Forms.Button FeedbackTab;
        private System.Windows.Forms.Button DiscountsTab;
        private System.Windows.Forms.Button ReviewsTab;
        private System.Windows.Forms.Button DriversTab;
        private System.Windows.Forms.Button ReportsTab;
        private System.Windows.Forms.Panel tabPointer;
        private Forms.HomeControl homeControl;
        private Controlls.ReportsControl reportsControl;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.PictureBox settingsBtn;
        private System.Windows.Forms.BindingSource accountStatusBindingSource;
        private Controlls.DriversControl driverControl;
        private Controlls.ReviewsControl reviewsControl;
        private Controlls.DiscountControl discountControl;
        private Controlls.FeedbackControl feedbackControl;
    }
}