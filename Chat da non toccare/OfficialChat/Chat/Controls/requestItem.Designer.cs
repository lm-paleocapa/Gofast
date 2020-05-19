namespace OfficialChat.Chat.Controls
{
    partial class requestItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestItem));
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.PictureBox();
            this.username = new OfficialChat.Chat.Controls.userLeft();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::OfficialChat.Properties.Resources.icons8_cancel_35;
            this.btnCancel.Location = new System.Drawing.Point(265, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OfficialChat.Properties.Resources.icons8_ok_35;
            this.btnOk.Location = new System.Drawing.Point(212, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(35, 35);
            this.btnOk.TabIndex = 1;
            this.btnOk.TabStop = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.username.Border = System.Windows.Forms.BorderStyle.None;
            this.username.hover = true;
            this.username.LA = false;
            this.username.lastAccess = "10:30";
            this.username.Location = new System.Drawing.Point(0, 0);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.name = "Username";
            this.username.Name = "username";
            this.username.picture = ((System.Drawing.Image)(resources.GetObject("username.picture")));
            this.username.Size = new System.Drawing.Size(200, 66);
            this.username.TabIndex = 0;
            // 
            // requestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "requestItem";
            this.Size = new System.Drawing.Size(314, 64);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            this.ResumeLayout(false);

        }
        private userLeft username;
        private System.Windows.Forms.PictureBox btnOk;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}