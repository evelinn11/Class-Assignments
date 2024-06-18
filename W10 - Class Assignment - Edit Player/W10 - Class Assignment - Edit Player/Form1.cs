using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W10___Class_Assignment___Edit_Player
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtPlayer;
        DataTable dtTeam;
        string sqlQuery;
        string birthdate;
        int count;
        int index;


        private void FormPlayer_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;port=3308;uid=root;pwd=Twklhrt#12;database=premier_league");

            dtPlayer = new DataTable();
            sqlQuery = "SELECT p.player_id, p.player_name, p.birthdate, n.nation, " +
                "t.team_name, p.team_number FROM player p, nationality n, team t " +
                "WHERE p.nationality_id = n.nationality_id AND p.team_id = t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPlayer);

            dtTeam = new DataTable();
            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);
            cBox_Team.DataSource = dtTeam;
            cBox_Team.ValueMember = "team_id";
            cBox_Team.DisplayMember = "team_name";

            count = 0;
            DisplayPlayer();
        }

        public void DisplayPlayer()
        {
            tB_PlayerID.Text = dtPlayer.Rows[count][0].ToString();
            tB_PlayerName.Text = dtPlayer.Rows[count][1].ToString();
            dTP_Birthdate.Format = DateTimePickerFormat.Custom;
            dTP_Birthdate.CustomFormat = "dddd, MMMM dd, yyyy";
            dTP_Birthdate.Value = DateTime.Parse(dtPlayer.Rows[count][2].ToString());
            tB_Nationality.Text = dtPlayer.Rows[count][3].ToString();
            for (int i = 0; i < dtTeam.Rows.Count; i++)
            {
                if (dtTeam.Rows[i][1].ToString() == dtPlayer.Rows[count][4].ToString())
                {
                    index = i;
                    break;
                }
            }
            cBox_Team.SelectedIndex = index;
            nUD_TeamNumber.Value = Convert.ToInt32(dtPlayer.Rows[count][5]);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                DisplayPlayer();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (count < dtPlayer.Rows.Count - 1)
            {
                count++;
                DisplayPlayer();
            }
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            count = 0;
            DisplayPlayer();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            count = dtPlayer.Rows.Count - 1;
            DisplayPlayer();
        }
    }
}
