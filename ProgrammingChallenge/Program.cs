﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StartWindow());
            //Application.Run(new PlayModeWindow());
            //Application.Run(new PlayLevel());
            //Application.Run(new PlayerLoginSP());
            Application.Run(new Game());
            //Application.Run(new PlayerLoginTP());
        }
    }
}
