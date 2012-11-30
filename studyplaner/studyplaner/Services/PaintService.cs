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
        public static readonly Pen LINEPEN = new Pen(Color.Black, 2);

        /// <summary>
        /// Paints the standard plan-grid to the
        /// graphics object. It is (mainly) adjusted to the
        /// size of graphics object.
        /// </summary>
        /// <param name="graphics">the graphics to paint on</param>
        public static void PaintGrid(Graphics graphics)
        {
            graphics.Clear(SystemColors.Control);

            RectangleF bounds = graphics.VisibleClipBounds;

            float generalOffset = bounds.Width * 0.0125f; // general offset from outer bounds
            float usedWidth = bounds.Width - generalOffset; // the resulting width
            float usedHeight = bounds.Height - generalOffset; // the resulting height

            float timeOffset = usedWidth * 0.1f; // offset for timecoloumn
            float dayWidth = (usedWidth - timeOffset) / 5; // width of a daycoloumn
            
            // dayline (horizontal)
            float headOffset = usedHeight * 0.1f; // offset of headline (separator)
            graphics.DrawLine(LINEPEN, new PointF(generalOffset, headOffset), new PointF(bounds.Width - generalOffset, headOffset));

            // days (vertical + strings)
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            float fontSize = usedWidth * 0.0225f;
            Font dayFont = new Font(FontFamily.GenericSansSerif, fontSize);
            for (int i = 0; i < 5; i++)
            {
                float x = timeOffset + (dayWidth * i);
                graphics.DrawLine(LINEPEN, new PointF(x, generalOffset), new PointF(x, bounds.Height - generalOffset));
                // set dayString center-center
                SizeF dayStringSize = graphics.MeasureString(days[i], dayFont);
                float stringX = (dayWidth / 2) - (dayStringSize.Width / 2) + x;
                float stringY = (headOffset / 2) - (dayStringSize.Height / 2);
                graphics.DrawString(days[i], dayFont, LINEPEN.Brush, new PointF(stringX, stringY));
            }

            //times
            int startTime = 8; // first time displayed
            int endTime = 19; // last time displayed

            float hourHeight = (usedHeight - headOffset) / (endTime - startTime + 1);
            float countingOffset = headOffset + hourHeight / 2;
            float lineWidth = timeOffset * 0.15f;
            float smallLineWidth = lineWidth * 0.75f;
            float fullHourFontsize = usedWidth * 0.0175f;
            float halfHourFontsize = usedWidth * 0.0125f;
            Font fullHourFont = new Font(FontFamily.GenericSansSerif, fullHourFontsize);
            Font halfHourFont = new Font(FontFamily.GenericSansSerif, halfHourFontsize);
            for (int i = startTime; i <= endTime; ++i)
            {
                float y = countingOffset + (hourHeight * (i - 8));
                // full hours
                graphics.DrawLine(LINEPEN, new PointF(timeOffset, y), new PointF(timeOffset - lineWidth, y));
                SizeF sizeFullString = graphics.MeasureString(i + ":00", fullHourFont);
                float fullX = timeOffset - lineWidth - sizeFullString.Width;
                float fullY = y - (sizeFullString.Height / 2) + (LINEPEN.Width / 2);
                graphics.DrawString(i + ":00", fullHourFont, LINEPEN.Brush, new PointF(fullX, fullY));
                // half hours
                if (i < endTime)
                {
                    y = y + hourHeight / 2;
                    graphics.DrawLine(LINEPEN, new PointF(timeOffset, y), new PointF(timeOffset - smallLineWidth, y));
                    SizeF sizeHalfString = graphics.MeasureString(i + ":30", halfHourFont);
                    float halfX = timeOffset - smallLineWidth - sizeHalfString.Width;
                    float halfY = y - (sizeHalfString.Height / 2) + (LINEPEN.Width / 2);
                    graphics.DrawString(i + ":30", halfHourFont, LINEPEN.Brush, new PointF(halfX, halfY));
                }
            }
        }
    }
}