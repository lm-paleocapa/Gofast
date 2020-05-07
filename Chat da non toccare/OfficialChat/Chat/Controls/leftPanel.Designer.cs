namespace OfficialChat.Chat.Controls
{
    partial class leftPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leftPanel));
            this.panelForUser = new System.Windows.Forms.Panel();
            this.panelForControl = new System.Windows.Forms.Panel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelForControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForUser
            // 
            this.panelForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelForUser.Location = new System.Drawing.Point(0, 51);
            this.panelForUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelForUser.Name = "panelForUser";
            this.panelForUser.Size = new System.Drawing.Size(202, 504);
            this.panelForUser.TabIndex = 0;
            this.panelForUser.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            // 
            // panelForControl
            // 
            this.panelForControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelForControl.Controls.Add(this.bunifuTextbox1);
            this.panelForControl.Location = new System.Drawing.Point(0, 0);
            this.panelForControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelForControl.Name = "panelForControl";
            this.panelForControl.Size = new System.Drawing.Size(202, 51);
            this.panelForControl.TabIndex = 1;
            this.panelForControl.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(7, 6);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(188, 36);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Search...";
            this.bunifuTextbox1.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            // 
            // leftPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.panelForControl);
            this.Controls.Add(this.panelForUser);
            this.Name = "leftPanel";
            this.Size = new System.Drawing.Size(202, 555);
            this.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            this.panelForControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForUser;
        private System.Windows.Forms.Panel panelForControl;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
