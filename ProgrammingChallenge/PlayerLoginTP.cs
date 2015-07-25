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
    public partial class PlayerLoginTP : Form
    {
        public PlayerLoginTP()
        {
            InitializeComponent();
        }
        Game game = new Game();
        PlayModeWindow pmw = new PlayModeWindow();
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            game.Show();
          
            game.labelPlayer1Score.Text = textBoxPlayer1.Text;
            game.labelPlayer2Score.Text = textBoxPlayer2.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pmw.Show();
        }
    }
}
