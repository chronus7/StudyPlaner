namespace Studyplaner.GUI.Forms
{
    partial class UniversitySelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblUni = new System.Windows.Forms.Label();
            this._cmBoxUni = new System.Windows.Forms.ComboBox();
            this._btnContinue = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblUni
            // 
            this._lblUni.AutoSize = true;
            this._lblUni.Location = new System.Drawing.Point(12, 15);
            this._lblUni.Name = "_lblUni";
            this._lblUni.Size = new System.Drawing.Size(53, 13);
            this._lblUni.TabIndex = 0;
            this._lblUni.Text = "University";
            // 
            // _cmBoxUni
            // 
            this._cmBoxUni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmBoxUni.FormattingEnabled = true;
            this._cmBoxUni.Location = new System.Drawing.Point(71, 12);
            this._cmBoxUni.Name = "_cmBoxUni";
            this._cmBoxUni.Size = new System.Drawing.Size(251, 21);
            this._cmBoxUni.TabIndex = 1;
            // 
            // _btnContinue
            // 
            this._btnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnContinue.Location = new System.Drawing.Point(247, 39);
            this._btnContinue.Name = "_btnContinue";
            this._btnContinue.Size = new System.Drawing.Size(75, 23);
            this._btnContinue.TabIndex = 2;
            this._btnContinue.Text = "Continue";
            this._btnContinue.UseVisualStyleBackColor = true;
            this._btnContinue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(166, 39);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // UniversitySelectForm
            // 
            this.AcceptButton = this._btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(334, 74);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnContinue);
            this.Controls.Add(this._cmBoxUni);
            this.Controls.Add(this._lblUni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UniversitySelectForm";
            this.Text = "Select university";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblUni;
        private System.Windows.Forms.ComboBox _cmBoxUni;
        private System.Windows.Forms.Button _btnContinue;
        private System.Windows.Forms.Button _btnCancel;
    }
}