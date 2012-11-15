using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StudyPlaner
{
    public class DrawHelper
    {
        public event EventHandler SelectedEventChanged;

        public Event SelectedEvent 
        {
            get
            {
                return _selectedEvent;
            }
        }

        private Event _selectedEvent;

        // Constant values
        private const int OFFSET_TIME_X = 74;
        private const int OFFSET_TIME_Y = 45;
        private const int OFFSET_DAY = 139;

        private const float SIZE_HOUR_NORMAL = 45F;
        private const float SIZE_HOUR_SMALL = 17.5F;

        private const int SIZE_X = 772;
        private const int SIZE_Y = 533;

        private Color COLOR_LECTURES = Properties.Settings.Default.COLOR_LECTURES;
        private Color COLOR_EXERCISES = Properties.Settings.Default.COLOR_EXERCISES;
        private Color COLOR_TUTORIALS = Properties.Settings.Default.COLOR_TUTORIALS;
        private Color COLOR_INTERNSHIPS = Properties.Settings.Default.COLOR_INTERNSHIPS;

        private float COLOR_BRIGHTNESSFACTOR = Properties.Settings.Default.COLOR_BRIGHTNESSFACTOR;
        private Color COLOR_SELECTED = Properties.Settings.Default.COLOR_SELECTED;

        private Color COLOR_FONT = Properties.Settings.Default.COLOR_FONT;

        public DrawHelper()
        {

        }

        public virtual void OnSelectedEventChanged(EventArgs e)
        {
            EventHandler myEvent = SelectedEventChanged;
            if (myEvent != null)
            {
                myEvent(this, e);
            }
        }

        /// <summary>
        /// Draws the background of the weekly Grid
        /// </summary>
        /// <param name="e">PainteventArgs of the corresponding Panel.Paint() Event</param>
        public void DrawBackground(PaintEventArgs e)
        {
            DrawGrid(e);
            DrawTime(e);
        }

        /// <summary>
        /// Draws the basic Grid and day strings
        /// </summary>
        /// <param name="e">PainteventArgs of the corresponding Panel.Paint() Event</param>
        private void DrawGrid(PaintEventArgs e)
        {
            // Get Graphics obeject
            Graphics cGraphics = e.Graphics;

            // Setup basic prerequesites
            Pen pen = new Pen(COLOR_FONT, 2F);
            Font font = new Font("Sans", 17);
            SolidBrush brush = new SolidBrush(COLOR_FONT);

            // Draw line below the days
            cGraphics.DrawLine(pen, new Point(5, OFFSET_TIME_Y), new Point(SIZE_X - 5, OFFSET_TIME_Y));

            for (int i = 0; i < 5; i++)
            {
                // Draw a line for each day
                cGraphics.DrawLine(pen, new Point(i * OFFSET_DAY + OFFSET_TIME_X, 5), new Point(i * OFFSET_DAY + OFFSET_TIME_X, SIZE_Y - 5));
            }

            for (int i = 0; i < 5; i++)
            {
                string day = Enum.GetName(typeof(GermanDay), i);

                // Calculate middle
                float x = OFFSET_TIME_X + i * OFFSET_DAY + 0.5F * OFFSET_DAY - cGraphics.MeasureString(day, font).Width / 2;

                // Draw Day-string
                cGraphics.DrawString(day, font, brush, new PointF(x, 10));
            }
        }

        /// <summary>
        /// Draws the "TimeLine" on the left side of the grid
        /// </summary>
        /// <param name="e">PainteventArgs of the corresponding Panel.Paint() Event</param>
        private void DrawTime(PaintEventArgs e)
        {
            // Get Graphics object
            Graphics cGraphics = e.Graphics;

            // Setup basic prerequesites
            Font fontNormal = new Font("Sans", 10);
            Font fontSmall = new Font("Sans", 7);
            SolidBrush brush = new SolidBrush(COLOR_FONT);

            for (int i = 8; i < 19; i++)
            {
                string time = i + ":00";

                // Calculate Coordinates
                float x = 10F;
                if (i < 10)
                    x += 7;

                float y = (i - 8) * SIZE_HOUR_NORMAL + SIZE_HOUR_SMALL + OFFSET_TIME_Y;

                // Draw hour and corresponding line
                cGraphics.DrawLine(new Pen(brush, 2F), new PointF(52F, y), new PointF(OFFSET_TIME_X, y));
                cGraphics.DrawString(time, fontNormal, brush, new PointF(x, y - 9));

                if (i < 18)
                {
                    time = i + ":30";

                    // Calculate Coordinates
                    x = 25F;
                    if (i < 10)
                        x += 5;
                    y += SIZE_HOUR_NORMAL / 2F;

                    // Draw half-hour and corresponding line
                    cGraphics.DrawLine(new Pen(brush, 1F), new PointF(60F, y), new PointF(OFFSET_TIME_X, y));
                    cGraphics.DrawString(time, fontSmall, brush, new PointF(x, y - 6));
                }
            }
        }

        /// <summary>
        /// Draws an event on the grid
        /// </summary>
        /// <param name="ev">The event to draw</param>
        /// <param name="sender">Object  of the corresponding Panel.Paint() Event</param>
        /// <param name="e">PainteventArgs of the corresponding Panel.Paint() Event</param>
        public void DrawSingleEvent(Event ev, object sender, PaintEventArgs e)
        {
            Panel mainPanel = (Panel)sender;
            Event cEvent = ev;
            Graphics cGraphics = e.Graphics;

            // Get position and size
            float[] possize = panelPaintCalc(cEvent);
            float x = possize[0];
            float y = possize[1];
            float duration = possize[2];

            // Do not paint in time region
            if (x < OFFSET_TIME_X)
                throw new ArgumentException("ev.Day Property not valid!", "ev");

            // Ignore Weekend
            if (x > SIZE_X - OFFSET_DAY)
                return;

            // Create Panel
            EventPanel panel = new EventPanel(cEvent);
            panel.Dock = DockStyle.None;
            panel.Location = new Point((int)x, (int)y);
            panel.Name = "panel_" + ev.ID;
            panel.Padding = new Padding(5, 6, 5, 6);
            panel.Size = new Size((int)OFFSET_DAY, (int)duration);
            panel.Click += new EventHandler(panel_Click);
            panel.Paint += new PaintEventHandler(panel_Paint);
            panel.MouseEnter += new EventHandler(panel_MouseEnter);
            panel.MouseLeave += new EventHandler(panel_MouseLeave);
            mainPanel.Controls.Add(panel);      // append Panel
            
        }

        private float[] panelPaintCalc(Event ev)
        {
            Event cEvent = ev;

            int x = OFFSET_TIME_X + (int)cEvent.Day * OFFSET_DAY;


            // Calculate Coordinates and Size
            string strStarttime = ev.Time.Split(',')[0];
            string[] stime = strStarttime.Split('.');

            float starttime = Convert.ToInt32(stime[0]) + Convert.ToInt32(stime[1]) / 60F;
            float y = (starttime - 8) * SIZE_HOUR_NORMAL + SIZE_HOUR_SMALL + OFFSET_TIME_Y;

            string strEndtime = ev.Time.Split(',')[1];
            string[] etime = strEndtime.Split('.');

            float endtime = Convert.ToInt32(etime[0]) + Convert.ToInt32(etime[1]) / 60F;
            float duration = (endtime - starttime) * SIZE_HOUR_NORMAL;

            float[] result = { x, y, duration };

            return result;

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (sender is EventPanel)
            {
                EventPanel panel = (EventPanel)sender;
                Event ev = panel.UsedEvent;
                Graphics cGraphics = e.Graphics;
                Brush fontBrush = new SolidBrush(COLOR_FONT);

                // Border
                cGraphics.DrawRectangle(new Pen(fontBrush, 2), e.ClipRectangle);

                // Textsize with dynamic factors!!!
                float textFactor = ((float)e.ClipRectangle.Width/(float)OFFSET_DAY);
                if (textFactor <= 0.5)
                    textFactor += 0.25F;

                if (e.ClipRectangle.Height <= 1.25 * SIZE_HOUR_NORMAL)
                    textFactor *= 0.75F;
                
                // Modulename
                Font nameFont = new Font("Sans", 18 * textFactor);
                    // calc
                float px = e.ClipRectangle.Width/2 - cGraphics.MeasureString(ev.ParentShort, nameFont).Width/2;
                float py = e.ClipRectangle.Height / 2 - cGraphics.MeasureString(ev.ParentShort, nameFont).Height/2;

                cGraphics.DrawString(ev.ParentShort, nameFont, fontBrush, new PointF(px, py));

                if (e.ClipRectangle.Height >= 1 * SIZE_HOUR_NORMAL)
                {
                    // Eventtype
                    string type = "";
                    switch (ev.Type)
                    {
                        case "lecture":
                            type = "Vorlesung";
                            break;
                        case "exercise":
                            type = "Übung";
                            break;
                        case "tutorial":
                            type = "Tutorial";
                            break;
                        case "internship":
                            type = "Praktikum";
                            break;
                        default:
                            break;
                    }
                    cGraphics.DrawString(type, new Font("Sans", 11 * textFactor), fontBrush, new PointF(1F, 1F));
                }

                // Location
                cGraphics.DrawString(ev.Location, new Font("Sans", 9 * textFactor), fontBrush, new PointF(1F, e.ClipRectangle.Bottom-(18 * textFactor)));
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            if (sender is EventPanel)
            {
                EventPanel panel = (EventPanel)sender;

                if (panel.UsedEvent != _selectedEvent)
                {
                    if (_selectedEvent != null)
                    {
                        foreach (EventPanel ep in panel.Parent.Controls)
                        {
                            if (ep.UsedEvent == _selectedEvent)
                                ep.BackColor = ep.eventTypeColor();
                        }
                    }

                    _selectedEvent = panel.UsedEvent;
                    panel.BackColor = COLOR_SELECTED;
                }
                else
                {
                    _selectedEvent = null;
                    panel.BackColor = panel.eventTypeColor();
                }

                OnSelectedEventChanged(EventArgs.Empty);
            }
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is EventPanel)
            {
                EventPanel panel = (EventPanel)sender;

                float[] color = { panel.BackColor.R, panel.BackColor.G, panel.BackColor.B };

                if (panel.UsedEvent != _selectedEvent)
                    panel.BackColor = Color.FromArgb((int)(color[0] * COLOR_BRIGHTNESSFACTOR), (int)(color[1] * COLOR_BRIGHTNESSFACTOR), (int)(color[2] * COLOR_BRIGHTNESSFACTOR));
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is EventPanel)
            {
                EventPanel panel = (EventPanel)sender;

                if(panel.UsedEvent != _selectedEvent)
                    panel.BackColor = panel.eventTypeColor();
            }
        }
    }

    /// <summary>
    /// Modified Panelclass to obtain the current Event
    /// </summary>
    public class EventPanel : Panel
    {
        public Event UsedEvent { get; set; }

        public EventPanel(Event ev)
        {
            this.UsedEvent = ev;
            this.BackColor = this.eventTypeColor();
        }


        public Color eventTypeColor()
        {
            switch (UsedEvent.Type)
            {
                case "lecture":
                    return Properties.Settings.Default.COLOR_LECTURES;
                case "exercise":
                    return Properties.Settings.Default.COLOR_EXERCISES;
                case "tutorial":
                    return Properties.Settings.Default.COLOR_TUTORIALS;
                case "internship":
                    return Properties.Settings.Default.COLOR_INTERNSHIPS;
                default:
                    return Color.White;
            }
        }
    }
}