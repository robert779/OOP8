namespace OOP8
{
    partial class FormSubject
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
            this.SubjectNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.PanelSubjects = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SubjectNameText
            // 
            this.SubjectNameText.Location = new System.Drawing.Point(12, 38);
            this.SubjectNameText.Name = "SubjectNameText";
            this.SubjectNameText.Size = new System.Drawing.Size(165, 20);
            this.SubjectNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Назва дисципліни ";
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddSubject.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSubject.Location = new System.Drawing.Point(11, 64);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(166, 23);
            this.buttonAddSubject.TabIndex = 21;
            this.buttonAddSubject.Text = "Додати дисципліну\r\n\r\n";
            this.buttonAddSubject.UseVisualStyleBackColor = false;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // PanelSubjects
            // 
            this.PanelSubjects.AutoScroll = true;
            this.PanelSubjects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelSubjects.Location = new System.Drawing.Point(11, 108);
            this.PanelSubjects.Name = "PanelSubjects";
            this.PanelSubjects.Size = new System.Drawing.Size(393, 330);
            this.PanelSubjects.TabIndex = 22;
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.PanelSubjects);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjectNameText);
            this.Name = "FormSubject";
            this.Text = "Bombardiro Crocodilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SubjectNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Panel PanelSubjects;
    }
}