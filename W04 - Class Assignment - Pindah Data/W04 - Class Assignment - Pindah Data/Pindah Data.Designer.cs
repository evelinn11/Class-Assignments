namespace W04___Class_Assignment___Pindah_Data
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
            this.lb_NamaA = new System.Windows.Forms.Label();
            this.lb_NamaB = new System.Windows.Forms.Label();
            this.tB_InputA = new System.Windows.Forms.TextBox();
            this.tB_InputB = new System.Windows.Forms.TextBox();
            this.btn_InputA = new System.Windows.Forms.Button();
            this.btn_InputB = new System.Windows.Forms.Button();
            this.lBox_Kiri = new System.Windows.Forms.ListBox();
            this.lBox_Kanan = new System.Windows.Forms.ListBox();
            this.btn_PindahKiriAll = new System.Windows.Forms.Button();
            this.btn_Kekiri = new System.Windows.Forms.Button();
            this.bt_Kekanan = new System.Windows.Forms.Button();
            this.btn_PindahKananAll = new System.Windows.Forms.Button();
            this.btn_ClearA = new System.Windows.Forms.Button();
            this.btn_ClearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_NamaA
            // 
            this.lb_NamaA.AutoSize = true;
            this.lb_NamaA.Location = new System.Drawing.Point(82, 51);
            this.lb_NamaA.Name = "lb_NamaA";
            this.lb_NamaA.Size = new System.Drawing.Size(35, 13);
            this.lb_NamaA.TabIndex = 0;
            this.lb_NamaA.Text = "Nama";
            // 
            // lb_NamaB
            // 
            this.lb_NamaB.AutoSize = true;
            this.lb_NamaB.Location = new System.Drawing.Point(297, 51);
            this.lb_NamaB.Name = "lb_NamaB";
            this.lb_NamaB.Size = new System.Drawing.Size(35, 13);
            this.lb_NamaB.TabIndex = 1;
            this.lb_NamaB.Text = "Nama";
            // 
            // tB_InputA
            // 
            this.tB_InputA.Location = new System.Drawing.Point(39, 67);
            this.tB_InputA.Name = "tB_InputA";
            this.tB_InputA.Size = new System.Drawing.Size(120, 20);
            this.tB_InputA.TabIndex = 2;
            // 
            // tB_InputB
            // 
            this.tB_InputB.Location = new System.Drawing.Point(252, 67);
            this.tB_InputB.Name = "tB_InputB";
            this.tB_InputB.Size = new System.Drawing.Size(120, 20);
            this.tB_InputB.TabIndex = 3;
            // 
            // btn_InputA
            // 
            this.btn_InputA.Location = new System.Drawing.Point(66, 93);
            this.btn_InputA.Name = "btn_InputA";
            this.btn_InputA.Size = new System.Drawing.Size(64, 23);
            this.btn_InputA.TabIndex = 4;
            this.btn_InputA.Text = "Input";
            this.btn_InputA.UseVisualStyleBackColor = true;
            this.btn_InputA.Click += new System.EventHandler(this.btn_InputA_Click);
            // 
            // btn_InputB
            // 
            this.btn_InputB.Location = new System.Drawing.Point(280, 93);
            this.btn_InputB.Name = "btn_InputB";
            this.btn_InputB.Size = new System.Drawing.Size(64, 23);
            this.btn_InputB.TabIndex = 5;
            this.btn_InputB.Text = "Input";
            this.btn_InputB.UseVisualStyleBackColor = true;
            this.btn_InputB.Click += new System.EventHandler(this.btn_InputB_Click);
            // 
            // lBox_Kiri
            // 
            this.lBox_Kiri.FormattingEnabled = true;
            this.lBox_Kiri.Location = new System.Drawing.Point(39, 138);
            this.lBox_Kiri.Name = "lBox_Kiri";
            this.lBox_Kiri.Size = new System.Drawing.Size(119, 121);
            this.lBox_Kiri.TabIndex = 6;
            // 
            // lBox_Kanan
            // 
            this.lBox_Kanan.FormattingEnabled = true;
            this.lBox_Kanan.Location = new System.Drawing.Point(253, 138);
            this.lBox_Kanan.Name = "lBox_Kanan";
            this.lBox_Kanan.Size = new System.Drawing.Size(119, 121);
            this.lBox_Kanan.TabIndex = 7;
            // 
            // btn_PindahKiriAll
            // 
            this.btn_PindahKiriAll.Location = new System.Drawing.Point(176, 149);
            this.btn_PindahKiriAll.Name = "btn_PindahKiriAll";
            this.btn_PindahKiriAll.Size = new System.Drawing.Size(56, 23);
            this.btn_PindahKiriAll.TabIndex = 8;
            this.btn_PindahKiriAll.Text = "<<";
            this.btn_PindahKiriAll.UseVisualStyleBackColor = true;
            this.btn_PindahKiriAll.Click += new System.EventHandler(this.btn_PindahKiriAll_Click);
            // 
            // btn_Kekiri
            // 
            this.btn_Kekiri.Location = new System.Drawing.Point(176, 178);
            this.btn_Kekiri.Name = "btn_Kekiri";
            this.btn_Kekiri.Size = new System.Drawing.Size(56, 23);
            this.btn_Kekiri.TabIndex = 9;
            this.btn_Kekiri.Text = "<";
            this.btn_Kekiri.UseVisualStyleBackColor = true;
            this.btn_Kekiri.Click += new System.EventHandler(this.btn_Kekiri_Click);
            // 
            // bt_Kekanan
            // 
            this.bt_Kekanan.Location = new System.Drawing.Point(176, 207);
            this.bt_Kekanan.Name = "bt_Kekanan";
            this.bt_Kekanan.Size = new System.Drawing.Size(56, 23);
            this.bt_Kekanan.TabIndex = 10;
            this.bt_Kekanan.Text = ">";
            this.bt_Kekanan.UseVisualStyleBackColor = true;
            this.bt_Kekanan.Click += new System.EventHandler(this.bt_Kekanan_Click);
            // 
            // btn_PindahKananAll
            // 
            this.btn_PindahKananAll.Location = new System.Drawing.Point(176, 236);
            this.btn_PindahKananAll.Name = "btn_PindahKananAll";
            this.btn_PindahKananAll.Size = new System.Drawing.Size(56, 23);
            this.btn_PindahKananAll.TabIndex = 11;
            this.btn_PindahKananAll.Text = ">>";
            this.btn_PindahKananAll.UseVisualStyleBackColor = true;
            this.btn_PindahKananAll.Click += new System.EventHandler(this.btn_PindahKananAll_Click);
            // 
            // btn_ClearA
            // 
            this.btn_ClearA.Location = new System.Drawing.Point(95, 265);
            this.btn_ClearA.Name = "btn_ClearA";
            this.btn_ClearA.Size = new System.Drawing.Size(64, 23);
            this.btn_ClearA.TabIndex = 12;
            this.btn_ClearA.Text = "Clear";
            this.btn_ClearA.UseVisualStyleBackColor = true;
            this.btn_ClearA.Click += new System.EventHandler(this.btn_ClearA_Click);
            // 
            // btn_ClearB
            // 
            this.btn_ClearB.Location = new System.Drawing.Point(252, 265);
            this.btn_ClearB.Name = "btn_ClearB";
            this.btn_ClearB.Size = new System.Drawing.Size(64, 23);
            this.btn_ClearB.TabIndex = 13;
            this.btn_ClearB.Text = "Clear";
            this.btn_ClearB.UseVisualStyleBackColor = true;
            this.btn_ClearB.Click += new System.EventHandler(this.btn_ClearB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 345);
            this.Controls.Add(this.btn_ClearB);
            this.Controls.Add(this.btn_ClearA);
            this.Controls.Add(this.btn_PindahKananAll);
            this.Controls.Add(this.bt_Kekanan);
            this.Controls.Add(this.btn_Kekiri);
            this.Controls.Add(this.btn_PindahKiriAll);
            this.Controls.Add(this.lBox_Kanan);
            this.Controls.Add(this.lBox_Kiri);
            this.Controls.Add(this.btn_InputB);
            this.Controls.Add(this.btn_InputA);
            this.Controls.Add(this.tB_InputB);
            this.Controls.Add(this.tB_InputA);
            this.Controls.Add(this.lb_NamaB);
            this.Controls.Add(this.lb_NamaA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NamaA;
        private System.Windows.Forms.Label lb_NamaB;
        private System.Windows.Forms.TextBox tB_InputA;
        private System.Windows.Forms.TextBox tB_InputB;
        private System.Windows.Forms.Button btn_InputA;
        private System.Windows.Forms.Button btn_InputB;
        private System.Windows.Forms.ListBox lBox_Kiri;
        private System.Windows.Forms.ListBox lBox_Kanan;
        private System.Windows.Forms.Button btn_PindahKiriAll;
        private System.Windows.Forms.Button btn_Kekiri;
        private System.Windows.Forms.Button bt_Kekanan;
        private System.Windows.Forms.Button btn_PindahKananAll;
        private System.Windows.Forms.Button btn_ClearA;
        private System.Windows.Forms.Button btn_ClearB;
    }
}

