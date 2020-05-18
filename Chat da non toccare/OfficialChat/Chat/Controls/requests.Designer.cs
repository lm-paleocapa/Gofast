namespace OfficialChat.Chat.Controls
{
    partial class requests
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
            this.panelForUser = new System.Windows.Forms.Panel();
            this.requestItem1 = new OfficialChat.Chat.Controls.requestItem();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panelForUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForUser
            // 
            this.panelForUser.Controls.Add(this.requestItem1);
            this.panelForUser.Location = new System.Drawing.Point(0, 68);
            this.panelForUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelForUser.Name = "panelForUser";
            this.panelForUser.Size = new System.Drawing.Size(314, 457);
            this.panelForUser.TabIndex = 0;
            // 
            // requestItem1
            // 
            this.requestItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.requestItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestItem1.Location = new System.Drawing.Point(0, 0);
            this.requestItem1.Margin = new System.Windows.Forms.Padding(0);
            this.requestItem1.Name = "requestItem1";
            this.requestItem1.Size = new System.Drawing.Size(314, 64);
            this.requestItem1.TabIndex = 0;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::OfficialChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBack.TabIndex = 13;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panelForUser);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "requests";
            this.Size = new System.Drawing.Size(314, 525);
            this.panelForUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForUser;
        private requestItem requestItem1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}
