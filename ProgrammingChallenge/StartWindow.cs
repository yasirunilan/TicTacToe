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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //Open the play mode window for the play button click and hide the other window
            PlayModeWindow pMW = new PlayModeWindow();
            pMW.Show();
            this.Visible=false;
        }

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

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
