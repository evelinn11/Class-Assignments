using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W15___Class_Assignment___Check_Match
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtTeamHome;
        DataTable dtTeamAway;
        DataTable dtSelectedTeamHome;
        DataTable dtSelectedTeamAway;
        DataTable dtInfoMatchLoc;
        DataTable dtMatchInfo;
        DataTable dtMatchDetail;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection($"server=localhost;port=3308;uid=root;pwd=Twklhrt#12;database=premier_league");

            dtTeamHome = new DataTable();
            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeamHome);
            cBox_TeamHome.ValueMember = "team_id";
            cBox_TeamHome.DisplayMember = "team_name";
            cBox_TeamHome.DataSource = dtTeamHome;
            cBox_TeamHome.SelectedIndex = -1;

            dtTeamAway = new DataTable();
            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeamAway);
            cBox_TeamAway.ValueMember = "team_id";
            cBox_TeamAway.DisplayMember = "team_name";
            cBox_TeamAway.DataSource = dtTeamAway;
            cBox_TeamAway.SelectedIndex = -1;
        }

        private void cBox_TeamHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBox_TeamHome.SelectedIndex != -1)
            {
                dtSelectedTeamHome = new DataTable();
                sqlQuery = $"SELECT t.team_id, m.manager_name, p.player_name FROM team t JOIN player p ON p.player_id = t.captain_id JOIN manager m ON m.manager_id = t.manager_id WHERE t.team_id = '{cBox_TeamHome.SelectedValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtSelectedTeamHome);

                lb_NamaManagerHome.Text = dtSelectedTeamHome.Rows[0][1].ToString();
                lb_NamaCaptainHome.Text = dtSelectedTeamHome.Rows[0][2].ToString();

                dtInfoMatchLoc = new DataTable();
                sqlQuery = $"SELECT CONCAT(home_stadium, ', ', city), capacity FROM team WHERE team_id = '{cBox_TeamHome.SelectedValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtInfoMatchLoc);

                lb_NamaStadium.Text = dtInfoMatchLoc.Rows[0][0].ToString();
                lb_JumlahCapacity.Text = dtInfoMatchLoc.Rows[0][1].ToString();
            }
            else
            {
                lb_NamaManagerHome.Text = "-";
                lb_NamaCaptainHome.Text = "-";
                lb_NamaStadium.Text = "-";
                lb_JumlahCapacity.Text = "-";
            }
        }

        private void cBox_TeamAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_TeamAway.SelectedIndex != -1)
            {
                dtSelectedTeamAway = new DataTable();
                sqlQuery = $"SELECT t.team_id, m.manager_name, p.player_name FROM team t JOIN player p ON p.player_id = t.captain_id JOIN manager m ON m.manager_id = t.manager_id WHERE t.team_id = '{cBox_TeamAway.SelectedValue}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtSelectedTeamAway);

                lb_NamaManagerAway.Text = dtSelectedTeamAway.Rows[0][1].ToString();
                lb_NamaCaptainAway.Text = dtSelectedTeamAway.Rows[0][2].ToString();
            }
            else
            {
                lb_NamaManagerAway.Text = "-";
                lb_NamaCaptainAway.Text = "-";
                lb_NamaStadium.Text = "-";
                lb_JumlahCapacity.Text = "-";
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            dtMatchInfo = new DataTable();
            sqlQuery = $"SELECT CONCAT(DAY(match_date), ' ', MONTHNAME(match_date), ' ', YEAR(match_date)), CONCAT(goal_home, '-', goal_away) FROM `match` WHERE team_away = '{cBox_TeamAway.SelectedValue}' AND team_home = '{cBox_TeamHome.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMatchInfo);

            lb_TanggalTanding.Text = dtMatchInfo.Rows[0][0].ToString();
            lb_Angka.Text = dtMatchInfo.Rows[0][1].ToString();

            dtMatchDetail = new DataTable();
            sqlQuery = $"SELECT sq.minute, sq.player1 as 'Player Name 1', sq.type1 as 'Type 1', sq.player2 as 'Player Name 2', sq.type2 as 'Type 2' FROM\r\n(SELECT d.minute as minute, p.player_name as player1, d.type as type1, null as player2 , null as type2\r\nFROM dmatch d\r\nJOIN player p ON p.player_id = d.player_id\r\nWHERE d.team_id = 'B001'\r\n\r\nUNION\r\n\r\nSELECT d.minute as minute, null as player1, null as type1, p.player_name player2, d.type as type2\r\nFROM dmatch d\r\nJOIN player p ON p.player_id = d.player_id\r\nWHERE d.team_id = 'A002') sq\r\norder by sq.minute";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMatchDetail);
            dGV_Match.DataSource = dtMatchDetail;

            for (int i = 0; i < dtMatchDetail.Rows.Count; i++)
            {
                if (dtMatchDetail.Rows[i][2].ToString() == "GO")
                {
                    dtMatchDetail.Rows[i][2] = "GOAL";
                }
                else if (dtMatchDetail.Rows[i][2].ToString() == "GP")
                {
                    dtMatchDetail.Rows[i][2] = "GOAL PENALTY";
                }
                else if (dtMatchDetail.Rows[i][2].ToString() == "CY")
                {
                    dtMatchDetail.Rows[i][2] = "YELLOW CARD";
                }
                else if (dtMatchDetail.Rows[i][2].ToString() == "CR")
                {
                    dtMatchDetail.Rows[i][2] = "RED CARD";
                }
                else if (dtMatchDetail.Rows[i][2].ToString() == "PM")
                {
                    dtMatchDetail.Rows[i][2] = "PENALTY MISS";
                }
                else if (dtMatchDetail.Rows[i][2].ToString() == "GW")
                {
                    dtMatchDetail.Rows[i][2] = "OWN GOAL";
                }
                else if(dtMatchDetail.Rows[i][4].ToString() == "GO")
                {
                    dtMatchDetail.Rows[i][4] = "GOAL";
                }
                else if (dtMatchDetail.Rows[i][4].ToString() == "GP")
                {
                    dtMatchDetail.Rows[i][4] = "GOAL PENALTY";
                }
                else if (dtMatchDetail.Rows[i][4].ToString() == "CY")
                {
                    dtMatchDetail.Rows[i][4] = "YELLOW CARD";
                }
                else if (dtMatchDetail.Rows[i][4].ToString() == "CR")
                {
                    dtMatchDetail.Rows[i][4] = "RED CARD";
                }
                else if (dtMatchDetail.Rows[i][4].ToString() == "PM")
                {
                    dtMatchDetail.Rows[i][4] = "PENALTY MISS";
                }
                else if (dtMatchDetail.Rows[i][4].ToString() == "GW")
                {
                    dtMatchDetail.Rows[i][4] = "OWN GOAL";
                }
            }
        }
    }
}
