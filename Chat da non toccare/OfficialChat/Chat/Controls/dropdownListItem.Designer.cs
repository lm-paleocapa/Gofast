namespace OfficialChat.Chat.Controls
{
    partial class dropdownListItem
    {
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
            this.labelItem = new System.Windows.Forms.Label();
            this.pictureboxItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelItem.Location = new System.Drawing.Point(20, 16);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(35, 13);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "label1";
            this.labelItem.Click += new System.EventHandler(this.labelItem_Click);
            this.labelItem.MouseEnter += new System.EventHandler(this.dropdownListItem_MouseEnter);
            this.labelItem.MouseLeave += new System.EventHandler(this.dropdownListItem_MouseLeave);
            // 
            // pictureboxItem
            // 
            this.pictureboxItem.Location = new System.Drawing.Point(93, 7);
            this.pictureboxItem.Name = "pictureboxItem";
            this.pictureboxItem.Size = new System.Drawing.Size(30, 30);
            this.pictureboxItem.TabIndex = 1;
            this.pictureboxItem.TabStop = false;
            this.pictureboxItem.Click += new System.EventHandler(this.labelItem_Click);
            this.pictureboxItem.MouseEnter += new System.EventHandler(this.dropdownListItem_MouseEnter);
            this.pictureboxItem.MouseLeave += new System.EventHandler(this.dropdownListItem_MouseLeave);
            // 
            // dropdownListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureboxItem);
            this.Controls.Add(this.labelItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "dropdownListItem";
            this.Size = new System.Drawing.Size(129, 44);
            this.Click += new System.EventHandler(this.labelItem_Click);
            this.MouseEnter += new System.EventHandler(this.dropdownListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.dropdownListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.PictureBox pictureboxItem;
    }
}