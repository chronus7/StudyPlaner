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
            //this.BackColor = TODO: Wie Color setzen?
        }
    }
}
