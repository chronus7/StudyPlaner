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
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this._fileDialog = new System.Windows.Forms.SaveFileDialog();
            this._folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._tabCtrl = new System.Windows.Forms.TabControl();
            this._tabPg_general = new System.Windows.Forms.TabPage();
            this._txBox_datapath = new System.Windows.Forms.TextBox();
            this._lbl_datapath = new System.Windows.Forms.Label();
            this._tabPg_colors = new System.Windows.Forms.TabPage();
            this._btn_colorCustoms = new System.Windows.Forms.Button();
            this._lbl_colorCustoms = new System.Windows.Forms.Label();
            this._btn_colorInternships = new System.Windows.Forms.Button();
            this._lbl_colorInternships = new System.Windows.Forms.Label();
            this._btn_colorTutorials = new System.Windows.Forms.Button();
            this._lbl_colorTutorials = new System.Windows.Forms.Label();
            this._btn_colorExercises = new System.Windows.Forms.Button();
            this._lbl_colorExercises = new System.Windows.Forms.Label();
            this._btn_colorLectures = new System.Windows.Forms.Button();
            this._lbl_colorLectures = new System.Windows.Forms.Label();
            this._btn_colorBG = new System.Windows.Forms.Button();
            this._lbl_colorBG = new System.Windows.Forms.Label();
            this._tabPg_logging = new System.Windows.Forms.TabPage();
            this._chkBox_writetime = new System.Windows.Forms.CheckBox();
            this._txBox_loggingpath = new System.Windows.Forms.TextBox();
            this._lbl_loggingpath = new System.Windows.Forms.Label();
            this._chkBox_toFile = new System.Windows.Forms.CheckBox();
            this._lbl_target = new System.Windows.Forms.Label();
            this._chkBox_toConsole = new System.Windows.Forms.CheckBox();
            this._chkBox_logging = new System.Windows.Forms.CheckBox();
            this._panel_bottom = new System.Windows.Forms.Panel();
            this._btn_confirm = new System.Windows.Forms.Button();
            this._btn_cancel = new System.Windows.Forms.Button();
            this._btn_reset = new System.Windows.Forms.Button();
            this._tabCtrl.SuspendLayout();
            this._tabPg_general.SuspendLayout();
            this._tabPg_colors.SuspendLayout();
            this._tabPg_logging.SuspendLayout();
            this._panel_bottom.SuspendLayout();
            this.SuspendLayout();
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
            // _tabCtrl
            // 
            this._tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabCtrl.Controls.Add(this._tabPg_general);
            this._tabCtrl.Controls.Add(this._tabPg_colors);
            this._tabCtrl.Controls.Add(this._tabPg_logging);
            this._tabCtrl.Location = new System.Drawing.Point(13, 13);
            this._tabCtrl.Name = "_tabCtrl";
            this._tabCtrl.SelectedIndex = 0;
            this._tabCtrl.Size = new System.Drawing.Size(454, 245);
            this._tabCtrl.TabIndex = 0;
            // 
            // _tabPg_general
            // 
            this._tabPg_general.Controls.Add(this._txBox_datapath);
            this._tabPg_general.Controls.Add(this._lbl_datapath);
            this._tabPg_general.Location = new System.Drawing.Point(4, 22);
            this._tabPg_general.Name = "_tabPg_general";
            this._tabPg_general.Padding = new System.Windows.Forms.Padding(3);
            this._tabPg_general.Size = new System.Drawing.Size(446, 219);
            this._tabPg_general.TabIndex = 0;
            this._tabPg_general.Text = "General";
            this._tabPg_general.UseVisualStyleBackColor = true;
            // 
            // _txBox_datapath
            // 
            this._txBox_datapath.Location = new System.Drawing.Point(63, 6);
            this._txBox_datapath.Name = "_txBox_datapath";
            this._txBox_datapath.Size = new System.Drawing.Size(377, 20);
            this._txBox_datapath.TabIndex = 1;
            // 
            // _lbl_datapath
            // 
            this._lbl_datapath.AutoSize = true;
            this._lbl_datapath.Location = new System.Drawing.Point(6, 9);
            this._lbl_datapath.Name = "_lbl_datapath";
            this._lbl_datapath.Size = new System.Drawing.Size(51, 13);
            this._lbl_datapath.TabIndex = 0;
            this._lbl_datapath.Text = "Datapath";
            // 
            // _tabPg_colors
            // 
            this._tabPg_colors.Controls.Add(this._btn_colorCustoms);
            this._tabPg_colors.Controls.Add(this._lbl_colorCustoms);
            this._tabPg_colors.Controls.Add(this._btn_colorInternships);
            this._tabPg_colors.Controls.Add(this._lbl_colorInternships);
            this._tabPg_colors.Controls.Add(this._btn_colorTutorials);
            this._tabPg_colors.Controls.Add(this._lbl_colorTutorials);
            this._tabPg_colors.Controls.Add(this._btn_colorExercises);
            this._tabPg_colors.Controls.Add(this._lbl_colorExercises);
            this._tabPg_colors.Controls.Add(this._btn_colorLectures);
            this._tabPg_colors.Controls.Add(this._lbl_colorLectures);
            this._tabPg_colors.Controls.Add(this._btn_colorBG);
            this._tabPg_colors.Controls.Add(this._lbl_colorBG);
            this._tabPg_colors.Location = new System.Drawing.Point(4, 22);
            this._tabPg_colors.Name = "_tabPg_colors";
            this._tabPg_colors.Padding = new System.Windows.Forms.Padding(3);
            this._tabPg_colors.Size = new System.Drawing.Size(446, 219);
            this._tabPg_colors.TabIndex = 1;
            this._tabPg_colors.Text = "Colours";
            this._tabPg_colors.UseVisualStyleBackColor = true;
            // 
            // _btn_colorCustoms
            // 
            this._btn_colorCustoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorCustoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorCustoms.Location = new System.Drawing.Point(77, 167);
            this._btn_colorCustoms.Name = "_btn_colorCustoms";
            this._btn_colorCustoms.Size = new System.Drawing.Size(23, 23);
            this._btn_colorCustoms.TabIndex = 11;
            this._btn_colorCustoms.UseVisualStyleBackColor = true;
            this._btn_colorCustoms.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // _lbl_colorCustoms
            // 
            this._lbl_colorCustoms.AutoSize = true;
            this._lbl_colorCustoms.Location = new System.Drawing.Point(6, 172);
            this._lbl_colorCustoms.Name = "_lbl_colorCustoms";
            this._lbl_colorCustoms.Size = new System.Drawing.Size(47, 13);
            this._lbl_colorCustoms.TabIndex = 10;
            this._lbl_colorCustoms.Text = "Customs";
            // 
            // _btn_colorInternships
            // 
            this._btn_colorInternships.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorInternships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorInternships.Location = new System.Drawing.Point(77, 109);
            this._btn_colorInternships.Name = "_btn_colorInternships";
            this._btn_colorInternships.Size = new System.Drawing.Size(23, 23);
            this._btn_colorInternships.TabIndex = 9;
            this._btn_colorInternships.UseVisualStyleBackColor = true;
            this._btn_colorInternships.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // _lbl_colorInternships
            // 
            this._lbl_colorInternships.AutoSize = true;
            this._lbl_colorInternships.Location = new System.Drawing.Point(6, 114);
            this._lbl_colorInternships.Name = "_lbl_colorInternships";
            this._lbl_colorInternships.Size = new System.Drawing.Size(58, 13);
            this._lbl_colorInternships.TabIndex = 8;
            this._lbl_colorInternships.Text = "Internships";
            // 
            // _btn_colorTutorials
            // 
            this._btn_colorTutorials.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorTutorials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorTutorials.Location = new System.Drawing.Point(77, 138);
            this._btn_colorTutorials.Name = "_btn_colorTutorials";
            this._btn_colorTutorials.Size = new System.Drawing.Size(23, 23);
            this._btn_colorTutorials.TabIndex = 7;
            this._btn_colorTutorials.UseVisualStyleBackColor = true;
            this._btn_colorTutorials.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // _lbl_colorTutorials
            // 
            this._lbl_colorTutorials.AutoSize = true;
            this._lbl_colorTutorials.Location = new System.Drawing.Point(6, 143);
            this._lbl_colorTutorials.Name = "_lbl_colorTutorials";
            this._lbl_colorTutorials.Size = new System.Drawing.Size(47, 13);
            this._lbl_colorTutorials.TabIndex = 6;
            this._lbl_colorTutorials.Text = "Tutorials";
            // 
            // _btn_colorExercises
            // 
            this._btn_colorExercises.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorExercises.Location = new System.Drawing.Point(77, 80);
            this._btn_colorExercises.Name = "_btn_colorExercises";
            this._btn_colorExercises.Size = new System.Drawing.Size(23, 23);
            this._btn_colorExercises.TabIndex = 5;
            this._btn_colorExercises.UseVisualStyleBackColor = true;
            this._btn_colorExercises.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // _lbl_colorExercises
            // 
            this._lbl_colorExercises.AutoSize = true;
            this._lbl_colorExercises.Location = new System.Drawing.Point(6, 85);
            this._lbl_colorExercises.Name = "_lbl_colorExercises";
            this._lbl_colorExercises.Size = new System.Drawing.Size(52, 13);
            this._lbl_colorExercises.TabIndex = 4;
            this._lbl_colorExercises.Text = "Exercises";
            // 
            // _btn_colorLectures
            // 
            this._btn_colorLectures.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorLectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorLectures.Location = new System.Drawing.Point(77, 51);
            this._btn_colorLectures.Name = "_btn_colorLectures";
            this._btn_colorLectures.Size = new System.Drawing.Size(23, 23);
            this._btn_colorLectures.TabIndex = 3;
            this._btn_colorLectures.UseVisualStyleBackColor = true;
            this._btn_colorLectures.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // _lbl_colorLectures
            // 
            this._lbl_colorLectures.AutoSize = true;
            this._lbl_colorLectures.Location = new System.Drawing.Point(6, 56);
            this._lbl_colorLectures.Name = "_lbl_colorLectures";
            this._lbl_colorLectures.Size = new System.Drawing.Size(48, 13);
            this._lbl_colorLectures.TabIndex = 2;
            this._lbl_colorLectures.Text = "Lectures";
            // 
            // _btn_colorBG
            // 
            this._btn_colorBG.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorBG.Location = new System.Drawing.Point(77, 6);
            this._btn_colorBG.Name = "_btn_colorBG";
            this._btn_colorBG.Size = new System.Drawing.Size(23, 23);
            this._btn_colorBG.TabIndex = 1;
            this._btn_colorBG.UseVisualStyleBackColor = true;
            this._btn_colorBG.Click += new System.EventHandler(this.ChooseBackground_Click);
            // 
            // _lbl_colorBG
            // 
            this._lbl_colorBG.AutoSize = true;
            this._lbl_colorBG.Location = new System.Drawing.Point(6, 11);
            this._lbl_colorBG.Name = "_lbl_colorBG";
            this._lbl_colorBG.Size = new System.Drawing.Size(65, 13);
            this._lbl_colorBG.TabIndex = 0;
            this._lbl_colorBG.Text = "Background";
            // 
            // _tabPg_logging
            // 
            this._tabPg_logging.Controls.Add(this._chkBox_writetime);
            this._tabPg_logging.Controls.Add(this._txBox_loggingpath);
            this._tabPg_logging.Controls.Add(this._lbl_loggingpath);
            this._tabPg_logging.Controls.Add(this._chkBox_toFile);
            this._tabPg_logging.Controls.Add(this._lbl_target);
            this._tabPg_logging.Controls.Add(this._chkBox_toConsole);
            this._tabPg_logging.Controls.Add(this._chkBox_logging);
            this._tabPg_logging.Location = new System.Drawing.Point(4, 22);
            this._tabPg_logging.Name = "_tabPg_logging";
            this._tabPg_logging.Size = new System.Drawing.Size(446, 219);
            this._tabPg_logging.TabIndex = 2;
            this._tabPg_logging.Text = "Logging";
            this._tabPg_logging.UseVisualStyleBackColor = true;
            // 
            // _chkBox_writetime
            // 
            this._chkBox_writetime.AutoSize = true;
            this._chkBox_writetime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._chkBox_writetime.Location = new System.Drawing.Point(3, 95);
            this._chkBox_writetime.Name = "_chkBox_writetime";
            this._chkBox_writetime.Size = new System.Drawing.Size(96, 17);
            this._chkBox_writetime.TabIndex = 7;
            this._chkBox_writetime.Text = "Log time          ";
            this._chkBox_writetime.UseVisualStyleBackColor = true;
            this._chkBox_writetime.CheckedChanged += new System.EventHandler(this.WriteTime_CheckedChanged);
            // 
            // _txBox_loggingpath
            // 
            this._txBox_loggingpath.Cursor = System.Windows.Forms.Cursors.Hand;
            this._txBox_loggingpath.Location = new System.Drawing.Point(136, 71);
            this._txBox_loggingpath.Name = "_txBox_loggingpath";
            this._txBox_loggingpath.Size = new System.Drawing.Size(307, 20);
            this._txBox_loggingpath.TabIndex = 6;
            this._txBox_loggingpath.Click += new System.EventHandler(this.LogPath_Click);
            // 
            // _lbl_loggingpath
            // 
            this._lbl_loggingpath.AutoSize = true;
            this._lbl_loggingpath.Location = new System.Drawing.Point(101, 74);
            this._lbl_loggingpath.Name = "_lbl_loggingpath";
            this._lbl_loggingpath.Size = new System.Drawing.Size(29, 13);
            this._lbl_loggingpath.TabIndex = 5;
            this._lbl_loggingpath.Text = "Path";
            // 
            // _chkBox_toFile
            // 
            this._chkBox_toFile.AutoSize = true;
            this._chkBox_toFile.Location = new System.Drawing.Point(85, 54);
            this._chkBox_toFile.Name = "_chkBox_toFile";
            this._chkBox_toFile.Size = new System.Drawing.Size(42, 17);
            this._chkBox_toFile.TabIndex = 4;
            this._chkBox_toFile.Text = "File";
            this._chkBox_toFile.UseVisualStyleBackColor = true;
            this._chkBox_toFile.CheckedChanged += new System.EventHandler(this.ToFile_CheckedChanged);
            // 
            // _lbl_target
            // 
            this._lbl_target.AutoSize = true;
            this._lbl_target.Location = new System.Drawing.Point(3, 32);
            this._lbl_target.Name = "_lbl_target";
            this._lbl_target.Size = new System.Drawing.Size(38, 13);
            this._lbl_target.TabIndex = 3;
            this._lbl_target.Text = "Target";
            // 
            // _chkBox_toConsole
            // 
            this._chkBox_toConsole.AutoSize = true;
            this._chkBox_toConsole.Location = new System.Drawing.Point(85, 31);
            this._chkBox_toConsole.Name = "_chkBox_toConsole";
            this._chkBox_toConsole.Size = new System.Drawing.Size(64, 17);
            this._chkBox_toConsole.TabIndex = 2;
            this._chkBox_toConsole.Text = "Console";
            this._chkBox_toConsole.UseVisualStyleBackColor = true;
            this._chkBox_toConsole.CheckedChanged += new System.EventHandler(this.ToConsole_CheckedChanged);
            // 
            // _chkBox_logging
            // 
            this._chkBox_logging.AutoSize = true;
            this._chkBox_logging.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._chkBox_logging.Location = new System.Drawing.Point(3, 8);
            this._chkBox_logging.Name = "_chkBox_logging";
            this._chkBox_logging.Size = new System.Drawing.Size(96, 17);
            this._chkBox_logging.TabIndex = 1;
            this._chkBox_logging.Text = "Enable logging";
            this._chkBox_logging.UseVisualStyleBackColor = true;
            this._chkBox_logging.CheckedChanged += new System.EventHandler(this.EnableLogging_CheckedChanged);
            // 
            // _panel_bottom
            // 
            this._panel_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panel_bottom.BackColor = System.Drawing.SystemColors.Control;
            this._panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panel_bottom.Controls.Add(this._btn_reset);
            this._panel_bottom.Controls.Add(this._btn_confirm);
            this._panel_bottom.Controls.Add(this._btn_cancel);
            this._panel_bottom.Location = new System.Drawing.Point(13, 264);
            this._panel_bottom.Name = "_panel_bottom";
            this._panel_bottom.Size = new System.Drawing.Size(454, 30);
            this._panel_bottom.TabIndex = 1;
            // 
            // _btn_confirm
            // 
            this._btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_confirm.Location = new System.Drawing.Point(293, 3);
            this._btn_confirm.Name = "_btn_confirm";
            this._btn_confirm.Size = new System.Drawing.Size(75, 22);
            this._btn_confirm.TabIndex = 1;
            this._btn_confirm.Text = "Confirm";
            this._btn_confirm.UseVisualStyleBackColor = true;
            this._btn_confirm.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // _btn_cancel
            // 
            this._btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_cancel.Location = new System.Drawing.Point(374, 3);
            this._btn_cancel.Name = "_btn_cancel";
            this._btn_cancel.Size = new System.Drawing.Size(75, 22);
            this._btn_cancel.TabIndex = 0;
            this._btn_cancel.Text = "Cancel";
            this._btn_cancel.UseVisualStyleBackColor = true;
            this._btn_cancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // _btn_reset
            // 
            this._btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_reset.Location = new System.Drawing.Point(3, 3);
            this._btn_reset.Name = "_btn_reset";
            this._btn_reset.Size = new System.Drawing.Size(75, 22);
            this._btn_reset.TabIndex = 2;
            this._btn_reset.Text = "Reset";
            this._btn_reset.UseVisualStyleBackColor = true;
            this._btn_reset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 307);
            this.Controls.Add(this._panel_bottom);
            this.Controls.Add(this._tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this._tabCtrl.ResumeLayout(false);
            this._tabPg_general.ResumeLayout(false);
            this._tabPg_general.PerformLayout();
            this._tabPg_colors.ResumeLayout(false);
            this._tabPg_colors.PerformLayout();
            this._tabPg_logging.ResumeLayout(false);
            this._tabPg_logging.PerformLayout();
            this._panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog _colorDialog;
        private System.Windows.Forms.SaveFileDialog _fileDialog;
        private System.Windows.Forms.FolderBrowserDialog _folderDialog;
        private System.Windows.Forms.TabControl _tabCtrl;
        private System.Windows.Forms.TabPage _tabPg_general;
        private System.Windows.Forms.TabPage _tabPg_colors;
        private System.Windows.Forms.TabPage _tabPg_logging;
        private System.Windows.Forms.TextBox _txBox_datapath;
        private System.Windows.Forms.Label _lbl_datapath;
        private System.Windows.Forms.Panel _panel_bottom;
        private System.Windows.Forms.Button _btn_confirm;
        private System.Windows.Forms.Button _btn_cancel;
        private System.Windows.Forms.Label _lbl_colorBG;
        private System.Windows.Forms.Button _btn_colorBG;
        private System.Windows.Forms.Button _btn_colorTutorials;
        private System.Windows.Forms.Label _lbl_colorTutorials;
        private System.Windows.Forms.Button _btn_colorExercises;
        private System.Windows.Forms.Label _lbl_colorExercises;
        private System.Windows.Forms.Button _btn_colorLectures;
        private System.Windows.Forms.Label _lbl_colorLectures;
        private System.Windows.Forms.Button _btn_colorCustoms;
        private System.Windows.Forms.Label _lbl_colorCustoms;
        private System.Windows.Forms.Button _btn_colorInternships;
        private System.Windows.Forms.Label _lbl_colorInternships;
        private System.Windows.Forms.CheckBox _chkBox_logging;
        private System.Windows.Forms.CheckBox _chkBox_toConsole;
        private System.Windows.Forms.CheckBox _chkBox_toFile;
        private System.Windows.Forms.Label _lbl_target;
        private System.Windows.Forms.Label _lbl_loggingpath;
        private System.Windows.Forms.TextBox _txBox_loggingpath;
        private System.Windows.Forms.CheckBox _chkBox_writetime;
        private System.Windows.Forms.Button _btn_reset;
    }
}