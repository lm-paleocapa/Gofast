namespace OfficialChat.Login.Controls
{
    partial class typingBox
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::OfficialChat.Properties.Resources.key;
            this.pictureBox.Location = new System.Drawing.Point(9, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(40, 40);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox.HintForeColor = System.Drawing.Color.Transparent;
            this.textBox.HintText = "";
            this.textBox.isPassword = false;
            this.textBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.textBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textBox.LineThickness = 3;
            this.textBox.Location = new System.Drawing.Point(65, 37);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(370, 44);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "Password";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox.OnValueChanged += new System.EventHandler(this.textBox_Clear);
            this.textBox.Click += new System.EventHandler(this.textBox_Clear);
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelError.Location = new System.Drawing.Point(61, 71);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(29, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "Error";
            this.labelError.Visible = false;
            // 
            // typingBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "typingBox";
            this.Size = new System.Drawing.Size(444, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox;
        private System.Windows.Forms.Label labelError;
    }
}