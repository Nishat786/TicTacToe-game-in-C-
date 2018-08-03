using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {

        int turn = 0; // True for X and False for O
        int turnCount = 0;

        public form1()
        {
            InitializeComponent();
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Includes New Game and Exit 
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Includes About the Game
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Nishat Bagga", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn % 2 == 0)
            {
                b.ForeColor = Color.Red;
                b.Text = "X";
            }
            else
            {
                b.ForeColor = Color.Blue;
                b.Text = "O";
            }
            turn++;
            b.Enabled = false;
            checkForWinner();
        }
        private void checkForWinner()
        {
            if(btnA1.Text== btnA2.Text && btnA1.Text== btnA3.Text && btnA1.Enabled==false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
            }
            if (btnB1.Text == btnB2.Text && btnB1.Text == btnB3.Text && btnB1.Enabled == false)
            {
                MessageBox.Show(btnB1.Text + " won the game!");
            }
            if (btnC1.Text == btnC2.Text && btnC1.Text == btnC3.Text && btnC1.Enabled == false)
            {
                MessageBox.Show(btnC1.Text + " won the game!");
            }
            if (btnA1.Text == btnB1.Text && btnA1.Text == btnC1.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
            }
            if (btnA2.Text == btnB2.Text && btnA2.Text == btnC2.Text && btnA2.Enabled == false)
            {
                MessageBox.Show(btnA2.Text + " won the game!");
            }
            if (btnA3.Text == btnB3.Text && btnA3.Text == btnC3.Text && btnA3.Enabled == false)
            {
                MessageBox.Show(btnA3.Text + " won the game!");
            }
            if (btnA1.Text == btnB2.Text && btnA1.Text == btnC3.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
            }
            if (btnA3.Text == btnB2.Text && btnA3.Text == btnC1.Text && btnA3.Enabled == false)
            {
                MessageBox.Show(btnA3.Text + " won the game!");
            }
            turnCount++;
            if (turnCount == 9)
            {
                MessageBox.Show("Game is Draw! No Win");
            }
        }
        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
        }
        private void resetButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {

            }
            turn++;
            turnCount = 0;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetButtons();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
