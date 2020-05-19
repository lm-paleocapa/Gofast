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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbCPassword = new System.Windows.Forms.Label();
            this.tbCPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.numericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
            this.numericUpDown.TabIndex = 5;
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OfficialChat.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(25, 98);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUsername.Location = new System.Drawing.Point(70, 142);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(5);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(35, 13);
            this.lbUsername.TabIndex = 31;
            this.lbUsername.Text = "label1";
            this.lbUsername.Visible = false;
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
            this.tbUsername.Location = new System.Drawing.Point(74, 94);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(370, 44);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Username";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.OnValueChanged += new System.EventHandler(this.tbUsername_OnValueChanged);
            this.tbUsername.Click += new System.EventHandler(this.userChanged);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OfficialChat.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(25, 164);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPassword.Location = new System.Drawing.Point(70, 208);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(35, 13);
            this.lbPassword.TabIndex = 34;
            this.lbPassword.Text = "label1";
            this.lbPassword.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPassword.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = false;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbPassword.LineThickness = 3;
            this.tbPassword.Location = new System.Drawing.Point(74, 160);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(370, 44);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.OnValueChanged += new System.EventHandler(this.passChanged);
            this.tbPassword.Click += new System.EventHandler(this.passChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OfficialChat.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(25, 230);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // lbCPassword
            // 
            this.lbCPassword.AutoSize = true;
            this.lbCPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCPassword.Location = new System.Drawing.Point(70, 274);
            this.lbCPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lbCPassword.Name = "lbCPassword";
            this.lbCPassword.Size = new System.Drawing.Size(35, 13);
            this.lbCPassword.TabIndex = 37;
            this.lbCPassword.Text = "label1";
            this.lbCPassword.Visible = false;
            // 
            // tbCPassword
            // 
            this.tbCPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbCPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCPassword.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCPassword.HintText = "";
            this.tbCPassword.isPassword = false;
            this.tbCPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbCPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.tbCPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbCPassword.LineThickness = 3;
            this.tbCPassword.Location = new System.Drawing.Point(74, 226);
            this.tbCPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbCPassword.Name = "tbCPassword";
            this.tbCPassword.Size = new System.Drawing.Size(370, 44);
            this.tbCPassword.TabIndex = 3;
            this.tbCPassword.Text = "Confirm password";
            this.tbCPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCPassword.OnValueChanged += new System.EventHandler(this.passCChanged);
            this.tbCPassword.Click += new System.EventHandler(this.passCChanged);
            this.tbCPassword.Enter += new System.EventHandler(this.tbCPassword_Enter);
            this.tbCPassword.Leave += new System.EventHandler(this.tbCPassword_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OfficialChat.Properties.Resources.mail;
            this.pictureBox4.Location = new System.Drawing.Point(24, 296);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMail.Location = new System.Drawing.Point(69, 340);
            this.lbMail.Margin = new System.Windows.Forms.Padding(5);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(35, 13);
            this.lbMail.TabIndex = 40;
            this.lbMail.Text = "label1";
            this.lbMail.Visible = false;
            // 
            // tbMail
            // 
            this.tbMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMail.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMail.HintText = "";
            this.tbMail.isPassword = false;
            this.tbMail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbMail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.tbMail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.tbMail.LineThickness = 3;
            this.tbMail.Location = new System.Drawing.Point(73, 292);
            this.tbMail.Margin = new System.Windows.Forms.Padding(0);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(370, 44);
            this.tbMail.TabIndex = 4;
            this.tbMail.Text = "Mail";
            this.tbMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMail.OnValueChanged += new System.EventHandler(this.tbMail_OnValueChanged);
            this.tbMail.Enter += new System.EventHandler(this.tbMail_Enter);
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbCPassword);
            this.Controls.Add(this.tbCPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.labelNumberError);
            this.Controls.Add(this.pictureBoxRemove);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.labelLogo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RegisterPage";
            this.Size = new System.Drawing.Size(463, 529);
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label labelNumberError;
        public System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label lbUsername;
        public System.Windows.Forms.Label lbPassword;
        public System.Windows.Forms.Label lbCPassword;
        public System.Windows.Forms.Label lbMail;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbUsername;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbCPassword;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbMail;
    }
}