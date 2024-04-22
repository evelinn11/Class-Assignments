namespace W08___Class_Assignment___Simpan_Data
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
            this.lb_Nama = new System.Windows.Forms.Label();
            this.lb_Alamat = new System.Windows.Forms.Label();
            this.lb_NoHP = new System.Windows.Forms.Label();
            this.tB_Nama = new System.Windows.Forms.TextBox();
            this.tB_Alamat = new System.Windows.Forms.TextBox();
            this.tB_NoHP = new System.Windows.Forms.TextBox();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.btn_Lihat = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Kembali = new System.Windows.Forms.Button();
            this.panel_View = new System.Windows.Forms.Panel();
            this.btn_File = new System.Windows.Forms.Button();
            this.panel_View.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Nama
            // 
            this.lb_Nama.AutoSize = true;
            this.lb_Nama.Location = new System.Drawing.Point(33, 65);
            this.lb_Nama.Name = "lb_Nama";
            this.lb_Nama.Size = new System.Drawing.Size(68, 25);
            this.lb_Nama.TabIndex = 0;
            this.lb_Nama.Text = "Nama";
            // 
            // lb_Alamat
            // 
            this.lb_Alamat.AutoSize = true;
            this.lb_Alamat.Location = new System.Drawing.Point(33, 102);
            this.lb_Alamat.Name = "lb_Alamat";
            this.lb_Alamat.Size = new System.Drawing.Size(78, 25);
            this.lb_Alamat.TabIndex = 1;
            this.lb_Alamat.Text = "Alamat";
            // 
            // lb_NoHP
            // 
            this.lb_NoHP.AutoSize = true;
            this.lb_NoHP.Location = new System.Drawing.Point(33, 136);
            this.lb_NoHP.Name = "lb_NoHP";
            this.lb_NoHP.Size = new System.Drawing.Size(74, 25);
            this.lb_NoHP.TabIndex = 2;
            this.lb_NoHP.Text = "No HP";
            // 
            // tB_Nama
            // 
            this.tB_Nama.Location = new System.Drawing.Point(157, 62);
            this.tB_Nama.Name = "tB_Nama";
            this.tB_Nama.Size = new System.Drawing.Size(255, 31);
            this.tB_Nama.TabIndex = 3;
            // 
            // tB_Alamat
            // 
            this.tB_Alamat.Location = new System.Drawing.Point(157, 96);
            this.tB_Alamat.Name = "tB_Alamat";
            this.tB_Alamat.Size = new System.Drawing.Size(255, 31);
            this.tB_Alamat.TabIndex = 4;
            // 
            // tB_NoHP
            // 
            this.tB_NoHP.Location = new System.Drawing.Point(157, 130);
            this.tB_NoHP.Name = "tB_NoHP";
            this.tB_NoHP.Size = new System.Drawing.Size(255, 31);
            this.tB_NoHP.TabIndex = 5;
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(157, 185);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(110, 40);
            this.btn_Simpan.TabIndex = 6;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // btn_Lihat
            // 
            this.btn_Lihat.Location = new System.Drawing.Point(286, 185);
            this.btn_Lihat.Name = "btn_Lihat";
            this.btn_Lihat.Size = new System.Drawing.Size(110, 40);
            this.btn_Lihat.TabIndex = 7;
            this.btn_Lihat.Text = "Lihat";
            this.btn_Lihat.UseVisualStyleBackColor = true;
            this.btn_Lihat.Click += new System.EventHandler(this.btn_Lihat_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(5, 9);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(79, 40);
            this.btn_Prev.TabIndex = 8;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(90, 9);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(83, 40);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Kembali
            // 
            this.btn_Kembali.Location = new System.Drawing.Point(179, 9);
            this.btn_Kembali.Name = "btn_Kembali";
            this.btn_Kembali.Size = new System.Drawing.Size(110, 40);
            this.btn_Kembali.TabIndex = 10;
            this.btn_Kembali.Text = "Kembali";
            this.btn_Kembali.UseVisualStyleBackColor = true;
            this.btn_Kembali.Click += new System.EventHandler(this.btn_Kembali_Click);
            // 
            // panel_View
            // 
            this.panel_View.Controls.Add(this.btn_Kembali);
            this.panel_View.Controls.Add(this.btn_Next);
            this.panel_View.Controls.Add(this.btn_Prev);
            this.panel_View.Location = new System.Drawing.Point(157, 185);
            this.panel_View.Name = "panel_View";
            this.panel_View.Size = new System.Drawing.Size(300, 57);
            this.panel_View.TabIndex = 11;
            this.panel_View.Visible = false;
            // 
            // btn_File
            // 
            this.btn_File.Location = new System.Drawing.Point(682, 27);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(104, 44);
            this.btn_File.TabIndex = 12;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 727);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.panel_View);
            this.Controls.Add(this.btn_Lihat);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.tB_NoHP);
            this.Controls.Add(this.tB_Alamat);
            this.Controls.Add(this.tB_Nama);
            this.Controls.Add(this.lb_NoHP);
            this.Controls.Add(this.lb_Alamat);
            this.Controls.Add(this.lb_Nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_View.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nama;
        private System.Windows.Forms.Label lb_Alamat;
        private System.Windows.Forms.Label lb_NoHP;
        private System.Windows.Forms.TextBox tB_Nama;
        private System.Windows.Forms.TextBox tB_Alamat;
        private System.Windows.Forms.TextBox tB_NoHP;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_Lihat;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Kembali;
        private System.Windows.Forms.Panel panel_View;
        private System.Windows.Forms.Button btn_File;
    }
}

