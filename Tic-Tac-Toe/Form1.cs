using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public
    partial class Form1 : Form
    {
        bool turn = true; // X always goes first
        int countPress = 0; // Counts number of clicks

        public
            Form1()
        {
            InitializeComponent();
        }

        private
            void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private
            void label1_Click(object sender, EventArgs e)
        {
        }

        private
            void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private
            void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Rohit Kadhe\n Version: 1.00", "Tic Tac Toe");
        }

        private
            void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the any of the blank buttons to start\n\nRules: Get X's or O's in a Row, Column, or diagonal before your opponent.", "Tic Tac Toe");
        }
        void resetGame()
        {
            countPress = 0;
            turn = true;
            foreach (Control buttons in Controls)
            {
                if (buttons is Button)
                {
                    buttons.Enabled = true;
                    buttons.BackColor = Color.FromArgb(81, 161, 243);
                    buttons.Text = " ";
                }
            }
        }
        private void clickbutton(object sender, EventArgs e)
        {
            Button button = (Button)(sender);
            if (turn)
            {
                button.Text = "X";
                button.BackColor = Color.FromArgb(73, 173, 8);
                turn = false;
                countPress++;
                button.Enabled = false;
                if (checkWin())
                {
                    disableButtons();
                    X_Score.Text = (Convert.ToInt32(X_Score.Text) + 1).ToString();
                    MessageBox.Show("X won", "Tic Tac Toe");
                }
            }
            else
            {
                button.Text = "O";
                countPress++;
                button.BackColor = Color.FromArgb(240, 144, 1);
                turn = true;
                button.Enabled = false;
                if (checkWin())
                {
                    disableButtons();
                    O_Score.Text = (Convert.ToInt32(O_Score.Text) + 1).ToString();
                    MessageBox.Show("O won", "Tic Tac Toe");
                }
            }
            if (countPress == 9)
            {

                MessageBox.Show("It's Draw", "Tic Tac Toe");
            }

            bool checkWin()
            {
                // True means Victory;

                // Rows check
                if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled || B4.Text == B5.Text && B5.Text == B6.Text && !B4.Enabled || B7.Text == B8.Text && B8.Text == B9.Text && !B7.Enabled)
                {
                    return true;
                }
                // Columns check
                if (B1.Text == B4.Text && B4.Text == B7.Text && !B1.Enabled || B2.Text == B5.Text && B5.Text == B8.Text && !B2.Enabled || B3.Text == B6.Text && B6.Text == B9.Text && !B3.Enabled)
                {
                    return true;
                }
                // Diagonals check
                if (B1.Text == B5.Text && B5.Text == B9.Text && !B1.Enabled || B3.Text == B5.Text && B5.Text == B7.Text && !B3.Enabled)
                {
                    return true;
                }

                return false;
            }
            void disableButtons()
            {

                foreach (Control buttons in Controls)
                {
                    if (buttons.GetType() == typeof(Button))
                        buttons.Enabled = false;
                }
            }
        }
        private
            void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private
            void click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_Score.Text = "0";
            O_Score .Text= "0";
        }

       
    }
}
