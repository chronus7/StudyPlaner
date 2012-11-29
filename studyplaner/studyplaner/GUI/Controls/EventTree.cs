using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Studyplaner.Materials.Uni;

namespace Studyplaner.GUI.Controls
{
    public partial class EventTree : TreeView
    {
        public EventTree()
        {
            InitializeComponent();
        }

        public EventTree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

    public class EventTreeNode : TreeNode
    {
        public UniEvent UniEvent { get; set; }

        public EventTreeNode(UniEvent ev)
        {
            UniEvent = ev;
            Text = ev.LVNum; // TODO | dj | maybe ToString()...
        }
    }
}
