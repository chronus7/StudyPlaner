using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Studyplaner.Materials.University;

namespace Studyplaner.GUI.Controls
{
    public partial class EventTree : TreeView
    {
        public EventTree()
        {
            InitializeComponent();
            Init();
        }

        public EventTree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.DrawNode += new DrawTreeNodeEventHandler(DrawNodeEvent);
        }

        void DrawNodeEvent(object sender, DrawTreeNodeEventArgs e)
        {
            if (e != null)
                e.Node.PrevVisibleNode.ExpandAll();
        }
    }

    public class EventTreeNode : TreeNode
    {
        public UniversityEvent UniEvent { get; set; }

        public EventTreeNode(UniversityEvent ev)
        {
            UniEvent = ev;
            Text = ev.LVNum; // TODO | dj | maybe ToString()...
        }
    }
}
