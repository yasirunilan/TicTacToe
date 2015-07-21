using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingChallenge
{
    public partial class Game : Form
    {
        int turnCount = 0; 
        public Game()
        {
            InitializeComponent();
            
        }

        Random rnd = new Random();
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit the Game?\r\nAny unsaved game date may loss", "Want to exit", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            //increment the turn counter with the button click
            turnCount++;
            //check whether to display cross or circle
            if (turnCount%2==1)
                this.buttonA1.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonA1.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            //disable the current button after changing icon
            buttonA1.Enabled = false;
            TurnChanger(turnCount);
            //call EasyPlay if the user has selected easy mode
            EasyPlay();
            
            
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonA2.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonA2.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonA2.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonA3.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonA3.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonA3.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonB1.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonB1.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonB1.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonB2.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonB2.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonB2.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonB3.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonB3.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonB3.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonC1.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonC1.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonC1.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonC2.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonC2.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonC2.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
                this.buttonC3.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
            else
                this.buttonC3.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
            buttonC3.Enabled = false;
            TurnChanger(turnCount);
            EasyPlay();
        }

        private void buttonHighScore_Click(object sender, EventArgs e)
        {
            labelResult.Text = turnCount.ToString();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
           // PlayModeWindow
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            //opens the new game window  if the user selects new game and hides the running window
            Game newGame = new Game();
            newGame.Show();
            this.Visible = false;
        }

        private void labelTurnIndicator_Click(object sender, EventArgs e)
        {
            
        }

        private void TurnChanger(int turnCount)
        {
            if (turnCount == 9)
                labelTurnIndicator.Text = "Game Over";
            else if (turnCount % 2 == 1)
                labelTurnIndicator.Text = "Turn for player 2";
            else
                labelTurnIndicator.Text = "Turn for player 1";
        }

        private void EasyPlay()
        {
            //created the button array for the convenience of use with random numbers
            Button[] btnarray = { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };
            int rand = 1;

            //go further if the game is not finished yet
            if (turnCount != 9)
            {
                //generate random button number
                while (btnarray[rand - 1].Enabled == false)
                {
                    rand = rnd.Next(1, 9);
                }


                turnCount++;
                //display the button icon according to the turn count
                if (turnCount % 2 == 1)
                    btnarray[rand - 1].BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                else
                    btnarray[rand - 1].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                btnarray[rand - 1].Enabled = false;
                TurnChanger(turnCount);
            }
            
        }

        private void CheckForWin()
        {
            Button[] btnarray = { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };
            
        }
    }
}