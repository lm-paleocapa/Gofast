namespace OfficialChat.Chat.Controls
{
    partial class userToAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.userToAdd_Click);
            this.labelUsername.MouseEnter += new System.EventHandler(this.userLeft_MouseEnter);
            this.labelUsername.MouseLeave += new System.EventHandler(this.userLeft_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::OfficialChat.Properties.Resources.userStandard;
            this.pictureBox.Location = new System.Drawing.Point(8, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.userToAdd_Click);
            this.pictureBox.MouseEnter += new System.EventHandler(this.userLeft_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.userLeft_MouseLeave);
            // 
            // userToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox);
            this.Name = "userToAdd";
            this.Size = new System.Drawing.Size(198, 64);
            this.Click += new System.EventHandler(this.userToAdd_Click);
            this.MouseEnter += new System.EventHandler(this.userLeft_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.userLeft_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel labelUsername;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
