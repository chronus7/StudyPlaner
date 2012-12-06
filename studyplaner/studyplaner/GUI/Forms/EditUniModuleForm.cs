using System;
using System.Windows.Forms;
using Studyplaner.GUI.Controls;
using Studyplaner.UniversityStuff;
using Studyplaner.UniversityStuff;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;
using Studyplaner.Various;

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

            _panelEventData.Visible = false;
        }

        // adds all UniEvents to the tree. Also their corresponding
        // type-nodes.
        private void buildTree()
        {
            _headNodes.Clear();
            _eventTree.Nodes.Clear();

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

        private void EventTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((e.Node as HeadTreeNode) != null)
            {
                _panelEventData.Visible = false;
            }
            else
            {
                _panelEventData.Visible = true;
                emptyEventFields();
                if (e.Node.Parent != null)
                    showEventData((e.Node as EventTreeNode));
            }
        }

        private void emptyEventFields()
        {
            _txBoxLVNum.Clear();
            _txBoxLocation.Clear();
            _txBoxLecturer.Clear();
            _cmBoxEventType.SelectedIndex = 0;
            _cmBoxWeekInterval.SelectedIndex = 0;
            _dtPickerDate.Value = DateTime.Now;
            _dtPickerTime.Value = DateTime.Now;
            _dtPickerDuration.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 1, 30, 0);
            _trackBarImportance.Value = _trackBarImportance.Maximum;
            _ckBoxPower.Checked = false;
        }

        private void showEventData(EventTreeNode node)
        {
            UniversityEvent ev = node.UniEvent;
            _txBoxLVNum.Text = ev.LVNum;
            _cmBoxEventType.SelectedItem = ev.Type;
            _dtPickerDate.Value = ev.Date.Date;
            int a = ev.Date.Date.Year;
            int b = ev.Date.Date.Month;
            int c = ev.Date.Date.Day;
            _dtPickerTime.Value = new DateTime(a, b, c, ev.Date.Hours, ev.Date.Minutes, 0);
            _cmBoxWeekInterval.SelectedItem = ev.Date.WeekInterval;
            _dtPickerDuration.Value = new DateTime(a, b, c, ev.Duration.Hours, ev.Duration.Minutes, ev.Duration.Seconds);
            _txBoxLocation.Text = ev.Location;
            _txBoxLecturer.Text = ev.Lecturer;
            _trackBarImportance.Value = ev.Importance;
            _ckBoxPower.Checked = ev.Power;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            UniversityEvent ev = new UniversityEvent();
            EventTreeNode etn = new EventTreeNode(ev);
            _eventTree.Add(etn);
            _eventTree.Focus();
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

        private void CancelModule_Click(object sender, EventArgs e)
        {
            // TODO | dj | ask user wether really want to cancel or save modifications...
            this.Close();
        }

        // TODO | dj | implement module saving

        private void DiscardEvent_Click(object sender, EventArgs e)
        {
            if (_eventTree.SelectedNode.Parent == null)
                emptyEventFields();
            else
                showEventData((_eventTree.SelectedNode as EventTreeNode));
        }

        private void SaveEvent_Click(object sender, EventArgs e)
        {
            EventTreeNode etn = (_eventTree.SelectedNode as EventTreeNode);
            if (etn == null)
                return;

            UniversityEvent ev = etn.UniEvent;

            // security checks??

            string lvnum = _txBoxLVNum.Text;
            EventType type = (EventType)_cmBoxEventType.SelectedItem;
            DateTime startDateRAW = _dtPickerDate.Value;
            DateTime startTimeRAW = _dtPickerTime.Value;
            DateTime durationRAW = _dtPickerDuration.Value;
            WeekInterval weekInterval = (WeekInterval)_cmBoxWeekInterval.SelectedItem;
            string location = _txBoxLocation.Text;
            string lecturer = _txBoxLecturer.Text;
            int importance = _trackBarImportance.Value;
            bool power = _ckBoxPower.Checked;

            Time startTime = new Time((byte)startTimeRAW.Hour, (byte)startTimeRAW.Minute, startDateRAW, weekInterval);
            TimeSpan duration = new TimeSpan(durationRAW.Hour, durationRAW.Minute, 0);

            ev.LVNum = lvnum;
            ev.ModuleID = _module.ID;
            ev.Type = type;
            ev.Date = startTime;
            ev.Duration = duration;
            ev.Location = location;
            ev.Lecturer = lecturer;
            ev.Importance = (byte)importance;
            ev.Power = power;
            // ID won't be changed (only generated for new Events (below))

            //if it's a new Event
            if (etn.Parent == null)
            {
                // TODO | dj | Here should be the id-generator!!!
                ev.ID = new Random().Next(_trackBarImportance.Minimum, _trackBarImportance.Maximum);
                _module.Events.Add(ev);
            }

            buildTree();
        }
    }
}
