namespace TaxiApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TitleLoginScreen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signUpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.termsCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.signupPassword1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signupUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signupSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signupName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signupLoginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginUsername
            // 
            this.loginUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginUsername.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.loginUsername.ForeColor = System.Drawing.Color.White;
            this.loginUsername.HintForeColor = System.Drawing.Color.DimGray;
            this.loginUsername.HintText = "User Name";
            this.loginUsername.isPassword = false;
            this.loginUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.loginUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.loginUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.loginUsername.LineThickness = 2;
            this.loginUsername.Location = new System.Drawing.Point(284, 222);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(4);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(379, 33);
            this.loginUsername.TabIndex = 0;
            this.loginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginPassword
            // 
            this.loginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPassword.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.loginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginPassword.HintForeColor = System.Drawing.Color.White;
            this.loginPassword.HintText = "Password";
            this.loginPassword.isPassword = true;
            this.loginPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.loginPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.loginPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.loginPassword.LineThickness = 2;
            this.loginPassword.Location = new System.Drawing.Point(284, 273);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(379, 33);
            this.loginPassword.TabIndex = 4;
            this.loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 7;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(247, 352);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(416, 49);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Futura Md BT", 14F);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TitleLoginScreen
            // 
            this.TitleLoginScreen.AutoSize = true;
            this.TitleLoginScreen.Font = new System.Drawing.Font("Harlow Solid Italic", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLoginScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.TitleLoginScreen.Location = new System.Drawing.Point(249, 50);
            this.TitleLoginScreen.Name = "TitleLoginScreen";
            this.TitleLoginScreen.Size = new System.Drawing.Size(411, 121);
            this.TitleLoginScreen.TabIndex = 6;
            this.TitleLoginScreen.Text = "Taxi Lab";
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Font = new System.Drawing.Font("Futura Md BT", 14F);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUp.Location = new System.Drawing.Point(422, 424);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(72, 22);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.signupPanel.Controls.Add(this.signupLoginButton);
            this.signupPanel.Controls.Add(this.bunifuCustomLabel1);
            this.signupPanel.Controls.Add(this.signUpButton);
            this.signupPanel.Controls.Add(this.termsCheckbox);
            this.signupPanel.Controls.Add(this.signupPassword1);
            this.signupPanel.Controls.Add(this.signupUsername);
            this.signupPanel.Controls.Add(this.signupSurname);
            this.signupPanel.Controls.Add(this.signupName);
            this.signupPanel.Location = new System.Drawing.Point(247, 174);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(416, 308);
            this.signupPanel.TabIndex = 9;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 212);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(266, 15);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "I Accept the Terms and Condition";
            // 
            // signUpButton
            // 
            this.signUpButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpButton.BorderRadius = 7;
            this.signUpButton.ButtonText = "SignUp";
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.DisabledColor = System.Drawing.Color.Gray;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.signUpButton.Iconcolor = System.Drawing.Color.Transparent;
            this.signUpButton.Iconimage = null;
            this.signUpButton.Iconimage_right = null;
            this.signUpButton.Iconimage_right_Selected = null;
            this.signUpButton.Iconimage_Selected = null;
            this.signUpButton.IconMarginLeft = 0;
            this.signUpButton.IconMarginRight = 0;
            this.signUpButton.IconRightVisible = true;
            this.signUpButton.IconRightZoom = 0D;
            this.signUpButton.IconVisible = true;
            this.signUpButton.IconZoom = 90D;
            this.signUpButton.IsTab = false;
            this.signUpButton.Location = new System.Drawing.Point(48, 259);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.signUpButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.signUpButton.OnHoverTextColor = System.Drawing.Color.White;
            this.signUpButton.selected = false;
            this.signUpButton.Size = new System.Drawing.Size(153, 49);
            this.signUpButton.TabIndex = 10;
            this.signUpButton.Text = "SignUp";
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.Textcolor = System.Drawing.Color.White;
            this.signUpButton.TextFont = new System.Drawing.Font("Futura Md BT", 14F);
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // termsCheckbox
            // 
            this.termsCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.termsCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.termsCheckbox.Checked = false;
            this.termsCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.termsCheckbox.ForeColor = System.Drawing.Color.White;
            this.termsCheckbox.Location = new System.Drawing.Point(48, 210);
            this.termsCheckbox.Name = "termsCheckbox";
            this.termsCheckbox.Size = new System.Drawing.Size(20, 20);
            this.termsCheckbox.TabIndex = 4;
            // 
            // signupPassword1
            // 
            this.signupPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupPassword1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.signupPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupPassword1.HintForeColor = System.Drawing.Color.DimGray;
            this.signupPassword1.HintText = "Create a password";
            this.signupPassword1.isPassword = false;
            this.signupPassword1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.signupPassword1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupPassword1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupPassword1.LineThickness = 2;
            this.signupPassword1.Location = new System.Drawing.Point(48, 156);
            this.signupPassword1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupPassword1.Name = "signupPassword1";
            this.signupPassword1.Size = new System.Drawing.Size(326, 27);
            this.signupPassword1.TabIndex = 3;
            this.signupPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signupUsername
            // 
            this.signupUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupUsername.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.signupUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupUsername.HintForeColor = System.Drawing.Color.DimGray;
            this.signupUsername.HintText = "Pick a username";
            this.signupUsername.isPassword = false;
            this.signupUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.signupUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupUsername.LineThickness = 2;
            this.signupUsername.Location = new System.Drawing.Point(48, 105);
            this.signupUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(326, 27);
            this.signupUsername.TabIndex = 2;
            this.signupUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signupSurname
            // 
            this.signupSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupSurname.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.signupSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupSurname.HintForeColor = System.Drawing.Color.DimGray;
            this.signupSurname.HintText = "Surname";
            this.signupSurname.isPassword = false;
            this.signupSurname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.signupSurname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupSurname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupSurname.LineThickness = 2;
            this.signupSurname.Location = new System.Drawing.Point(221, 54);
            this.signupSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupSurname.Name = "signupSurname";
            this.signupSurname.Size = new System.Drawing.Size(153, 27);
            this.signupSurname.TabIndex = 1;
            this.signupSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signupName
            // 
            this.signupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupName.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.signupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupName.HintForeColor = System.Drawing.Color.DimGray;
            this.signupName.HintText = "Name";
            this.signupName.isPassword = false;
            this.signupName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.signupName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(54)))));
            this.signupName.LineThickness = 2;
            this.signupName.Location = new System.Drawing.Point(48, 54);
            this.signupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupName.Name = "signupName";
            this.signupName.Size = new System.Drawing.Size(153, 27);
            this.signupName.TabIndex = 0;
            this.signupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signupLoginButton
            // 
            this.signupLoginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.signupLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.signupLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupLoginButton.BorderRadius = 7;
            this.signupLoginButton.ButtonText = "Login";
            this.signupLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupLoginButton.DisabledColor = System.Drawing.Color.Gray;
            this.signupLoginButton.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.signupLoginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.signupLoginButton.Iconimage = null;
            this.signupLoginButton.Iconimage_right = null;
            this.signupLoginButton.Iconimage_right_Selected = null;
            this.signupLoginButton.Iconimage_Selected = null;
            this.signupLoginButton.IconMarginLeft = 0;
            this.signupLoginButton.IconMarginRight = 0;
            this.signupLoginButton.IconRightVisible = true;
            this.signupLoginButton.IconRightZoom = 0D;
            this.signupLoginButton.IconVisible = true;
            this.signupLoginButton.IconZoom = 90D;
            this.signupLoginButton.IsTab = false;
            this.signupLoginButton.Location = new System.Drawing.Point(221, 259);
            this.signupLoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signupLoginButton.Name = "signupLoginButton";
            this.signupLoginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.signupLoginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.signupLoginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.signupLoginButton.selected = false;
            this.signupLoginButton.Size = new System.Drawing.Size(153, 49);
            this.signupLoginButton.TabIndex = 12;
            this.signupLoginButton.Text = "Login";
            this.signupLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupLoginButton.Textcolor = System.Drawing.Color.White;
            this.signupLoginButton.TextFont = new System.Drawing.Font("Futura Md BT", 14F);
            this.signupLoginButton.Click += new System.EventHandler(this.signupLoginButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TaxiApp.Properties.Resources.ic_close;
            this.pictureBox3.Location = new System.Drawing.Point(836, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TaxiApp.Properties.Resources.Key;
            this.pictureBox2.Location = new System.Drawing.Point(247, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.TitleLoginScreen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox loginUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLoginScreen;
        private Bunifu.Framework.UI.BunifuCustomLabel btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel signupPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox signupName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox signupSurname;
        private Bunifu.Framework.UI.BunifuCheckbox termsCheckbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox signupPassword1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox signupUsername;
        private Bunifu.Framework.UI.BunifuFlatButton signUpButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton signupLoginButton;
    }
}

