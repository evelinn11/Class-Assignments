using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04___Class_Assignment___Pindah_Data
{
    public partial class Form1 : Form
    {
        //Evelin Alim Natadjaja
        //NIM : 0706022310021

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_InputA_Click(object sender, EventArgs e)
        {
            if (lBox_Kiri.Items.Contains(tB_InputA.Text) || lBox_Kanan.Items.Contains(tB_InputA.Text))
            {
                MessageBox.Show("This Item Is Already In The List");
            }
            else
            {
                lBox_Kiri.Items.Add(tB_InputA.Text);
            }
            tB_InputA.Clear();
        }

        private void btn_InputB_Click(object sender, EventArgs e)
        {
            if (lBox_Kanan.Items.Contains(tB_InputB.Text) || lBox_Kiri.Items.Contains(tB_InputB.Text))
            {
                MessageBox.Show("This Item Is Already In The List");
            }
            else
            {
                lBox_Kanan.Items.Add(tB_InputB.Text);
            }
            tB_InputB.Clear();
        }

        private void btn_PindahKiriAll_Click(object sender, EventArgs e)
        {
            foreach (string item in lBox_Kanan.Items)
            {
                lBox_Kiri.Items.Add(item);
            }
            lBox_Kanan.Items.Clear();
        }

        private void btn_PindahKananAll_Click(object sender, EventArgs e)
        {
            foreach (string item in lBox_Kiri.Items)
            {
                lBox_Kanan.Items.Add(item);
            }
            lBox_Kiri.Items.Clear();
        }

        private void btn_ClearA_Click(object sender, EventArgs e)
        {
            lBox_Kiri.Items.Clear();
        }

        private void btn_ClearB_Click(object sender, EventArgs e)
        {
            lBox_Kanan.Items.Clear();
        }

        private void btn_Kekiri_Click(object sender, EventArgs e)
        {
            lBox_Kiri.Items.Add(lBox_Kanan.SelectedItem);
            lBox_Kanan.Items.Remove(lBox_Kanan.SelectedItem);
        }

        private void bt_Kekanan_Click(object sender, EventArgs e)
        {
            lBox_Kanan.Items.Add(lBox_Kiri.SelectedItem);
            lBox_Kiri.Items.Remove(lBox_Kiri.SelectedItem);
        }
    }
}
