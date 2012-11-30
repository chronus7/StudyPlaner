using System;
using System.Windows.Forms;
using Studyplaner.GUI.Controls;
using Studyplaner.Materials.University;
using System.Text.RegularExpressions;

namespace Studyplaner.GUI.Forms
{
    public partial class EditUniModuleForm : Form
    {
        private bool _shortModified;

        public EditUniModuleForm()
        {
            InitializeComponent();
            Init();
            // TODO | dj | DYNAMIC!!!!!! - resize has to be implemented! -
        }

        private void Init()
        {
            _cmBoxSemester.DataSource = Enum.GetValues(typeof(Studyplaner.Enums.Semester));
            _cmBoxDepartment.DataSource = Enum.GetValues(typeof(Studyplaner.Enums.Department));

            #region NODETEST
            //TODO | dj | delete... (mock up)
            UniversityEvent ev = new UniversityEvent();
            ev.LVNum = "64-001";
            EventTreeNode t1 = new EventTreeNode(ev);
            TreeNode lectures = new TreeNode("Lectures", new TreeNode[] {t1});
            TreeNode exercises = new TreeNode("Exercises");
            TreeNode tutorials = new TreeNode("Tutorials");
            TreeNode internships = new TreeNode("Internships");
            _eventTree.AddRange(new TreeNode[]{ lectures, exercises, tutorials, internships });
            #endregion
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
    }
}
