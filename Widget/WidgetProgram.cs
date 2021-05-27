using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Widget
{
    static class WidgetProgram
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Widget());
        }
    }
}
