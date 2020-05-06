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
            this.labelLastAccess = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            // 
            // labelLastAccess
            // 
            this.labelLastAccess.AutoSize = true;
            this.labelLastAccess.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLastAccess.Location = new System.Drawing.Point(71, 35);
            this.labelLastAccess.Name = "labelLastAccess";
            this.labelLastAccess.Size = new System.Drawing.Size(34, 13);
            this.labelLastAccess.TabIndex = 2;
            this.labelLastAccess.Text = "10:30";
            this.labelLastAccess.Click += new System.EventHandler(this.userLeft_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::OfficialChat.Properties.Resources.userStandard;
            this.pictureBox.Location = new System.Drawing.Point(11, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.userLeft_Click);
            // 
            // userLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelLastAccess);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox);
            this.Name = "userLeft";
            this.Size = new System.Drawing.Size(200, 66);
            this.Load += new System.EventHandler(this.userLeft_Load);
            this.Click += new System.EventHandler(this.userLeft_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel labelLastAccess;
    }
}