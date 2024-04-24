using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W09___Class_Assignment___User_Login
{
    //Evelin Alim Natadjaja
    //NIM : 0706022310021
    public partial class Login : Form
    {
        List<string> listUsername = new List<string>();
        List<string> listPassword = new List<string>();
        MainForm mainForm;
        AddUser addUser;
        public string currentUsername;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int indexUser = 0;
            for (int i = 0; i < listUsername.Count; i++)
            {
                if (tB_Username.Text == listUsername[i])
                {
                    indexUser = i;
                }
            }

            if (tB_Password.Text == listPassword[indexUser])
            {
                mainForm = new MainForm();
                mainForm.AmbilUsername(tB_Username.Text);
                mainForm.Show();
                addUser = new AddUser(this);
                addUser.AmbilData(listUsername, listPassword);
                tB_Username.Text = string.Empty;
                tB_Password.Text = string.Empty;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
                tB_Username.Text = string.Empty;
                tB_Password.Text = string.Empty;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            listUsername.Add("admin");
            listPassword.Add("admin");
        }

        public void NewUser(string username, string pass)
        {
            listUsername.Add(username);
            listPassword.Add(pass);
        }
    }
}
