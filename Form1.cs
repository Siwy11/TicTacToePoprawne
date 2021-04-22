using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe1
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }
        private void checkForWinner()
        {
            bool ther_is_a_winner = false;

            //poziomo
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                ther_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                ther_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                ther_is_a_winner = true;

            //pionowo
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                ther_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B1.Enabled))
                ther_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!C1.Enabled))
                ther_is_a_winner = true;

            if (ther_is_a_winner)
            {
                disableButtons();


                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " wygrywa!!");
            }
            else
            {
                if(turn_count == 9)
                {
                    MessageBox.Show("Remis");
                }
            }
        }
        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            }
        }
    }
}
