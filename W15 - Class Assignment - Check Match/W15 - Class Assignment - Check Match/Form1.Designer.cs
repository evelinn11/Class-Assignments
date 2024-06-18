namespace W15___Class_Assignment___Check_Match
{
    partial class Form1
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
            this.cBox_TeamHome = new System.Windows.Forms.ComboBox();
            this.cBox_TeamAway = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ManagerHome = new System.Windows.Forms.Label();
            this.lb_CaptainHome = new System.Windows.Forms.Label();
            this.lb_NamaManagerHome = new System.Windows.Forms.Label();
            this.lb_NamaCaptainHome = new System.Windows.Forms.Label();
            this.lb_ManagerAway = new System.Windows.Forms.Label();
            this.lb_CaptainAway = new System.Windows.Forms.Label();
            this.lb_NamaManagerAway = new System.Windows.Forms.Label();
            this.lb_NamaCaptainAway = new System.Windows.Forms.Label();
            this.lb_Stadium = new System.Windows.Forms.Label();
            this.lb_NamaStadium = new System.Windows.Forms.Label();
            this.lb_Capacity = new System.Windows.Forms.Label();
            this.lb_JumlahCapacity = new System.Windows.Forms.Label();
            this.lb_Tanggal = new System.Windows.Forms.Label();
            this.lb_TanggalTanding = new System.Windows.Forms.Label();
            this.lb_Skor = new System.Windows.Forms.Label();
            this.lb_Angka = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.dGV_Match = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // cBox_TeamHome
            // 
            this.cBox_TeamHome.FormattingEnabled = true;
            this.cBox_TeamHome.Location = new System.Drawing.Point(65, 51);
            this.cBox_TeamHome.Name = "cBox_TeamHome";
            this.cBox_TeamHome.Size = new System.Drawing.Size(273, 33);
            this.cBox_TeamHome.TabIndex = 0;
            this.cBox_TeamHome.SelectedIndexChanged += new System.EventHandler(this.cBox_TeamHome_SelectedIndexChanged);
            // 
            // cBox_TeamAway
            // 
            this.cBox_TeamAway.FormattingEnabled = true;
            this.cBox_TeamAway.Location = new System.Drawing.Point(727, 51);
            this.cBox_TeamAway.Name = "cBox_TeamAway";
            this.cBox_TeamAway.Size = new System.Drawing.Size(275, 33);
            this.cBox_TeamAway.TabIndex = 1;
            this.cBox_TeamAway.SelectedIndexChanged += new System.EventHandler(this.cBox_TeamAway_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // lb_ManagerHome
            // 
            this.lb_ManagerHome.AutoSize = true;
            this.lb_ManagerHome.Location = new System.Drawing.Point(60, 126);
            this.lb_ManagerHome.Name = "lb_ManagerHome";
            this.lb_ManagerHome.Size = new System.Drawing.Size(109, 25);
            this.lb_ManagerHome.TabIndex = 3;
            this.lb_ManagerHome.Text = "Manager :";
            // 
            // lb_CaptainHome
            // 
            this.lb_CaptainHome.AutoSize = true;
            this.lb_CaptainHome.Location = new System.Drawing.Point(60, 181);
            this.lb_CaptainHome.Name = "lb_CaptainHome";
            this.lb_CaptainHome.Size = new System.Drawing.Size(98, 25);
            this.lb_CaptainHome.TabIndex = 4;
            this.lb_CaptainHome.Text = "Captain :";
            // 
            // lb_NamaManagerHome
            // 
            this.lb_NamaManagerHome.AutoSize = true;
            this.lb_NamaManagerHome.Location = new System.Drawing.Point(180, 126);
            this.lb_NamaManagerHome.Name = "lb_NamaManagerHome";
            this.lb_NamaManagerHome.Size = new System.Drawing.Size(158, 25);
            this.lb_NamaManagerHome.TabIndex = 5;
            this.lb_NamaManagerHome.Text = "Nama manager";
            // 
            // lb_NamaCaptainHome
            // 
            this.lb_NamaCaptainHome.AutoSize = true;
            this.lb_NamaCaptainHome.Location = new System.Drawing.Point(180, 181);
            this.lb_NamaCaptainHome.Name = "lb_NamaCaptainHome";
            this.lb_NamaCaptainHome.Size = new System.Drawing.Size(144, 25);
            this.lb_NamaCaptainHome.TabIndex = 6;
            this.lb_NamaCaptainHome.Text = "Nama captain";
            // 
            // lb_ManagerAway
            // 
            this.lb_ManagerAway.AutoSize = true;
            this.lb_ManagerAway.Location = new System.Drawing.Point(722, 126);
            this.lb_ManagerAway.Name = "lb_ManagerAway";
            this.lb_ManagerAway.Size = new System.Drawing.Size(109, 25);
            this.lb_ManagerAway.TabIndex = 7;
            this.lb_ManagerAway.Text = "Manager :";
            // 
            // lb_CaptainAway
            // 
            this.lb_CaptainAway.AutoSize = true;
            this.lb_CaptainAway.Location = new System.Drawing.Point(722, 181);
            this.lb_CaptainAway.Name = "lb_CaptainAway";
            this.lb_CaptainAway.Size = new System.Drawing.Size(98, 25);
            this.lb_CaptainAway.TabIndex = 8;
            this.lb_CaptainAway.Text = "Captain :";
            // 
            // lb_NamaManagerAway
            // 
            this.lb_NamaManagerAway.AutoSize = true;
            this.lb_NamaManagerAway.Location = new System.Drawing.Point(844, 126);
            this.lb_NamaManagerAway.Name = "lb_NamaManagerAway";
            this.lb_NamaManagerAway.Size = new System.Drawing.Size(158, 25);
            this.lb_NamaManagerAway.TabIndex = 9;
            this.lb_NamaManagerAway.Text = "Nama manager";
            // 
            // lb_NamaCaptainAway
            // 
            this.lb_NamaCaptainAway.AutoSize = true;
            this.lb_NamaCaptainAway.Location = new System.Drawing.Point(844, 181);
            this.lb_NamaCaptainAway.Name = "lb_NamaCaptainAway";
            this.lb_NamaCaptainAway.Size = new System.Drawing.Size(144, 25);
            this.lb_NamaCaptainAway.TabIndex = 10;
            this.lb_NamaCaptainAway.Text = "Nama captain";
            // 
            // lb_Stadium
            // 
            this.lb_Stadium.AutoSize = true;
            this.lb_Stadium.Location = new System.Drawing.Point(394, 285);
            this.lb_Stadium.Name = "lb_Stadium";
            this.lb_Stadium.Size = new System.Drawing.Size(108, 25);
            this.lb_Stadium.TabIndex = 11;
            this.lb_Stadium.Text = "Stadium : ";
            // 
            // lb_NamaStadium
            // 
            this.lb_NamaStadium.AutoSize = true;
            this.lb_NamaStadium.Location = new System.Drawing.Point(501, 285);
            this.lb_NamaStadium.Name = "lb_NamaStadium";
            this.lb_NamaStadium.Size = new System.Drawing.Size(149, 25);
            this.lb_NamaStadium.TabIndex = 12;
            this.lb_NamaStadium.Text = "Nama stadium";
            // 
            // lb_Capacity
            // 
            this.lb_Capacity.AutoSize = true;
            this.lb_Capacity.Location = new System.Drawing.Point(387, 348);
            this.lb_Capacity.Name = "lb_Capacity";
            this.lb_Capacity.Size = new System.Drawing.Size(108, 25);
            this.lb_Capacity.TabIndex = 13;
            this.lb_Capacity.Text = "Capacity :";
            // 
            // lb_JumlahCapacity
            // 
            this.lb_JumlahCapacity.AutoSize = true;
            this.lb_JumlahCapacity.Location = new System.Drawing.Point(501, 348);
            this.lb_JumlahCapacity.Name = "lb_JumlahCapacity";
            this.lb_JumlahCapacity.Size = new System.Drawing.Size(167, 25);
            this.lb_JumlahCapacity.TabIndex = 14;
            this.lb_JumlahCapacity.Text = "Jumlah capacity";
            // 
            // lb_Tanggal
            // 
            this.lb_Tanggal.AutoSize = true;
            this.lb_Tanggal.Location = new System.Drawing.Point(397, 484);
            this.lb_Tanggal.Name = "lb_Tanggal";
            this.lb_Tanggal.Size = new System.Drawing.Size(102, 25);
            this.lb_Tanggal.TabIndex = 15;
            this.lb_Tanggal.Text = "Tanggal :";
            // 
            // lb_TanggalTanding
            // 
            this.lb_TanggalTanding.AutoSize = true;
            this.lb_TanggalTanding.Location = new System.Drawing.Point(504, 484);
            this.lb_TanggalTanding.Name = "lb_TanggalTanding";
            this.lb_TanggalTanding.Size = new System.Drawing.Size(129, 25);
            this.lb_TanggalTanding.TabIndex = 16;
            this.lb_TanggalTanding.Text = "Tanggal asli";
            // 
            // lb_Skor
            // 
            this.lb_Skor.AutoSize = true;
            this.lb_Skor.Location = new System.Drawing.Point(430, 540);
            this.lb_Skor.Name = "lb_Skor";
            this.lb_Skor.Size = new System.Drawing.Size(68, 25);
            this.lb_Skor.TabIndex = 17;
            this.lb_Skor.Text = "Skor :";
            // 
            // lb_Angka
            // 
            this.lb_Angka.AutoSize = true;
            this.lb_Angka.Location = new System.Drawing.Point(504, 540);
            this.lb_Angka.Name = "lb_Angka";
            this.lb_Angka.Size = new System.Drawing.Size(73, 25);
            this.lb_Angka.TabIndex = 18;
            this.lb_Angka.Text = "Angka";
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(440, 404);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(144, 51);
            this.btn_Check.TabIndex = 19;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // dGV_Match
            // 
            this.dGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Match.Location = new System.Drawing.Point(41, 618);
            this.dGV_Match.Name = "dGV_Match";
            this.dGV_Match.RowHeadersWidth = 82;
            this.dGV_Match.RowTemplate.Height = 33;
            this.dGV_Match.Size = new System.Drawing.Size(1210, 439);
            this.dGV_Match.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1088);
            this.Controls.Add(this.dGV_Match);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.lb_Angka);
            this.Controls.Add(this.lb_Skor);
            this.Controls.Add(this.lb_TanggalTanding);
            this.Controls.Add(this.lb_Tanggal);
            this.Controls.Add(this.lb_JumlahCapacity);
            this.Controls.Add(this.lb_Capacity);
            this.Controls.Add(this.lb_NamaStadium);
            this.Controls.Add(this.lb_Stadium);
            this.Controls.Add(this.lb_NamaCaptainAway);
            this.Controls.Add(this.lb_NamaManagerAway);
            this.Controls.Add(this.lb_CaptainAway);
            this.Controls.Add(this.lb_ManagerAway);
            this.Controls.Add(this.lb_NamaCaptainHome);
            this.Controls.Add(this.lb_NamaManagerHome);
            this.Controls.Add(this.lb_CaptainHome);
            this.Controls.Add(this.lb_ManagerHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_TeamAway);
            this.Controls.Add(this.cBox_TeamHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_TeamHome;
        private System.Windows.Forms.ComboBox cBox_TeamAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ManagerHome;
        private System.Windows.Forms.Label lb_CaptainHome;
        private System.Windows.Forms.Label lb_NamaManagerHome;
        private System.Windows.Forms.Label lb_NamaCaptainHome;
        private System.Windows.Forms.Label lb_ManagerAway;
        private System.Windows.Forms.Label lb_CaptainAway;
        private System.Windows.Forms.Label lb_NamaManagerAway;
        private System.Windows.Forms.Label lb_NamaCaptainAway;
        private System.Windows.Forms.Label lb_Stadium;
        private System.Windows.Forms.Label lb_NamaStadium;
        private System.Windows.Forms.Label lb_Capacity;
        private System.Windows.Forms.Label lb_JumlahCapacity;
        private System.Windows.Forms.Label lb_Tanggal;
        private System.Windows.Forms.Label lb_TanggalTanding;
        private System.Windows.Forms.Label lb_Skor;
        private System.Windows.Forms.Label lb_Angka;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.DataGridView dGV_Match;
    }
}

