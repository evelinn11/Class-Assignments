using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W07___Class_Assignment___Soccer_Match
{
    public partial class MainForm : Form
    {
        DataTable dtMatch;
        AddTeam add;
        List<string> listNamaTim1 = new List<string>();
        List<string> listNamaTim2 = new List<string>();

        //Evelin Alim Natadjaja
        //NIM : 0706022310021

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtMatch = new DataTable();
            dtMatch.Columns.Add("Date");
            dtMatch.Columns.Add("Home Team Name");
            dtMatch.Columns.Add("Home Score");
            dtMatch.Columns.Add("Away Score");
            dtMatch.Columns.Add("Away Team Name");
            dGV_Match.DataSource = dtMatch;

            listNamaTim1.Add("Boston Celtics");
            listNamaTim1.Add("Brooklyn Nets");
            listNamaTim1.Add("New Yorks Nicks");
            listNamaTim1.Add("Philadelphia 76ers");
            listNamaTim1.Add("Toronto Raptors");
            listNamaTim1.Add("Chicago Bulls");
            listNamaTim1.Add("Cleaveland Cavalier");
            listNamaTim1.Add("Detroit Pistons");
            listNamaTim1.Add("Indiana Pacers");
            listNamaTim1.Add("Milwauke Bucks");

            foreach (string nama in listNamaTim1)
            {
                cBox_NamaTim1.Items.Add(nama);
            }

            listNamaTim2.Add("Boston Celtics");
            listNamaTim2.Add("Brooklyn Nets");
            listNamaTim2.Add("New Yorks Nicks");
            listNamaTim2.Add("Philadelphia 76ers");
            listNamaTim2.Add("Toronto Raptors");
            listNamaTim2.Add("Chicago Bulls");
            listNamaTim2.Add("Cleaveland Cavalier");
            listNamaTim2.Add("Detroit Pistons");
            listNamaTim2.Add("Indiana Pacers");
            listNamaTim2.Add("Milwauke Bucks");

            foreach (string nama in listNamaTim1)
            {
                cBox_NamaTim2.Items.Add(nama);
            }
        }

        private void cBox_NamaTim1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_NamaTim1.SelectedIndex >= -1)
            {
                string selectedTeam = cBox_NamaTim1.SelectedItem.ToString();
                if (cBox_NamaTim2.Items.Contains(selectedTeam))
                {
                    cBox_NamaTim2.Items.Clear();
                    foreach (string i in listNamaTim2)
                    {
                        cBox_NamaTim2.Items.Add(i);
                    }
                    cBox_NamaTim2.Items.Remove(selectedTeam);
                }
            }
        }

        private void cBox_NamaTim2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_NamaTim2.SelectedIndex >= -1)
            {
                string selectedTeam = cBox_NamaTim2.SelectedItem.ToString();
                if (cBox_NamaTim1.Items.Contains(selectedTeam))
                {
                    cBox_NamaTim1.Items.Clear();
                    foreach (string i in listNamaTim1)
                    {
                        cBox_NamaTim1.Items.Add(i);
                    }
                    cBox_NamaTim1.Items.Remove(selectedTeam);
                }
            }
        }

        private void btn_AddMatch_Click(object sender, EventArgs e)
        {
            dtMatch.Rows.Add(dTP_Match.Value.ToString(), cBox_NamaTim1.Text, tBox_Skor1.Text, tBox_Skor2.Text, cBox_NamaTim2.Text);
        }

        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            add = new AddTeam(this);
            add.AmbilListNama(listNamaTim1);
            add.ShowDialog();
        }

        public void AddTeamBaru(string nama)
        {
            listNamaTim1.Add(nama);
            listNamaTim2.Add(nama);
            cBox_NamaTim1.Items.Add(nama);
            cBox_NamaTim2.Items.Add(nama);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow now = dGV_Match.CurrentRow;
            dGV_Match.Rows.Remove(now);
        }

        private void tBox_Skor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tBox_Skor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
