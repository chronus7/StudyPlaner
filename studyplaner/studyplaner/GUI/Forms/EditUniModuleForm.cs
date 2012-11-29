using System;
using System.Windows.Forms;
using Studyplaner.GUI.Controls;
using Studyplaner.Materials.Uni;

namespace Studyplaner.GUI.Forms
{
    public partial class EditUniModuleForm : Form
    {
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
            UniEvent ev = new UniEvent();
            ev.LVNum = "64-001";
            EventTreeNode t1 = new EventTreeNode(ev);
            TreeNode lectures = new TreeNode("Lectures", new TreeNode[] {t1});
            TreeNode exercises = new TreeNode("Exercises");
            TreeNode tutorials = new TreeNode("Tutorials");
            TreeNode internships = new TreeNode("Internships");
            _eventTree.Nodes.AddRange(new TreeNode[]{ lectures, exercises, tutorials, internships });
            #endregion
        }
    }
}
