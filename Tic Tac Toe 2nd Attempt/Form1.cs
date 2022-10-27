using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_2nd_Attempt
{
    public partial class Form1 : Form
    {
        //Create Variables
        char who = 'O';
        short movement = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e) //New Game menu event handler. 
        {
            who = 'O';
            movement = 0;
            btn1.Enabled = true; btn1.Text = "";
            btn2.Enabled = true; btn2.Text = "";
            btn3.Enabled = true; btn3.Text = "";
            btn4.Enabled = true; btn4.Text = "";
            btn5.Enabled = true; btn5.Text = "";
            btn6.Enabled = true; btn6.Text = "";
            btn7.Enabled = true; btn7.Text = "";
            btn8.Enabled = true; btn8.Text = "";
            btn9.Enabled = true; btn9.Text = "";
            tableLayoutPanel1.Enabled = true;
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)//Info Event handler
        {
            MessageBox.Show("A simple game of Tic Tac Toe.");
        }

        private void btn1_Click(object sender, EventArgs e)//Button event handler. Replicated across all 9 buttons. 
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Gray; //Box color after user clicks on button. 
            if(who == 'O')
            {
                //Create if else if loop
                bt.Text = "O";
                if((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                    (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                    (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                    (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                    (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                    (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                    (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                    (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != ""))
                {
                    MessageBox.Show(($"The Winner is player{who.ToString().ToUpper()} !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if(movement == 8)
                {
                    //If game ends in draw. Display message informing user of draw. 
                    MessageBox.Show("This game has ended in a draw.");
                }

                who = 'X';
            }
            else if(who == 'X')
            {
                bt.Text = "X";
                
                //Create if else if loop. 
                if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                   (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                   (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                   (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                   (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                   (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                   (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                   (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != ""))
                {
                    //If there is a winner. Display message. 
                    MessageBox.Show(($"Congratulations {who.ToString().ToUpper()} !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    //Display error message. 
                    MessageBox.Show("ERROR");
                }
                who = 'O';
            }
            movement++;//Increment by 1 
        }
    }
}
