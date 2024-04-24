namespace W09___Class_Assignment___User_Login
{
    partial class Login
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
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.lb_Usename = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.Location = new System.Drawing.Point(65, 28);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(108, 25);
            this.lb_Welcome.TabIndex = 0;
            this.lb_Welcome.Text = "Welcome";
            // 
            // lb_Usename
            // 
            this.lb_Usename.AutoSize = true;
            this.lb_Usename.Location = new System.Drawing.Point(12, 78);
            this.lb_Usename.Name = "lb_Usename";
            this.lb_Usename.Size = new System.Drawing.Size(55, 13);
            this.lb_Usename.TabIndex = 1;
            this.lb_Usename.Text = "Username";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(14, 105);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password";
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(86, 75);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(100, 20);
            this.tB_Username.TabIndex = 3;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(86, 102);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(100, 20);
            this.tB_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(90, 143);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(83, 26);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 199);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Usename);
            this.Controls.Add(this.lb_Welcome);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label lb_Usename;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}

