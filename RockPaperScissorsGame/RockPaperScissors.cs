using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class RockPaperScissors : Form
    {
        string username;
        string[] moves = new string[3] { "rock", "paper", "scissors" };
        string userMove;
        string computerMove;
        int userScore = 0;
        int computerScore = 0;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbComputerChoice.Image = Properties.Resources.smile;
            pbUserChoice.Image = Properties.Resources.smile;
            tbUsername.Text = "";
            lblResult.Text = "X:X";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbRock_Click(object sender, EventArgs e)
        {
            pbUserChoice.Image = Properties.Resources.rock;
            userMove = "rock";
        }

        private void pbPaper_Click(object sender, EventArgs e)
        {
            pbUserChoice.Image = Properties.Resources.paper;
            userMove = "paper";
        }

        private void pbScissors_Click(object sender, EventArgs e)
        {
            pbUserChoice.Image = Properties.Resources.unnamed;
            userMove = "scissors";
        }
        private void ComputerChoice()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 3);

            computerMove = moves[num];
            if (num==0)
            {
                pbComputerChoice.Image = Properties.Resources.rock;
                computerMove = "rock";
            }
            else if (num==1)
            {
                pbComputerChoice.Image = Properties.Resources.paper;
                computerMove = "paper";
            }
            else if (num==2)
            {
                pbComputerChoice.Image = Properties.Resources.unnamed;
                computerMove = "scissors";
            }
        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            lblUsername.Text = username;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ComputerChoice();
            GameResult();
        }
        private void GameResult()
        {

            if (userMove == computerMove)
            {
                lblResult.Text = userScore + ":" + computerScore;
            }

            else if (userMove == "scissors" && computerMove == "paper" || userMove == "paper" && computerMove == "rock" || userMove == "rock" && computerMove == "scissors")
            {
                userScore++;
                lblResult.Text = userScore.ToString() + ":" + computerScore.ToString();

            }
            else
            {
                computerScore++;
                lblResult.Text = userScore.ToString() + ":" + computerScore.ToString();

            }
           
        }
    }
}
