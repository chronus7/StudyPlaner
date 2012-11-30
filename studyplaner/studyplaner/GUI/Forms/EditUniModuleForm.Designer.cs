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
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._eventTree = new Studyplaner.GUI.Controls.EventTree(this.components);
            this._grpBoxEvent.SuspendLayout();
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
            this._txBoxName.Location = new System.Drawing.Point(69, 12);
            this._txBoxName.Name = "_txBoxName";
            this._txBoxName.Size = new System.Drawing.Size(291, 20);
            this._txBoxName.TabIndex = 1;
            // 
            // _lblShort
            // 
            this._lblShort.AutoSize = true;
            this._lblShort.Location = new System.Drawing.Point(366, 15);
            this._lblShort.Name = "_lblShort";
            this._lblShort.Size = new System.Drawing.Size(32, 13);
            this._lblShort.TabIndex = 2;
            this._lblShort.Text = "Short";
            // 
            // _txBoxShort
            // 
            this._txBoxShort.Location = new System.Drawing.Point(404, 12);
            this._txBoxShort.Name = "_txBoxShort";
            this._txBoxShort.Size = new System.Drawing.Size(68, 20);
            this._txBoxShort.TabIndex = 3;
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
            // _eventTree
            // 
            this._eventTree.FullRowSelect = true;
            this._eventTree.Location = new System.Drawing.Point(6, 19);
            this._eventTree.Name = "_eventTree";
            this._eventTree.ShowLines = false;
            this._eventTree.ShowPlusMinus = false;
            this._eventTree.ShowRootLines = false;
            this._eventTree.Size = new System.Drawing.Size(156, 181);
            this._eventTree.TabIndex = 0;
            // 
            // EditUniModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this._grpBoxEvent);
            this.Controls.Add(this._cmBoxDepartment);
            this.Controls.Add(this._lblDepartment);
            this.Controls.Add(this._lblSemester);
            this.Controls.Add(this._cmBoxSemester);
            this.Controls.Add(this._txBoxShort);
            this.Controls.Add(this._lblShort);
            this.Controls.Add(this._txBoxName);
            this.Controls.Add(this._lblName);
            this.Name = "EditUniModuleForm";
            this.Text = "Create / Edit module";
            this._grpBoxEvent.ResumeLayout(false);
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
    }
}