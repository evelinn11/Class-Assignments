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
    public partial class AddTeam : Form
    {
        MainForm main = new MainForm();
        List<string> teamName = new List<string>();

        public AddTeam()
        {
            InitializeComponent();
        }

        public AddTeam(Form _sender)
        {
            InitializeComponent();
            main = (MainForm)_sender;
        }

        public void AmbilListNama(List<string> namatim)
        {
            teamName = namatim;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool kembar = false;
            for (int i = 0; i < teamName.Count; i++)
            {
                if (teamName[i] == tBox_Name.Text)
                {
                    kembar = true;
                }
            }
            if (kembar)
            {
                MessageBox.Show("Nama Tim Sudah Ada");
                tBox_Name.Text = string.Empty;
            }
            else
            {
                main.AddTeamBaru(tBox_Name.Text);
                tBox_Name.Text = string.Empty;
                this.Close();
            }
        }
    }
}
