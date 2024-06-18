namespace W11___Class_Assignment___Detail_Match
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
            this.lb_Server = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Database = new System.Windows.Forms.Label();
            this.tB_Server = new System.Windows.Forms.TextBox();
            this.tB_User = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.tB_Database = new System.Windows.Forms.TextBox();
            this.lb_MatchID = new System.Windows.Forms.Label();
            this.tB_MatchID = new System.Windows.Forms.TextBox();
            this.lb_TeamHome = new System.Windows.Forms.Label();
            this.cBox_TeamHome = new System.Windows.Forms.ComboBox();
            this.cBox_TeamAway = new System.Windows.Forms.ComboBox();
            this.lb_TeamAway = new System.Windows.Forms.Label();
            this.lb_MatchDate = new System.Windows.Forms.Label();
            this.dTP_MatchDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Login = new System.Windows.Forms.Button();
            this.dGV_Match = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Server
            // 
            this.lb_Server.AutoSize = true;
            this.lb_Server.Location = new System.Drawing.Point(28, 24);
            this.lb_Server.Name = "lb_Server";
            this.lb_Server.Size = new System.Drawing.Size(38, 13);
            this.lb_Server.TabIndex = 0;
            this.lb_Server.Text = "Server";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(28, 50);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(29, 13);
            this.lb_User.TabIndex = 1;
            this.lb_User.Text = "User";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(28, 77);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password";
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Location = new System.Drawing.Point(28, 102);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(53, 13);
            this.lb_Database.TabIndex = 3;
            this.lb_Database.Text = "Database";
            // 
            // tB_Server
            // 
            this.tB_Server.Location = new System.Drawing.Point(88, 21);
            this.tB_Server.Name = "tB_Server";
            this.tB_Server.Size = new System.Drawing.Size(104, 20);
            this.tB_Server.TabIndex = 4;
            // 
            // tB_User
            // 
            this.tB_User.Location = new System.Drawing.Point(88, 47);
            this.tB_User.Name = "tB_User";
            this.tB_User.Size = new System.Drawing.Size(104, 20);
            this.tB_User.TabIndex = 5;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(88, 73);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(104, 20);
            this.tB_Password.TabIndex = 6;
            // 
            // tB_Database
            // 
            this.tB_Database.Location = new System.Drawing.Point(88, 99);
            this.tB_Database.Name = "tB_Database";
            this.tB_Database.Size = new System.Drawing.Size(104, 20);
            this.tB_Database.TabIndex = 7;
            // 
            // lb_MatchID
            // 
            this.lb_MatchID.AutoSize = true;
            this.lb_MatchID.Location = new System.Drawing.Point(246, 24);
            this.lb_MatchID.Name = "lb_MatchID";
            this.lb_MatchID.Size = new System.Drawing.Size(51, 13);
            this.lb_MatchID.TabIndex = 8;
            this.lb_MatchID.Text = "Match ID";
            // 
            // tB_MatchID
            // 
            this.tB_MatchID.Enabled = false;
            this.tB_MatchID.Location = new System.Drawing.Point(317, 21);
            this.tB_MatchID.Name = "tB_MatchID";
            this.tB_MatchID.Size = new System.Drawing.Size(104, 20);
            this.tB_MatchID.TabIndex = 9;
            // 
            // lb_TeamHome
            // 
            this.lb_TeamHome.AutoSize = true;
            this.lb_TeamHome.Location = new System.Drawing.Point(246, 77);
            this.lb_TeamHome.Name = "lb_TeamHome";
            this.lb_TeamHome.Size = new System.Drawing.Size(65, 13);
            this.lb_TeamHome.TabIndex = 10;
            this.lb_TeamHome.Text = "Team Home";
            // 
            // cBox_TeamHome
            // 
            this.cBox_TeamHome.FormattingEnabled = true;
            this.cBox_TeamHome.Location = new System.Drawing.Point(317, 74);
            this.cBox_TeamHome.Name = "cBox_TeamHome";
            this.cBox_TeamHome.Size = new System.Drawing.Size(104, 21);
            this.cBox_TeamHome.TabIndex = 11;
            this.cBox_TeamHome.SelectedIndexChanged += new System.EventHandler(this.cBox_TeamHome_SelectedIndexChanged);
            // 
            // cBox_TeamAway
            // 
            this.cBox_TeamAway.FormattingEnabled = true;
            this.cBox_TeamAway.Location = new System.Drawing.Point(529, 74);
            this.cBox_TeamAway.Name = "cBox_TeamAway";
            this.cBox_TeamAway.Size = new System.Drawing.Size(104, 21);
            this.cBox_TeamAway.TabIndex = 13;
            this.cBox_TeamAway.SelectedIndexChanged += new System.EventHandler(this.cBox_TeamAway_SelectedIndexChanged);
            // 
            // lb_TeamAway
            // 
            this.lb_TeamAway.AutoSize = true;
            this.lb_TeamAway.Location = new System.Drawing.Point(460, 76);
            this.lb_TeamAway.Name = "lb_TeamAway";
            this.lb_TeamAway.Size = new System.Drawing.Size(63, 13);
            this.lb_TeamAway.TabIndex = 12;
            this.lb_TeamAway.Text = "Team Away";
            // 
            // lb_MatchDate
            // 
            this.lb_MatchDate.AutoSize = true;
            this.lb_MatchDate.Location = new System.Drawing.Point(460, 24);
            this.lb_MatchDate.Name = "lb_MatchDate";
            this.lb_MatchDate.Size = new System.Drawing.Size(63, 13);
            this.lb_MatchDate.TabIndex = 14;
            this.lb_MatchDate.Text = "Match Date";
            // 
            // dTP_MatchDate
            // 
            this.dTP_MatchDate.Location = new System.Drawing.Point(529, 21);
            this.dTP_MatchDate.Name = "dTP_MatchDate";
            this.dTP_MatchDate.Size = new System.Drawing.Size(137, 20);
            this.dTP_MatchDate.TabIndex = 15;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(88, 125);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(61, 21);
            this.btn_Login.TabIndex = 16;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // dGV_Match
            // 
            this.dGV_Match.AllowUserToAddRows = false;
            this.dGV_Match.AllowUserToDeleteRows = false;
            this.dGV_Match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Match.Location = new System.Drawing.Point(249, 112);
            this.dGV_Match.MultiSelect = false;
            this.dGV_Match.Name = "dGV_Match";
            this.dGV_Match.ReadOnly = true;
            this.dGV_Match.RowHeadersVisible = false;
            this.dGV_Match.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Match.Size = new System.Drawing.Size(384, 231);
            this.dGV_Match.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 355);
            this.Controls.Add(this.dGV_Match);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.dTP_MatchDate);
            this.Controls.Add(this.lb_MatchDate);
            this.Controls.Add(this.cBox_TeamAway);
            this.Controls.Add(this.lb_TeamAway);
            this.Controls.Add(this.cBox_TeamHome);
            this.Controls.Add(this.lb_TeamHome);
            this.Controls.Add(this.tB_MatchID);
            this.Controls.Add(this.lb_MatchID);
            this.Controls.Add(this.tB_Database);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_User);
            this.Controls.Add(this.tB_Server);
            this.Controls.Add(this.lb_Database);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.lb_Server);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Server;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Database;
        private System.Windows.Forms.TextBox tB_Server;
        private System.Windows.Forms.TextBox tB_User;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.TextBox tB_Database;
        private System.Windows.Forms.Label lb_MatchID;
        private System.Windows.Forms.TextBox tB_MatchID;
        private System.Windows.Forms.Label lb_TeamHome;
        private System.Windows.Forms.ComboBox cBox_TeamHome;
        private System.Windows.Forms.ComboBox cBox_TeamAway;
        private System.Windows.Forms.Label lb_TeamAway;
        private System.Windows.Forms.Label lb_MatchDate;
        private System.Windows.Forms.DateTimePicker dTP_MatchDate;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.DataGridView dGV_Match;
    }
}

