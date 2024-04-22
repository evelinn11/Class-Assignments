using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W08___Class_Assignment___Simpan_Data
{
    public partial class Form1 : Form
    {
        List<string> listNama = new List<string>();
        List<string> listAlamat = new List<string>();
        List<string> listNomor = new List<string>();
        int indexNow;
        string[] splitData = new string[3];
        OpenFileDialog ofd = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            listNama.Add(tB_Nama.Text);
            listAlamat.Add(tB_Alamat.Text);
            listNomor.Add(tB_NoHP.Text);
            tB_Nama.Text = string.Empty;
            tB_Alamat.Text = string.Empty;
            tB_NoHP.Text = string.Empty;

            StreamWriter sw = new StreamWriter(ofd.FileName);
            for (int i = 0; i < listNama.Count; i++)
            {
                sw.WriteLine(listNama[i] + ";" + listAlamat[i] + ";" + listNomor[i]);
            }
            sw.Close();
        }

        private void btn_Lihat_Click(object sender, EventArgs e)
        {
            btn_Simpan.Visible = false;
            btn_Lihat.Visible = false;
            panel_View.Visible = true;
            tB_Nama.Enabled = false;
            tB_Alamat.Enabled = false;
            tB_NoHP.Enabled = false;

            if (listNama.Count <= 0)
            {
                tB_Nama.Text = string.Empty;
                tB_Alamat.Text = string.Empty;
                tB_NoHP.Text = string.Empty;
            }
            else
            {
                tB_Nama.Text = listNama[0];
                tB_Alamat.Text = listAlamat[0];
                tB_NoHP.Text = listNomor[0];
                indexNow = 0;
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (indexNow > 0)
            {
                indexNow--;
                tB_Nama.Text = listNama[indexNow];
                tB_Alamat.Text = listAlamat[indexNow];
                tB_NoHP.Text = listNomor[indexNow];
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (indexNow < listNama.Count - 1)
            {
                indexNow++;
                tB_Nama.Text = listNama[indexNow];
                tB_Alamat.Text = listAlamat[indexNow];
                tB_NoHP.Text = listNomor[indexNow];
            }
        }

        private void btn_Kembali_Click(object sender, EventArgs e)
        {
            panel_View.Visible = false;
            btn_Simpan.Visible = true;
            btn_Lihat.Visible = true;
            tB_Nama.Text = string.Empty;
            tB_Alamat.Text = string.Empty;
            tB_NoHP.Text = string.Empty;
            tB_Nama.Enabled = true;
            tB_Alamat.Enabled = true;
            tB_NoHP.Enabled = true;
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "D:\\UC\\Semester 2\\Application Development\\Folder TXT"; 
            ofd.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.ShowDialog();

            StreamReader sr = new StreamReader(ofd.FileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                splitData = line.Split(';');
                listNama.Add(splitData[0]);
                listAlamat.Add(splitData[1]);
                listNomor.Add(splitData[2]);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
