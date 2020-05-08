namespace OfficialChat.Chat.Controls
{
    partial class addFriends
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addFriends));
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelForControl = new System.Windows.Forms.Panel();
            this.textboxSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelForUser = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panelForControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::OfficialChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxBack.TabIndex = 12;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelForControl
            // 
            this.panelForControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelForControl.Controls.Add(this.textboxSearch);
            this.panelForControl.Location = new System.Drawing.Point(0, 60);
            this.panelForControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelForControl.Name = "panelForControl";
            this.panelForControl.Size = new System.Drawing.Size(202, 51);
            this.panelForControl.TabIndex = 13;
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
            // 
            // panelForUser
            // 
            this.panelForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelForUser.Location = new System.Drawing.Point(0, 111);
            this.panelForUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelForUser.Name = "panelForUser";
            this.panelForUser.Size = new System.Drawing.Size(202, 447);
            this.panelForUser.TabIndex = 14;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(61, 571);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // addFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelForUser);
            this.Controls.Add(this.panelForControl);
            this.Controls.Add(this.pictureBoxBack);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "addFriends";
            this.Size = new System.Drawing.Size(202, 612);
            this.Load += new System.EventHandler(this.addFriends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panelForControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelForControl;
        private Bunifu.Framework.UI.BunifuTextbox textboxSearch;
        private System.Windows.Forms.Panel panelForUser;
        private System.Windows.Forms.Button buttonAdd;
    }
}
