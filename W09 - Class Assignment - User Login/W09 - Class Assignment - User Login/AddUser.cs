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
    public partial class AddUser : Form
    {
        List<string> listUser = new List<string>();
        List<string> listPass = new List<string>();
        Login loginForm;

        public AddUser(Form _sender)
        {
            InitializeComponent();
            loginForm = (Login)_sender;
        }

        public void AmbilData(List<string> user, List <string> pass)
        {
            listUser = user;
            listPass = pass;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            listUser.Add(tB_Username.Text);
            if (tB_Password.Text == tB_Confirm.Text)
            {
                loginForm.NewUser(tB_Username.Text, tB_Password.Text);
                MessageBox.Show("User Added!");
                tB_Username.Text = string.Empty;
                tB_Password.Text = string.Empty;
                tB_Confirm.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Passwords not match");
            }
        }
    }
}
