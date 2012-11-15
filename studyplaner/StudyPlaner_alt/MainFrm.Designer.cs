namespace StudyPlaner
{
    partial class MainFrm
    {
        /// <summary>
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem tlstrBtnFileSaveAs;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tlstrSystemlike = new System.Windows.Forms.ToolStrip();
            this.tlstrFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlstrFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrFileNewPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrFileNewModule = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrBtnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrFileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrBtnFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrFileSepertor2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrBtnFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrExtras = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlstBtnExtrasSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctMenuTrayShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctMenuTrayClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ContainerMain = new System.Windows.Forms.Panel();
            this.PanelDetails = new System.Windows.Forms.Panel();
            this.PanelPaint = new System.Windows.Forms.Panel();
            this.lblDetailsModuleName = new System.Windows.Forms.Label();
            tlstrBtnFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrSystemlike.SuspendLayout();
            this.ctMenuTray.SuspendLayout();
            this.ContainerMain.SuspendLayout();
            this.PanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlstrBtnFileSaveAs
            // 
            tlstrBtnFileSaveAs.Name = "tlstrBtnFileSaveAs";
            tlstrBtnFileSaveAs.ShortcutKeyDisplayString = "Strg+Umschalt+S";
            tlstrBtnFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            tlstrBtnFileSaveAs.Size = new System.Drawing.Size(266, 22);
            tlstrBtnFileSaveAs.Text = "Speichern unter...";
            // 
            // tlstrSystemlike
            // 
            this.tlstrSystemlike.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlstrSystemlike.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrFile,
            this.tlstrExtras,
            this.tlstrHelp});
            this.tlstrSystemlike.Location = new System.Drawing.Point(0, 0);
            this.tlstrSystemlike.Name = "tlstrSystemlike";
            this.tlstrSystemlike.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.tlstrSystemlike.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tlstrSystemlike.Size = new System.Drawing.Size(1018, 25);
            this.tlstrSystemlike.TabIndex = 0;
            // 
            // tlstrFile
            // 
            this.tlstrFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstrFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrFileNew,
            this.tlstrBtnFileOpen,
            this.tlstrFileSeperator1,
            this.tlstrBtnFileSave,
            tlstrBtnFileSaveAs,
            this.tlstrFileSepertor2,
            this.tlstrBtnFileQuit});
            this.tlstrFile.Image = ((System.Drawing.Image)(resources.GetObject("tlstrFile.Image")));
            this.tlstrFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrFile.Name = "tlstrFile";
            this.tlstrFile.ShowDropDownArrow = false;
            this.tlstrFile.Size = new System.Drawing.Size(38, 22);
            this.tlstrFile.Text = "Datei";
            // 
            // tlstrFileNew
            // 
            this.tlstrFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrFileNewPlan,
            this.tlstrFileNewModule});
            this.tlstrFileNew.Name = "tlstrFileNew";
            this.tlstrFileNew.ShortcutKeyDisplayString = "";
            this.tlstrFileNew.Size = new System.Drawing.Size(266, 22);
            this.tlstrFileNew.Text = "Neu";
            // 
            // tlstrFileNewPlan
            // 
            this.tlstrFileNewPlan.Name = "tlstrFileNewPlan";
            this.tlstrFileNewPlan.ShortcutKeyDisplayString = "";
            this.tlstrFileNewPlan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tlstrFileNewPlan.Size = new System.Drawing.Size(177, 22);
            this.tlstrFileNewPlan.Text = "Neuer Plan";
            // 
            // tlstrFileNewModule
            // 
            this.tlstrFileNewModule.Name = "tlstrFileNewModule";
            this.tlstrFileNewModule.Size = new System.Drawing.Size(177, 22);
            this.tlstrFileNewModule.Text = "Neues Modul";
            // 
            // tlstrBtnFileOpen
            // 
            this.tlstrBtnFileOpen.Image = global::StudyPlaner.Properties.Resources.open;
            this.tlstrBtnFileOpen.Name = "tlstrBtnFileOpen";
            this.tlstrBtnFileOpen.ShortcutKeyDisplayString = "";
            this.tlstrBtnFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tlstrBtnFileOpen.Size = new System.Drawing.Size(266, 22);
            this.tlstrBtnFileOpen.Text = "Öffnen...";
            // 
            // tlstrFileSeperator1
            // 
            this.tlstrFileSeperator1.Name = "tlstrFileSeperator1";
            this.tlstrFileSeperator1.Size = new System.Drawing.Size(263, 6);
            // 
            // tlstrBtnFileSave
            // 
            this.tlstrBtnFileSave.Image = ((System.Drawing.Image)(resources.GetObject("tlstrBtnFileSave.Image")));
            this.tlstrBtnFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.tlstrBtnFileSave.Name = "tlstrBtnFileSave";
            this.tlstrBtnFileSave.ShortcutKeyDisplayString = "";
            this.tlstrBtnFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tlstrBtnFileSave.Size = new System.Drawing.Size(266, 22);
            this.tlstrBtnFileSave.Text = "Speichern";
            // 
            // tlstrFileSepertor2
            // 
            this.tlstrFileSepertor2.Name = "tlstrFileSepertor2";
            this.tlstrFileSepertor2.Size = new System.Drawing.Size(263, 6);
            // 
            // tlstrBtnFileQuit
            // 
            this.tlstrBtnFileQuit.Name = "tlstrBtnFileQuit";
            this.tlstrBtnFileQuit.ShortcutKeyDisplayString = "";
            this.tlstrBtnFileQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tlstrBtnFileQuit.Size = new System.Drawing.Size(266, 22);
            this.tlstrBtnFileQuit.Text = "Beenden";
            this.tlstrBtnFileQuit.Click += new System.EventHandler(this.tlstrBtnFileQuitClick);
            // 
            // tlstrExtras
            // 
            this.tlstrExtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstrExtras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstBtnExtrasSettings});
            this.tlstrExtras.Image = ((System.Drawing.Image)(resources.GetObject("tlstrExtras.Image")));
            this.tlstrExtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrExtras.Name = "tlstrExtras";
            this.tlstrExtras.ShowDropDownArrow = false;
            this.tlstrExtras.Size = new System.Drawing.Size(41, 22);
            this.tlstrExtras.Text = "Extras";
            // 
            // tlstBtnExtrasSettings
            // 
            this.tlstBtnExtrasSettings.Name = "tlstBtnExtrasSettings";
            this.tlstBtnExtrasSettings.Size = new System.Drawing.Size(154, 22);
            this.tlstBtnExtrasSettings.Text = "Einstellungen...";
            // 
            // tlstrHelp
            // 
            this.tlstrHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlstrHelp.Image = ((System.Drawing.Image)(resources.GetObject("tlstrHelp.Image")));
            this.tlstrHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrHelp.Name = "tlstrHelp";
            this.tlstrHelp.ShowDropDownArrow = false;
            this.tlstrHelp.Size = new System.Drawing.Size(16, 22);
            this.tlstrHelp.Text = "?";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(726, 377);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.ctMenuTray;
            this.trayIcon.Text = "Study Planer running!";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // ctMenuTray
            // 
            this.ctMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctMenuTrayShow,
            this.ctMenuTrayClose});
            this.ctMenuTray.Name = "contextMenuStrip1";
            this.ctMenuTray.Size = new System.Drawing.Size(191, 48);
            // 
            // ctMenuTrayShow
            // 
            this.ctMenuTrayShow.Name = "ctMenuTrayShow";
            this.ctMenuTrayShow.Size = new System.Drawing.Size(190, 22);
            this.ctMenuTrayShow.Text = "Study Planer anzeigen";
            this.ctMenuTrayShow.Click += new System.EventHandler(this.ctMenuTrayShow_Click);
            // 
            // ctMenuTrayClose
            // 
            this.ctMenuTrayClose.Name = "ctMenuTrayClose";
            this.ctMenuTrayClose.Size = new System.Drawing.Size(190, 22);
            this.ctMenuTrayClose.Text = "Beenden";
            this.ctMenuTrayClose.Click += new System.EventHandler(this.ctMenuTrayClose_Click);
            // 
            // ContainerMain
            // 
            this.ContainerMain.BackColor = System.Drawing.Color.LightSlateGray;
            this.ContainerMain.Controls.Add(this.PanelDetails);
            this.ContainerMain.Controls.Add(this.PanelPaint);
            this.ContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerMain.Location = new System.Drawing.Point(0, 25);
            this.ContainerMain.Name = "ContainerMain";
            this.ContainerMain.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ContainerMain.Size = new System.Drawing.Size(1018, 547);
            this.ContainerMain.TabIndex = 1;
            // 
            // PanelDetails
            // 
            this.PanelDetails.BackColor = System.Drawing.SystemColors.Control;
            this.PanelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDetails.Controls.Add(this.lblDetailsModuleName);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDetails.Location = new System.Drawing.Point(785, 6);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(228, 535);
            this.PanelDetails.TabIndex = 1;
            // 
            // PanelPaint
            // 
            this.PanelPaint.BackColor = System.Drawing.Color.White;
            this.PanelPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPaint.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPaint.Location = new System.Drawing.Point(5, 6);
            this.PanelPaint.Name = "PanelPaint";
            this.PanelPaint.Size = new System.Drawing.Size(774, 535);
            this.PanelPaint.TabIndex = 0;
            this.PanelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaint_Paint);
            // 
            // lblDetailsModuleName
            // 
            this.lblDetailsModuleName.AutoSize = true;
            this.lblDetailsModuleName.Location = new System.Drawing.Point(17, 23);
            this.lblDetailsModuleName.Name = "lblDetailsModuleName";
            this.lblDetailsModuleName.Size = new System.Drawing.Size(65, 13);
            this.lblDetailsModuleName.TabIndex = 0;
            this.lblDetailsModuleName.Text = "Modulname:";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 572);
            this.Controls.Add(this.ContainerMain);
            this.Controls.Add(this.tlstrSystemlike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyPlaner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.tlstrSystemlike.ResumeLayout(false);
            this.tlstrSystemlike.PerformLayout();
            this.ctMenuTray.ResumeLayout(false);
            this.ContainerMain.ResumeLayout(false);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlstrSystemlike;
        private System.Windows.Forms.ToolStripDropDownButton tlstrFile;
        private System.Windows.Forms.ToolStripMenuItem tlstrFileNew;
        private System.Windows.Forms.ToolStripMenuItem tlstrBtnFileQuit;
        private System.Windows.Forms.ToolStripMenuItem tlstrFileNewPlan;
        private System.Windows.Forms.ToolStripMenuItem tlstrFileNewModule;
        private System.Windows.Forms.ToolStripSeparator tlstrFileSepertor2;
        private System.Windows.Forms.ToolStripMenuItem tlstrBtnFileOpen;
        private System.Windows.Forms.ToolStripSeparator tlstrFileSeperator1;
        private System.Windows.Forms.ToolStripMenuItem tlstrBtnFileSave;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip ctMenuTray;
        private System.Windows.Forms.ToolStripMenuItem ctMenuTrayClose;
        private System.Windows.Forms.ToolStripMenuItem ctMenuTrayShow;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel ContainerMain;
        private System.Windows.Forms.Panel PanelPaint;
        private System.Windows.Forms.Panel PanelDetails;
        private System.Windows.Forms.ToolStripDropDownButton tlstrExtras;
        private System.Windows.Forms.ToolStripMenuItem tlstBtnExtrasSettings;
        private System.Windows.Forms.ToolStripDropDownButton tlstrHelp;
        private System.Windows.Forms.Label lblDetailsModuleName;

    }
}

