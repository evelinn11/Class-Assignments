namespace W07___Class_Assignment___Soccer_Match
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
            this.dTP_Match = new System.Windows.Forms.DateTimePicker();
            this.dGV_Match = new System.Windows.Forms.DataGridView();
            this.btn_AddMatch = new System.Windows.Forms.Button();
            this.cBox_NamaTim1 = new System.Windows.Forms.ComboBox();
            this.cBox_NamaTim2 = new System.Windows.Forms.ComboBox();
            this.tBox_Skor1 = new System.Windows.Forms.TextBox();
            this.tBox_Skor2 = new System.Windows.Forms.TextBox();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.lb_Versus = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // dTP_Match
            // 
            this.dTP_Match.Location = new System.Drawing.Point(384, 448);
            this.dTP_Match.Name = "dTP_Match";
            this.dTP_Match.Size = new System.Drawing.Size(467, 31);
            this.dTP_Match.TabIndex = 0;
            // 
            // dGV_Match
            // 
            this.dGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Match.Location = new System.Drawing.Point(15, 33);
            this.dGV_Match.Name = "dGV_Match";
            this.dGV_Match.RowHeadersWidth = 82;
            this.dGV_Match.RowTemplate.Height = 33;
            this.dGV_Match.Size = new System.Drawing.Size(1159, 387);
            this.dGV_Match.TabIndex = 1;
            // 
            // btn_AddMatch
            // 
            this.btn_AddMatch.Location = new System.Drawing.Point(423, 648);
            this.btn_AddMatch.Name = "btn_AddMatch";
            this.btn_AddMatch.Size = new System.Drawing.Size(167, 53);
            this.btn_AddMatch.TabIndex = 2;
            this.btn_AddMatch.Text = "Add Match";
            this.btn_AddMatch.UseVisualStyleBackColor = true;
            this.btn_AddMatch.Click += new System.EventHandler(this.btn_AddMatch_Click);
            // 
            // cBox_NamaTim1
            // 
            this.cBox_NamaTim1.FormattingEnabled = true;
            this.cBox_NamaTim1.Location = new System.Drawing.Point(384, 516);
            this.cBox_NamaTim1.Name = "cBox_NamaTim1";
            this.cBox_NamaTim1.Size = new System.Drawing.Size(180, 33);
            this.cBox_NamaTim1.TabIndex = 3;
            this.cBox_NamaTim1.SelectedIndexChanged += new System.EventHandler(this.cBox_NamaTim1_SelectedIndexChanged);
            // 
            // cBox_NamaTim2
            // 
            this.cBox_NamaTim2.FormattingEnabled = true;
            this.cBox_NamaTim2.Location = new System.Drawing.Point(671, 516);
            this.cBox_NamaTim2.Name = "cBox_NamaTim2";
            this.cBox_NamaTim2.Size = new System.Drawing.Size(180, 33);
            this.cBox_NamaTim2.TabIndex = 4;
            this.cBox_NamaTim2.SelectedIndexChanged += new System.EventHandler(this.cBox_NamaTim2_SelectedIndexChanged);
            // 
            // tBox_Skor1
            // 
            this.tBox_Skor1.Location = new System.Drawing.Point(384, 582);
            this.tBox_Skor1.Name = "tBox_Skor1";
            this.tBox_Skor1.Size = new System.Drawing.Size(180, 31);
            this.tBox_Skor1.TabIndex = 5;
            this.tBox_Skor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_Skor1_KeyPress);
            // 
            // tBox_Skor2
            // 
            this.tBox_Skor2.Location = new System.Drawing.Point(671, 582);
            this.tBox_Skor2.Name = "tBox_Skor2";
            this.tBox_Skor2.Size = new System.Drawing.Size(180, 31);
            this.tBox_Skor2.TabIndex = 6;
            this.tBox_Skor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox_Skor2_KeyPress);
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.Location = new System.Drawing.Point(644, 648);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(167, 53);
            this.btn_AddTeam.TabIndex = 7;
            this.btn_AddTeam.Text = "Add Team";
            this.btn_AddTeam.UseVisualStyleBackColor = true;
            this.btn_AddTeam.Click += new System.EventHandler(this.btn_AddTeam_Click);
            // 
            // lb_Versus
            // 
            this.lb_Versus.AutoSize = true;
            this.lb_Versus.Location = new System.Drawing.Point(598, 519);
            this.lb_Versus.Name = "lb_Versus";
            this.lb_Versus.Size = new System.Drawing.Size(34, 25);
            this.lb_Versus.TabIndex = 8;
            this.lb_Versus.Text = "vs";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 439);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(167, 53);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 728);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lb_Versus);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.tBox_Skor2);
            this.Controls.Add(this.tBox_Skor1);
            this.Controls.Add(this.cBox_NamaTim2);
            this.Controls.Add(this.cBox_NamaTim1);
            this.Controls.Add(this.btn_AddMatch);
            this.Controls.Add(this.dGV_Match);
            this.Controls.Add(this.dTP_Match);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP_Match;
        private System.Windows.Forms.DataGridView dGV_Match;
        private System.Windows.Forms.Button btn_AddMatch;
        private System.Windows.Forms.ComboBox cBox_NamaTim1;
        private System.Windows.Forms.ComboBox cBox_NamaTim2;
        private System.Windows.Forms.TextBox tBox_Skor1;
        private System.Windows.Forms.TextBox tBox_Skor2;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Label lb_Versus;
        private System.Windows.Forms.Button btn_Delete;
    }
}

