using PCSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Card
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
