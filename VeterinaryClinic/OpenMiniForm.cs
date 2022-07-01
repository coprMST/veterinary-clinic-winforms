using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryClinic.Forms;

namespace VeterinaryClinic
{
    internal static class OpenMiniForm
    {
        /// <summary>
        /// Source: https://www.cyberforum.ru/windows-forms/thread2572216.html
        /// </summary>
        /// <param name="thisMainForm">Передача this</param>
        /// <param name="miniForm">Форма для отображения</param>
        public static void Shading(Form miniForm)
        {
            var localThis = Program.MainFormLink;
            var bmp = new Bitmap(localThis.ClientRectangle.Width, localThis.ClientRectangle.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                g.CopyFromScreen(
                    localThis.PointToScreen(new Point(0, 0)), 
                    new Point(0, 0), localThis.ClientRectangle.Size);
                const double percent = 0.70;
                var darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brush = new SolidBrush(darken))
                {
                    g.FillRectangle(brush, localThis.ClientRectangle);
                }
            }

            using (var p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = localThis.ClientRectangle.Size;
                p.BackgroundImage = bmp;

                localThis.Controls.Add(p);
                p.BringToFront();

                miniForm.StartPosition = FormStartPosition.CenterParent;
                miniForm.ShowDialog(localThis);
            }
        }
    }
}
