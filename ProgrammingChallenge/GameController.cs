using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenge
{
    class GameController : ProgrammingChallenge.Game
    {
        private void TurnChanger(int turnCount)
        {
            Console.WriteLine(turnCount);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(390, 326);
            this.Name = "GameController";
            this.Load += new System.EventHandler(this.GameController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GameController_Load(object sender, EventArgs e)
        {

        }
    }
}
