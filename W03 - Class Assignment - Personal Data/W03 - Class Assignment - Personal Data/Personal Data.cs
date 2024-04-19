using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03___Class_Assignment___Personal_Data
{
    public partial class Form1 : Form
    {
        //Evelin Alim Natadjaja
        //NIM = 0706022310021

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool errorDetected = false;
            List<string> listAngka = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string listHuruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxyz ";

            foreach (string angka in listAngka)
            {
                if (tB_Name.Text.Contains(angka))
                {
                    errorDetected = true;
                }

                if (tB_Hobbies.Text.Contains(angka))
                {
                    errorDetected = true;
                }
            }

            foreach(char huruf in listHuruf)
            {
                if (tB_Age.Text.Contains(huruf))
                {
                    errorDetected = true;
                }
            }

            if (errorDetected == true)
            {
                MessageBox.Show("Error : Text Box has incorrect input");
            }
            else if (errorDetected == false)
            {
                string genderChosen;
                if (rBtn_Male.Checked == true)
                {
                    genderChosen = rBtn_Male.Text;
                }
                else
                {
                    genderChosen = rBtn_Female.Text;
                }

                List<string> hobbiesChosen = new List<string>();
                if (cB_Reading.Checked == true)
                {
                    hobbiesChosen.Add(cB_Reading.Text);
                }
                if (cB_Watching.Checked == true)
                {
                    hobbiesChosen.Add(cB_Watching.Text);
                }
                if (cB_Playing.Checked == true)
                {
                    hobbiesChosen.Add(cB_Playing.Text);
                }
                if (cB_Hobbies.Checked == true)
                {
                    hobbiesChosen.Add(tB_Hobbies.Text);
                }

                string hobbiesShown = "";
                for (int i = 0; i < hobbiesChosen.Count - 1; i++)
                {
                    hobbiesShown += hobbiesChosen[i] + ", ";
                }

                hobbiesShown += hobbiesChosen[hobbiesChosen.Count - 1];

                if (rBtn_Green.Checked == true)
                {
                    this.BackColor = Color.Green;
                }
                else if (rBtn_Blue.Checked == true)
                {
                    this.BackColor = Color.Blue;
                }
                else if (rBtn_Yellow.Checked == true)
                {
                    this.BackColor = Color.Yellow;
                }

                MessageBox.Show($"Name: {tB_Name.Text} \nAge: {tB_Age.Text} \nGender: {genderChosen}" +
                    $" \nHobbies: {hobbiesShown}");

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tB_Name.Text = string.Empty;
            tB_Age.Text = string.Empty;
            tB_Hobbies.Text = string.Empty;
            rBtn_Blue.Checked = false;
            rBtn_Yellow.Checked = false;
            rBtn_Green.Checked = false;
            rBtn_Male.Checked = false;
            rBtn_Female.Checked = false;
            cB_Reading.Checked = false;
            cB_Watching.Checked = false;
            cB_Playing.Checked = false;
            cB_Hobbies.Checked = false;
            this.BackColor = SystemColors.Control;
        }
    }
}