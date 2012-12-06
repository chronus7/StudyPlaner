using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Studyplaner.UniversityStuff;

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
            if ((node as HeadTreeNode) != null)
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
        public UniversityEvent UniEvent
        {
            get {
                return _uniEvent;
            }
            set {
                _uniEvent = value;
                this.Text = (value.LVNum == null) ? " > New Event" : value.LVNum; // TODO | dj | maybe ToString()...
            }
        }
        private UniversityEvent _uniEvent;

        public EventTreeNode(UniversityEvent ev)
        {
            UniEvent = ev;
        }
    }

    public class HeadTreeNode : TreeNode
    {
        public Studyplaner.UniversityStuff.EventType EventType
        {
            get {
                return _evType;
            }
            set {
                _evType = value;
                this.Text = value.ToString();
            }
        }
        private Studyplaner.UniversityStuff.EventType _evType;

        public HeadTreeNode(Studyplaner.UniversityStuff.EventType eventType)
        {
            EventType = eventType;
        }
    }
}
