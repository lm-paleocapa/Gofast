namespace OfficialChat.Chat.Controls
{
    partial class userSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSetting));
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.textBoxMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.textboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // profileImage
            // 
            this.profileImage.Image = global::OfficialChat.Properties.Resources.icons8_edit_90;
            this.profileImage.Location = new System.Drawing.Point(155, 59);
            this.profileImage.Margin = new System.Windows.Forms.Padding(0);
            this.profileImage.MaximumSize = new System.Drawing.Size(90, 90);
            this.profileImage.MinimumSize = new System.Drawing.Size(90, 90);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(90, 90);
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            this.profileImage.Click += new System.EventHandler(this.profileImage_Click);
            this.profileImage.MouseEnter += new System.EventHandler(this.profileImage_MouseEnter);
            this.profileImage.MouseLeave += new System.EventHandler(this.profileImage_MouseLeave);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMail.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMail.HintText = "";
            this.textBoxMail.isPassword = false;
            this.textBoxMail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textBoxMail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.textBoxMail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textBoxMail.LineThickness = 3;
            this.textBoxMail.Location = new System.Drawing.Point(16, 184);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(370, 44);
            this.textBoxMail.TabIndex = 1;
            this.textBoxMail.Text = "Mail";
            this.textBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMail.OnValueChanged += new System.EventHandler(this.textBoxMail_OnValueChanged);
            this.textBoxMail.Enter += new System.EventHandler(this.textBoxMail_Enter);
            this.textBoxMail.Leave += new System.EventHandler(this.textBoxMail_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(155, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(164)))), ((int)(((byte)(1)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(98, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::OfficialChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(6, 8);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBack.TabIndex = 13;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textboxPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxPassword.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxPassword.HintText = "";
            this.textboxPassword.isPassword = false;
            this.textboxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textboxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.textboxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textboxPassword.LineThickness = 3;
            this.textboxPassword.Location = new System.Drawing.Point(16, 236);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(370, 44);
            this.textboxPassword.TabIndex = 14;
            this.textboxPassword.Text = "Password";
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxPassword.OnValueChanged += new System.EventHandler(this.textboxPassword_OnValueChanged);
            this.textboxPassword.Enter += new System.EventHandler(this.textboxPassword_Enter);
            this.textboxPassword.Leave += new System.EventHandler(this.textboxPassword_Leave);
            // 
            // textboxConfirmPassword
            // 
            this.textboxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textboxConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxConfirmPassword.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxConfirmPassword.HintText = "";
            this.textboxConfirmPassword.isPassword = false;
            this.textboxConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textboxConfirmPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.textboxConfirmPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textboxConfirmPassword.LineThickness = 3;
            this.textboxConfirmPassword.Location = new System.Drawing.Point(16, 288);
            this.textboxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxConfirmPassword.Name = "textboxConfirmPassword";
            this.textboxConfirmPassword.Size = new System.Drawing.Size(370, 44);
            this.textboxConfirmPassword.TabIndex = 15;
            this.textboxConfirmPassword.Text = "Confirm password";
            this.textboxConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxConfirmPassword.OnValueChanged += new System.EventHandler(this.textboxConfirmPassword_OnValueChanged);
            this.textboxConfirmPassword.Enter += new System.EventHandler(this.textboxConfirmPassword_Enter);
            this.textboxConfirmPassword.Leave += new System.EventHandler(this.textboxConfirmPassword_Leave);
            // 
            // userSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.textboxConfirmPassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.profileImage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "userSetting";
            this.Size = new System.Drawing.Size(400, 450);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox profileImage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxMail;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxConfirmPassword;
    }
}