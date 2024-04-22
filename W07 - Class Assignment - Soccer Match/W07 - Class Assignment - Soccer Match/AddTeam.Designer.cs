namespace W07___Class_Assignment___Soccer_Match
{
    partial class AddTeam
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
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.lb_TeamName = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(229, 170);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(246, 31);
            this.tBox_Name.TabIndex = 0;
            // 
            // lb_TeamName
            // 
            this.lb_TeamName.AutoSize = true;
            this.lb_TeamName.Location = new System.Drawing.Point(283, 115);
            this.lb_TeamName.Name = "lb_TeamName";
            this.lb_TeamName.Size = new System.Drawing.Size(134, 25);
            this.lb_TeamName.TabIndex = 1;
            this.lb_TeamName.Text = "Team Name:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(288, 228);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(129, 41);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 353);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_TeamName);
            this.Controls.Add(this.tBox_Name);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.Label lb_TeamName;
        private System.Windows.Forms.Button btn_Add;
    }
}