using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Studyplaner.Materials.Uni;

namespace Studyplaner.GUI.Controls
{
    public partial class UniEventPanel : Panel
    {
        // (Re-)Size constants TODO: fine tune them
        private const double DEFAULTSIZE_X = 1.0d;
        private const double FACTOR_DURATION_Y = 1.0d;

        public UniEvent EventToRepresent { get; set; }

        public UniEventPanel(UniEvent ev, double xFactor, double yFactor)
        {
            this.EventToRepresent = ev;
            this.BackColor = GetBackgroundColorFromEventType(EventToRepresent.Type);
            this.Size = new Size((int)(DEFAULTSIZE_X * xFactor), (int)(EventToRepresent.Duration.TotalMinutes * FACTOR_DURATION_Y * yFactor));
        }

        private Color GetBackgroundColorFromEventType(Enums.EventType eventType)
        {
            Color bg = Color.LightGray;

            switch (eventType)
            {
                case Studyplaner.Enums.EventType.Lecture:
                    bg = Properties.Settings.Default.USER_COLOR_LECTURE;
                    break;
                case Studyplaner.Enums.EventType.Exercise:
                    bg = Properties.Settings.Default.USER_COLOR_EXERCISE;
                    break;
                case Studyplaner.Enums.EventType.Tutorial:
                    bg = Properties.Settings.Default.USER_COLOR_TUTORIAL;
                    break;
                case Studyplaner.Enums.EventType.Internship:
                    bg = Properties.Settings.Default.USER_COLOR_INTERNSHIP;
                    break;
            }

            return bg;
        }

        private void DrawContent(Graphics graphics)
        {
            //TODO: Draw Event info corresponding to size
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawContent(e.Graphics);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

            //TODO: Do we need to do anything here?
        }
    }
}
