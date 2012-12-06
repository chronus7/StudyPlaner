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
            this._btnReset = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._lblBgColor = new System.Windows.Forms.Label();
            this._btnBgColor = new System.Windows.Forms.Button();
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this._grpBoxGeneral = new System.Windows.Forms.GroupBox();
            this._grpBoxEventSettings = new System.Windows.Forms.GroupBox();
            this._btnColorLecture = new System.Windows.Forms.Button();
            this._lblColorLecture = new System.Windows.Forms.Label();
            this._mainPanel.SuspendLayout();
            this._grpBoxGeneral.SuspendLayout();
            this._grpBoxEventSettings.SuspendLayout();
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
            // _lblBgColor
            // 
            this._lblBgColor.AutoSize = true;
            this._lblBgColor.Location = new System.Drawing.Point(8, 23);
            this._lblBgColor.Name = "_lblBgColor";
            this._lblBgColor.Size = new System.Drawing.Size(91, 13);
            this._lblBgColor.TabIndex = 0;
            this._lblBgColor.Text = "Backgroundcolor:";
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
            // _colorDialog
            // 
            this._colorDialog.AnyColor = true;
            this._colorDialog.FullOpen = true;
            // 
            // _grpBoxGeneral
            // 
            this._grpBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpBoxGeneral.Controls.Add(this._btnBgColor);
            this._grpBoxGeneral.Controls.Add(this._lblBgColor);
            this._grpBoxGeneral.Location = new System.Drawing.Point(3, 3);
            this._grpBoxGeneral.Name = "_grpBoxGeneral";
            this._grpBoxGeneral.Size = new System.Drawing.Size(452, 103);
            this._grpBoxGeneral.TabIndex = 5;
            this._grpBoxGeneral.TabStop = false;
            this._grpBoxGeneral.Text = "General";
            // 
            // _grpBoxEventSettings
            // 
            this._grpBoxEventSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // 
            // _lblColorLecture
            // 
            this._lblColorLecture.AutoSize = true;
            this._lblColorLecture.Location = new System.Drawing.Point(8, 23);
            this._lblColorLecture.Name = "_lblColorLecture";
            this._lblColorLecture.Size = new System.Drawing.Size(78, 13);
            this._lblColorLecture.TabIndex = 2;
            this._lblColorLecture.Text = "Color Lectures:";
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
            this._grpBoxGeneral.ResumeLayout(false);
            this._grpBoxGeneral.PerformLayout();
            this._grpBoxEventSettings.ResumeLayout(false);
            this._grpBoxEventSettings.PerformLayout();
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
    }
}