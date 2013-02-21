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

            InitComboBox();
        }

        private void InitComboBox()
        {
            ushort[] uniIDs = UniversityManager.GetUniversities();
            University[] unis = new University[uniIDs.Length];

            for (int i = 0; i < uniIDs.Length; i++)
                unis[i] = UniversityManager.GetUniversity(uniIDs[i]);

            _cmBoxUni.DataSource = unis;
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
