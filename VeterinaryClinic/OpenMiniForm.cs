using System.Drawing;
using System.Windows.Forms;

namespace VeterinaryClinic
{
    internal static class OpenMiniForm
    {
        /// <summary>
        /// Source: https://www.cyberforum.ru/windows-forms/thread2572216.html
        /// </summary>
        /// <param name="thisMainForm">Передача this</param>
        /// <param name="miniForm">Форма для отображения</param>
        public static void Shading(ref MainForm thisMainForm, Form miniForm)
        {
            var bmp = new Bitmap(thisMainForm.ClientRectangle.Width, thisMainForm.ClientRectangle.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                g.CopyFromScreen(
                    thisMainForm.PointToScreen(new Point(0, 0)), 
                    new Point(0, 0), thisMainForm.ClientRectangle.Size);
                const double percent = 0.70;
                var darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brush = new SolidBrush(darken))
                {
                    g.FillRectangle(brush, thisMainForm.ClientRectangle);
                }
            }

            using (var p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = thisMainForm.ClientRectangle.Size;
                p.BackgroundImage = bmp;

                thisMainForm.Controls.Add(p);
                p.BringToFront();

                miniForm.StartPosition = FormStartPosition.CenterParent;
                miniForm.ShowDialog(thisMainForm);
            }
        }
    }
}
