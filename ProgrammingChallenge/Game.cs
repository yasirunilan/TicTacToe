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
        public Game()
        {
            InitializeComponent();
        }

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
            
        }
    }
}
