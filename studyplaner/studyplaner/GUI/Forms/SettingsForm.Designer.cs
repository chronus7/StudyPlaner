namespace Studyplaner.GUI.Forms
{
    partial class SettingsForm
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
            this._mainPanel = new System.Windows.Forms.Panel();
            this._grpBoxEventSettings = new System.Windows.Forms.GroupBox();
            this._btnColorLecture = new System.Windows.Forms.Button();
            this._lblColorLecture = new System.Windows.Forms.Label();
            this._grpBoxGeneral = new System.Windows.Forms.GroupBox();
            this._txBoxDatapath = new System.Windows.Forms.TextBox();
            this._lblDatapath = new System.Windows.Forms.Label();
            this._ckBoxOutputFile = new System.Windows.Forms.CheckBox();
            this._ckBoxOutputConsole = new System.Windows.Forms.CheckBox();
            this._lblOutput = new System.Windows.Forms.Label();
            this._txBoxOutputFile = new System.Windows.Forms.TextBox();
            this._ckBoxLogging = new System.Windows.Forms.CheckBox();
            this._btnBgColor = new System.Windows.Forms.Button();
            this._lblBgColor = new System.Windows.Forms.Label();
            this._btnReset = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this._fileDialog = new System.Windows.Forms.SaveFileDialog();
            this._folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._btnColorExercises = new System.Windows.Forms.Button();
            this._lblColorExercises = new System.Windows.Forms.Label();
            this._btnColorInternships = new System.Windows.Forms.Button();
            this._lblColorInternships = new System.Windows.Forms.Label();
            this._btnColorTutorials = new System.Windows.Forms.Button();
            this._lblColorTutorials = new System.Windows.Forms.Label();
            this._btnColorCustoms = new System.Windows.Forms.Button();
            this._lblColorCustoms = new System.Windows.Forms.Label();
            this._mainPanel.SuspendLayout();
            this._grpBoxEventSettings.SuspendLayout();
            this._grpBoxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this._mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._mainPanel.Controls.Add(this._grpBoxEventSettings);
            this._mainPanel.Controls.Add(this._grpBoxGeneral);
            this._mainPanel.Controls.Add(this._btnReset);
            this._mainPanel.Controls.Add(this._btnCancel);
            this._mainPanel.Controls.Add(this._btnSave);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(10, 10);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(460, 287);
            this._mainPanel.TabIndex = 0;
            // 
            // _grpBoxEventSettings
            // 
            this._grpBoxEventSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpBoxEventSettings.Controls.Add(this._btnColorCustoms);
            this._grpBoxEventSettings.Controls.Add(this._lblColorCustoms);
            this._grpBoxEventSettings.Controls.Add(this._btnColorTutorials);
            this._grpBoxEventSettings.Controls.Add(this._lblColorTutorials);
            this._grpBoxEventSettings.Controls.Add(this._btnColorInternships);
            this._grpBoxEventSettings.Controls.Add(this._lblColorInternships);
            this._grpBoxEventSettings.Controls.Add(this._btnColorExercises);
            this._grpBoxEventSettings.Controls.Add(this._lblColorExercises);
            this._grpBoxEventSettings.Controls.Add(this._btnColorLecture);
            this._grpBoxEventSettings.Controls.Add(this._lblColorLecture);
            this._grpBoxEventSettings.Location = new System.Drawing.Point(3, 112);
            this._grpBoxEventSettings.Name = "_grpBoxEventSettings";
            this._grpBoxEventSettings.Size = new System.Drawing.Size(452, 141);
            this._grpBoxEventSettings.TabIndex = 6;
            this._grpBoxEventSettings.TabStop = false;
            this._grpBoxEventSettings.Text = "Events";
            // 
            // _btnColorLecture
            // 
            this._btnColorLecture.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnColorLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnColorLecture.Location = new System.Drawing.Point(105, 19);
            this._btnColorLecture.Name = "_btnColorLecture";
            this._btnColorLecture.Size = new System.Drawing.Size(20, 20);
            this._btnColorLecture.TabIndex = 3;
            this._btnColorLecture.UseVisualStyleBackColor = false;
            this._btnColorLecture.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // _lblColorLecture
            // 
            this._lblColorLecture.AutoSize = true;
            this._lblColorLecture.Location = new System.Drawing.Point(8, 23);
            this._lblColorLecture.Name = "_lblColorLecture";
            this._lblColorLecture.Size = new System.Drawing.Size(75, 13);
            this._lblColorLecture.TabIndex = 2;
            this._lblColorLecture.Text = "Color Lectures";
            // 
            // _grpBoxGeneral
            // 
            this._grpBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpBoxGeneral.Controls.Add(this._txBoxDatapath);
            this._grpBoxGeneral.Controls.Add(this._lblDatapath);
            this._grpBoxGeneral.Controls.Add(this._ckBoxOutputFile);
            this._grpBoxGeneral.Controls.Add(this._ckBoxOutputConsole);
            this._grpBoxGeneral.Controls.Add(this._lblOutput);
            this._grpBoxGeneral.Controls.Add(this._txBoxOutputFile);
            this._grpBoxGeneral.Controls.Add(this._ckBoxLogging);
            this._grpBoxGeneral.Controls.Add(this._btnBgColor);
            this._grpBoxGeneral.Controls.Add(this._lblBgColor);
            this._grpBoxGeneral.Location = new System.Drawing.Point(3, 3);
            this._grpBoxGeneral.Name = "_grpBoxGeneral";
            this._grpBoxGeneral.Size = new System.Drawing.Size(452, 103);
            this._grpBoxGeneral.TabIndex = 5;
            this._grpBoxGeneral.TabStop = false;
            this._grpBoxGeneral.Text = "General";
            // 
            // _txBoxDatapath
            // 
            this._txBoxDatapath.Location = new System.Drawing.Point(105, 70);
            this._txBoxDatapath.Name = "_txBoxDatapath";
            this._txBoxDatapath.Size = new System.Drawing.Size(341, 20);
            this._txBoxDatapath.TabIndex = 9;
            this._txBoxDatapath.Click += new System.EventHandler(this.Datapath_Click);
            // 
            // _lblDatapath
            // 
            this._lblDatapath.AutoSize = true;
            this._lblDatapath.Location = new System.Drawing.Point(8, 73);
            this._lblDatapath.Name = "_lblDatapath";
            this._lblDatapath.Size = new System.Drawing.Size(51, 13);
            this._lblDatapath.TabIndex = 8;
            this._lblDatapath.Text = "Datapath";
            // 
            // _ckBoxOutputFile
            // 
            this._ckBoxOutputFile.AutoSize = true;
            this._ckBoxOutputFile.Location = new System.Drawing.Point(219, 46);
            this._ckBoxOutputFile.Name = "_ckBoxOutputFile";
            this._ckBoxOutputFile.Size = new System.Drawing.Size(42, 17);
            this._ckBoxOutputFile.TabIndex = 7;
            this._ckBoxOutputFile.Text = "File";
            this._ckBoxOutputFile.UseVisualStyleBackColor = true;
            this._ckBoxOutputFile.Visible = false;
            this._ckBoxOutputFile.CheckedChanged += new System.EventHandler(this.OutputFile_CheckedChanged);
            // 
            // _ckBoxOutputConsole
            // 
            this._ckBoxOutputConsole.AutoSize = true;
            this._ckBoxOutputConsole.Location = new System.Drawing.Point(149, 46);
            this._ckBoxOutputConsole.Name = "_ckBoxOutputConsole";
            this._ckBoxOutputConsole.Size = new System.Drawing.Size(64, 17);
            this._ckBoxOutputConsole.TabIndex = 4;
            this._ckBoxOutputConsole.Text = "Console";
            this._ckBoxOutputConsole.UseVisualStyleBackColor = true;
            this._ckBoxOutputConsole.Visible = false;
            // 
            // _lblOutput
            // 
            this._lblOutput.AutoSize = true;
            this._lblOutput.Location = new System.Drawing.Point(102, 47);
            this._lblOutput.Name = "_lblOutput";
            this._lblOutput.Size = new System.Drawing.Size(42, 13);
            this._lblOutput.TabIndex = 6;
            this._lblOutput.Text = "Output:";
            this._lblOutput.Visible = false;
            // 
            // _txBoxOutputFile
            // 
            this._txBoxOutputFile.Location = new System.Drawing.Point(267, 44);
            this._txBoxOutputFile.Name = "_txBoxOutputFile";
            this._txBoxOutputFile.Size = new System.Drawing.Size(179, 20);
            this._txBoxOutputFile.TabIndex = 5;
            this._txBoxOutputFile.Visible = false;
            this._txBoxOutputFile.Click += new System.EventHandler(this.OutputFile_Click);
            // 
            // _ckBoxLogging
            // 
            this._ckBoxLogging.AutoSize = true;
            this._ckBoxLogging.Location = new System.Drawing.Point(6, 46);
            this._ckBoxLogging.Name = "_ckBoxLogging";
            this._ckBoxLogging.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._ckBoxLogging.Size = new System.Drawing.Size(64, 17);
            this._ckBoxLogging.TabIndex = 2;
            this._ckBoxLogging.Text = "Logging";
            this._ckBoxLogging.UseVisualStyleBackColor = true;
            this._ckBoxLogging.CheckedChanged += new System.EventHandler(this.Logging_CheckedChanged);
            // 
            // _btnBgColor
            // 
            this._btnBgColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnBgColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBgColor.Location = new System.Drawing.Point(105, 19);
            this._btnBgColor.Name = "_btnBgColor";
            this._btnBgColor.Size = new System.Drawing.Size(20, 20);
            this._btnBgColor.TabIndex = 1;
            this._btnBgColor.UseVisualStyleBackColor = false;
            this._btnBgColor.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // _lblBgColor
            // 
            this._lblBgColor.AutoSize = true;
            this._lblBgColor.Location = new System.Drawing.Point(8, 23);
            this._lblBgColor.Name = "_lblBgColor";
            this._lblBgColor.Size = new System.Drawing.Size(88, 13);
            this._lblBgColor.TabIndex = 0;
            this._lblBgColor.Text = "Backgroundcolor";
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(218, 259);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(75, 23);
            this._btnReset.TabIndex = 4;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this._btnCancel.Location = new System.Drawing.Point(380, 259);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(299, 259);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _colorDialog
            // 
            this._colorDialog.AnyColor = true;
            this._colorDialog.FullOpen = true;
            // 
            // _fileDialog
            // 
            this._fileDialog.CreatePrompt = true;
            this._fileDialog.DefaultExt = "log";
            this._fileDialog.FileName = "studyplaner.log";
            this._fileDialog.Filter = "LOG-Files|*.log|All Files|*.*";
            // 
            // _folderDialog
            // 
            this._folderDialog.Description = "Directory containing the important datafiles.";
            // 
            // _btnColorExercises
            // 
            this._btnColorExercises.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnColorExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnColorExercises.Location = new System.Drawing.Point(105, 45);
            this._btnColorExercises.Name = "_btnColorExercises";
            this._btnColorExercises.Size = new System.Drawing.Size(20, 20);
            this._btnColorExercises.TabIndex = 5;
            this._btnColorExercises.UseVisualStyleBackColor = false;
            this._btnColorExercises.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // _lblColorExercises
            // 
            this._lblColorExercises.AutoSize = true;
            this._lblColorExercises.Location = new System.Drawing.Point(8, 49);
            this._lblColorExercises.Name = "_lblColorExercises";
            this._lblColorExercises.Size = new System.Drawing.Size(79, 13);
            this._lblColorExercises.TabIndex = 4;
            this._lblColorExercises.Text = "Color Exercises";
            // 
            // _btnColorInternships
            // 
            this._btnColorInternships.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnColorInternships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnColorInternships.Location = new System.Drawing.Point(105, 71);
            this._btnColorInternships.Name = "_btnColorInternships";
            this._btnColorInternships.Size = new System.Drawing.Size(20, 20);
            this._btnColorInternships.TabIndex = 7;
            this._btnColorInternships.UseVisualStyleBackColor = false;
            this._btnColorInternships.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // _lblColorInternships
            // 
            this._lblColorInternships.AutoSize = true;
            this._lblColorInternships.Location = new System.Drawing.Point(8, 75);
            this._lblColorInternships.Name = "_lblColorInternships";
            this._lblColorInternships.Size = new System.Drawing.Size(85, 13);
            this._lblColorInternships.TabIndex = 6;
            this._lblColorInternships.Text = "Color Internships";
            // 
            // _btnColorTutorials
            // 
            this._btnColorTutorials.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnColorTutorials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnColorTutorials.Location = new System.Drawing.Point(241, 19);
            this._btnColorTutorials.Name = "_btnColorTutorials";
            this._btnColorTutorials.Size = new System.Drawing.Size(20, 20);
            this._btnColorTutorials.TabIndex = 9;
            this._btnColorTutorials.UseVisualStyleBackColor = false;
            this._btnColorTutorials.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // _lblColorTutorials
            // 
            this._lblColorTutorials.AutoSize = true;
            this._lblColorTutorials.Location = new System.Drawing.Point(144, 23);
            this._lblColorTutorials.Name = "_lblColorTutorials";
            this._lblColorTutorials.Size = new System.Drawing.Size(74, 13);
            this._lblColorTutorials.TabIndex = 8;
            this._lblColorTutorials.Text = "Color Tutorials";
            // 
            // _btnColorCustoms
            // 
            this._btnColorCustoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnColorCustoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnColorCustoms.Location = new System.Drawing.Point(241, 45);
            this._btnColorCustoms.Name = "_btnColorCustoms";
            this._btnColorCustoms.Size = new System.Drawing.Size(20, 20);
            this._btnColorCustoms.TabIndex = 11;
            this._btnColorCustoms.UseVisualStyleBackColor = false;
            this._btnColorCustoms.Click += new System.EventHandler(this.ChangeColorClick);
            // 
            // _lblColorCustoms
            // 
            this._lblColorCustoms.AutoSize = true;
            this._lblColorCustoms.Location = new System.Drawing.Point(144, 49);
            this._lblColorCustoms.Name = "_lblColorCustoms";
            this._lblColorCustoms.Size = new System.Drawing.Size(74, 13);
            this._lblColorCustoms.TabIndex = 10;
            this._lblColorCustoms.Text = "Color Customs";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 307);
            this.Controls.Add(this._mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this._mainPanel.ResumeLayout(false);
            this._grpBoxEventSettings.ResumeLayout(false);
            this._grpBoxEventSettings.PerformLayout();
            this._grpBoxGeneral.ResumeLayout(false);
            this._grpBoxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Label _lblBgColor;
        private System.Windows.Forms.Button _btnBgColor;
        private System.Windows.Forms.ColorDialog _colorDialog;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.GroupBox _grpBoxGeneral;
        private System.Windows.Forms.GroupBox _grpBoxEventSettings;
        private System.Windows.Forms.Button _btnColorLecture;
        private System.Windows.Forms.Label _lblColorLecture;
        private System.Windows.Forms.CheckBox _ckBoxLogging;
        private System.Windows.Forms.TextBox _txBoxOutputFile;
        private System.Windows.Forms.Label _lblOutput;
        private System.Windows.Forms.CheckBox _ckBoxOutputFile;
        private System.Windows.Forms.CheckBox _ckBoxOutputConsole;
        private System.Windows.Forms.SaveFileDialog _fileDialog;
        private System.Windows.Forms.TextBox _txBoxDatapath;
        private System.Windows.Forms.Label _lblDatapath;
        private System.Windows.Forms.FolderBrowserDialog _folderDialog;
        private System.Windows.Forms.Button _btnColorCustoms;
        private System.Windows.Forms.Label _lblColorCustoms;
        private System.Windows.Forms.Button _btnColorTutorials;
        private System.Windows.Forms.Label _lblColorTutorials;
        private System.Windows.Forms.Button _btnColorInternships;
        private System.Windows.Forms.Label _lblColorInternships;
        private System.Windows.Forms.Button _btnColorExercises;
        private System.Windows.Forms.Label _lblColorExercises;
    }
}