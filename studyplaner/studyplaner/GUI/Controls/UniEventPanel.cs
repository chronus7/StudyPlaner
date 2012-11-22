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
        public UniEvent EventToRepresent { get; set; }

        public UniEventPanel(UniEvent ev)
        {
            this.EventToRepresent = ev;
            this.BackColor = GetBackgroundColorFromEventType(EventToRepresent.Type);
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
