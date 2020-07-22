using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._9TicTacToe
{
    public partial class Form1 : Form
    {

        bool turn = true;   // true = X turn, False = Y turn
        int turncounted = 0; // if turn reach 9  = draw        // static to reach from 1 form to another.
        static string player1, player2;

        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayernames(string p1, string p2)
        {
            player1 = p1;
            player2 = p2;
        }

        private void Button_clicked(object sender, EventArgs e)
        {

            Button button = (Button)sender;                              // sending Button object
            
            if(turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            turn = !turn;                         // its like you want to rotate something you add in *-1  but this sets to false and true;
            button.Enabled = false;
            //MessageBox.Show("HEJJJ");
            // can announce the winner
            turncounted++;
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

      // check condition for victory
      // Horizontal

            if((A1.Text ==A2.Text && A2.Text ==A3.Text)&&(!A1.Enabled))
                    {
                there_is_a_winner = true;
            }
            else if ((B1.Text == B2.Text && B2.Text == B3.Text) && (!B1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((C1.Text == C2.Text && C2.Text == C3.Text) && (!C1.Enabled))
            {
                there_is_a_winner = true;
            }


            // vertical

           else if ((A1.Text == B1.Text && B1.Text == C1.Text) && (!A1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((A2.Text == B2.Text && B2.Text == C2.Text) && (!A2.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((A3.Text == B3.Text && B3.Text == C3.Text) && (!A3.Enabled))
            {
                there_is_a_winner = true;
            }



           // diagonal

            else if ((A1.Text == B2.Text && B2.Text == C3.Text) && (!A1.Enabled))
            {
                there_is_a_winner = true;
            }
            else if ((A3.Text == B2.Text && B2.Text == C1.Text) && (!C1.Enabled))
            {
                there_is_a_winner = true;
            }

            // if found a winner
            if (there_is_a_winner)
            {
                string Thewinner = "";
                if(turn)
                {
                    Thewinner = player2;
                    Player_2_O.Text = (int.Parse(Player_2_O.Text)+1).ToString();
                }
                else
                {
                    Thewinner = player1;
                    Player_1_X.Text = (int.Parse(Player_1_X.Text)+1).ToString();
                }

                MessageBox.Show("The winner is "+Thewinner);

               
                    foreach (Control c in Controls)                // check all our control in Windows form
                    {
                    try
                    {

                        Button button = (Button)c;
                        c.Enabled = false;
                    }
                    catch
                    {

                    }
                }
            }
            else
            {// draw
                if(turncounted == 9)
                {
                    Count_Draw.Text = (int.Parse(Count_Draw.Text)+1).ToString();
                    MessageBox.Show("No winner ");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            if(b.Enabled)
            {
                if(turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }

        private void button_leave(object sender, EventArgs e)
        {

            Button b = (Button)sender;


            if (b.Enabled)
            {
                
                    b.Text = "";
                }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            turn = true;
            turncounted = 0;
            foreach (Control c in Controls)
            {

                try
                {
                    Button d = (Button)c;
                    d.Enabled = true;
                    d.Text = "";
                }
                catch
                {

                }
            }
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player_1_X.Text = "0";
            Player_2_O.Text = "0";
            Count_Draw.Text = "0";
            Form2 f2 = new Form2();
            f2.ShowDialog();
            PlayerLabel1.Text = player1;
            PlayerLabel2.Text = player2;

            turn = true;
            turncounted = 0;
            foreach (Control c in Controls)
            {

                try
                {
                    Button d = (Button)c;
                    d.Enabled = true;
                    d.Text = "";
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();  // show the form 2 before 1
            f2.ShowDialog();       // dialog prioritys over show                 
            PlayerLabel1.Text = player1;
            PlayerLabel2.Text = player2;

        }
    }
}
