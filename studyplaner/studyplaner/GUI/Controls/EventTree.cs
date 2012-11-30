using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Studyplaner.Materials.University;
using System.Drawing;

namespace Studyplaner.GUI.Controls
{
    public partial class EventTree : TreeView
    {
        private static readonly Font HEADERFONT = new Font(DefaultFont, FontStyle.Italic);

        public EventTree()
        {
            InitializeComponent();
        }

        public EventTree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Add(TreeNode node)
        {
            if ((node as EventTreeNode) == null)
                node.NodeFont = HEADERFONT;
            this.Nodes.Add(node);
            if (node.PrevVisibleNode != null)
                node.PrevVisibleNode.ExpandAll();
        }

        public void AddRange(TreeNode[] nodes)
        {
            foreach (TreeNode n in nodes)
                Add(n);
        }
    }

    public class EventTreeNode : TreeNode
    {
        public UniversityEvent UniEvent { get; set; }

        public EventTreeNode(UniversityEvent ev)
        {
            UniEvent = ev;
            Text = (ev.LVNum == null)? " > New Event" : ev.LVNum; // TODO | dj | maybe ToString()...
        }
    }
}
