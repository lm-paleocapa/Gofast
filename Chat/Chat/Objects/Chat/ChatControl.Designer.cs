namespace Chat.Objects.Chat
{
    partial class ChatControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelLastAccess = new System.Windows.Forms.Label();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.tbMessageToSend = new System.Windows.Forms.TextBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(102, 10);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 21;
            this.labelUserName.Text = "Name";
            // 
            // labelLastAccess
            // 
            this.labelLastAccess.AutoSize = true;
            this.labelLastAccess.Location = new System.Drawing.Point(102, 31);
            this.labelLastAccess.Name = "labelLastAccess";
            this.labelLastAccess.Size = new System.Drawing.Size(64, 13);
            this.labelLastAccess.TabIndex = 20;
            this.labelLastAccess.Text = "Last access";
            this.labelLastAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Location = new System.Drawing.Point(55, 6);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxUserImage.TabIndex = 19;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(338, 356);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(52, 23);
            this.BtnSend.TabIndex = 18;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            // 
            // tbMessageToSend
            // 
            this.tbMessageToSend.Location = new System.Drawing.Point(7, 356);
            this.tbMessageToSend.Name = "tbMessageToSend";
            this.tbMessageToSend.Size = new System.Drawing.Size(325, 20);
            this.tbMessageToSend.TabIndex = 17;
            // 
            // panelMessages
            // 
            this.panelMessages.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMessages.Location = new System.Drawing.Point(7, 50);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(367, 290);
            this.panelMessages.TabIndex = 16;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(377, 50);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(13, 290);
            this.gunaVScrollBar1.TabIndex = 23;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelLastAccess);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.tbMessageToSend);
            this.Controls.Add(this.panelMessages);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(396, 384);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelLastAccess;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox tbMessageToSend;
        private System.Windows.Forms.Panel panelMessages;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
    }
}
