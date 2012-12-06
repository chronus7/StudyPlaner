namespace Studyplaner.GUI.Forms
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
            this.components = new System.ComponentModel.Container();
            this._panelMain = new System.Windows.Forms.Panel();
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._mainMenu_file = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_file_quit = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_extras = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_extras_settings = new System.Windows.Forms.ToolStripMenuItem();
            this._mainMenu_help = new System.Windows.Forms.ToolStripMenuItem();
            this._panelInfo = new System.Windows.Forms.Panel();
            this._statusMenu = new System.Windows.Forms.StatusStrip();
            this._statusElementTooltip = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusElementBattery = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusElementDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this._dateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this._mainMenuStrip.SuspendLayout();
            this._statusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMain
            // 
            this._panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._panelMain.BackColor = System.Drawing.SystemColors.Control;
            this._panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._panelMain.Location = new System.Drawing.Point(10, 35);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(685, 495);
            this._panelMain.TabIndex = 0;
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mainMenu_file,
            this._mainMenu_edit,
            this._mainMenu_extras,
            this._mainMenu_help});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this._mainMenu_file_quit.ToolTipText = "Close the application";
            this._mainMenu_file_quit.Click += new System.EventHandler(this.TotalQuitClick);
            this._mainMenu_file_quit.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this._mainMenu_file_quit.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // _mainMenu_edit
            // 
            this._mainMenu_edit.Name = "_mainMenu_edit";
            this._mainMenu_edit.Size = new System.Drawing.Size(39, 20);
            this._mainMenu_edit.Text = "Edit";
            // 
            // _mainMenu_extras
            // 
            this._mainMenu_extras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mainMenu_extras_settings});
            this._mainMenu_extras.Name = "_mainMenu_extras";
            this._mainMenu_extras.Size = new System.Drawing.Size(49, 20);
            this._mainMenu_extras.Text = "Extras";
            // 
            // _mainMenu_extras_settings
            // 
            this._mainMenu_extras_settings.Name = "_mainMenu_extras_settings";
            this._mainMenu_extras_settings.Size = new System.Drawing.Size(125, 22);
            this._mainMenu_extras_settings.Text = "Settings...";
            this._mainMenu_extras_settings.ToolTipText = "Open the settings dialog";
            this._mainMenu_extras_settings.Click += new System.EventHandler(this.OpenSettingsDialog);
            this._mainMenu_extras_settings.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this._mainMenu_extras_settings.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
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
            this._panelInfo.Location = new System.Drawing.Point(700, 35);
            this._panelInfo.Name = "_panelInfo";
            this._panelInfo.Size = new System.Drawing.Size(275, 495);
            this._panelInfo.TabIndex = 2;
            // 
            // _statusMenu
            // 
            this._statusMenu.BackColor = System.Drawing.SystemColors.Control;
            this._statusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusElementTooltip,
            this._statusElementBattery,
            this._statusElementDateTime});
            this._statusMenu.Location = new System.Drawing.Point(0, 540);
            this._statusMenu.Name = "_statusMenu";
            this._statusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this._statusMenu.ShowItemToolTips = true;
            this._statusMenu.Size = new System.Drawing.Size(984, 22);
            this._statusMenu.TabIndex = 3;
            // 
            // _statusElementTooltip
            // 
            this._statusElementTooltip.BackColor = System.Drawing.SystemColors.Control;
            this._statusElementTooltip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._statusElementTooltip.Name = "_statusElementTooltip";
            this._statusElementTooltip.Size = new System.Drawing.Size(838, 17);
            this._statusElementTooltip.Spring = true;
            this._statusElementTooltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _statusElementBattery
            // 
            this._statusElementBattery.BackColor = System.Drawing.SystemColors.Control;
            this._statusElementBattery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._statusElementBattery.Image = global::Studyplaner.Properties.Resources.BATTERY_HIGH;
            this._statusElementBattery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._statusElementBattery.Name = "_statusElementBattery";
            this._statusElementBattery.Size = new System.Drawing.Size(16, 17);
            this._statusElementBattery.Text = " ";
            this._statusElementBattery.ToolTipText = "Time Remaining: qq:zz";
            // 
            // _statusElementDateTime
            // 
            this._statusElementDateTime.Name = "_statusElementDateTime";
            this._statusElementDateTime.Size = new System.Drawing.Size(115, 17);
            this._statusElementDateTime.Text = "Mo, 00.00.0000 00:00";
            // 
            // _dateTimeTimer
            // 
            this._dateTimeTimer.Interval = 30000;
            this._dateTimeTimer.Tick += new System.EventHandler(this.dateTimeTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this._statusMenu);
            this.Controls.Add(this._panelInfo);
            this.Controls.Add(this._panelMain);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Planer";
            this.Load += new System.EventHandler(this.MainForm_Loaded);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._statusMenu.ResumeLayout(false);
            this._statusMenu.PerformLayout();
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
        private System.Windows.Forms.StatusStrip _statusMenu;
        private System.Windows.Forms.ToolStripStatusLabel _statusElementTooltip;
        private System.Windows.Forms.ToolStripStatusLabel _statusElementBattery;
        private System.Windows.Forms.ToolStripStatusLabel _statusElementDateTime;
        private System.Windows.Forms.Timer _dateTimeTimer;
        private System.Windows.Forms.ToolStripMenuItem _mainMenu_extras;
        private System.Windows.Forms.ToolStripMenuItem _mainMenu_extras_settings;
    }
}