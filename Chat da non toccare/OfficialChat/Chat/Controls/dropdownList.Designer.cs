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
            this.dropdownListItem3 = new OfficialChat.Chat.Controls.dropdownListItem();
            this.dropdownListItem2 = new OfficialChat.Chat.Controls.dropdownListItem();
            this.dropdownListItem1 = new OfficialChat.Chat.Controls.dropdownListItem();
            this.SuspendLayout();
            // 
            // dropdownListItem3
            // 
            this.dropdownListItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownListItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropdownListItem3.itemImage = global::OfficialChat.Properties.Resources.icons8_ingranaggio_30;
            this.dropdownListItem3.itemName = "Profile";
            this.dropdownListItem3.Location = new System.Drawing.Point(0, 0);
            this.dropdownListItem3.Margin = new System.Windows.Forms.Padding(1);
            this.dropdownListItem3.Name = "dropdownListItem3";
            this.dropdownListItem3.Padding = new System.Windows.Forms.Padding(1);
            this.dropdownListItem3.Size = new System.Drawing.Size(129, 44);
            this.dropdownListItem3.TabIndex = 2;
            // 
            // dropdownListItem2
            // 
            this.dropdownListItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownListItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropdownListItem2.itemImage = ((System.Drawing.Image)(resources.GetObject("dropdownListItem2.itemImage")));
            this.dropdownListItem2.itemName = "Create group";
            this.dropdownListItem2.Location = new System.Drawing.Point(0, 44);
            this.dropdownListItem2.Margin = new System.Windows.Forms.Padding(1);
            this.dropdownListItem2.Name = "dropdownListItem2";
            this.dropdownListItem2.Padding = new System.Windows.Forms.Padding(1);
            this.dropdownListItem2.Size = new System.Drawing.Size(129, 44);
            this.dropdownListItem2.TabIndex = 1;
            // 
            // dropdownListItem1
            // 
            this.dropdownListItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownListItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropdownListItem1.itemImage = global::OfficialChat.Properties.Resources.icons8_uscita_30;
            this.dropdownListItem1.itemName = "Log out";
            this.dropdownListItem1.Location = new System.Drawing.Point(0, 88);
            this.dropdownListItem1.Margin = new System.Windows.Forms.Padding(1);
            this.dropdownListItem1.Name = "dropdownListItem1";
            this.dropdownListItem1.Padding = new System.Windows.Forms.Padding(1);
            this.dropdownListItem1.Size = new System.Drawing.Size(129, 44);
            this.dropdownListItem1.TabIndex = 0;
            // 
            // dropdownList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.dropdownListItem3);
            this.Controls.Add(this.dropdownListItem2);
            this.Controls.Add(this.dropdownListItem1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "dropdownList";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(129, 132);
            this.ResumeLayout(false);

        }

        #endregion

        private dropdownListItem dropdownListItem1;
        private dropdownListItem dropdownListItem2;
        private dropdownListItem dropdownListItem3;
    }
}
