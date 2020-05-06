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
            this.panelForUser = new System.Windows.Forms.Panel();
            this.panelForControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelForUser
            // 
            this.panelForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(99)))), ((int)(((byte)(109)))));
            this.panelForUser.Location = new System.Drawing.Point(0, 68);
            this.panelForUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelForUser.Name = "panelForUser";
            this.panelForUser.Size = new System.Drawing.Size(202, 487);
            this.panelForUser.TabIndex = 0;
            // 
            // panelForControl
            // 
            this.panelForControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelForControl.Location = new System.Drawing.Point(0, 0);
            this.panelForControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelForControl.Name = "panelForControl";
            this.panelForControl.Size = new System.Drawing.Size(202, 68);
            this.panelForControl.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForUser;
        private System.Windows.Forms.Panel panelForControl;
    }
}
