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
    public partial class PlayModeWindow : Form
    {
        public PlayModeWindow()
        {
            InitializeComponent();
        }
        Game game = new Game();
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //display a message box when the user clicks exit button
            DialogResult exit = MessageBox.Show("Do you want to exit the Game?", "Want to exit", MessageBoxButtons.YesNo);

            //exit the application if user confirms the exit command
            if (exit == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void buttonSinglePlayer_Click(object sender, EventArgs e)
        {
            //opens the new window for selecting play level if the user selects single player mode and hides the other windows
            game.mode = "single";
            PlayLevel pLevel = new PlayLevel();
            pLevel.Show();
            this.Visible = false;
        }

        private void buttonTwoPlayer_Click(object sender, EventArgs e)
        {
            //opens the new window for login if the user selects two player mode and hides the other windows
            game.mode = "double";
            PlayerLoginTP loginTP = new PlayerLoginTP();
            loginTP.Show();
            this.Visible = false;
        }
    }
}
