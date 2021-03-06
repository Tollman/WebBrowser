﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 0)
            {
                if (args[0].CompareTo("tray") == 0)
                {
                    Application.Run(new Form1());
                }
                else Application.Run(new Form2());
            }
            else Application.Run(new Form2());
        }
    }
}
