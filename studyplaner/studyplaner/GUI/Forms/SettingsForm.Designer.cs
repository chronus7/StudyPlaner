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
            this._tabPg_colors = new System.Windows.Forms.TabPage();
            this._tabPg_logging = new System.Windows.Forms.TabPage();
            this._lbl_datapath = new System.Windows.Forms.Label();
            this._txBox_datapath = new System.Windows.Forms.TextBox();
            this._panel_bottom = new System.Windows.Forms.Panel();
            this._btn_cancel = new System.Windows.Forms.Button();
            this._btn_confirm = new System.Windows.Forms.Button();
            this._lbl_colorBG = new System.Windows.Forms.Label();
            this._btn_colorBG = new System.Windows.Forms.Button();
            this._lbl_colorLectures = new System.Windows.Forms.Label();
            this._btn_colorLectures = new System.Windows.Forms.Button();
            this._btn_colorExercises = new System.Windows.Forms.Button();
            this._lbl_colorExercises = new System.Windows.Forms.Label();
            this._btn_colorTutorials = new System.Windows.Forms.Button();
            this._lbl_colorTutorials = new System.Windows.Forms.Label();
            this._btn_colorInternships = new System.Windows.Forms.Button();
            this._lbl_colorInternships = new System.Windows.Forms.Label();
            this._btn_colorCustoms = new System.Windows.Forms.Button();
            this._lbl_colorCustoms = new System.Windows.Forms.Label();
            this._tabCtrl.SuspendLayout();
            this._tabPg_general.SuspendLayout();
            this._tabPg_colors.SuspendLayout();
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
            // _tabPg_logging
            // 
            this._tabPg_logging.Location = new System.Drawing.Point(4, 22);
            this._tabPg_logging.Name = "_tabPg_logging";
            this._tabPg_logging.Size = new System.Drawing.Size(452, 261);
            this._tabPg_logging.TabIndex = 2;
            this._tabPg_logging.Text = "Logging";
            this._tabPg_logging.UseVisualStyleBackColor = true;
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
            // _txBox_datapath
            // 
            this._txBox_datapath.Location = new System.Drawing.Point(63, 6);
            this._txBox_datapath.Name = "_txBox_datapath";
            this._txBox_datapath.Size = new System.Drawing.Size(377, 20);
            this._txBox_datapath.TabIndex = 1;
            // 
            // _panel_bottom
            // 
            this._panel_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panel_bottom.BackColor = System.Drawing.SystemColors.Control;
            this._panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panel_bottom.Controls.Add(this._btn_confirm);
            this._panel_bottom.Controls.Add(this._btn_cancel);
            this._panel_bottom.Location = new System.Drawing.Point(13, 264);
            this._panel_bottom.Name = "_panel_bottom";
            this._panel_bottom.Size = new System.Drawing.Size(454, 30);
            this._panel_bottom.TabIndex = 1;
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
            // _btn_colorBG
            // 
            this._btn_colorBG.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorBG.Location = new System.Drawing.Point(77, 6);
            this._btn_colorBG.Name = "_btn_colorBG";
            this._btn_colorBG.Size = new System.Drawing.Size(23, 23);
            this._btn_colorBG.TabIndex = 1;
            this._btn_colorBG.UseVisualStyleBackColor = true;
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
            // _btn_colorLectures
            // 
            this._btn_colorLectures.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorLectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorLectures.Location = new System.Drawing.Point(77, 51);
            this._btn_colorLectures.Name = "_btn_colorLectures";
            this._btn_colorLectures.Size = new System.Drawing.Size(23, 23);
            this._btn_colorLectures.TabIndex = 3;
            this._btn_colorLectures.UseVisualStyleBackColor = true;
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
            // _btn_colorTutorials
            // 
            this._btn_colorTutorials.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorTutorials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorTutorials.Location = new System.Drawing.Point(77, 138);
            this._btn_colorTutorials.Name = "_btn_colorTutorials";
            this._btn_colorTutorials.Size = new System.Drawing.Size(23, 23);
            this._btn_colorTutorials.TabIndex = 7;
            this._btn_colorTutorials.UseVisualStyleBackColor = true;
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
            // _btn_colorInternships
            // 
            this._btn_colorInternships.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorInternships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorInternships.Location = new System.Drawing.Point(77, 109);
            this._btn_colorInternships.Name = "_btn_colorInternships";
            this._btn_colorInternships.Size = new System.Drawing.Size(23, 23);
            this._btn_colorInternships.TabIndex = 9;
            this._btn_colorInternships.UseVisualStyleBackColor = true;
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
            // _btn_colorCustoms
            // 
            this._btn_colorCustoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_colorCustoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_colorCustoms.Location = new System.Drawing.Point(77, 167);
            this._btn_colorCustoms.Name = "_btn_colorCustoms";
            this._btn_colorCustoms.Size = new System.Drawing.Size(23, 23);
            this._btn_colorCustoms.TabIndex = 11;
            this._btn_colorCustoms.UseVisualStyleBackColor = true;
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
    }
}