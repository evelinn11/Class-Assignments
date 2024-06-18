using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W11___Class_Assignment___Detail_Match
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;
        DataTable dtTeamHome;
        DataTable dtTeamAway;
        DataTable dtDmatch;
        DataTable dtSelectedMatch;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection($"server={tB_Server.Text};port=3308;uid={tB_User.Text};pwd={tB_Password.Text};database={tB_Database.Text}");

            dtTeamHome = new DataTable();
            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeamHome);
            cBox_TeamHome.ValueMember = "team_id";
            cBox_TeamHome.DisplayMember = "team_name";
            cBox_TeamHome.DataSource = dtTeamHome;
            cBox_TeamHome.SelectedIndex = -1;

            dtTeamAway = new DataTable();
            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeamAway);
            cBox_TeamAway.ValueMember = "team_id";
            cBox_TeamAway.DisplayMember = "team_name";
            cBox_TeamAway.DataSource = dtTeamAway;
            cBox_TeamAway.SelectedIndex = -1;

            tB_Server.Text = string.Empty;
            tB_User.Text = string.Empty;
            tB_Password.Text = string.Empty;
            tB_Database.Text = string.Empty;
        }

        private void cBox_TeamHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_TeamHome.SelectedIndex != -1 && cBox_TeamAway.SelectedIndex != -1)
            {
                if (cBox_TeamHome.SelectedIndex == cBox_TeamAway.SelectedIndex)
                {
                    MessageBox.Show("Team Home can't be the same with Team Away");
                    cBox_TeamHome.SelectedIndex = -1;
                }
                else
                {
                    dtSelectedMatch = new DataTable();
                    sqlQuery = $@"SELECT match_id, match_date FROM `match` 
                                    WHERE team_home = '{cBox_TeamHome.SelectedValue}' AND team_away = '{cBox_TeamAway.SelectedValue}'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtSelectedMatch);
                    tB_MatchID.Text = dtSelectedMatch.Rows[0][0].ToString();
                    dTP_MatchDate.Value = DateTime.Parse(dtSelectedMatch.Rows[0][1].ToString());

                    dtDmatch = new DataTable();
                    sqlQuery = $@"SELECT d.match_id, d.minute, t.team_name, p.player_name, d.type 
                                    FROM dmatch d
                                    JOIN team t ON t.team_id = d.team_id
                                    JOIN player p ON p.player_id = d.player_id
                                    WHERE d.team_id = '{cBox_TeamHome.SelectedValue}' OR d.team_id = '{cBox_TeamAway.SelectedValue}'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtDmatch);
                    dGV_Match.DataSource = dtDmatch;
                    dGV_Match.Columns[1].Width = 40;
                    dGV_Match.Columns[4].Width = 60;
                }
            }
        }

        private void cBox_TeamAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox_TeamHome.SelectedIndex != -1 && cBox_TeamAway.SelectedIndex != -1)
            {
                if (cBox_TeamAway.SelectedIndex == cBox_TeamHome.SelectedIndex)
                {
                    MessageBox.Show("Team Away can't be the same with Team Home");
                    cBox_TeamAway.SelectedIndex = -1;
                }
                else
                {
                    dtSelectedMatch = new DataTable();
                    sqlQuery = $@"SELECT match_id, match_date FROM `match` 
                                    WHERE team_home = '{cBox_TeamHome.SelectedValue}' AND team_away = '{cBox_TeamAway.SelectedValue}'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtSelectedMatch);
                    tB_MatchID.Text = dtSelectedMatch.Rows[0][0].ToString();
                    dTP_MatchDate.Value = DateTime.Parse(dtSelectedMatch.Rows[0][1].ToString());

                    dtDmatch = new DataTable();
                    sqlQuery = $@"SELECT d.match_id, d.minute, t.team_name, p.player_name, d.type 
                                    FROM dmatch d
                                    JOIN team t ON t.team_id = d.team_id
                                    JOIN player p ON p.player_id = d.player_id
                                    WHERE (d.team_id = '{cBox_TeamHome.SelectedValue}' OR d.team_id = '{cBox_TeamAway.SelectedValue}') AND d.match_id = '{tB_MatchID.Text}'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtDmatch);
                    dGV_Match.DataSource = dtDmatch;
                    dGV_Match.Columns[1].Width = 40;
                    dGV_Match.Columns[4].Width = 60;
                }
            }
        }
    }
}
