using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudyPlaner
{
    public partial class ModuleEditFrm : Form
    {
        private Module _module;
        private bool _existing = false;
        private XMLParser _parser = new XMLParser();

        public ModuleEditFrm()
        {
            InitializeComponent();
            InitializeCmBoxes();
            _existing = false;

            Initialize();
        }

        public ModuleEditFrm(Module module)
        {
            InitializeComponent();
            InitializeCmBoxes();
            _module = module;
            _existing = true;

            Initialize();
        }

        private void InitializeCmBoxes()
        {
            cmBoxLecturesDay.DataSource = (GermanDay[])Enum.GetValues(typeof(GermanDay));
            cmBoxExercisesDay.DataSource = (GermanDay[])Enum.GetValues(typeof(GermanDay));
            cmBoxTutorialsDay.DataSource = (GermanDay[])Enum.GetValues(typeof(GermanDay));
            cmBoxInternshipsDay.DataSource = (GermanDay[])Enum.GetValues(typeof(GermanDay));
        }

        private void Initialize()
        {

            if (_existing)
            {
                ckBoxLectures.Checked = _module.Lectures > 0;
                ckBoxExercises.Checked = _module.Exercises > 0;
                ckBoxTutorials.Checked = _module.Tutorials > 0;
                ckBoxInterships.Checked = _module.Internships > 0; 
                
                txBoxID.Text = _module.ID;
                txBoxName.Text = _module.Name;

                btnConfirm.Enabled = true;
                btnConfirm.Text = "Modul ändern";

                this.Text = "Modul bearbeiten";
            }
            else
            {
                ckBoxLectures.Checked = false;
                ckBoxExercises.Checked = false;
                ckBoxTutorials.Checked = false;
                ckBoxInterships.Checked = false; 
                
                txBoxName.Text = "";
                
                btnConfirm.Text = "Modul erstellen";
                btnConfirm.Enabled = false;
                if (txBoxID.Text != "")
                {
                    btnConfirm.Enabled = true;
                }

                tControl.TabPages.Remove(tPage2);
                tControl.TabPages.Remove(tPage3);
                tControl.TabPages.Remove(tPage4);
                tControl.TabPages.Remove(tPage5);

                this.Text = "Modul erstellen";
            }
        }

        private void UpdatePages()
        {
            #region Page: Lectures
            if (ckBoxLectures.Checked)
            {
                if (_existing)
                {
                    Event[] lectures = _module.EventsOfType("lecture").ToArray();
                    if (lectures.Length > 0)
                    {
                        lBoxLectures.Items.Clear();
                        lBoxLectures.Items.AddRange(lectures);
                        lBoxLectures.SelectedIndex = 0;
                        ContainerLectures.Visible = true;
                        tPage2.Refresh();
                        UpdateLectures();
                    }
                }
                else
                {
                    lBoxLectures.Items.Clear();
                    ContainerLectures.Visible = false;
                    this.Refresh();
                }
            }
            #endregion
            
            #region Page: Exercises
            if (ckBoxExercises.Checked)
            {
                if (_existing)
                {
                    Event[] exercises = _module.EventsOfType("exercise").ToArray();
                    if (exercises.Length > 0)
                    {
                        lBoxExercises.Items.Clear();
                        lBoxExercises.Items.AddRange(exercises);
                        lBoxExercises.SelectedIndex = 0;
                        ContainerExercises.Visible = true;
                        tPage3.Refresh();
                        UpdateExercises();
                    }
                }
                else
                {
                    lBoxExercises.Items.Clear();
                    ContainerExercises.Visible = false;
                    this.Refresh();
                }
            }
            #endregion
            
            #region Page: Tutorials
            if (ckBoxTutorials.Checked)
            {
                if (_existing)
                {
                    Event[] tutorials = _module.EventsOfType("tutorial").ToArray();
                    if (tutorials.Length > 0)
                    {
                        lBoxTutorials.Items.Clear();
                        lBoxTutorials.Items.AddRange(tutorials);
                        lBoxTutorials.SelectedIndex = 0;
                        ContainerTutorials.Visible = true;
                        tPage4.Refresh();
                        UpdateTutorials();
                    }
                }
                else
                {
                    lBoxTutorials.Items.Clear();
                    ContainerTutorials.Visible = false;
                    //this.Refresh(); ???
                    UpdateTutorials();
                }
            }
            #endregion

            #region Page: Internships
            if (ckBoxInterships.Checked)
            {
                if (_existing)
                {
                    Event[] internships = _module.EventsOfType("internship").ToArray();
                    if (internships.Length > 0)
                    {
                        lBoxInternships.Items.Clear();
                        lBoxInternships.Items.AddRange(internships);
                        lBoxInternships.SelectedIndex = 0;
                        ContainerInternships.Visible = true;
                        tPage5.Refresh();
                        UpdateInternships();
                    }
                }
                else
                {
                    lBoxInternships.Items.Clear();
                    ContainerInternships.Visible = false;
                    UpdateInternships();
                }
            }
            #endregion
        }

        #region ## UpdatePages() ##

        private void UpdateLectures()
        {
            // selected event
            Event sEvent = (Event)lBoxLectures.SelectedItem;

            if (sEvent != null)
            {
                txBoxLecturesLV.Text = sEvent.ID.Split('_')[0];     // != Event.ID <- important for saving
                cmBoxLecturesDay.SelectedItem = sEvent.Day;
                txBoxLecturesTime1.Text = sEvent.Time.Split(',')[0];
                txBoxLecturesTime2.Text = sEvent.Time.Split(',')[1];
                txBoxLecturesLocation.Text = sEvent.Location;
                tBarLecturesImportance.Value = sEvent.Importance;
                numLecturesImportance.Value = sEvent.Importance;
                ckBoxLecturesPower.Checked = Convert.ToBoolean(sEvent.Power);
            }
        }

        private void UpdateExercises()
        {
            // selected event
            Event sEvent = (Event)lBoxExercises.SelectedItem;

            if (sEvent != null)
            {
                txBoxExercisesLV.Text = sEvent.ID.Split('_')[0];     // != Event.ID <- important for saving
                cmBoxExercisesDay.SelectedItem = sEvent.Day;
                txBoxExercisesTime1.Text = sEvent.Time.Split(',')[0];
                txBoxExercisesTime2.Text = sEvent.Time.Split(',')[1];
                txBoxExercisesLocation.Text = sEvent.Location;
                tBarExercisesImportance.Value = sEvent.Importance;
                numExercisesImportance.Value = sEvent.Importance;
                ckBoxExercisesPower.Checked = Convert.ToBoolean(sEvent.Power);
            }
        }

        private void UpdateTutorials()
        {
            // selected event
            Event sEvent = (Event)lBoxTutorials.SelectedItem;

            if (sEvent != null)
            {
                txBoxTutorialsLV.Text = sEvent.ID.Split('_')[0];     // != Event.ID <- important for saving
                cmBoxTutorialsDay.SelectedItem = sEvent.Day;
                txBoxTutorialsTime1.Text = sEvent.Time.Split(',')[0];
                txBoxTutorialsTime2.Text = sEvent.Time.Split(',')[1];
                txBoxTutorialsLocation.Text = sEvent.Location;
                tBarTutorialsImportance.Value = sEvent.Importance;
                numTutorialsImportance.Value = sEvent.Importance;
                ckBoxTutorialsPower.Checked = Convert.ToBoolean(sEvent.Power);
            }
        }

        private void UpdateInternships()
        {
            // selected event
            Event sEvent = (Event)lBoxInternships.SelectedItem;

            if (sEvent != null)
            {
                txBoxInternshipsLV.Text = sEvent.ID.Split('_')[0];     // != Event.ID <- important for saving
                cmBoxInternshipsDay.SelectedItem = sEvent.Day;
                txBoxInternshipsTime1.Text = sEvent.Time.Split(',')[0];
                txBoxInternshipsTime2.Text = sEvent.Time.Split(',')[1];
                txBoxInternshipsLocation.Text = sEvent.Location;
                tBarInternshipsImportance.Value = sEvent.Importance;
                numInternshipsImportance.Value = sEvent.Importance;
                ckBoxInternshipsPower.Checked = Convert.ToBoolean(sEvent.Power);
            }
        }

        #endregion


        private void ckBoxBools_Change(object sender, EventArgs e)
        {
            AddRemovePageFromCheckBox(ckBoxLectures);
            AddRemovePageFromCheckBox(ckBoxExercises);
            AddRemovePageFromCheckBox(ckBoxTutorials);
            AddRemovePageFromCheckBox(ckBoxInterships);
        }

        private void txBoxID_Change(object sender, EventArgs e)
        {
            Module module = _parser.getModule(txBoxID.Text);

            if (module != null)
            {
                _module = module;
                _existing = true;
                Initialize();
            }
            else
            {
                _module = new Module();
                _module.Uni = "001_UHH";        // dynamic
                _module.Region = "Informatik";  // ---"---
                _module.Semester = "Winter";    // ---"---
                _existing = false;
                Initialize();
            }
        }

        private void trBarLecturesImportance_Scroll(object sender, EventArgs e)
        {
            numLecturesImportance.Value = tBarLecturesImportance.Value;
        }

        private void numUDLecturesImportance_ValueChanged(object sender, EventArgs e)
        {
            tBarLecturesImportance.Value = Convert.ToInt32(numLecturesImportance.Value);
        }

        #region ## lBoxEvent_SelextedIndexChanged(...) ##
        
        private void lBoxLectures_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLectures();
        }

        private void lBoxExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExercises();
        }

        private void lBoxTutorials_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTutorials();
        }

        private void lBoxInternships_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInternships();
        }
        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Modul speichern und Form beenden
            if (txBoxName.Text != "")
            {
                try
                {
                    _module.ID = txBoxID.Text;
                    _module.Name = txBoxName.Text;
                    _module.Short = txBoxShort.Text;
                    // further information!!!

                    if (_existing)
                    {
                        _parser.updateModule(_module);
                    }
                    else
                    {
                        _parser.writeModule(_module);
                    }
                    _parser.updateXML();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten. Bitte kontrollieren Sie ihre Eingaben noch einmal.", "Fehler!", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (MessageBox.Show("Es wurden notwendige Felder nicht ausgefüllt.", "Unvollständiges Formular", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    txBoxName.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Änderungen gehen verloren!", "Möchten Sie wirklich abbrechen?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        // ===== HELPMETHODS ===== //

        private void AddRemovePageFromCheckBox(CheckBox box)
        {
            TabPage page;
            if (!(box.Tag is String))
                throw new ArgumentException("The given CheckBox had no String-Tag", "box");

            switch ((string)(box.Tag))
            {
                case "Lectures":
                    page = tPage2;
                    break;
                case "Exercises":
                    page = tPage3;
                    break;
                case "Tutorials":
                    page = tPage4;
                    break;
                case "Internships":
                    page = tPage5;
                    break;
                default:
                    page = null;        // eventuell unnötig
                    break;
            }

            if (page != null)
            {
                if (box.Checked)
                {
                    UpdatePages();
                    if (!tControl.TabPages.Contains(page))
                    {
                        tControl.TabPages.Remove(tPage6);       // anpassen: tabPage passend einfügen
                        tControl.TabPages.Add(page);
                        tControl.TabPages.Add(tPage6);
                        
                    }
                }
                else if (tControl.TabPages.Contains(page))
                {
                        tControl.TabPages.Remove(page);
                }
            }
        }
    }
}