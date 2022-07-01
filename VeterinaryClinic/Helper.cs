using System.Windows.Forms;

namespace VeterinaryClinic
{
    internal class Helper
    {
        private const string Helpfile = "help.chm";

        internal static void Open()
        {
            Help.ShowHelp(Program.MainFormLink, Helpfile);
        }
    }
}
