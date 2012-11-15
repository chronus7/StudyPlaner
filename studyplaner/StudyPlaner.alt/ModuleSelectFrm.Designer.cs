namespace StudyPlaner
{
    partial class ModuleSelectFrm
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
            this.cmBoxModules = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBoxSummary = new System.Windows.Forms.GroupBox();
            this.cmBoxInternships = new System.Windows.Forms.ComboBox();
            this.lblInterships = new System.Windows.Forms.Label();
            this.cmBoxTutorials = new System.Windows.Forms.ComboBox();
            this.lblTutorials = new System.Windows.Forms.Label();
            this.cmBoxExercises = new System.Windows.Forms.ComboBox();
            this.lblExercises = new System.Windows.Forms.Label();
            this.lblLectures = new System.Windows.Forms.Label();
            this.grpBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmBoxModules
            // 
            this.cmBoxModules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxModules.FormattingEnabled = true;
            this.cmBoxModules.Location = new System.Drawing.Point(56, 10);
            this.cmBoxModules.Name = "cmBoxModules";
            this.cmBoxModules.Size = new System.Drawing.Size(396, 21);
            this.cmBoxModules.TabIndex = 0;
            this.cmBoxModules.SelectedIndexChanged += new System.EventHandler(this.cmBoxModules_SelectedIndexChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(12, 13);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(39, 13);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "Modul:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(232, 187);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Modul hinzufügen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBoxSummary
            // 
            this.grpBoxSummary.Controls.Add(this.cmBoxInternships);
            this.grpBoxSummary.Controls.Add(this.lblInterships);
            this.grpBoxSummary.Controls.Add(this.cmBoxTutorials);
            this.grpBoxSummary.Controls.Add(this.lblTutorials);
            this.grpBoxSummary.Controls.Add(this.cmBoxExercises);
            this.grpBoxSummary.Controls.Add(this.lblExercises);
            this.grpBoxSummary.Controls.Add(this.lblLectures);
            this.grpBoxSummary.Location = new System.Drawing.Point(12, 37);
            this.grpBoxSummary.Name = "grpBoxSummary";
            this.grpBoxSummary.Size = new System.Drawing.Size(440, 144);
            this.grpBoxSummary.TabIndex = 4;
            this.grpBoxSummary.TabStop = false;
            this.grpBoxSummary.Text = "Modulzusammenfassung";
            // 
            // cmBoxInternships
            // 
            this.cmBoxInternships.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxInternships.FormattingEnabled = true;
            this.cmBoxInternships.Location = new System.Drawing.Point(82, 107);
            this.cmBoxInternships.Name = "cmBoxInternships";
            this.cmBoxInternships.Size = new System.Drawing.Size(352, 21);
            this.cmBoxInternships.TabIndex = 6;
            // 
            // lblInterships
            // 
            this.lblInterships.AutoSize = true;
            this.lblInterships.Location = new System.Drawing.Point(22, 110);
            this.lblInterships.Name = "lblInterships";
            this.lblInterships.Size = new System.Drawing.Size(49, 13);
            this.lblInterships.TabIndex = 5;
            this.lblInterships.Text = "Praktika:";
            // 
            // cmBoxTutorials
            // 
            this.cmBoxTutorials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxTutorials.FormattingEnabled = true;
            this.cmBoxTutorials.Location = new System.Drawing.Point(82, 80);
            this.cmBoxTutorials.Name = "cmBoxTutorials";
            this.cmBoxTutorials.Size = new System.Drawing.Size(352, 21);
            this.cmBoxTutorials.TabIndex = 4;
            // 
            // lblTutorials
            // 
            this.lblTutorials.AutoSize = true;
            this.lblTutorials.Location = new System.Drawing.Point(22, 83);
            this.lblTutorials.Name = "lblTutorials";
            this.lblTutorials.Size = new System.Drawing.Size(49, 13);
            this.lblTutorials.TabIndex = 3;
            this.lblTutorials.Text = "Tutorien:";
            // 
            // cmBoxExercises
            // 
            this.cmBoxExercises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxExercises.FormattingEnabled = true;
            this.cmBoxExercises.Location = new System.Drawing.Point(82, 53);
            this.cmBoxExercises.Name = "cmBoxExercises";
            this.cmBoxExercises.Size = new System.Drawing.Size(352, 21);
            this.cmBoxExercises.TabIndex = 2;
            // 
            // lblExercises
            // 
            this.lblExercises.AutoSize = true;
            this.lblExercises.Location = new System.Drawing.Point(22, 56);
            this.lblExercises.Name = "lblExercises";
            this.lblExercises.Size = new System.Drawing.Size(54, 13);
            this.lblExercises.TabIndex = 1;
            this.lblExercises.Text = "Übungen:";
            // 
            // lblLectures
            // 
            this.lblLectures.AutoSize = true;
            this.lblLectures.Location = new System.Drawing.Point(22, 29);
            this.lblLectures.Name = "lblLectures";
            this.lblLectures.Size = new System.Drawing.Size(159, 13);
            this.lblLectures.TabIndex = 0;
            this.lblLectures.Text = "Keine Vorlesung(en) vorhanden!";
            // 
            // ModuleSelectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 222);
            this.Controls.Add(this.grpBoxSummary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.cmBoxModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuleSelectFrm";
            this.Text = "Modul auswählen";
            this.grpBoxSummary.ResumeLayout(false);
            this.grpBoxSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBoxModules;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBoxSummary;
        private System.Windows.Forms.Label lblLectures;
        private System.Windows.Forms.ComboBox cmBoxTutorials;
        private System.Windows.Forms.Label lblTutorials;
        private System.Windows.Forms.ComboBox cmBoxExercises;
        private System.Windows.Forms.Label lblExercises;
        private System.Windows.Forms.ComboBox cmBoxInternships;
        private System.Windows.Forms.Label lblInterships;
    }
}