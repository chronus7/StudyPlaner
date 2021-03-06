﻿namespace Studyplaner.GUI.Forms
{
    partial class LogForm
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
            this.roBxLog = new ReadOnlyListBox();
            this._worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // roBxLog
            // 
            this.roBxLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.roBxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roBxLog.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roBxLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.roBxLog.FormattingEnabled = true;
            this.roBxLog.ItemHeight = 16;
            this.roBxLog.Location = new System.Drawing.Point(0, 0);
            this.roBxLog.Name = "roBxLog";
            this.roBxLog.ReadOnly = true;
            this.roBxLog.Size = new System.Drawing.Size(509, 276);
            this.roBxLog.TabIndex = 0;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 276);
            this.Controls.Add(this.roBxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ReadOnlyListBox roBxLog;
        private System.ComponentModel.BackgroundWorker _worker;




    }
}