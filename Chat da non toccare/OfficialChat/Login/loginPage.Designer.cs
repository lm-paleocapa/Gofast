namespace OfficialChat.Login
{
    partial class LoginPage
    { 
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.buttonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelLogo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelDontHaveAnAccount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelSignUp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(253)))));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.BorderRadius = 7;
            this.buttonLogin.ButtonText = "Login";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Iconimage")));
            this.buttonLogin.Iconimage_right = null;
            this.buttonLogin.Iconimage_right_Selected = null;
            this.buttonLogin.Iconimage_Selected = null;
            this.buttonLogin.IconMarginLeft = 0;
            this.buttonLogin.IconMarginRight = 0;
            this.buttonLogin.IconRightVisible = true;
            this.buttonLogin.IconRightZoom = 0D;
            this.buttonLogin.IconVisible = false;
            this.buttonLogin.IconZoom = 90D;
            this.buttonLogin.IsTab = false;
            this.buttonLogin.Location = new System.Drawing.Point(179, 362);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(173)))));
            this.buttonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogin.selected = false;
            this.buttonLogin.Size = new System.Drawing.Size(105, 48);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Textcolor = System.Drawing.Color.White;
            this.buttonLogin.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.CausesValidation = false;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.labelLogo.Location = new System.Drawing.Point(178, 36);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(106, 38);
            this.labelLogo.TabIndex = 9;
            this.labelLogo.Text = "GoFast";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDontHaveAnAccount
            // 
            this.labelDontHaveAnAccount.AutoSize = true;
            this.labelDontHaveAnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDontHaveAnAccount.Location = new System.Drawing.Point(135, 468);
            this.labelDontHaveAnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            this.labelDontHaveAnAccount.Size = new System.Drawing.Size(125, 13);
            this.labelDontHaveAnAccount.TabIndex = 10;
            this.labelDontHaveAnAccount.Text = "Don\'t have an account ?";
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.labelSignUp.Location = new System.Drawing.Point(258, 468);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(45, 13);
            this.labelSignUp.TabIndex = 5;
            this.labelSignUp.Text = " SingUp";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUsername.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUsername.HintText = "";
            this.tbUsername.isPassword = false;
            this.tbUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.tbUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbUsername.LineThickness = 3;
            this.tbUsername.Location = new System.Drawing.Point(66, 133);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(370, 44);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsername.Location = new System.Drawing.Point(62, 181);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(35, 13);
            this.lbUsername.TabIndex = 13;
            this.lbUsername.Text = "label1";
            this.lbUsername.Visible = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPassword.Location = new System.Drawing.Point(66, 262);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(35, 13);
            this.lbPassword.TabIndex = 14;
            this.lbPassword.Text = "label2";
            this.lbPassword.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OfficialChat.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(17, 218);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OfficialChat.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(17, 137);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // tbPass
            // 
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPass.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPass.HintText = "";
            this.tbPass.isPassword = false;
            this.tbPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.tbPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbPass.LineThickness = 3;
            this.tbPass.Location = new System.Drawing.Point(66, 214);
            this.tbPass.Margin = new System.Windows.Forms.Padding(0);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(370, 44);
            this.tbPass.TabIndex = 18;
            this.tbPass.Text = "Password";
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelDontHaveAnAccount);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(463, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel labelLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel labelDontHaveAnAccount;
        private Bunifu.Framework.UI.BunifuCustomLabel labelSignUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lbUsername;
        public System.Windows.Forms.Label lbPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPass;
    }
}