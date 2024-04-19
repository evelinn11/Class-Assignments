using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05___Class_Assignment___List_Tim_Sepak_Bola
{
    public partial class Form1 : Form
    {
        //Evelin Alim Natadjaja
        //NIM : 0706022310021

        DataTable dt;
        string hurufPertama;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ID Tim");
            dt.Columns.Add("Nama Tim");
            dt.Columns.Add("Nama Stadium");
            dt.Columns.Add("Kapasitas");
            dt.Columns.Add("Kota");
            dt.Columns.Add("Nama Manager");
            dGV_Tim.DataSource = dt;
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            bool kembar = false;

            foreach (DataGridViewRow row in dGV_Tim.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == tB_NamaTim.Text)
                {
                    kembar = true;
                }
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == tB_NamaStadium.Text)
                {
                    kembar = true;
                }
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == tB_NamaManager.Text)
                {
                    kembar = true;
                }
            }


            if (kembar)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.Rows.Add(tB_TimID.Text, tB_NamaTim.Text, tB_NamaStadium.Text, tB_Kapasitas.Text, tB_Kota.Text, tB_NamaManager.Text);
            }
            tB_TimID.Text = string.Empty;
            tB_NamaTim.Text = string.Empty;
            tB_NamaStadium.Text = string.Empty;
            tB_Kapasitas.Text = string.Empty;
            tB_Kota.Text = string.Empty;
            tB_NamaManager.Text = string.Empty;
            hurufPertama = "";
        }

        private void tB_NamaTim_TextChanged(object sender, EventArgs e)
        {
            int count = 1;
            if (tB_NamaTim.Text != string.Empty)
            {
                hurufPertama = tB_NamaTim.Text.Substring(0, 1);
                foreach (DataGridViewRow row in dGV_Tim.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().StartsWith(hurufPertama))
                    {
                        count++;
                    }
                }
                if (count < 10)
                {
                    tB_TimID.Text = hurufPertama.ToUpper() + "0" + count;
                }
                else
                {
                    tB_TimID.Text = hurufPertama.ToUpper() + count;
                }
            }
        }
    }
}
