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
        int[] numbers = new int[9];
        String winner;

        
        public String level { get; set; }
        public String player1 { get; set; }
        public string player2 { get; set; }

        public String mode { get; set; }
        
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
            if (turnCount%2==1){
                this.buttonA1.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[0] = 1;
                //labelResult.Text = numbers[0].ToString();
            }
            else 
            {
                this.buttonA1.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[0] = 2;
                //labelResult.Text = numbers[0].ToString();
            }
                
            //disable the current button after changing icon
            buttonA1.Enabled = false;
            TurnChanger(turnCount);
            //call EasyPlay if the user has selected easy mode otherwise paly hard
            if (mode=="single")
            {
                CheckConditions();
            }
            else if(mode == "double")
            {
                CheckConditions();
            }

            labelResult.Text = level;
           
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonA2.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[1] = 1;
                //labelResult.Text = numbers[1].ToString();
            }

            else
            {
                this.buttonA2.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[1] = 2;
                //labelResult.Text = numbers[1].ToString();
            }
                
            buttonA2.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonA3.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[2] = 1;
                //labelResult.Text = numbers[2].ToString();
            }

            else
            {
                this.buttonA3.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[2] = 2;
                //labelResult.Text = numbers[2].ToString();
            }
                
            buttonA3.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonB1.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[3] = 1;
                //labelResult.Text = numbers[3].ToString();
            }

            else
            {
                this.buttonB1.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[3] = 2;
                //labelResult.Text = numbers[3].ToString();
            }
                
            buttonB1.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonB2.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[4] = 1;
                //labelResult.Text = numbers[4].ToString();
            }

            else
            {
                this.buttonB2.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[4] = 2;
                //labelResult.Text = numbers[4].ToString();
            }
                
            buttonB2.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1)
            {
                this.buttonB3.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[5] = 1;
                //labelResult.Text = numbers[5].ToString();
            }

            else
            {
                numbers[5] = 1;
                this.buttonB3.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                //labelResult.Text = numbers[5].ToString();
            }
                
            buttonB3.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonC1.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[6] = 1;
                //labelResult.Text = numbers[6].ToString();
            }

            else
            {
                this.buttonC1.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[6] = 2;
                //labelResult.Text = numbers[6].ToString();
            }
                
            buttonC1.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonC2.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[7] = 1;
                //labelResult.Text = numbers[7].ToString();
            }

            else
            {
                this.buttonC2.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[7] = 2;
                //labelResult.Text = numbers[7].ToString();
            }
                
            buttonC2.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            turnCount++;
            if (turnCount % 2 == 1){
                this.buttonC3.BackgroundImage = ProgrammingChallenge.Properties.Resources.cross;
                numbers[8] = 1;
                //labelResult.Text = numbers[8].ToString();
            }

            else
            {
                this.buttonC3.BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                numbers[8] = 2;
                //labelResult.Text = numbers[8].ToString();
            }
                
            buttonC3.Enabled = false;
            TurnChanger(turnCount);
            if (mode == "single")
            {
                CheckConditions();
            }
            else if (mode == "double")
            {
                CheckConditions();
            }
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
            this.Visible = false;
            PlayModeWindow pmw = new PlayModeWindow();
            pmw.Show();
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
            //change the turn and dispaly it in the label
            if (turnCount == 9)
                labelTurnIndicator.Text = "Game Over"; 
            else if (turnCount % 2 == 1)
                labelTurnIndicator.Text = "Turn for player 2";
            else
                labelTurnIndicator.Text = "Turn for player 1";
        }

        private void EasyPlay()
        {
            winner=CheckForWin();
            if (winner == null)
            {
                //initialize the button array for the use in this function
                Button[] btnarray = { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };


                int random = 0;
                //if game has not ended
                if (turnCount != 9)
                {
                    //select a button which is still enabled
                    while (btnarray[random].Enabled == false)
                    {
                        random = rnd.Next(0, 9);
                    }
                    //increment the turnCount and do other changes
                    turnCount++;
                    btnarray[random].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                    numbers[random] = 2;
                    btnarray[random].Enabled = false;
                }
                //change the turn
                TurnChanger(turnCount);
                //check for a winner
                CheckForWin();
            }

            
            

        }

        private String CheckForWin()
        {
            Button[] btnarray = {buttonA1,buttonA2,buttonA3,buttonB1,buttonB2,buttonB3,buttonC1,buttonC2,buttonC3};


            if ((numbers[0] == numbers[1]) && (numbers[0] == numbers[2]) && (numbers[0] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 1";
            }
            else if ((numbers[0] == numbers[1]) && (numbers[0] == numbers[2]) && (numbers[0] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 2";
            }
            else if ((numbers[0] == numbers[3]) && (numbers[0] == numbers[6]) && (numbers[0] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 3";
            }
            else if ((numbers[0] == numbers[3]) && (numbers[0] == numbers[6]) && (numbers[0] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 4";
            }
            else if ((numbers[0] == numbers[4]) && (numbers[0] == numbers[8]) && (numbers[0] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 5";
            }
            else if ((numbers[0] == numbers[4]) && (numbers[0] == numbers[8]) && (numbers[0] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 6";
            }

            else if ((numbers[1] == numbers[4]) && (numbers[1] == numbers[7]) && (numbers[1] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 7";
            }
            else if ((numbers[1] == numbers[4]) && (numbers[1] == numbers[7]) && (numbers[1] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 8";
            }

            else if ((numbers[2] == numbers[5]) && (numbers[2] == numbers[8]) && (numbers[2] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 9";
            }
            else if ((numbers[2] == numbers[5]) && (numbers[2] == numbers[8]) && (numbers[2] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 10";
            }
            else if ((numbers[2] == numbers[4]) && (numbers[2] == numbers[6]) && (numbers[2] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 11";
            }
            else if ((numbers[2] == numbers[4]) && (numbers[2] == numbers[6]) && (numbers[2] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 12";
            }

            else if ((numbers[3] == numbers[4]) && (numbers[3] == numbers[5]) && (numbers[3] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 13";
            }
            else if ((numbers[3] == numbers[4]) && (numbers[3] == numbers[5]) && (numbers[3] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 14";
            }

            else if ((numbers[6] == numbers[7]) && (numbers[6] == numbers[8]) && (numbers[6] == 1))
            {
                winner = "Player 1";
                label1.Text = "Condition 15";
            }
            else if ((numbers[6] == numbers[7]) && (numbers[6] == numbers[8]) && (numbers[6] == 2))
            {
                winner = "Player 2";
                label1.Text = "Condition 16";
            }



            if (winner != null)
            {
                labelTurnIndicator.Text = "Game Finished!!";
                foreach (Button i in btnarray)
                {
                    i.Enabled = false;
                }
                labelResult.Text = winner+"  wins !!";
                return winner;

            }
            else
                return null;
            
            
        }

        public void HardPlay()
        {
            winner = CheckForWin();
            if (winner == null)
            {
                Button[] btnarray = { buttonA1, buttonA2, buttonA3, buttonB1, buttonB2, buttonB3, buttonC1, buttonC2, buttonC3 };

                if (turnCount != 9)
                {
                    turnCount++;
                    if((numbers[0]==numbers[1]) && (btnarray[2].Enabled==true)){

                        btnarray[2].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[2] = 2;
                        btnarray[2].Enabled = false;
                    }
                    else if ((numbers[0] == numbers[2]) && (btnarray[1].Enabled == true))
                    {
                        btnarray[1].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[1] = 2;
                        btnarray[1].Enabled = false;
                    }
                    else if ((numbers[1] == numbers[2]) && (btnarray[0].Enabled == true))
                    {
                        btnarray[0].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[0] = 2;
                        btnarray[0].Enabled = false;
                    }


                    else if ((numbers[0] == numbers[3]) && (btnarray[6].Enabled == true))
                    {
                        btnarray[6].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[6] = 2;
                        btnarray[6].Enabled = false;
                    }
                    else if ((numbers[0] == numbers[6]) && (btnarray[3].Enabled == true))
                    {
                        btnarray[3].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[3] = 2;
                        btnarray[3].Enabled = false;
                    }
                    else if ((numbers[3] == numbers[6]) && (btnarray[0].Enabled == true))
                    {
                        btnarray[0].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[0] = 2;
                        btnarray[0].Enabled = false;
                    }

                    
                    else if ((numbers[2] == numbers[5]) && (btnarray[8].Enabled == true))
                    {
                        btnarray[8].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[8] = 2;
                        btnarray[8].Enabled = false;
                    }
                    else if ((numbers[2] == numbers[8]) && (btnarray[5].Enabled == true))
                    {
                        btnarray[5].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[5] = 2;
                        btnarray[5].Enabled = false;
                    }
                    else if ((numbers[5] == numbers[5]) && (btnarray[2].Enabled == true))
                    {
                        btnarray[2].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[2] = 2;
                        btnarray[2].Enabled = false;
                    }

                    else if ((numbers[6] == numbers[7]) && (btnarray[8].Enabled == true))
                    {
                        btnarray[8].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[8] = 2;
                        btnarray[8].Enabled = false;
                    }
                    else if ((numbers[6] == numbers[8]) && (btnarray[7].Enabled == true))
                    {
                        btnarray[7].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[7] = 2;
                        btnarray[7].Enabled = false;
                    }
                    else if ((numbers[7] == numbers[8]) && (btnarray[6].Enabled == true))
                    {
                        btnarray[6].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[6] = 2;
                        btnarray[6].Enabled = false;
                    }

                    else if ((numbers[0] == numbers[4]) && (btnarray[8].Enabled == true))
                    {
                        btnarray[8].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[8] = 2;
                        btnarray[8].Enabled = false;
                    }
                    else if ((numbers[0] == numbers[8]) && (btnarray[4].Enabled == true))
                    {
                        btnarray[4].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[4] = 2;
                        btnarray[4].Enabled = false;
                    }
                    else if ((numbers[8] == numbers[4]) && (btnarray[0].Enabled == true))
                    {
                        btnarray[0].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[0] = 2;
                        btnarray[0].Enabled = false;
                    }

                    else if ((numbers[2] == numbers[4]) && (btnarray[6].Enabled == true))
                    {
                        btnarray[6].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[6] = 2;
                        btnarray[6].Enabled = false;
                    }
                    else if ((numbers[2] == numbers[6]) && (btnarray[4].Enabled == true))
                    {
                        btnarray[4].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[4] = 2;
                        btnarray[4].Enabled = false;
                    }
                    else if ((numbers[4] == numbers[6]) && (btnarray[2].Enabled == true))
                    {
                        btnarray[2].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[2] = 2;
                        btnarray[2].Enabled = false;
                    }

                    else if ((numbers[1] == numbers[4]) && (btnarray[7].Enabled == true))
                    {
                        btnarray[7].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[7] = 2;
                        btnarray[7].Enabled = false;
                    }
                    else if ((numbers[1] == numbers[7]) && (btnarray[4].Enabled == true))
                    {
                        btnarray[4].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[4] = 2;
                        btnarray[4].Enabled = false;
                    }
                    else if ((numbers[7] == numbers[4]) && (btnarray[1].Enabled == true))
                    {
                        btnarray[1].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[1] = 2;
                        btnarray[1].Enabled = false;
                    }



                    else if ((numbers[3] == numbers[4]) && (btnarray[5].Enabled == true))
                    {
                        
                        btnarray[5].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[5] = 2;
                        btnarray[5].Enabled = false;
                        

                    }
                    else if ((numbers[3] == numbers[5]) && (btnarray[4].Enabled == true))
                    {
                        
                        btnarray[4].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[4] = 2;
                        btnarray[4].Enabled = false;
                        

                    }
                    else if ((numbers[5] == numbers[4]) && (btnarray[3].Enabled == true))
                    {
                        
                        btnarray[3].BackgroundImage = ProgrammingChallenge.Properties.Resources.circle;
                        numbers[3] = 2;
                        btnarray[3].Enabled = false;
                        

                    }

                    else
                    {
                        EasyPlay();
                    }


                    
                }
                
                CheckForWin();
                
                
            }


        }


        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckConditions()
        {
            if (level == "Easy")
            {
                EasyPlay();
            }
            else if (level == "Hard")
            {
                HardPlay();
            }
        }

        
    }
}