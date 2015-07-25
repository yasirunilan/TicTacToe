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
    public partial class PlayerLoginSP : Form
    {
        public PlayerLoginSP()
        {
            InitializeComponent();
        }
        Game game = new Game();
        PlayModeWindow pmw = new PlayModeWindow();
        private void PlayerLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            game.Show();
            game.labelTurnIndicator.Text= textBoxName.Text +"  Start the play";
            game.labelPlayer1Score.Text = textBoxName.Text;
            game.labelPlayer2Score.Text = "Computer";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            pmw.Show();
        }
    }
}
