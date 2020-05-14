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
            this.buttonAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panelForControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::OfficialChat.Properties.Resources.back;
            this.pictureBoxBack.Location = new System.Drawing.Point(6, 8);
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
            this.panelForControl.Location = new System.Drawing.Point(0, 66);
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
            this.textboxSearch.Enter += new System.EventHandler(this.textboxSearch_Enter);
            this.textboxSearch.Leave += new System.EventHandler(this.textboxSearch_Leave);
            // 
            // panelForUser
            // 
            this.panelForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelForUser.Location = new System.Drawing.Point(0, 117);
            this.panelForUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelForUser.Name = "panelForUser";
            this.panelForUser.Size = new System.Drawing.Size(202, 426);
            this.panelForUser.TabIndex = 14;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.BorderRadius = 0;
            this.buttonAdd.ButtonText = "Add";
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Iconimage")));
            this.buttonAdd.Iconimage_right = null;
            this.buttonAdd.Iconimage_right_Selected = null;
            this.buttonAdd.Iconimage_Selected = null;
            this.buttonAdd.IconMarginLeft = 0;
            this.buttonAdd.IconMarginRight = 0;
            this.buttonAdd.IconRightVisible = false;
            this.buttonAdd.IconRightZoom = 0D;
            this.buttonAdd.IconVisible = false;
            this.buttonAdd.IconZoom = 90D;
            this.buttonAdd.IsTab = false;
            this.buttonAdd.Location = new System.Drawing.Point(50, 555);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.buttonAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdd.selected = false;
            this.buttonAdd.Size = new System.Drawing.Size(102, 48);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdd.Textcolor = System.Drawing.Color.White;
            this.buttonAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
        private Bunifu.Framework.UI.BunifuFlatButton buttonAdd;
    }
}
