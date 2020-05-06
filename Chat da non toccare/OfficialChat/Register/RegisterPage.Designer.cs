namespace OfficialChat.Register
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.labelLogo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonImage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.labelNumberError = new System.Windows.Forms.Label();
            this.typingBoxMail = new OfficialChat.Login.Controls.typingBox();
            this.typingBoxConfirmPassword = new OfficialChat.Login.Controls.typingBox();
            this.typingBoxPassword = new OfficialChat.Login.Controls.typingBox();
            this.typingBoxUser = new OfficialChat.Login.Controls.typingBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.CausesValidation = false;
            this.labelLogo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.labelLogo.Location = new System.Drawing.Point(173, 30);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(106, 38);
            this.labelLogo.TabIndex = 10;
            this.labelLogo.Text = "GoFast";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDown.Location = new System.Drawing.Point(74, 454);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(40, 16);
            this.numericUpDown.TabIndex = 16;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Age";
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Image = global::OfficialChat.Properties.Resources.remove;
            this.pictureBoxRemove.Location = new System.Drawing.Point(150, 498);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxRemove.TabIndex = 26;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Visible = false;
            this.pictureBoxRemove.Click += new System.EventHandler(this.pictureBoxRemove_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(104, 482);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(40, 40);
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(253)))));
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegister.BorderRadius = 7;
            this.buttonRegister.ButtonText = "Register";
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.DisabledColor = System.Drawing.Color.Gray;
            this.buttonRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonRegister.Iconimage")));
            this.buttonRegister.Iconimage_right = null;
            this.buttonRegister.Iconimage_right_Selected = null;
            this.buttonRegister.Iconimage_Selected = null;
            this.buttonRegister.IconMarginLeft = 0;
            this.buttonRegister.IconMarginRight = 0;
            this.buttonRegister.IconRightVisible = true;
            this.buttonRegister.IconRightZoom = 0D;
            this.buttonRegister.IconVisible = false;
            this.buttonRegister.IconZoom = 90D;
            this.buttonRegister.IsTab = false;
            this.buttonRegister.Location = new System.Drawing.Point(350, 487);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.buttonRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(173)))));
            this.buttonRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonRegister.selected = false;
            this.buttonRegister.Size = new System.Drawing.Size(99, 31);
            this.buttonRegister.TabIndex = 20;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonRegister.Textcolor = System.Drawing.Color.White;
            this.buttonRegister.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(253)))));
            this.buttonImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.buttonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonImage.BorderRadius = 7;
            this.buttonImage.ButtonText = "Image...";
            this.buttonImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImage.DisabledColor = System.Drawing.Color.Gray;
            this.buttonImage.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonImage.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonImage.Iconimage")));
            this.buttonImage.Iconimage_right = null;
            this.buttonImage.Iconimage_right_Selected = null;
            this.buttonImage.Iconimage_Selected = null;
            this.buttonImage.IconMarginLeft = 0;
            this.buttonImage.IconMarginRight = 0;
            this.buttonImage.IconRightVisible = true;
            this.buttonImage.IconRightZoom = 0D;
            this.buttonImage.IconVisible = false;
            this.buttonImage.IconZoom = 90D;
            this.buttonImage.IsTab = false;
            this.buttonImage.Location = new System.Drawing.Point(33, 487);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.buttonImage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(173)))));
            this.buttonImage.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonImage.selected = false;
            this.buttonImage.Size = new System.Drawing.Size(64, 31);
            this.buttonImage.TabIndex = 18;
            this.buttonImage.Text = "Image...";
            this.buttonImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonImage.Textcolor = System.Drawing.Color.White;
            this.buttonImage.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click_1);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::OfficialChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(14, 18);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBack.TabIndex = 11;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // labelNumberError
            // 
            this.labelNumberError.AutoSize = true;
            this.labelNumberError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNumberError.Location = new System.Drawing.Point(129, 457);
            this.labelNumberError.Name = "labelNumberError";
            this.labelNumberError.Size = new System.Drawing.Size(94, 13);
            this.labelNumberError.TabIndex = 27;
            this.labelNumberError.Text = "You are too young";
            this.labelNumberError.Visible = false;
            // 
            // typingBoxMail
            // 
            this.typingBoxMail.errorTop = 71;
            this.typingBoxMail.hint = "Mail";
            this.typingBoxMail.img = global::OfficialChat.Properties.Resources.mail;
            this.typingBoxMail.isPassword = false;
            this.typingBoxMail.Location = new System.Drawing.Point(14, 358);
            this.typingBoxMail.Name = "typingBoxMail";
            this.typingBoxMail.nameOfPanel = "Register";
            this.typingBoxMail.pictureBoxTop = 21;
            this.typingBoxMail.Size = new System.Drawing.Size(444, 90);
            this.typingBoxMail.TabIndex = 24;
            this.typingBoxMail.text = "Mail";
            this.typingBoxMail.typingBoxTop = 17;
            // 
            // typingBoxConfirmPassword
            // 
            this.typingBoxConfirmPassword.errorTop = 71;
            this.typingBoxConfirmPassword.hint = "Confirm password";
            this.typingBoxConfirmPassword.img = ((System.Drawing.Image)(resources.GetObject("typingBoxConfirmPassword.img")));
            this.typingBoxConfirmPassword.isPassword = true;
            this.typingBoxConfirmPassword.Location = new System.Drawing.Point(14, 262);
            this.typingBoxConfirmPassword.Name = "typingBoxConfirmPassword";
            this.typingBoxConfirmPassword.nameOfPanel = "Register";
            this.typingBoxConfirmPassword.pictureBoxTop = 21;
            this.typingBoxConfirmPassword.Size = new System.Drawing.Size(444, 90);
            this.typingBoxConfirmPassword.TabIndex = 23;
            this.typingBoxConfirmPassword.text = "Confirm password";
            this.typingBoxConfirmPassword.typingBoxTop = 17;
            // 
            // typingBoxPassword
            // 
            this.typingBoxPassword.errorTop = 71;
            this.typingBoxPassword.hint = "Password";
            this.typingBoxPassword.img = ((System.Drawing.Image)(resources.GetObject("typingBoxPassword.img")));
            this.typingBoxPassword.isPassword = true;
            this.typingBoxPassword.Location = new System.Drawing.Point(14, 167);
            this.typingBoxPassword.Name = "typingBoxPassword";
            this.typingBoxPassword.nameOfPanel = "Register";
            this.typingBoxPassword.pictureBoxTop = 21;
            this.typingBoxPassword.Size = new System.Drawing.Size(444, 90);
            this.typingBoxPassword.TabIndex = 22;
            this.typingBoxPassword.text = "Password";
            this.typingBoxPassword.typingBoxTop = 17;
            // 
            // typingBoxUser
            // 
            this.typingBoxUser.errorTop = 71;
            this.typingBoxUser.hint = "Username";
            this.typingBoxUser.img = global::OfficialChat.Properties.Resources.user;
            this.typingBoxUser.isPassword = false;
            this.typingBoxUser.Location = new System.Drawing.Point(14, 71);
            this.typingBoxUser.Name = "typingBoxUser";
            this.typingBoxUser.nameOfPanel = "Register";
            this.typingBoxUser.pictureBoxTop = 21;
            this.typingBoxUser.Size = new System.Drawing.Size(444, 90);
            this.typingBoxUser.TabIndex = 21;
            this.typingBoxUser.text = "Username";
            this.typingBoxUser.typingBoxTop = 17;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.labelNumberError);
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.typingBoxMail);
            this.Controls.Add(this.typingBoxConfirmPassword);
            this.Controls.Add(this.typingBoxPassword);
            this.Controls.Add(this.typingBoxUser);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.labelLogo);
            this.Name = "RegisterPage";
            this.Size = new System.Drawing.Size(463, 529);
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Bunifu.Framework.UI.BunifuCustomLabel labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private Bunifu.Framework.UI.BunifuFlatButton buttonImage;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonRegister;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        public Login.Controls.typingBox typingBoxUser;
        public Login.Controls.typingBox typingBoxMail;
        private System.Windows.Forms.Label labelNumberError;
        public System.Windows.Forms.NumericUpDown numericUpDown;
        public Login.Controls.typingBox typingBoxPassword;
        public Login.Controls.typingBox typingBoxConfirmPassword;
    }
}