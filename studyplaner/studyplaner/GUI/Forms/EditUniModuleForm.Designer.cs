namespace Studyplaner.GUI.Forms
{
    partial class EditUniModuleForm
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
            this._lblName = new System.Windows.Forms.Label();
            this._txBoxName = new System.Windows.Forms.TextBox();
            this._lblShort = new System.Windows.Forms.Label();
            this._txBoxShort = new System.Windows.Forms.TextBox();
            this._cmBoxSemester = new System.Windows.Forms.ComboBox();
            this._lblSemester = new System.Windows.Forms.Label();
            this._lblDepartment = new System.Windows.Forms.Label();
            this._cmBoxDepartment = new System.Windows.Forms.ComboBox();
            this._grpBoxEvent = new System.Windows.Forms.GroupBox();
            this._panelEventData = new System.Windows.Forms.Panel();
            this._btnDiscardEvent = new System.Windows.Forms.Button();
            this._btnSaveEvent = new System.Windows.Forms.Button();
            this._ckBoxPower = new System.Windows.Forms.CheckBox();
            this._trackBarImportance = new System.Windows.Forms.TrackBar();
            this._lblImportance = new System.Windows.Forms.Label();
            this._txBoxLecturer = new System.Windows.Forms.TextBox();
            this._lblLecturer = new System.Windows.Forms.Label();
            this._txBoxLocation = new System.Windows.Forms.TextBox();
            this._lblLocation = new System.Windows.Forms.Label();
            this._dtPickerDuration = new System.Windows.Forms.DateTimePicker();
            this._lblDuration = new System.Windows.Forms.Label();
            this._cmBoxWeekInterval = new System.Windows.Forms.ComboBox();
            this._lblWeekInterval = new System.Windows.Forms.Label();
            this._dtPickerTime = new System.Windows.Forms.DateTimePicker();
            this._lblStarttime = new System.Windows.Forms.Label();
            this._dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this._lblStartdate = new System.Windows.Forms.Label();
            this._cmBoxEventType = new System.Windows.Forms.ComboBox();
            this._lblType = new System.Windows.Forms.Label();
            this._txBoxLVNum = new System.Windows.Forms.TextBox();
            this._lblLVNum = new System.Windows.Forms.Label();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnSaveModule = new System.Windows.Forms.Button();
            this._btnCancelModule = new System.Windows.Forms.Button();
            this._eventTree = new Studyplaner.GUI.Controls.EventTree(this.components);
            this._grpBoxEvent.SuspendLayout();
            this._panelEventData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._trackBarImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(12, 15);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(35, 13);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Name";
            // 
            // _txBoxName
            // 
            this._txBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txBoxName.Location = new System.Drawing.Point(69, 12);
            this._txBoxName.Name = "_txBoxName";
            this._txBoxName.Size = new System.Drawing.Size(291, 20);
            this._txBoxName.TabIndex = 1;
            this._txBoxName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // _lblShort
            // 
            this._lblShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblShort.AutoSize = true;
            this._lblShort.Location = new System.Drawing.Point(366, 15);
            this._lblShort.Name = "_lblShort";
            this._lblShort.Size = new System.Drawing.Size(32, 13);
            this._lblShort.TabIndex = 2;
            this._lblShort.Text = "Short";
            // 
            // _txBoxShort
            // 
            this._txBoxShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._txBoxShort.Location = new System.Drawing.Point(404, 12);
            this._txBoxShort.Name = "_txBoxShort";
            this._txBoxShort.Size = new System.Drawing.Size(68, 20);
            this._txBoxShort.TabIndex = 3;
            this._txBoxShort.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Short_TextChanged);
            // 
            // _cmBoxSemester
            // 
            this._cmBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmBoxSemester.FormattingEnabled = true;
            this._cmBoxSemester.Location = new System.Drawing.Point(69, 38);
            this._cmBoxSemester.Name = "_cmBoxSemester";
            this._cmBoxSemester.Size = new System.Drawing.Size(121, 21);
            this._cmBoxSemester.TabIndex = 4;
            // 
            // _lblSemester
            // 
            this._lblSemester.AutoSize = true;
            this._lblSemester.Location = new System.Drawing.Point(12, 41);
            this._lblSemester.Name = "_lblSemester";
            this._lblSemester.Size = new System.Drawing.Size(51, 13);
            this._lblSemester.TabIndex = 5;
            this._lblSemester.Text = "Semester";
            // 
            // _lblDepartment
            // 
            this._lblDepartment.AutoSize = true;
            this._lblDepartment.Location = new System.Drawing.Point(196, 41);
            this._lblDepartment.Name = "_lblDepartment";
            this._lblDepartment.Size = new System.Drawing.Size(62, 13);
            this._lblDepartment.TabIndex = 6;
            this._lblDepartment.Text = "Department";
            // 
            // _cmBoxDepartment
            // 
            this._cmBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmBoxDepartment.FormattingEnabled = true;
            this._cmBoxDepartment.Location = new System.Drawing.Point(264, 38);
            this._cmBoxDepartment.Name = "_cmBoxDepartment";
            this._cmBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this._cmBoxDepartment.TabIndex = 7;
            // 
            // _grpBoxEvent
            // 
            this._grpBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpBoxEvent.Controls.Add(this._panelEventData);
            this._grpBoxEvent.Controls.Add(this._btnAdd);
            this._grpBoxEvent.Controls.Add(this._btnRemove);
            this._grpBoxEvent.Controls.Add(this._eventTree);
            this._grpBoxEvent.Location = new System.Drawing.Point(12, 65);
            this._grpBoxEvent.Name = "_grpBoxEvent";
            this._grpBoxEvent.Size = new System.Drawing.Size(460, 235);
            this._grpBoxEvent.TabIndex = 8;
            this._grpBoxEvent.TabStop = false;
            this._grpBoxEvent.Text = "Events";
            // 
            // _panelEventData
            // 
            this._panelEventData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelEventData.Controls.Add(this._btnDiscardEvent);
            this._panelEventData.Controls.Add(this._btnSaveEvent);
            this._panelEventData.Controls.Add(this._ckBoxPower);
            this._panelEventData.Controls.Add(this._trackBarImportance);
            this._panelEventData.Controls.Add(this._lblImportance);
            this._panelEventData.Controls.Add(this._txBoxLecturer);
            this._panelEventData.Controls.Add(this._lblLecturer);
            this._panelEventData.Controls.Add(this._txBoxLocation);
            this._panelEventData.Controls.Add(this._lblLocation);
            this._panelEventData.Controls.Add(this._dtPickerDuration);
            this._panelEventData.Controls.Add(this._lblDuration);
            this._panelEventData.Controls.Add(this._cmBoxWeekInterval);
            this._panelEventData.Controls.Add(this._lblWeekInterval);
            this._panelEventData.Controls.Add(this._dtPickerTime);
            this._panelEventData.Controls.Add(this._lblStarttime);
            this._panelEventData.Controls.Add(this._dtPickerDate);
            this._panelEventData.Controls.Add(this._lblStartdate);
            this._panelEventData.Controls.Add(this._cmBoxEventType);
            this._panelEventData.Controls.Add(this._lblType);
            this._panelEventData.Controls.Add(this._txBoxLVNum);
            this._panelEventData.Controls.Add(this._lblLVNum);
            this._panelEventData.Location = new System.Drawing.Point(168, 19);
            this._panelEventData.Margin = new System.Windows.Forms.Padding(0);
            this._panelEventData.Name = "_panelEventData";
            this._panelEventData.Size = new System.Drawing.Size(286, 210);
            this._panelEventData.TabIndex = 3;
            // 
            // _btnDiscardEvent
            // 
            this._btnDiscardEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDiscardEvent.Location = new System.Drawing.Point(127, 184);
            this._btnDiscardEvent.Name = "_btnDiscardEvent";
            this._btnDiscardEvent.Size = new System.Drawing.Size(75, 23);
            this._btnDiscardEvent.TabIndex = 27;
            this._btnDiscardEvent.Text = "Discard";
            this._btnDiscardEvent.UseVisualStyleBackColor = true;
            // 
            // _btnSaveEvent
            // 
            this._btnSaveEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveEvent.Location = new System.Drawing.Point(208, 184);
            this._btnSaveEvent.Name = "_btnSaveEvent";
            this._btnSaveEvent.Size = new System.Drawing.Size(75, 23);
            this._btnSaveEvent.TabIndex = 26;
            this._btnSaveEvent.Text = "Save Event";
            this._btnSaveEvent.UseVisualStyleBackColor = true;
            // 
            // _ckBoxPower
            // 
            this._ckBoxPower.AutoSize = true;
            this._ckBoxPower.Location = new System.Drawing.Point(3, 164);
            this._ckBoxPower.Name = "_ckBoxPower";
            this._ckBoxPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._ckBoxPower.Size = new System.Drawing.Size(56, 17);
            this._ckBoxPower.TabIndex = 25;
            this._ckBoxPower.Text = "Power";
            this._ckBoxPower.UseVisualStyleBackColor = true;
            // 
            // _trackBarImportance
            // 
            this._trackBarImportance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._trackBarImportance.Location = new System.Drawing.Point(69, 135);
            this._trackBarImportance.Name = "_trackBarImportance";
            this._trackBarImportance.Size = new System.Drawing.Size(217, 45);
            this._trackBarImportance.TabIndex = 24;
            this._trackBarImportance.Value = 10;
            // 
            // _lblImportance
            // 
            this._lblImportance.AutoSize = true;
            this._lblImportance.Location = new System.Drawing.Point(3, 140);
            this._lblImportance.Name = "_lblImportance";
            this._lblImportance.Size = new System.Drawing.Size(60, 13);
            this._lblImportance.TabIndex = 23;
            this._lblImportance.Text = "Importance";
            // 
            // _txBoxLecturer
            // 
            this._txBoxLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txBoxLecturer.Location = new System.Drawing.Point(59, 109);
            this._txBoxLecturer.Name = "_txBoxLecturer";
            this._txBoxLecturer.Size = new System.Drawing.Size(224, 20);
            this._txBoxLecturer.TabIndex = 22;
            // 
            // _lblLecturer
            // 
            this._lblLecturer.AutoSize = true;
            this._lblLecturer.Location = new System.Drawing.Point(3, 112);
            this._lblLecturer.Name = "_lblLecturer";
            this._lblLecturer.Size = new System.Drawing.Size(46, 13);
            this._lblLecturer.TabIndex = 21;
            this._lblLecturer.Text = "Lecturer";
            // 
            // _txBoxLocation
            // 
            this._txBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txBoxLocation.Location = new System.Drawing.Point(59, 83);
            this._txBoxLocation.Name = "_txBoxLocation";
            this._txBoxLocation.Size = new System.Drawing.Size(224, 20);
            this._txBoxLocation.TabIndex = 20;
            // 
            // _lblLocation
            // 
            this._lblLocation.AutoSize = true;
            this._lblLocation.Location = new System.Drawing.Point(3, 86);
            this._lblLocation.Name = "_lblLocation";
            this._lblLocation.Size = new System.Drawing.Size(48, 13);
            this._lblLocation.TabIndex = 19;
            this._lblLocation.Text = "Location";
            // 
            // _dtPickerDuration
            // 
            this._dtPickerDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dtPickerDuration.CustomFormat = "HH:mm";
            this._dtPickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtPickerDuration.Location = new System.Drawing.Point(224, 53);
            this._dtPickerDuration.Name = "_dtPickerDuration";
            this._dtPickerDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._dtPickerDuration.ShowUpDown = true;
            this._dtPickerDuration.Size = new System.Drawing.Size(59, 20);
            this._dtPickerDuration.TabIndex = 18;
            // 
            // _lblDuration
            // 
            this._lblDuration.AutoSize = true;
            this._lblDuration.Location = new System.Drawing.Point(170, 59);
            this._lblDuration.Name = "_lblDuration";
            this._lblDuration.Size = new System.Drawing.Size(47, 13);
            this._lblDuration.TabIndex = 17;
            this._lblDuration.Text = "Duration";
            // 
            // _cmBoxWeekInterval
            // 
            this._cmBoxWeekInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmBoxWeekInterval.FormattingEnabled = true;
            this._cmBoxWeekInterval.Location = new System.Drawing.Point(59, 56);
            this._cmBoxWeekInterval.Name = "_cmBoxWeekInterval";
            this._cmBoxWeekInterval.Size = new System.Drawing.Size(105, 21);
            this._cmBoxWeekInterval.TabIndex = 16;
            // 
            // _lblWeekInterval
            // 
            this._lblWeekInterval.AutoSize = true;
            this._lblWeekInterval.Location = new System.Drawing.Point(3, 59);
            this._lblWeekInterval.Name = "_lblWeekInterval";
            this._lblWeekInterval.Size = new System.Drawing.Size(42, 13);
            this._lblWeekInterval.TabIndex = 15;
            this._lblWeekInterval.Text = "Interval";
            // 
            // _dtPickerTime
            // 
            this._dtPickerTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dtPickerTime.CustomFormat = "HH:mm";
            this._dtPickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtPickerTime.Location = new System.Drawing.Point(224, 30);
            this._dtPickerTime.Name = "_dtPickerTime";
            this._dtPickerTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._dtPickerTime.ShowUpDown = true;
            this._dtPickerTime.Size = new System.Drawing.Size(59, 20);
            this._dtPickerTime.TabIndex = 14;
            // 
            // _lblStarttime
            // 
            this._lblStarttime.AutoSize = true;
            this._lblStarttime.Location = new System.Drawing.Point(170, 33);
            this._lblStarttime.Name = "_lblStarttime";
            this._lblStarttime.Size = new System.Drawing.Size(48, 13);
            this._lblStarttime.TabIndex = 13;
            this._lblStarttime.Text = "Starttime";
            // 
            // _dtPickerDate
            // 
            this._dtPickerDate.CustomFormat = "dd.MM.yyyy";
            this._dtPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtPickerDate.Location = new System.Drawing.Point(59, 30);
            this._dtPickerDate.Name = "_dtPickerDate";
            this._dtPickerDate.Size = new System.Drawing.Size(105, 20);
            this._dtPickerDate.TabIndex = 12;
            // 
            // _lblStartdate
            // 
            this._lblStartdate.AutoSize = true;
            this._lblStartdate.Location = new System.Drawing.Point(3, 33);
            this._lblStartdate.Name = "_lblStartdate";
            this._lblStartdate.Size = new System.Drawing.Size(50, 13);
            this._lblStartdate.TabIndex = 11;
            this._lblStartdate.Text = "Startdate";
            // 
            // _cmBoxEventType
            // 
            this._cmBoxEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cmBoxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmBoxEventType.FormattingEnabled = true;
            this._cmBoxEventType.Location = new System.Drawing.Point(159, 3);
            this._cmBoxEventType.Name = "_cmBoxEventType";
            this._cmBoxEventType.Size = new System.Drawing.Size(124, 21);
            this._cmBoxEventType.TabIndex = 10;
            // 
            // _lblType
            // 
            this._lblType.AutoSize = true;
            this._lblType.Location = new System.Drawing.Point(122, 6);
            this._lblType.Name = "_lblType";
            this._lblType.Size = new System.Drawing.Size(31, 13);
            this._lblType.TabIndex = 9;
            this._lblType.Text = "Type";
            // 
            // _txBoxLVNum
            // 
            this._txBoxLVNum.Location = new System.Drawing.Point(46, 3);
            this._txBoxLVNum.Name = "_txBoxLVNum";
            this._txBoxLVNum.Size = new System.Drawing.Size(70, 20);
            this._txBoxLVNum.TabIndex = 8;
            // 
            // _lblLVNum
            // 
            this._lblLVNum.AutoSize = true;
            this._lblLVNum.Location = new System.Drawing.Point(3, 6);
            this._lblLVNum.Name = "_lblLVNum";
            this._lblLVNum.Size = new System.Drawing.Size(37, 13);
            this._lblLVNum.TabIndex = 7;
            this._lblLVNum.Text = "LV-Nr.";
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnAdd.Location = new System.Drawing.Point(87, 206);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 2;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // _btnRemove
            // 
            this._btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnRemove.Location = new System.Drawing.Point(6, 206);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(75, 23);
            this._btnRemove.TabIndex = 1;
            this._btnRemove.Text = "Remove";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // _btnSaveModule
            // 
            this._btnSaveModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveModule.Location = new System.Drawing.Point(353, 306);
            this._btnSaveModule.Name = "_btnSaveModule";
            this._btnSaveModule.Size = new System.Drawing.Size(119, 23);
            this._btnSaveModule.TabIndex = 9;
            this._btnSaveModule.Text = "Save Module";
            this._btnSaveModule.UseVisualStyleBackColor = true;
            // 
            // _btnCancelModule
            // 
            this._btnCancelModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancelModule.Location = new System.Drawing.Point(228, 306);
            this._btnCancelModule.Name = "_btnCancelModule";
            this._btnCancelModule.Size = new System.Drawing.Size(119, 23);
            this._btnCancelModule.TabIndex = 10;
            this._btnCancelModule.Text = "Cancel";
            this._btnCancelModule.UseVisualStyleBackColor = true;
            this._btnCancelModule.Click += new System.EventHandler(this.CancelModule_Click);
            // 
            // _eventTree
            // 
            this._eventTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._eventTree.FullRowSelect = true;
            this._eventTree.Location = new System.Drawing.Point(6, 19);
            this._eventTree.Name = "_eventTree";
            this._eventTree.ShowLines = false;
            this._eventTree.ShowPlusMinus = false;
            this._eventTree.ShowRootLines = false;
            this._eventTree.Size = new System.Drawing.Size(156, 181);
            this._eventTree.TabIndex = 0;
            this._eventTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EventTree_AfterSelect);
            // 
            // EditUniModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 337);
            this.Controls.Add(this._btnCancelModule);
            this.Controls.Add(this._btnSaveModule);
            this.Controls.Add(this._grpBoxEvent);
            this.Controls.Add(this._cmBoxDepartment);
            this.Controls.Add(this._lblDepartment);
            this.Controls.Add(this._lblSemester);
            this.Controls.Add(this._cmBoxSemester);
            this.Controls.Add(this._txBoxShort);
            this.Controls.Add(this._lblShort);
            this.Controls.Add(this._txBoxName);
            this.Controls.Add(this._lblName);
            this.MinimumSize = new System.Drawing.Size(500, 375);
            this.Name = "EditUniModuleForm";
            this.Text = "Create / Edit module";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Short_TextChanged);
            this._grpBoxEvent.ResumeLayout(false);
            this._panelEventData.ResumeLayout(false);
            this._panelEventData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._trackBarImportance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.TextBox _txBoxName;
        private System.Windows.Forms.Label _lblShort;
        private System.Windows.Forms.TextBox _txBoxShort;
        private System.Windows.Forms.ComboBox _cmBoxSemester;
        private System.Windows.Forms.Label _lblSemester;
        private System.Windows.Forms.Label _lblDepartment;
        private System.Windows.Forms.ComboBox _cmBoxDepartment;
        private System.Windows.Forms.GroupBox _grpBoxEvent;
        private Controls.EventTree _eventTree;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Panel _panelEventData;
        private System.Windows.Forms.ComboBox _cmBoxEventType;
        private System.Windows.Forms.Label _lblType;
        private System.Windows.Forms.TextBox _txBoxLVNum;
        private System.Windows.Forms.Label _lblLVNum;
        private System.Windows.Forms.Label _lblStartdate;
        private System.Windows.Forms.DateTimePicker _dtPickerDate;
        private System.Windows.Forms.Label _lblStarttime;
        private System.Windows.Forms.DateTimePicker _dtPickerTime;
        private System.Windows.Forms.ComboBox _cmBoxWeekInterval;
        private System.Windows.Forms.Label _lblWeekInterval;
        private System.Windows.Forms.Label _lblDuration;
        private System.Windows.Forms.DateTimePicker _dtPickerDuration;
        private System.Windows.Forms.TextBox _txBoxLocation;
        private System.Windows.Forms.Label _lblLocation;
        private System.Windows.Forms.Label _lblLecturer;
        private System.Windows.Forms.TextBox _txBoxLecturer;
        private System.Windows.Forms.TrackBar _trackBarImportance;
        private System.Windows.Forms.Label _lblImportance;
        private System.Windows.Forms.CheckBox _ckBoxPower;
        private System.Windows.Forms.Button _btnSaveEvent;
        private System.Windows.Forms.Button _btnDiscardEvent;
        private System.Windows.Forms.Button _btnSaveModule;
        private System.Windows.Forms.Button _btnCancelModule;
    }
}