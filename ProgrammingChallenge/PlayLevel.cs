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
    public partial class PlayLevel : Form
    {
        public PlayLevel()
        {
            InitializeComponent();
        }

        Game game = new Game();
        PlayerLoginSP splogin = new PlayerLoginSP();
        private void buttonEasy_Click(object sender, EventArgs e)
        {
            game.level = "Easy";
            splogin.Show();
            this.Visible = false;
        }

        

        private void buttonHard_Click(object sender, EventArgs e)
        {
            game.level = "Hard";
            splogin.Show();
            this.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PlayModeWindow pmwi = new PlayModeWindow();
            pmwi.Show();
        }

        private void PlayLevel_Load(object sender, EventArgs e)
        {

        }
    }
}
