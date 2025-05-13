namespace OOP8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelGroups = new System.Windows.Forms.Panel();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelStudents = new System.Windows.Forms.Panel();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.PanelGroupInfo = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.FindGroupText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindSurnameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FindNameText = new System.Windows.Forms.TextBox();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.PanelStudentInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentGroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddTeacher = new System.Windows.Forms.Button();
            this.StudentSecondName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.RatingStart = new System.Windows.Forms.TextBox();
            this.RatingEnd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BoxSuccess = new System.Windows.Forms.ComboBox();
            this.BoxNotSuccess = new System.Windows.Forms.ComboBox();
            this.ButtonFindSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelGroups
            // 
            this.PanelGroups.AutoScroll = true;
            this.PanelGroups.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelGroups.Location = new System.Drawing.Point(12, 115);
            this.PanelGroups.Name = "PanelGroups";
            this.PanelGroups.Size = new System.Drawing.Size(305, 519);
            this.PanelGroups.TabIndex = 0;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddGroup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroup.Location = new System.Drawing.Point(13, 86);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(137, 23);
            this.buttonAddGroup.TabIndex = 0;
            this.buttonAddGroup.Text = "Додати групу";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // GroupName
            // 
            this.GroupName.Location = new System.Drawing.Point(12, 60);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(138, 20);
            this.GroupName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Назва групи";
            // 
            // PanelStudents
            // 
            this.PanelStudents.AutoScroll = true;
            this.PanelStudents.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelStudents.Location = new System.Drawing.Point(337, 115);
            this.PanelStudents.Name = "PanelStudents";
            this.PanelStudents.Size = new System.Drawing.Size(424, 386);
            this.PanelStudents.TabIndex = 1;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(411, 60);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(178, 20);
            this.StudentName.TabIndex = 3;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddStudent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.Location = new System.Drawing.Point(595, 6);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(166, 23);
            this.buttonAddStudent.TabIndex = 4;
            this.buttonAddStudent.Text = "Додати студента";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.buttonShowAll.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAll.Location = new System.Drawing.Point(797, 6);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(150, 23);
            this.buttonShowAll.TabIndex = 5;
            this.buttonShowAll.Text = "Показати усіх студентів";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // PanelGroupInfo
            // 
            this.PanelGroupInfo.AutoScroll = true;
            this.PanelGroupInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelGroupInfo.Location = new System.Drawing.Point(797, 115);
            this.PanelGroupInfo.Name = "PanelGroupInfo";
            this.PanelGroupInfo.Size = new System.Drawing.Size(428, 153);
            this.PanelGroupInfo.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(346, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Група";
            // 
            // FindGroupText
            // 
            this.FindGroupText.Location = new System.Drawing.Point(411, 529);
            this.FindGroupText.Name = "FindGroupText";
            this.FindGroupText.Size = new System.Drawing.Size(178, 20);
            this.FindGroupText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Прізвище";
            // 
            // FindSurnameText
            // 
            this.FindSurnameText.Location = new System.Drawing.Point(411, 557);
            this.FindSurnameText.Name = "FindSurnameText";
            this.FindSurnameText.Size = new System.Drawing.Size(178, 20);
            this.FindSurnameText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(346, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ім\'я";
            // 
            // FindNameText
            // 
            this.FindNameText.Location = new System.Drawing.Point(411, 585);
            this.FindNameText.Name = "FindNameText";
            this.FindNameText.Size = new System.Drawing.Size(178, 20);
            this.FindNameText.TabIndex = 13;
            // 
            // ButtonFind
            // 
            this.ButtonFind.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonFind.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFind.Location = new System.Drawing.Point(349, 611);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(240, 23);
            this.ButtonFind.TabIndex = 14;
            this.ButtonFind.Text = "Знайти";
            this.ButtonFind.UseVisualStyleBackColor = false;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveDataButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDataButton.Location = new System.Drawing.Point(1059, 12);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(166, 23);
            this.SaveDataButton.TabIndex = 15;
            this.SaveDataButton.Text = "Зберегти дані";
            this.SaveDataButton.UseVisualStyleBackColor = false;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.GetDataButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetDataButton.Location = new System.Drawing.Point(1059, 41);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(166, 23);
            this.GetDataButton.TabIndex = 16;
            this.GetDataButton.Text = "Відновити дані";
            this.GetDataButton.UseVisualStyleBackColor = false;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // PanelStudentInfo
            // 
            this.PanelStudentInfo.AutoScroll = true;
            this.PanelStudentInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelStudentInfo.Location = new System.Drawing.Point(797, 274);
            this.PanelStudentInfo.Name = "PanelStudentInfo";
            this.PanelStudentInfo.Size = new System.Drawing.Size(428, 227);
            this.PanelStudentInfo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(346, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Знайти студента";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(156, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Переглянути дисципліни ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentSurname
            // 
            this.StudentSurname.Location = new System.Drawing.Point(411, 34);
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.Size = new System.Drawing.Size(178, 20);
            this.StudentSurname.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(334, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Прізвище";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(334, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ім\'я";
            // 
            // StudentGroup
            // 
            this.StudentGroup.Location = new System.Drawing.Point(411, 8);
            this.StudentGroup.Name = "StudentGroup";
            this.StudentGroup.Size = new System.Drawing.Size(178, 20);
            this.StudentGroup.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(334, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Група";
            // 
            // AddTeacher
            // 
            this.AddTeacher.BackColor = System.Drawing.SystemColors.Control;
            this.AddTeacher.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeacher.Location = new System.Drawing.Point(595, 32);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(166, 23);
            this.AddTeacher.TabIndex = 24;
            this.AddTeacher.Text = "Додати викладача";
            this.AddTeacher.UseVisualStyleBackColor = false;
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacherClick);
            // 
            // StudentSecondName
            // 
            this.StudentSecondName.Location = new System.Drawing.Point(411, 86);
            this.StudentSecondName.Name = "StudentSecondName";
            this.StudentSecondName.Size = new System.Drawing.Size(178, 20);
            this.StudentSecondName.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(334, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "По-Батькові";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(797, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 22);
            this.button3.TabIndex = 27;
            this.button3.Text = "Показати викладачів";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ShowTeachers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(608, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Рейтинг від";
            // 
            // RatingStart
            // 
            this.RatingStart.Location = new System.Drawing.Point(683, 586);
            this.RatingStart.Name = "RatingStart";
            this.RatingStart.Size = new System.Drawing.Size(68, 20);
            this.RatingStart.TabIndex = 29;
            // 
            // RatingEnd
            // 
            this.RatingEnd.Location = new System.Drawing.Point(783, 587);
            this.RatingEnd.Name = "RatingEnd";
            this.RatingEnd.Size = new System.Drawing.Size(68, 20);
            this.RatingEnd.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(757, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "до";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(607, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Успішний за ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(607, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Неуспішний за ";
            // 
            // BoxSuccess
            // 
            this.BoxSuccess.FormattingEnabled = true;
            this.BoxSuccess.Location = new System.Drawing.Point(698, 529);
            this.BoxSuccess.Name = "BoxSuccess";
            this.BoxSuccess.Size = new System.Drawing.Size(153, 21);
            this.BoxSuccess.TabIndex = 36;
            this.BoxSuccess.Click += new System.EventHandler(this.BoxSuccess_Click);
            // 
            // BoxNotSuccess
            // 
            this.BoxNotSuccess.FormattingEnabled = true;
            this.BoxNotSuccess.Location = new System.Drawing.Point(698, 558);
            this.BoxNotSuccess.Name = "BoxNotSuccess";
            this.BoxNotSuccess.Size = new System.Drawing.Size(153, 21);
            this.BoxNotSuccess.TabIndex = 37;
            this.BoxNotSuccess.Click += new System.EventHandler(this.BoxNotSuccess_Click);
            // 
            // ButtonFindSuccess
            // 
            this.ButtonFindSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonFindSuccess.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFindSuccess.Location = new System.Drawing.Point(611, 611);
            this.ButtonFindSuccess.Name = "ButtonFindSuccess";
            this.ButtonFindSuccess.Size = new System.Drawing.Size(240, 23);
            this.ButtonFindSuccess.TabIndex = 38;
            this.ButtonFindSuccess.Text = "Знайти за успішністю";
            this.ButtonFindSuccess.UseVisualStyleBackColor = false;
            this.ButtonFindSuccess.Click += new System.EventHandler(this.ButtonFindSuccess_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 642);
            this.Controls.Add(this.ButtonFindSuccess);
            this.Controls.Add(this.BoxNotSuccess);
            this.Controls.Add(this.BoxSuccess);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RatingEnd);
            this.Controls.Add(this.RatingStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StudentSecondName);
            this.Controls.Add(this.AddTeacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StudentGroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentSurname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PanelStudentInfo);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.FindNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FindSurnameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FindGroupText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelGroupInfo);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.PanelStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.PanelGroups);
            this.Name = "MainForm";
            this.Text = "Tralalero Tralala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGroups;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelStudents;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Panel PanelGroupInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FindGroupText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FindSurnameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FindNameText;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Panel PanelStudentInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox StudentSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StudentGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddTeacher;
        private System.Windows.Forms.TextBox StudentSecondName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RatingStart;
        private System.Windows.Forms.TextBox RatingEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox BoxSuccess;
        private System.Windows.Forms.ComboBox BoxNotSuccess;
        private System.Windows.Forms.Button ButtonFindSuccess;
    }
}

