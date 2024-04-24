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
    public partial class MainForm : Form
    {
        Login loginForm = new Login();
        string username;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser(loginForm);
            addUserForm.MdiParent = this;
            addUserForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel_MainForm.Text = username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Waktu.Text = DateTime.Now.ToString("ddd, dd - MM - yyyy HH:mm:ss");
        }

        public void AmbilUsername(string user)
        {
            username = user;
        }
    }
}
