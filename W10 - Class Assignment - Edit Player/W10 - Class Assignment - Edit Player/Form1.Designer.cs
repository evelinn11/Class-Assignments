namespace W10___Class_Assignment___Edit_Player
{
    partial class FormPlayer
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
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.lb_PlayerID = new System.Windows.Forms.Label();
            this.lb_PlayerName = new System.Windows.Forms.Label();
            this.lb_Birthdate = new System.Windows.Forms.Label();
            this.lb_Nationality = new System.Windows.Forms.Label();
            this.lb_Team = new System.Windows.Forms.Label();
            this.lb_TeamNumber = new System.Windows.Forms.Label();
            this.tB_PlayerID = new System.Windows.Forms.TextBox();
            this.tB_PlayerName = new System.Windows.Forms.TextBox();
            this.dTP_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.tB_Nationality = new System.Windows.Forms.TextBox();
            this.cBox_Team = new System.Windows.Forms.ComboBox();
            this.nUD_TeamNumber = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(31, 36);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(65, 61);
            this.btn_First.TabIndex = 0;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(102, 36);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(65, 61);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(173, 36);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(65, 61);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(244, 36);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(65, 61);
            this.btn_Last.TabIndex = 3;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // lb_PlayerID
            // 
            this.lb_PlayerID.AutoSize = true;
            this.lb_PlayerID.Location = new System.Drawing.Point(28, 117);
            this.lb_PlayerID.Name = "lb_PlayerID";
            this.lb_PlayerID.Size = new System.Drawing.Size(50, 13);
            this.lb_PlayerID.TabIndex = 4;
            this.lb_PlayerID.Text = "Player ID";
            // 
            // lb_PlayerName
            // 
            this.lb_PlayerName.AutoSize = true;
            this.lb_PlayerName.Location = new System.Drawing.Point(28, 143);
            this.lb_PlayerName.Name = "lb_PlayerName";
            this.lb_PlayerName.Size = new System.Drawing.Size(67, 13);
            this.lb_PlayerName.TabIndex = 5;
            this.lb_PlayerName.Text = "Player Name";
            // 
            // lb_Birthdate
            // 
            this.lb_Birthdate.AutoSize = true;
            this.lb_Birthdate.Location = new System.Drawing.Point(28, 170);
            this.lb_Birthdate.Name = "lb_Birthdate";
            this.lb_Birthdate.Size = new System.Drawing.Size(49, 13);
            this.lb_Birthdate.TabIndex = 6;
            this.lb_Birthdate.Text = "Birthdate";
            // 
            // lb_Nationality
            // 
            this.lb_Nationality.AutoSize = true;
            this.lb_Nationality.Location = new System.Drawing.Point(28, 195);
            this.lb_Nationality.Name = "lb_Nationality";
            this.lb_Nationality.Size = new System.Drawing.Size(56, 13);
            this.lb_Nationality.TabIndex = 7;
            this.lb_Nationality.Text = "Nationality";
            // 
            // lb_Team
            // 
            this.lb_Team.AutoSize = true;
            this.lb_Team.Location = new System.Drawing.Point(28, 221);
            this.lb_Team.Name = "lb_Team";
            this.lb_Team.Size = new System.Drawing.Size(34, 13);
            this.lb_Team.TabIndex = 8;
            this.lb_Team.Text = "Team";
            // 
            // lb_TeamNumber
            // 
            this.lb_TeamNumber.AutoSize = true;
            this.lb_TeamNumber.Location = new System.Drawing.Point(28, 248);
            this.lb_TeamNumber.Name = "lb_TeamNumber";
            this.lb_TeamNumber.Size = new System.Drawing.Size(74, 13);
            this.lb_TeamNumber.TabIndex = 9;
            this.lb_TeamNumber.Text = "Team Number";
            // 
            // tB_PlayerID
            // 
            this.tB_PlayerID.Enabled = false;
            this.tB_PlayerID.Location = new System.Drawing.Point(117, 114);
            this.tB_PlayerID.Name = "tB_PlayerID";
            this.tB_PlayerID.Size = new System.Drawing.Size(139, 20);
            this.tB_PlayerID.TabIndex = 10;
            // 
            // tB_PlayerName
            // 
            this.tB_PlayerName.Location = new System.Drawing.Point(117, 140);
            this.tB_PlayerName.Name = "tB_PlayerName";
            this.tB_PlayerName.Size = new System.Drawing.Size(139, 20);
            this.tB_PlayerName.TabIndex = 11;
            // 
            // dTP_Birthdate
            // 
            this.dTP_Birthdate.Location = new System.Drawing.Point(117, 166);
            this.dTP_Birthdate.Name = "dTP_Birthdate";
            this.dTP_Birthdate.Size = new System.Drawing.Size(214, 20);
            this.dTP_Birthdate.TabIndex = 12;
            // 
            // tB_Nationality
            // 
            this.tB_Nationality.Location = new System.Drawing.Point(117, 192);
            this.tB_Nationality.Name = "tB_Nationality";
            this.tB_Nationality.Size = new System.Drawing.Size(139, 20);
            this.tB_Nationality.TabIndex = 13;
            // 
            // cBox_Team
            // 
            this.cBox_Team.FormattingEnabled = true;
            this.cBox_Team.Location = new System.Drawing.Point(117, 218);
            this.cBox_Team.Name = "cBox_Team";
            this.cBox_Team.Size = new System.Drawing.Size(139, 21);
            this.cBox_Team.TabIndex = 14;
            // 
            // nUD_TeamNumber
            // 
            this.nUD_TeamNumber.Location = new System.Drawing.Point(117, 245);
            this.nUD_TeamNumber.Name = "nUD_TeamNumber";
            this.nUD_TeamNumber.Size = new System.Drawing.Size(120, 20);
            this.nUD_TeamNumber.TabIndex = 16;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(117, 271);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(67, 26);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 334);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.nUD_TeamNumber);
            this.Controls.Add(this.cBox_Team);
            this.Controls.Add(this.tB_Nationality);
            this.Controls.Add(this.dTP_Birthdate);
            this.Controls.Add(this.tB_PlayerName);
            this.Controls.Add(this.tB_PlayerID);
            this.Controls.Add(this.lb_TeamNumber);
            this.Controls.Add(this.lb_Team);
            this.Controls.Add(this.lb_Nationality);
            this.Controls.Add(this.lb_Birthdate);
            this.Controls.Add(this.lb_PlayerName);
            this.Controls.Add(this.lb_PlayerID);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "FormPlayer";
            this.Text = "Form Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Label lb_PlayerID;
        private System.Windows.Forms.Label lb_PlayerName;
        private System.Windows.Forms.Label lb_Birthdate;
        private System.Windows.Forms.Label lb_Nationality;
        private System.Windows.Forms.Label lb_Team;
        private System.Windows.Forms.Label lb_TeamNumber;
        private System.Windows.Forms.TextBox tB_PlayerID;
        private System.Windows.Forms.TextBox tB_PlayerName;
        private System.Windows.Forms.DateTimePicker dTP_Birthdate;
        private System.Windows.Forms.TextBox tB_Nationality;
        private System.Windows.Forms.ComboBox cBox_Team;
        private System.Windows.Forms.NumericUpDown nUD_TeamNumber;
        private System.Windows.Forms.Button btn_Save;
    }
}

