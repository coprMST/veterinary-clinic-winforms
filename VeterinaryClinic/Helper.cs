using System.Windows.Forms;
using static System.String;

namespace VeterinaryClinic
{
    internal class Helper
    {
        private const string Helpfile = "help.chm";
        private const string Topic = "Overview.htm";

        internal void Open(ref MainForm thisMainForm, string topic = Topic)
        {
            Help.ShowHelp(thisMainForm, Helpfile, HelpNavigator.Topic, IsNullOrEmpty(topic) ? topic : Topic);
        }
    }
}
