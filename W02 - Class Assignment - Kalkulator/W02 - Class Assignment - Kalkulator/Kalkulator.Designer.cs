namespace W02___Class_Assignment___Kalkulator
{
    partial class Kalkulator
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
            this.lb_AngkaPertama = new System.Windows.Forms.Label();
            this.lb_AngkaKedua = new System.Windows.Forms.Label();
            this.tB_AngkaPertama = new System.Windows.Forms.TextBox();
            this.tB_AngkaKedua = new System.Windows.Forms.TextBox();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.lb_Hasil = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.rBtn_Penjumlahan = new System.Windows.Forms.RadioButton();
            this.rBtn_Pengurangan = new System.Windows.Forms.RadioButton();
            this.rBtn_Perkalian = new System.Windows.Forms.RadioButton();
            this.rBtn_Pembagian = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lb_AngkaPertama
            // 
            this.lb_AngkaPertama.AutoSize = true;
            this.lb_AngkaPertama.Location = new System.Drawing.Point(32, 31);
            this.lb_AngkaPertama.Name = "lb_AngkaPertama";
            this.lb_AngkaPertama.Size = new System.Drawing.Size(47, 13);
            this.lb_AngkaPertama.TabIndex = 0;
            this.lb_AngkaPertama.Text = "Angka 1";
            // 
            // lb_AngkaKedua
            // 
            this.lb_AngkaKedua.AutoSize = true;
            this.lb_AngkaKedua.Location = new System.Drawing.Point(32, 59);
            this.lb_AngkaKedua.Name = "lb_AngkaKedua";
            this.lb_AngkaKedua.Size = new System.Drawing.Size(47, 13);
            this.lb_AngkaKedua.TabIndex = 1;
            this.lb_AngkaKedua.Text = "Angka 2";
            // 
            // tB_AngkaPertama
            // 
            this.tB_AngkaPertama.Location = new System.Drawing.Point(93, 28);
            this.tB_AngkaPertama.Name = "tB_AngkaPertama";
            this.tB_AngkaPertama.Size = new System.Drawing.Size(55, 20);
            this.tB_AngkaPertama.TabIndex = 2;
            // 
            // tB_AngkaKedua
            // 
            this.tB_AngkaKedua.Location = new System.Drawing.Point(93, 56);
            this.tB_AngkaKedua.Name = "tB_AngkaKedua";
            this.tB_AngkaKedua.Size = new System.Drawing.Size(55, 20);
            this.tB_AngkaKedua.TabIndex = 3;
            // 
            // btn_Hitung
            // 
            this.btn_Hitung.Location = new System.Drawing.Point(93, 90);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(54, 26);
            this.btn_Hitung.TabIndex = 4;
            this.btn_Hitung.Text = "Hitung";
            this.btn_Hitung.UseVisualStyleBackColor = true;
            this.btn_Hitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // lb_Hasil
            // 
            this.lb_Hasil.AutoSize = true;
            this.lb_Hasil.Location = new System.Drawing.Point(32, 135);
            this.lb_Hasil.Name = "lb_Hasil";
            this.lb_Hasil.Size = new System.Drawing.Size(30, 13);
            this.lb_Hasil.TabIndex = 5;
            this.lb_Hasil.Text = "Hasil";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(101, 135);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(13, 13);
            this.lb_Total.TabIndex = 6;
            this.lb_Total.Text = "0";
            // 
            // rBtn_Penjumlahan
            // 
            this.rBtn_Penjumlahan.AutoSize = true;
            this.rBtn_Penjumlahan.Location = new System.Drawing.Point(171, 31);
            this.rBtn_Penjumlahan.Name = "rBtn_Penjumlahan";
            this.rBtn_Penjumlahan.Size = new System.Drawing.Size(86, 17);
            this.rBtn_Penjumlahan.TabIndex = 7;
            this.rBtn_Penjumlahan.TabStop = true;
            this.rBtn_Penjumlahan.Text = "Penjumlahan";
            this.rBtn_Penjumlahan.UseVisualStyleBackColor = true;
            // 
            // rBtn_Pengurangan
            // 
            this.rBtn_Pengurangan.AutoSize = true;
            this.rBtn_Pengurangan.Location = new System.Drawing.Point(171, 54);
            this.rBtn_Pengurangan.Name = "rBtn_Pengurangan";
            this.rBtn_Pengurangan.Size = new System.Drawing.Size(89, 17);
            this.rBtn_Pengurangan.TabIndex = 8;
            this.rBtn_Pengurangan.TabStop = true;
            this.rBtn_Pengurangan.Text = "Pengurangan";
            this.rBtn_Pengurangan.UseVisualStyleBackColor = true;
            // 
            // rBtn_Perkalian
            // 
            this.rBtn_Perkalian.AutoSize = true;
            this.rBtn_Perkalian.Location = new System.Drawing.Point(171, 77);
            this.rBtn_Perkalian.Name = "rBtn_Perkalian";
            this.rBtn_Perkalian.Size = new System.Drawing.Size(69, 17);
            this.rBtn_Perkalian.TabIndex = 9;
            this.rBtn_Perkalian.TabStop = true;
            this.rBtn_Perkalian.Text = "Perkalian";
            this.rBtn_Perkalian.UseVisualStyleBackColor = true;
            // 
            // rBtn_Pembagian
            // 
            this.rBtn_Pembagian.AutoSize = true;
            this.rBtn_Pembagian.Location = new System.Drawing.Point(171, 100);
            this.rBtn_Pembagian.Name = "rBtn_Pembagian";
            this.rBtn_Pembagian.Size = new System.Drawing.Size(78, 17);
            this.rBtn_Pembagian.TabIndex = 10;
            this.rBtn_Pembagian.TabStop = true;
            this.rBtn_Pembagian.Text = "Pembagian";
            this.rBtn_Pembagian.UseVisualStyleBackColor = true;
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 191);
            this.Controls.Add(this.rBtn_Pembagian);
            this.Controls.Add(this.rBtn_Perkalian);
            this.Controls.Add(this.rBtn_Pengurangan);
            this.Controls.Add(this.rBtn_Penjumlahan);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.lb_Hasil);
            this.Controls.Add(this.btn_Hitung);
            this.Controls.Add(this.tB_AngkaKedua);
            this.Controls.Add(this.tB_AngkaPertama);
            this.Controls.Add(this.lb_AngkaKedua);
            this.Controls.Add(this.lb_AngkaPertama);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AngkaPertama;
        private System.Windows.Forms.Label lb_AngkaKedua;
        private System.Windows.Forms.TextBox tB_AngkaPertama;
        private System.Windows.Forms.TextBox tB_AngkaKedua;
        private System.Windows.Forms.Button btn_Hitung;
        private System.Windows.Forms.Label lb_Hasil;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.RadioButton rBtn_Penjumlahan;
        private System.Windows.Forms.RadioButton rBtn_Pengurangan;
        private System.Windows.Forms.RadioButton rBtn_Perkalian;
        private System.Windows.Forms.RadioButton rBtn_Pembagian;
    }
}

