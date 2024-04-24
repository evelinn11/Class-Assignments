namespace W09___Class_Assignment___User_Login
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip_MainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_MainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_MainForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_MainForm = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel_Waktu = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_MainForm.SuspendLayout();
            this.statusStrip_MainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_MainForm
            // 
            this.menuStrip_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip_MainForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip_MainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainForm.Name = "menuStrip_MainForm";
            this.menuStrip_MainForm.Size = new System.Drawing.Size(800, 24);
            this.menuStrip_MainForm.TabIndex = 0;
            this.menuStrip_MainForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logoutToolStripMenuItem.Text = "Log Out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // statusStrip_MainForm
            // 
            this.statusStrip_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_MainForm,
            this.toolStripStatusLabel_Waktu});
            this.statusStrip_MainForm.Location = new System.Drawing.Point(0, 428);
            this.statusStrip_MainForm.Name = "statusStrip_MainForm";
            this.statusStrip_MainForm.Size = new System.Drawing.Size(800, 22);
            this.statusStrip_MainForm.TabIndex = 4;
            this.statusStrip_MainForm.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_MainForm
            // 
            this.toolStripStatusLabel_MainForm.Name = "toolStripStatusLabel_MainForm";
            this.toolStripStatusLabel_MainForm.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel_MainForm.Text = "Current text";
            // 
            // timer_MainForm
            // 
            this.timer_MainForm.Enabled = true;
            this.timer_MainForm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel_Waktu
            // 
            this.toolStripStatusLabel_Waktu.Name = "toolStripStatusLabel_Waktu";
            this.toolStripStatusLabel_Waktu.Size = new System.Drawing.Size(715, 17);
            this.toolStripStatusLabel_Waktu.Spring = true;
            this.toolStripStatusLabel_Waktu.Text = "Waktu";
            this.toolStripStatusLabel_Waktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip_MainForm);
            this.Controls.Add(this.menuStrip_MainForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_MainForm;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip_MainForm.ResumeLayout(false);
            this.menuStrip_MainForm.PerformLayout();
            this.statusStrip_MainForm.ResumeLayout(false);
            this.statusStrip_MainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_MainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip_MainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_MainForm;
        private System.Windows.Forms.Timer timer_MainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Waktu;
    }
}