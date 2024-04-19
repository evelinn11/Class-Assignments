using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02___Class_Assignment___Kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            double angkaPertama = Convert.ToDouble(tB_AngkaPertama.Text);
            double angkaKedua = Convert.ToDouble(tB_AngkaKedua.Text);

            if (angkaPertama > angkaKedua)
            {
                MessageBox.Show("Angka 1 tidak boleh lebih besar dari Angka 2");
            }
            else
            {
                if (rBtn_Penjumlahan.Checked == true)
                {
                    lb_Total.Text = Convert.ToString(angkaPertama + angkaKedua);
                }
                else if (rBtn_Pengurangan.Checked == true)
                {
                    lb_Total.Text = Convert.ToString(angkaPertama - angkaKedua);
                }
                else if (rBtn_Perkalian.Checked == true)
                {
                    lb_Total.Text = Convert.ToString(angkaPertama * angkaKedua);
                }
                else if (rBtn_Pembagian.Checked == true)
                {
                    lb_Total.Text = Convert.ToString(angkaPertama / angkaKedua);
                }
                else
                {
                    MessageBox.Show("Mode Belum Dipilih");
                }
            }
            tB_AngkaPertama.Text = string.Empty;
            tB_AngkaKedua.Text = string.Empty;
        }
    }
}
