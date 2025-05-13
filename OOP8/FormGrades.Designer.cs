namespace OOP8
{
    partial class FormGrades
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
            this.PanelStudents = new System.Windows.Forms.Panel();
            this.PanelStudy = new System.Windows.Forms.Panel();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTeachers = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelStudents
            // 
            this.PanelStudents.AutoScroll = true;
            this.PanelStudents.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelStudents.Location = new System.Drawing.Point(12, 104);
            this.PanelStudents.Name = "PanelStudents";
            this.PanelStudents.Size = new System.Drawing.Size(348, 407);
            this.PanelStudents.TabIndex = 1;
            // 
            // PanelStudy
            // 
            this.PanelStudy.AutoScroll = true;
            this.PanelStudy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelStudy.Location = new System.Drawing.Point(366, 104);
            this.PanelStudy.Name = "PanelStudy";
            this.PanelStudy.Size = new System.Drawing.Size(751, 407);
            this.PanelStudy.TabIndex = 2;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(12, -2);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(83, 30);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "label1";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(951, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(166, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Зберегти оцінки";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTeachers
            // 
            this.labelTeachers.AutoSize = true;
            this.labelTeachers.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeachers.Location = new System.Drawing.Point(12, 28);
            this.labelTeachers.Name = "labelTeachers";
            this.labelTeachers.Size = new System.Drawing.Size(83, 30);
            this.labelTeachers.TabIndex = 7;
            this.labelTeachers.Text = "label1";
            // 
            // Students
            // 
            this.Students.Location = new System.Drawing.Point(12, 75);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(143, 23);
            this.Students.TabIndex = 8;
            this.Students.Text = "Студенти";
            this.Students.UseVisualStyleBackColor = true;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Teachers
            // 
            this.Teachers.Location = new System.Drawing.Point(217, 75);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(143, 23);
            this.Teachers.TabIndex = 9;
            this.Teachers.Text = "Викладачі";
            this.Teachers.UseVisualStyleBackColor = true;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // FormGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 523);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.labelTeachers);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.PanelStudy);
            this.Controls.Add(this.PanelStudents);
            this.Name = "FormGrades";
            this.Text = "Bobrito Bandito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelStudents;
        private System.Windows.Forms.Panel PanelStudy;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTeachers;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Teachers;
    }
}