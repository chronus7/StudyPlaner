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
        private static Pen LINEPEN = new Pen(Color.Black, 2); //TODO | dj | i want static final!!

        public static void PaintGrid(Graphics graphics)
        {
            graphics.Clear(SystemColors.Control);

            RectangleF bounds = graphics.VisibleClipBounds;

            float generalOffset = bounds.Width * 0.0125f;
            float usedWidth = bounds.Width - generalOffset;
            float usedHeight = bounds.Height - generalOffset;

            float timeOffset = usedWidth * 0.1f;
            float dayWidth = (usedWidth - timeOffset) / 5;
            
            // days (vertical)
            for (int i = 0; i < 5; i++)
            {
                float x = timeOffset + (dayWidth * i);
                graphics.DrawLine(LINEPEN, new PointF(x, generalOffset), new PointF(x, bounds.Height - generalOffset));
            }

            // dayline (horizontal)
            float headOffset = usedHeight * 0.1f;
            graphics.DrawLine(LINEPEN, new PointF(generalOffset, headOffset), new PointF(bounds.Width - generalOffset, headOffset));

            //times
            int[] nums = { 0, 15, 30, 45 };
            //TODO CHANGE DIS!!!!
            float hourHeight = (usedHeight - headOffset) / 12;
            float countingOffset = headOffset + hourHeight / 2;
            float xStringOffset = 40;
            for (int i = 8; i < 20; ++i)
            {
                if (i == 10)
                    xStringOffset += 7.5f;
                float y = countingOffset + (hourHeight * (i - 8));
                graphics.DrawLine(LINEPEN, new PointF(timeOffset, y), new PointF(timeOffset - 10, y));
                graphics.DrawString(i + ":00", new Font(FontFamily.GenericSansSerif, 10), LINEPEN.Brush, new PointF(timeOffset - xStringOffset, y - 7.5f));
            }
        }
    }
}