using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace OOP8
{
    public partial class FormGrades : Form
    {
        public School school;
        public Subject s;
        public InterfaceManager im = new InterfaceManager();
        public FormGrades(School sc, Subject sub)
        {
            InitializeComponent();
            school = sc;
            s = sub;
            labelSubject.Text = s.name;
            ShowStudents();
            ShowStudy();
            ViewTeachers();
        }
        private void ShowStudents()
        {
            PanelStudents.Controls.Clear();
            int counter = 0;
            foreach (StudentGroup group in school.groups)
            {
                foreach (Student student in group.students)
                {
                    Label nameLabel;
                    CheckBox check;
                    nameLabel = im.CreateLabel($"{student.group.Groupname} {student.Surname} {student.Name}", 15, 17 + counter * 30);

                    check = new CheckBox();
                    if (student.grades.Keys.Any(subject => subject.name == s.name))
                    {
                        check.Checked = true;
                    }
                    else
                    {
                        check.Checked = false;
                    }
                    check.Location = new Point(230, 17 + counter * 30);
                    check.Tag = student;
                    check.CheckedChanged += new EventHandler(StudentCheck);

                    PanelStudents.Controls.Add(nameLabel);
                    PanelStudents.Controls.Add(check);
                    counter++;
                }
            }
        }
        private void ShowTeachers()
        {
            PanelStudents.Controls.Clear();
            int counter = 0;
            foreach (Teacher teacher in school.teachers)
            {
                Label nameLabel;
                CheckBox check;
                nameLabel = im.CreateLabel($"{teacher.Surname} {teacher.Name} {teacher.SecondName}", 15, 17 + counter * 30);
                check = new CheckBox();
                if (teacher.subjects.Contains(s))
                {
                    check.Checked = true;
                }
                else
                {
                    check.Checked = false;
                }
                check.Location = new Point(230, 17 + counter * 30);
                check.Tag = teacher;
                check.CheckedChanged += new EventHandler(TeacherCheck);

                PanelStudents.Controls.Add(nameLabel);
                PanelStudents.Controls.Add(check);
                counter++;
            }
        }
        private void ViewTeachers()
        {
            labelTeachers.Text = "Викладають: ";
            foreach (Teacher teacher in school.teachers)
            {
                if (teacher.subjects.Contains(s))
                {
                    labelTeachers.Text += teacher.GetInitials();
                }
            }
        }
        private void StudentCheck(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            Student student = check.Tag as Student;
            if (check.Checked)
            {
                s.AddStudent(student);
                ShowStudy();
                ShowGrades();
            }
            else
            {
                s.students.Remove(student);
                student.grades.Remove(s);
                ShowStudy();
                ShowGrades();
            }
        }
        private void TeacherCheck(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            Teacher teacher = check.Tag as Teacher;
            if (check.Checked)
            {
                teacher.subjects.Add(s);
                ShowTeachers();
                ViewTeachers();
            }
            else
            {
                teacher.subjects.Remove(s);
                ShowTeachers();
                ViewTeachers();
            }
        }
        private void ShowStudy()
        {
            PanelStudy.Controls.Clear();
            int counter = 0;
            foreach (Student student in s.students)
            {
                Label nameLabel;
                nameLabel = im.CreateLabel($"{student.group.Groupname} {student.Surname} {student.Name}", 15, 40 + counter * 30);

                PanelStudy.Controls.Add(nameLabel);
                counter++;
            }
            ShowGrades();
        }
        private void ShowGrades()
        {
            int counter = 0;
            if (s.students.Count!=0 && s.students[0].grades.Count!=0)
            {
                Student stud = s.students[0];
                foreach (Grade grade in stud.grades[s])
                {
                    TextBox description;
                    description = im.CreateTextBox(grade.description, 250 + counter * 50, 10, 40, 40);
                    description.Name = $"{counter}";
                    PanelStudy.Controls.Add(description);
                    counter++;
                }
                int studentcount = 0;
                foreach (Student student in s.students)
                {
                    int gradecount = 0;
                    foreach (Grade grade in student.grades[s])
                    {
                        TextBox gradeText;
                        gradeText = im.CreateTextBox($"{grade.value}", 250 + gradecount * 50, 40+studentcount*30, 40, 40);
                        gradeText.Name = $"{studentcount} {gradecount}";
                        gradeText.Tag = grade;
                        PanelStudy.Controls.Add(gradeText);
                        gradecount++;
                    }
                    studentcount++;
                }
                Button addGrade, deleteGrade;
                addGrade = im.CreateButton("+", 250 + counter * 50, 10, 23, 23);
                addGrade.Click += new EventHandler(AddGradeClick);
                deleteGrade = im.CreateButton("-", 300 + counter * 50, 10, 23, 23);
                deleteGrade.Click += new EventHandler(DeleteGradeClick);
                PanelStudy.Controls.Add(addGrade);
                PanelStudy.Controls.Add(deleteGrade);
            }
        }
        private void AddGradeClick(object sender, EventArgs e)
        {
            s.AddGrade();
            ShowStudy();
        }
        private void DeleteGradeClick(object sender, EventArgs e)
        {
            s.DeleteGrade();
            ShowStudy();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            float data;
            string description;
            int studentcount = 0;
            foreach (Student student in s.students)
            {
                int gradecount = 0;
                foreach (Grade grade in student.grades[s])
                {
                    TextBox descriptionBox = PanelStudy.Controls.Find($"{gradecount}", true).FirstOrDefault() as TextBox;
                    description = descriptionBox.Text;
                    TextBox dataBox = PanelStudy.Controls.Find($"{studentcount} {gradecount}", true).FirstOrDefault() as TextBox;
                    data = float.Parse(dataBox.Text);
                    Grade newgrade = dataBox.Tag as Grade;
                    newgrade.description = description;
                    newgrade.value = data;
                    gradecount++;
                }
                studentcount++;
            }
        }

        private void Students_Click(object sender, EventArgs e)
        {
            ShowStudents();
            ShowStudy();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            ShowTeachers();
        }
    }
}
