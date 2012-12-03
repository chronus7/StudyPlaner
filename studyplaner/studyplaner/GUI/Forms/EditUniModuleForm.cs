using System;
using System.Windows.Forms;
using Studyplaner.GUI.Controls;
using Studyplaner.Materials.UniversityStuff;
using Studyplaner.Enums;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;

namespace Studyplaner.GUI.Forms
{
    public partial class EditUniModuleForm : Form
    {
        private UniversityModule _module;
        private bool _shortModified;
        private List<HeadTreeNode> _headNodes;

        public EditUniModuleForm()
        {
            InitializeComponent();
            Init();
            // TODO | dj | DYNAMIC!!!!!! - resize has to be implemented! -
            // TODO | dj | Tooltips for properties?!?
        }

        public EditUniModuleForm(UniversityModule module)
            : this()
        {
            this._module = module;
            this._shortModified = true;
            _txBoxName.Text = module.Name;
            _txBoxShort.Text = module.Short;
            _cmBoxSemester.SelectedItem = module.Semester;
            _cmBoxDepartment.SelectedItem = module.Department;
            buildTree();
        }

        private void Init()
        {
            _headNodes = new List<HeadTreeNode>();

            _cmBoxSemester.DataSource = Enum.GetValues(typeof(Semester));
            _cmBoxDepartment.DataSource = Enum.GetValues(typeof(Department));
            _cmBoxEventType.DataSource = Enum.GetValues(typeof(EventType));
            _cmBoxWeekInterval.DataSource = Enum.GetValues(typeof(WeekInterval));
        }

        // adds all UniEvents to the tree. Also their correspondending
        // type-nodes.
        private void buildTree()
        {
            foreach (UniversityEvent ev in _module.Events)
            {
                HeadTreeNode htn = null;
                foreach (HeadTreeNode htn2 in _headNodes)
                {
                    if (htn2.EventType == ev.Type)
                    {
                        htn = htn2;
                        break;
                    }
                }
                if (htn == null)
                {
                    htn = new HeadTreeNode(ev.Type);
                    _eventTree.Add(htn);
                }

                _headNodes.Add(htn);

                EventTreeNode etn = new EventTreeNode(ev);
                htn.Nodes.Add(etn);
            }
            _eventTree.Sort();
            _eventTree.ExpandAll();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            UniversityEvent ev = new UniversityEvent();
            EventTreeNode etn = new EventTreeNode(ev);
            _eventTree.Add(etn);
            _eventTree.SelectedNode = etn;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            EventTreeNode etn = _eventTree.SelectedNode as EventTreeNode;
            if (etn != null)
            {
                _eventTree.Nodes.Remove(etn);
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (!_shortModified)
            {
                string text = _txBoxName.Text;

                string[] strarr = text.Split(' ');
                string str = string.Empty;

                foreach (string s in strarr)
                {
                    if (s.Length > 0)
                        str += s[0];
                }

                _txBoxShort.Text = str;
            }
        }

        private void Short_TextChanged(object sender, KeyEventArgs e)
        {
            _shortModified = true;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            _txBoxName.Size = new Size(_lblShort.Location.X - _txBoxName.Location.X - 6, _txBoxName.Size.Height);
        }
    }
}
