using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Studyplaner.UniversityStuff;
using Studyplaner.UniversityStuff.Enums;

namespace Studyplaner.GUI.Controls
{
    public class UniEventPanel : Panel
    {
        private const float FACTOR_X_HEADER = 0.03f, FACTOR_Y_HEADER = 0.03f;
        private const float FACTOR_FONT_NAME = 0.15f, FACTOR_FONT_SUB = 0.1f;

        private UniversityEvent _eventToRepresent;

        public UniEventPanel(UniversityEvent ev)
        {
            this.EventToRepresent = ev;
            UpdateBackgroundColor();
        }

        public UniversityEvent EventToRepresent
        {
            get
            {
                return _eventToRepresent;
            }
            set
            {
                if (!ValidateUniEvent())
                    throw new ArgumentException("The given UniEvent is not valid.");
                _eventToRepresent = value;
                UpdateBackgroundColor();
            }
        }

        private bool ValidateUniEvent()
        {
            return true; // TODO: |f| obviously not finished
        }


        private Color GetBackgroundColorFromEventType(UniversityStuff.Enums.EventType eventType)
        {
            Color bg = Color.LightGray;

            switch (eventType)
            {
                case EventType.Lecture:
                    bg = Properties.Settings.Default.USER_COLOR_LECTURE;
                    break;
                case EventType.Exercise:
                    bg = Properties.Settings.Default.USER_COLOR_EXERCISE;
                    break;
                case EventType.Tutorial:
                    bg = Properties.Settings.Default.USER_COLOR_TUTORIAL;
                    break;
                case EventType.Internship:
                    bg = Properties.Settings.Default.USER_COLOR_INTERNSHIP;
                    break;
                case EventType.Custom:
                    bg = Properties.Settings.Default.USER_COLOR_CUSTOM;
                    break;
                default:
                    bg = Color.Gray;
                    break;
            }

            return bg;
        }

        private void UpdateBackgroundColor()
        {
            this.BackColor = GetBackgroundColorFromEventType(EventToRepresent.Type);
        }

        private void PaintContent(Graphics graphics)
        {
            RectangleF panelArea = graphics.VisibleClipBounds;

            float width = panelArea.Width, height = panelArea.Height;

            float fontSizeTitle = height * FACTOR_FONT_NAME;
 
            PointF header = new PointF(panelArea.X + width * FACTOR_X_HEADER, panelArea.Y + height * FACTOR_Y_HEADER);

            SizeF size = graphics.MeasureString("SoftwareEntwicklung III Funktional", new Font(FontFamily.GenericSansSerif, fontSizeTitle));

            graphics.DrawString("SoftwareEntwicklung III Funktional", new Font(FontFamily.GenericSansSerif, fontSizeTitle), PaintService.LINEPEN.Brush, header);

            //TODO: |f| finish that when there is a way to get parent information
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            PaintContent(e.Graphics);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

            this.Refresh();
        }
    }
}
