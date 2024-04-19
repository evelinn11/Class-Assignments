using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06___Class_Assignment___Puzzle
{
    public partial class Puzzle : Form
    {
        //Evelin Alim Natadjaja
        //NIM : 0706022310021

        List<Button> listTiles = new List<Button>();
        Button tile;
        int inputUser = 0;
        public Puzzle()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tB_Input.Text) < 3)
            {
                MessageBox.Show("Please Input A Larger Size");
            }
            else
            {
                MessageBox.Show("Let's Play");
                inputUser = Convert.ToInt32(tB_Input.Text);
                panel_InputView.Visible = false;
                panel_Score.Visible = true;
            }
        }

        private void tB_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel_InputView_VisibleChanged(object sender, EventArgs e)
        {
            int countLocationX = 0;
            int countLocationY = 0;
            for (int i = 0; i < inputUser; i++)
            {
                for (int j = 0; j < inputUser; j++)
                {
                    tile = new Button();
                    tile.Size = new Size(50, 50);
                    tile.Tag = "gray";
                    tile.Location = new Point(countLocationX, countLocationY);
                    countLocationX += 50;
                    listTiles.Add(tile);
                    this.Controls.Add(tile);
                    tile.Click += new EventHandler(tile_Click);
                }
                countLocationX = 0;
                countLocationY += 50;
            }

        }

        private void tile_Click(object sender, EventArgs e)
        {
            Button tileClicked = (Button)sender;
            int locationX = tileClicked.Location.X;
            int locationY = tileClicked.Location.Y;
            
            for (int i = 0; i < listTiles.Count; i++)
            {
                if (listTiles[i].Location.X == locationX + 50 && listTiles[i].Location.Y == locationY && listTiles[i].Tag != "gray")
                {
                    if (listTiles[i].Tag == "red")
                    {
                        listTiles[i].Tag = "blue";
                        listTiles[i].BackColor = Color.Blue;
                    }
                    else if (listTiles[i].Tag == "blue")
                    {
                        listTiles[i].Tag = "red";
                        listTiles[i].BackColor = Color.Red;
                    }
                }
                if (listTiles[i].Location.X == locationX && listTiles[i].Location.Y == locationY + 50 && listTiles[i].Tag != "gray")
                {
                    if (listTiles[i].Tag == "red")
                    {
                        listTiles[i].Tag = "blue";
                        listTiles[i].BackColor = Color.Blue;
                    }
                    else if (listTiles[i].Tag == "blue")
                    {
                        listTiles[i].Tag = "red";
                        listTiles[i].BackColor = Color.Red;
                    }
                }
                if (listTiles[i].Location.X == locationX && listTiles[i].Location.Y == locationY - 50 && listTiles[i].Tag != "gray")
                {
                    if (listTiles[i].Tag == "red")
                    {
                        listTiles[i].Tag = "blue";
                        listTiles[i].BackColor = Color.Blue;
                    }
                    else if (listTiles[i].Tag == "blue")
                    {
                        listTiles[i].Tag = "red";
                        listTiles[i].BackColor = Color.Red;
                    }
                }
                if (listTiles[i].Location.X == locationX - 50 && listTiles[i].Location.Y == locationY && listTiles[i].Tag != "gray")
                {
                    if (listTiles[i].Tag == "red")
                    {
                        listTiles[i].Tag = "blue";
                        listTiles[i].BackColor = Color.Blue;
                    }
                    else if (listTiles[i].Tag == "blue")
                    {
                        listTiles[i].Tag = "red";
                        listTiles[i].BackColor = Color.Red;
                    }
                }
            }
           

            if (tileClicked.Tag == "gray")
            {
                tileClicked.BackColor = Color.Red;
                tileClicked.Tag = "red";
            }
            else if (tileClicked.Tag == "red")
            {
                tileClicked.BackColor = Color.Blue;
                tileClicked.Tag = "blue";
            }
            else if (tileClicked.Tag == "blue")
            {
                tileClicked.BackColor = Color.Red;
                tileClicked.Tag = "red";
            }

            int countRed = 0;
            int countBlue = 0;
            foreach (Button tile in listTiles)
            {
                if (tile.Tag == "red")
                {
                    countRed++;
                }
                else if (tile.Tag == "blue")
                {
                    countBlue++;
                }
            }

            lb_CountRed.Text = countRed.ToString();
            lb_CountBlue.Text = countBlue.ToString();

            if (countRed == inputUser*inputUser || countBlue == inputUser * inputUser)
            {
                MessageBox.Show("Congrats You Win!");
            }
        }
    }
}
