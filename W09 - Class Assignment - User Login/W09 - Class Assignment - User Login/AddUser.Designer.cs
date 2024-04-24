namespace W09___Class_Assignment___User_Login
{
    partial class AddUser
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
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Usename = new System.Windows.Forms.Label();
            this.lb_Confirm = new System.Windows.Forms.Label();
            this.tB_Confirm = new System.Windows.Forms.TextBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(135, 81);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(100, 20);
            this.tB_Password.TabIndex = 8;
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(135, 50);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(100, 20);
            this.tB_Username.TabIndex = 7;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(26, 84);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 6;
            this.lb_Password.Text = "Password";
            // 
            // lb_Usename
            // 
            this.lb_Usename.AutoSize = true;
            this.lb_Usename.Location = new System.Drawing.Point(26, 53);
            this.lb_Usename.Name = "lb_Usename";
            this.lb_Usename.Size = new System.Drawing.Size(55, 13);
            this.lb_Usename.TabIndex = 5;
            this.lb_Usename.Text = "Username";
            // 
            // lb_Confirm
            // 
            this.lb_Confirm.AutoSize = true;
            this.lb_Confirm.Location = new System.Drawing.Point(26, 113);
            this.lb_Confirm.Name = "lb_Confirm";
            this.lb_Confirm.Size = new System.Drawing.Size(91, 13);
            this.lb_Confirm.TabIndex = 9;
            this.lb_Confirm.Text = "Confirm Password";
            // 
            // tB_Confirm
            // 
            this.tB_Confirm.Location = new System.Drawing.Point(135, 110);
            this.tB_Confirm.Name = "tB_Confirm";
            this.tB_Confirm.PasswordChar = '*';
            this.tB_Confirm.Size = new System.Drawing.Size(100, 20);
            this.tB_Confirm.TabIndex = 10;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(136, 147);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(98, 24);
            this.btn_AddUser.TabIndex = 11;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 289);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.tB_Confirm);
            this.Controls.Add(this.lb_Confirm);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Usename);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Usename;
        private System.Windows.Forms.Label lb_Confirm;
        private System.Windows.Forms.TextBox tB_Confirm;
        private System.Windows.Forms.Button btn_AddUser;
    }
}