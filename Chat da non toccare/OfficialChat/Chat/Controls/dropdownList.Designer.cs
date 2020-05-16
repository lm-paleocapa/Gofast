namespace OfficialChat.Chat.Controls
{
    partial class dropdownList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dropdownList));
            this.btnProfileSetting = new OfficialChat.Chat.Controls.dropdownListItem();
            this.friendshipRequest = new OfficialChat.Chat.Controls.dropdownListItem();
            this.btnLogOut = new OfficialChat.Chat.Controls.dropdownListItem();
            this.SuspendLayout();
            // 
            // btnProfileSetting
            // 
            this.btnProfileSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProfileSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnProfileSetting.itemImage = global::OfficialChat.Properties.Resources.icons8_ingranaggio_30;
            this.btnProfileSetting.itemName = "Profile";
            this.btnProfileSetting.Location = new System.Drawing.Point(0, 0);
            this.btnProfileSetting.Margin = new System.Windows.Forms.Padding(1);
            this.btnProfileSetting.Name = "btnProfileSetting";
            this.btnProfileSetting.Padding = new System.Windows.Forms.Padding(1);
            this.btnProfileSetting.Size = new System.Drawing.Size(129, 44);
            this.btnProfileSetting.TabIndex = 2;
            this.btnProfileSetting.Click += new System.EventHandler(this.btnProfileSetting_Click);
            // 
            // friendshipRequest
            // 
            this.friendshipRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.friendshipRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendshipRequest.itemImage = ((System.Drawing.Image)(resources.GetObject("friendshipRequest.itemImage")));
            this.friendshipRequest.itemName = "Friend request";
            this.friendshipRequest.Location = new System.Drawing.Point(0, 44);
            this.friendshipRequest.Margin = new System.Windows.Forms.Padding(1);
            this.friendshipRequest.Name = "friendshipRequest";
            this.friendshipRequest.Padding = new System.Windows.Forms.Padding(1);
            this.friendshipRequest.Size = new System.Drawing.Size(129, 44);
            this.friendshipRequest.TabIndex = 1;
            this.friendshipRequest.Click += new System.EventHandler(this.friendshipRequest_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLogOut.itemImage = global::OfficialChat.Properties.Resources.icons8_uscita_30;
            this.btnLogOut.itemName = "Log out";
            this.btnLogOut.Location = new System.Drawing.Point(0, 88);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(1);
            this.btnLogOut.Size = new System.Drawing.Size(129, 44);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dropdownList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnProfileSetting);
            this.Controls.Add(this.friendshipRequest);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "dropdownList";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(129, 132);
            this.ResumeLayout(false);

        }

        #endregion

        private dropdownListItem btnLogOut;
        private dropdownListItem friendshipRequest;
        private dropdownListItem btnProfileSetting;
    }
}
