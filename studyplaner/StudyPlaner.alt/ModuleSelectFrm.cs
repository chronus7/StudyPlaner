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
    public partial class ModuleSelectFrm : Form
    {
        private XMLParser _parser;

        public ModuleSelectFrm()
        {
            InitializeComponent();

            _parser = new XMLParser();     // maybe parser already initalized in MainFrm?!
            this.cmBoxModules.DataSource = _parser.getAllModules("001_UHH"); // has to be "dynamic"

            showData();
        }

        public void showData()
        {
            Module module = (Module) cmBoxModules.SelectedItem;
            // Lectures
            if (module.Lectures > 0)
            {
                this.lblLectures.Text = module.Lectures + " Vorlesung(en) vorhanden!";
            }
            else
            {
                this.lblLectures.Text = "Keine Vorlesung(en) vorhanden!";
            }
            // Exercises
            if (module.Exercises > 0)
            {
                this.lblExercises.Text = "Übungen:";
                this.cmBoxExercises.Visible = true;
                this.cmBoxExercises.DataSource = _parser.getAllEvents(module, "exercise");
            }
            else
            {
                this.cmBoxExercises.Visible = false;
                this.lblExercises.Text = "Keine Übung(en) vorhanden!";
            }
            // Tutorials
            if (module.Tutorials > 0)
            {
                this.lblTutorials.Text = "Tutorien:";
                this.cmBoxTutorials.Visible = true;
                this.cmBoxTutorials.DataSource = _parser.getAllEvents(module, "tutorial");
            }
            else
            {
                this.cmBoxTutorials.Visible = false;
                this.lblTutorials.Text = "Keine Tutorien vorhanden!";
            }
            // Internships
            if (module.Internships > 0)
            {
                this.lblInterships.Text = "Praktika:";
                this.cmBoxInternships.Visible = true;
                this.cmBoxInternships.DataSource = _parser.getAllEvents(module, "internship");
            }
            else
            {
                this.cmBoxInternships.Visible = false;
                this.lblInterships.Text = "Keine Praktika vorhanden!";
            }
        }

        private void cmBoxModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
