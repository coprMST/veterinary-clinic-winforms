using System;
using System.Windows.Forms;

namespace VeterinaryClinic
{
    internal static class Program
    {
        public static MainForm MainFormLink;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
