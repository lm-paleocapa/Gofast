namespace OfficialChat.Chat.Controls
{
    partial class userLeft
    {
        /// </summary>
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
            this.labelUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsername.Location = new System.Drawing.Point(67, 10);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.userLeft_Click);
            this.labelUsername.MouseEnter += new System.EventHandler(this.userLeft_MouseEnter);
            this.labelUsername.MouseLeave += new System.EventHandler(this.userLeft_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::OfficialChat.Properties.Resources.userStandard;
            this.pictureBox.Location = new System.Drawing.Point(11, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(45, 45);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.userLeft_Click);
            this.pictureBox.MouseEnter += new System.EventHandler(this.userLeft_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.userLeft_MouseLeave);
            // 
            // userLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox);
            this.Name = "userLeft";
            this.Size = new System.Drawing.Size(200, 66);
            this.Load += new System.EventHandler(this.userLeft_Load);
            this.Click += new System.EventHandler(this.userLeft_Click);
            this.MouseEnter += new System.EventHandler(this.userLeft_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.userLeft_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUsername;
    }
}