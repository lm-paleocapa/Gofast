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
            this.textboxSearch = new Bunifu.Framework.UI.BunifuTextbox();
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
            this.panelForControl.Controls.Add(this.textboxSearch);
            this.panelForControl.Location = new System.Drawing.Point(0, 0);
            this.panelForControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelForControl.Name = "panelForControl";
            this.panelForControl.Size = new System.Drawing.Size(202, 51);
            this.panelForControl.TabIndex = 1;
            this.panelForControl.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.textboxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxSearch.BackgroundImage")));
            this.textboxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxSearch.ForeColor = System.Drawing.Color.White;
            this.textboxSearch.Icon = ((System.Drawing.Image)(resources.GetObject("textboxSearch.Icon")));
            this.textboxSearch.Location = new System.Drawing.Point(7, 6);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(188, 36);
            this.textboxSearch.TabIndex = 0;
            this.textboxSearch.text = "Search...";
            this.textboxSearch.OnTextChange += new System.EventHandler(this.textboxSearch_OnTextChange);
            this.textboxSearch.Click += new System.EventHandler(this.bunifuTextbox1_Click);
            this.textboxSearch.Enter += new System.EventHandler(this.bunifuTextbox1_Click);
            this.textboxSearch.Leave += new System.EventHandler(this.textboxSearch_Leave);
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
        private Bunifu.Framework.UI.BunifuTextbox textboxSearch;
    }
}
