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
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.labelSignUp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.typingBoxPassword = new OfficialChat.Login.Controls.typingBox();
            this.typingBoxUser = new OfficialChat.Login.Controls.typingBox();
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
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton.Location = new System.Drawing.Point(337, 278);
            this.radioButton.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton.Name = "radioButton";
            this.radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton.Size = new System.Drawing.Size(109, 19);
            this.radioButton.TabIndex = 3;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "Remember me";
            this.radioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.Click += new System.EventHandler(this.radioButton_Click);
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
            // typingBoxPassword
            // 
            this.typingBoxPassword.errorTop = 55;
            this.typingBoxPassword.hint = "Password";
            this.typingBoxPassword.img = ((System.Drawing.Image)(resources.GetObject("typingBoxPassword.img")));
            this.typingBoxPassword.isPassword = true;
            this.typingBoxPassword.Location = new System.Drawing.Point(9, 187);
            this.typingBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.typingBoxPassword.Name = "typingBoxPassword";
            this.typingBoxPassword.nameOfPanel = "Login";
            this.typingBoxPassword.pictureBoxTop = 10;
            this.typingBoxPassword.Size = new System.Drawing.Size(444, 90);
            this.typingBoxPassword.TabIndex = 2;
            this.typingBoxPassword.text = "Password";
            this.typingBoxPassword.typingBoxTop = 6;
            // 
            // typingBoxUser
            // 
            this.typingBoxUser.errorTop = 71;
            this.typingBoxUser.hint = "Username";
            this.typingBoxUser.img = global::OfficialChat.Properties.Resources.user;
            this.typingBoxUser.isPassword = false;
            this.typingBoxUser.Location = new System.Drawing.Point(9, 91);
            this.typingBoxUser.Margin = new System.Windows.Forms.Padding(0);
            this.typingBoxUser.Name = "typingBoxUser";
            this.typingBoxUser.nameOfPanel = "Login";
            this.typingBoxUser.pictureBoxTop = 41;
            this.typingBoxUser.Size = new System.Drawing.Size(444, 90);
            this.typingBoxUser.TabIndex = 1;
            this.typingBoxUser.text = "Username";
            this.typingBoxUser.typingBoxTop = 37;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.typingBoxPassword);
            this.Controls.Add(this.typingBoxUser);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.labelDontHaveAnAccount);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(463, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel labelLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel labelDontHaveAnAccount;
        private System.Windows.Forms.RadioButton radioButton;
        private Bunifu.Framework.UI.BunifuCustomLabel labelSignUp;
        private Controls.typingBox typingBoxUser;
        private Controls.typingBox typingBoxPassword;
    }
}