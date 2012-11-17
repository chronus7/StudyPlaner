namespace Studyplaner.GUI
{
    partial class MainForm
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
            this._panelMain = new System.Windows.Forms.Panel();
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._mainMenu_file = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_file_quit = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_help = new System.Windows.Forms.ToolStripMenuItem();
            this._panelInfo = new System.Windows.Forms.Panel();
            this._mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMain
            // 
            this._panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._panelMain.BackColor = System.Drawing.SystemColors.Control;
            this._panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelMain.Location = new System.Drawing.Point(12, 37);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(685, 513);
            this._panelMain.TabIndex = 0;
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mainMenu_file,
            this._mainMenu_edit,
            this._mainMenu_help});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this._mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._mainMenuStrip.Size = new System.Drawing.Size(984, 24);
            this._mainMenuStrip.TabIndex = 1;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _mainMenu_file
            // 
            this._mainMenu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mainMenu_file_new,
            this._mainMenu_file_quit});
            this._mainMenu_file.Name = "_mainMenu_file";
            this._mainMenu_file.Size = new System.Drawing.Size(37, 20);
            this._mainMenu_file.Text = "File";
            // 
            // _mainMenu_file_new
            // 
            this._mainMenu_file_new.Name = "_mainMenu_file_new";
            this._mainMenu_file_new.Size = new System.Drawing.Size(142, 22);
            this._mainMenu_file_new.Text = "New";
            // 
            // _mainMenu_file_quit
            // 
            this._mainMenu_file_quit.Name = "_mainMenu_file_quit";
            this._mainMenu_file_quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this._mainMenu_file_quit.Size = new System.Drawing.Size(142, 22);
            this._mainMenu_file_quit.Text = "Quit";
            this._mainMenu_file_quit.Click += new System.EventHandler(this.totalQuitClick);
            // 
            // _mainMenu_edit
            // 
            this._mainMenu_edit.Name = "_mainMenu_edit";
            this._mainMenu_edit.Size = new System.Drawing.Size(39, 20);
            this._mainMenu_edit.Text = "Edit";
            // 
            // _mainMenu_help
            // 
            this._mainMenu_help.Name = "_mainMenu_help";
            this._mainMenu_help.Size = new System.Drawing.Size(44, 20);
            this._mainMenu_help.Text = "Help";
            // 
            // _panelInfo
            // 
            this._panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._panelInfo.BackColor = System.Drawing.SystemColors.Control;
            this._panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelInfo.Location = new System.Drawing.Point(703, 37);
            this._panelInfo.Name = "_panelInfo";
            this._panelInfo.Size = new System.Drawing.Size(269, 513);
            this._panelInfo.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this._panelInfo);
            this.Controls.Add(this._panelMain);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyPlaner";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _mainMenu_file;
        private System.Windows.Forms.ToolStripMenuItem _mainMenu_edit;
        private System.Windows.Forms.ToolStripMenuItem _mainMenu_help;
        private System.Windows.Forms.Panel _panelInfo;
        private System.Windows.Forms.ToolStripMenuItem _mainMenu_file_new;
        public System.Windows.Forms.ToolStripMenuItem _mainMenu_file_quit;
    }
}