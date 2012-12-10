using System.Windows.Forms;
using Studyplaner.UniversityStuff;

namespace Studyplaner.GUI.Forms
{
    public partial class UniversitySelectForm : Form
    {
        public University SelectedUniversity { get; private set; }

        public UniversitySelectForm()
        {
            InitializeComponent();
            // TODO | dj | init cmBox correctly
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void Continue_Click(object sender, System.EventArgs e)
        {
            SelectedUniversity = (University)_cmBoxUni.SelectedItem;
            this.Dispose();
        }
    }
}
