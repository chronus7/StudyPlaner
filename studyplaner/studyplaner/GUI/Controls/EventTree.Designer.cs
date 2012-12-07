using System.Windows.Forms;
namespace Studyplaner.GUI.Controls
{
    partial class EventTree : TreeView
    {
        /// 
        /// summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EventTree
            // 
            this.FullRowSelect = true;
            this.LineColor = System.Drawing.Color.Black;
            this.ShowLines = false;
            this.ShowPlusMinus = false;
            this.ShowRootLines = false;
            this.ResumeLayout(false);

        }

        #endregion
    }
}
