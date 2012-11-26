using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Studyplaner.Services
{
    /// <summary>
    /// Paints on a Panel via GDI+. Will be used for drawing
    /// the general Grid and actual UniEvents on the MainPanel.
    /// </summary>
    public class PaintService
    {
        /// <summary>
        /// Pen, used for the normal lines.
        /// </summary>
        private static readonly Pen LINEPEN = new Pen(Color.Black, 2);

        /// <summary>
        /// Paints the standard plan-grid to the
        /// graphics. It is (mainly) adjusted to the
        /// size of graphics-object.
        /// </summary>
        /// <param name="graphics">the graphics to paint on</param>
        public static void PaintGrid(Graphics graphics)
        {
            graphics.Clear(SystemColors.Control);

            RectangleF bounds = graphics.VisibleClipBounds;

            float generalOffset = bounds.Width * 0.0125f; // general offset from outer bounds
            float usedWidth = bounds.Width - generalOffset; // the resulting width
            float usedHeight = bounds.Height - generalOffset; // the resulting height

            float timeOffset = usedWidth * 0.1f;
            float dayWidth = (usedWidth - timeOffset) / 5;
            
            // days (vertical + strings)
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            for (int i = 0; i < 5; i++)
            {
                float x = timeOffset + (dayWidth * i);
                graphics.DrawLine(LINEPEN, new PointF(x, generalOffset), new PointF(x, bounds.Height - generalOffset));
                //graphics.DrawString(days[i], new Font(FontFamily.GenericSansSerif, 12), LINEPEN.Brush, new PointF(x + 5, generalOffset));
                //TODO | dj | make those fontsizes dynamic!!!
            }

            // dayline (horizontal)
            float headOffset = usedHeight * 0.1f;
            graphics.DrawLine(LINEPEN, new PointF(generalOffset, headOffset), new PointF(bounds.Width - generalOffset, headOffset));

            //times
            float hourHeight = (usedHeight - headOffset) / 12;
            float countingOffset = headOffset + hourHeight / 2;
            float xStringOffset = 40; //TODO | dj | fontsize relative to size.
            for (int i = 8; i < 20; ++i)
            {
                if (i == 10)
                    xStringOffset += 7.5f;
                float y = countingOffset + (hourHeight * (i - 8));
                // full hours
                graphics.DrawLine(LINEPEN, new PointF(timeOffset, y), new PointF(timeOffset - 10, y));
                graphics.DrawString(i + ":00", new Font(FontFamily.GenericSansSerif, 10), LINEPEN.Brush, new PointF(timeOffset - xStringOffset, y - 7.5f));
                // half hours
                if (i < 19)
                {
                    y = y + hourHeight / 2;
                    float xStrOffset = xStringOffset - 10;
                    graphics.DrawLine(LINEPEN, new PointF(timeOffset, y), new PointF(timeOffset - 5, y));
                    graphics.DrawString(i + ":30", new Font(FontFamily.GenericSansSerif, 7.5f), LINEPEN.Brush, new PointF(timeOffset - xStrOffset, y - 6.75f));
                
                }
            }
        }
    }
}