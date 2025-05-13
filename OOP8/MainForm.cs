using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace OOP8
{
    public partial class MainForm : Form
    {
        public static Font StandartFont = new Font("Arial", 10, FontStyle.Bold);
        public int groupcount = 0;
        public School school = new School();
        InterfaceManager im;
        public MainForm()
        {
            InitializeComponent();
            im = new InterfaceManager();
        }
        private void AddGroup_Click(object sender, EventArgs e)
        {
            string groupname = GroupName.Text;
            school.AddGroup(groupname);
            ShowGroups();
        }
        private void ShowGroups()
        {
            PanelGroups.Controls.Clear();
            school.SortGroups();
            int group_count = 0;
            foreach (StudentGroup group in school.groups)
            {
                Button viewButton, deleteButton;
                Label nameLabel;
                nameLabel = im.CreateLabel(group.Groupname, 15, 17 + group_count * 30);

                viewButton = im.CreateButton("Переглянути", 90, 15 + group_count * 30, 80, 23);
                viewButton.Tag = group;
                viewButton.Click += new EventHandler(ViewGroup_Click);

                deleteButton = im.CreateButton("Видалити", 190, 15 + group_count * 30, 80, 23);
                deleteButton.Tag = group;
                deleteButton.Click += new EventHandler(DeleteGroup_Click);

                PanelGroups.Controls.Add(nameLabel);
                PanelGroups.Controls.Add(viewButton);
                PanelGroups.Controls.Add(deleteButton);
                group_count++;
            }
        }
        private void ShowStudent(Student student, int counter)
        {
            Button viewButton, deleteButton;
            Label nameLabel;
            Label studentnameLabel = new Label();
            nameLabel = im.CreateLabel($"{student.group.Groupname} {student.Surname} {student.Name}", 15, 17 + counter * 30);

            viewButton = im.CreateButton("Переглянути", 250, 15 + counter * 30, 80, 23);
            viewButton.Tag = student;
            viewButton.Click += new EventHandler(ViewStudent_Click);

            deleteButton = im.CreateButton("Відрахувати", 340, 15 + counter * 30, 80, 23);
            deleteButton.Tag = student;
            deleteButton.Click += new EventHandler(DeleteStudent_Click);

            PanelStudents.Controls.Add(nameLabel);
            PanelStudents.Controls.Add(viewButton);
            PanelStudents.Controls.Add(deleteButton);
        }
        private void ShowStudents(StudentGroup group)
        {
            group.SortStudents();
            int student_count = 0;
            foreach (Student student in group.students)
            {
                ShowStudent(student, student_count);
                student_count++;
            }
        }
        private void ViewGroup_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            StudentGroup group = btn.Tag as StudentGroup;
            PanelStudents.Controls.Clear();
            ShowStudents(group);
            PanelGroupInfo.Controls.Clear();
            ShowGroupInfo(group);
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            StudentGroup group = btn.Tag as StudentGroup;
            school.RemoveGroup(group);
            PanelGroupInfo.Controls.Clear();
            PanelStudents.Controls.Clear();
            ShowGroups();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            string groupname = StudentGroup.Text;
            string studentname = StudentName.Text;
            string studentsurname = StudentSurname.Text;
            string secondname = StudentSecondName.Text;
            StudentGroup group = school.groups.FirstOrDefault(g => g.Groupname == groupname);
            if (studentname == string.Empty || studentsurname == string.Empty|| group == null)
            {
                return;
            }
            Student student = new Student(studentname, studentsurname, secondname, group);
            group.AddStudent(student);
            PanelStudents.Controls.Clear();
            ShowStudents(group);
        }
        private void ViewStudent_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Student student = btn.Tag as Student;
            TextBox nameText, surnameText, secondnameText, groupText;
            Label name, surname, group, average, subjects, secondname;
            Button buttonSave;
            PanelStudentInfo.Controls.Clear();

            nameText = im.CreateTextBox(student.Name, 150, 10, 240, 20);
            surnameText = im.CreateTextBox(student.Surname, 150, 35, 240, 20);
            secondnameText = im.CreateTextBox(student.SecondName, 150, 60, 240, 20);
            groupText = im.CreateTextBox(student.group.Groupname, 150, 85, 240, 20);

            name = im.CreateLabel("Ім'я ", 15, 10);
            surname = im.CreateLabel("Прізвище ", 15, 35);
            secondname = im.CreateLabel("По-Батькові ", 15, 60);
            group = im.CreateLabel("Група ", 15, 85);
            average = im.CreateLabel($"Рейтинг: {student.GetRating()} ", 15, 110);
            subjects = im.CreateLabel("Вивчає:", 15, 135);
            int height = 160;
            if (student.grades.Count == 0)
            {
                subjects.Text += "\nнічого(";
                height += 15;
            }
            else
            {
                foreach (var entry in student.grades)
                {
                    Subject subject = entry.Key;
                    subjects.Text += $"\n{subject.name} ({student.GetScore(subject)})";
                    height += 15;
                }
            }
            buttonSave = im.CreateButton("Зберегти", 15, height, 80, 23);
            buttonSave.Tag = student;
            buttonSave.Click += new EventHandler(SaveStudentInfo);

            PanelStudentInfo.Controls.Add(nameText);
            PanelStudentInfo.Controls.Add(surnameText);
            PanelStudentInfo.Controls.Add(secondnameText);
            PanelStudentInfo.Controls.Add(groupText);
            PanelStudentInfo.Controls.Add(name);
            PanelStudentInfo.Controls.Add(surname);
            PanelStudentInfo.Controls.Add(secondname);
            PanelStudentInfo.Controls.Add(group);
            PanelStudentInfo.Controls.Add(average);
            PanelStudentInfo.Controls.Add(subjects);
            PanelStudentInfo.Controls.Add(buttonSave);
        }
        private void SaveStudentInfo(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Student student = btn.Tag as Student;
            StudentGroup lastGroup = student.group;
            student.Name = PanelStudentInfo.Controls[0].Text;
            student.Surname = PanelStudentInfo.Controls[1].Text;
            student.SecondName = PanelStudentInfo.Controls[2].Text;
            string groupname = PanelStudentInfo.Controls[3].Text;
            StudentGroup group = school.groups.FirstOrDefault(g => g.Groupname == groupname);
            if (group != null)
            {
                student.group = group;
                group.students.Add(student);
                lastGroup.students.Remove(student);
            }
            PanelStudents.Controls.Clear();
            ShowStudents(student.group);
            PanelStudentInfo.Controls.Clear();
        }
        private void DeleteStudent_Click(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Student student = btn.Tag as Student;
            StudentGroup group = student.group;
            group.students.Remove(student);
            foreach (var entry in student.grades)
            {
                Subject subject = entry.Key;
                subject.students.Remove(student);
            }
            student= null;
            PanelStudents.Controls.Clear();
            PanelGroupInfo.Controls.Clear();
            PanelStudentInfo.Controls.Clear();
            ShowStudents(group);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            PanelStudents.Controls.Clear();
            foreach (StudentGroup group in school.groups)
            {
                foreach(Student student in group.students)
                {
                    ShowStudent(student, count++);
                }
            }
        }
        private void ShowGroupInfo(StudentGroup group)
        {
            TextBox groupnameText, facultyText, specialtyText, courseText;
            Label faculty, specialty, course, average;

            groupnameText = im.CreateTextBox(group.Groupname, 15, 10, 120, 20);
            groupnameText.Tag = group;
            groupnameText.TextChanged += new EventHandler(ChangeGroupName);

            facultyText = im.CreateTextBox(group.Faculty, 150, 35, 240, 20);
            facultyText.Tag = group;
            facultyText.TextChanged += new EventHandler(ChangeFaculty);

            specialtyText = im.CreateTextBox(group.Specialty, 150, 60, 240, 20);
            specialtyText.Tag = group;
            specialtyText.TextChanged += new EventHandler(ChangeSpecialty);

            courseText = im.CreateTextBox($"{group.Course}", 150, 85, 240, 20);
            courseText.Tag = group;
            courseText.TextChanged += new EventHandler(ChangeCourse);

            faculty = im.CreateLabel("Факультет: ", 15, 35);
            specialty = im.CreateLabel("Спеціальність: ", 15, 60);
            course = im.CreateLabel("Курс: ", 15, 85);
            average = im.CreateLabel($"Середній рейтинг: {group.GetAverage(school):F2}", 15, 110);

            PanelGroupInfo.Controls.Add(groupnameText);
            PanelGroupInfo.Controls.Add(faculty);
            PanelGroupInfo.Controls.Add(specialty);
            PanelGroupInfo.Controls.Add(facultyText);
            PanelGroupInfo.Controls.Add(specialtyText);
            PanelGroupInfo.Controls.Add(course);
            PanelGroupInfo.Controls.Add(courseText);
            PanelGroupInfo.Controls.Add(average);

            PanelStudentInfo.Controls.Clear();
        }
        private void ChangeGroupName(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            StudentGroup group = tb.Tag as StudentGroup;
            group.Groupname = tb.Text;
            ShowGroups();
            PanelStudents.Controls.Clear();
            ShowStudents(group);
        }
        private void ChangeFaculty(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            StudentGroup group = tb.Tag as StudentGroup;
            group.Faculty = tb.Text;
        }
        private void ChangeSpecialty(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            StudentGroup group = tb.Tag as StudentGroup;
            group.Specialty = tb.Text;
        }
        private void ChangeCourse(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            StudentGroup group = tb.Tag as StudentGroup;
            group.Course = int.Parse(tb.Text);
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string searchName = FindNameText.Text;
            string searchSurname = FindSurnameText.Text;
            string searchGroup = FindGroupText.Text;
            PanelStudents.Controls.Clear();
            foreach (StudentGroup g in school.groups)
            {
                foreach (Student s in g.students)
                {
                    if (s.Matches(searchName, searchSurname, searchGroup))
                    {
                        ShowStudent(s, counter++);
                    }
                }
            }
        }
        private void ButtonFindSuccess_Click(object sender, EventArgs e)
        {
            int counter = 0;
            Subject subject1, subject2;
            float ratingstart, ratingend;
            bool successMatch, notsuccessMatch, ratingMatch;
            PanelStudents.Controls.Clear();
            if (string.IsNullOrEmpty(RatingStart.Text) || !float.TryParse(RatingStart.Text, out float start) || start < 0)
            {
                ratingstart = 0;

            }
            else if (start > 100)
            {
                ratingstart = 100;
            }
            else
            {
                ratingstart = float.Parse(RatingStart.Text);
            }
            if (string.IsNullOrEmpty(RatingEnd.Text) || !float.TryParse(RatingEnd.Text, out float end) || end > 100)
            {
                ratingend = 100;

            }
            else if (end < 0)
            {
                ratingend = 0;
            }
            else
            {
                ratingend = float.Parse(RatingEnd.Text);
            }
            if (ratingend < ratingstart)
            {
                ratingend = ratingstart + 10;
                if (ratingend > 100) ratingend = 100;
            }
            RatingStart.Text = $"{ratingstart}";
            RatingEnd.Text = $"{ratingend}";
            subject1 = school.subjects.FirstOrDefault(s => s.name == BoxSuccess.Text);
            subject2 = school.subjects.FirstOrDefault(s => s.name == BoxNotSuccess.Text);
            foreach (StudentGroup g in school.groups)
            {
                foreach (Student s in g.students)
                {
                    ratingMatch =s.GetRating()>=ratingstart && s.GetRating()<=ratingend;
                    if (BoxSuccess.Text == string.Empty)
                    {
                        successMatch = true;
                    }
                    else
                    {
                        successMatch = s.SuccessfullIn(subject1);
                    }
                    if (BoxNotSuccess.Text == string.Empty)
                    {
                        notsuccessMatch = true;
                    }
                    else
                    {
                        notsuccessMatch = s.NotSuccessfullIn(subject2);
                    }
                    if (ratingMatch && successMatch && notsuccessMatch)
                    {
                        ShowStudent(s, counter++);
                    }
                }
            }

        }
        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            school.SaveData();
        }
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            school.GetData();
            ShowGroups();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormSubject form = new FormSubject(school);
            form.Show();
        }
        private void AddTeacherClick(object sender, EventArgs e)
        {
            string name = StudentName.Text;
            string surname = StudentSurname.Text;
            string secondname = StudentSecondName.Text;
            if (name == string.Empty || surname == string.Empty || secondname == string.Empty)
            {
                return;
            }
            school.AddTeacher(name,surname,secondname);
            PanelStudents.Controls.Clear();
            PanelStudentInfo.Controls.Clear();
            PanelGroupInfo.Controls.Clear();
            ShowTeachers();
        }
        private void ShowTeachers()
        {
            int count = 0;
            foreach (Teacher teacher in school.teachers)
            {
                ShowTeacher(teacher, count++);
            }
        }
        private void ShowTeacher(Teacher teacher, int count)
        {
            Button viewButton, deleteButton;
            Label nameLabel;
            nameLabel = im.CreateLabel($" {teacher.Surname} {teacher.Name} {teacher.SecondName}", 15, 17 + count * 30);

            viewButton = im.CreateButton("Переглянути", 250, 15 + count * 30, 80, 23);
            viewButton.Tag = teacher;
            viewButton.Click += new EventHandler(ViewTeacher_Click);

            deleteButton = im.CreateButton("Звільнити", 340, 15 + count * 30, 80, 23);
            deleteButton.Tag = teacher;
            deleteButton.Click += new EventHandler(DeleteTeacher_Click);

            PanelStudents.Controls.Add(nameLabel);
            PanelStudents.Controls.Add(viewButton);
            PanelStudents.Controls.Add(deleteButton);
        }
        private void ViewTeacher_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Teacher teacher = btn.Tag as Teacher;
            TextBox nameText, surnameText, secondnameText;
            Label name, surname, secondname, subjectsText;
            Button buttonSave;
            PanelStudentInfo.Controls.Clear();

            nameText = im.CreateTextBox(teacher.Name, 150, 10, 240, 20);
            surnameText = im.CreateTextBox(teacher.Surname, 150, 35, 240, 20);
            secondnameText = im.CreateTextBox(teacher.SecondName, 150, 60, 240, 20);

            name = im.CreateLabel("Ім'я ", 15, 10);
            surname = im.CreateLabel("Прізвище ", 15, 35);
            secondname = im.CreateLabel("По-Батькові ", 15, 60);
            subjectsText = im.CreateLabel("Викладає:", 15, 85);
            int height = 110;
            if (teacher.subjects.Count == 0)
            {
                subjectsText.Text += "\nнічого(";
                height += 15;
            }
            else
            {
                foreach (Subject subject in teacher.subjects)
                {
                    subjectsText.Text += $"\n{subject.name}";
                    height += 15;
                }
            }

            buttonSave = im.CreateButton("Зберегти", 15, height, 80, 23);
            buttonSave.Tag = teacher;
            buttonSave.Click += new EventHandler(SaveTeacherInfo);

            PanelStudentInfo.Controls.Add(nameText);
            PanelStudentInfo.Controls.Add(surnameText);
            PanelStudentInfo.Controls.Add(secondnameText);
            PanelStudentInfo.Controls.Add(name);
            PanelStudentInfo.Controls.Add(surname);
            PanelStudentInfo.Controls.Add(secondname);
            PanelStudentInfo.Controls.Add(subjectsText);
            PanelStudentInfo.Controls.Add(buttonSave);
        }
        private void SaveTeacherInfo(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Teacher teacher = btn.Tag as Teacher;
            teacher.Name = PanelStudentInfo.Controls[0].Text;
            teacher.Surname = PanelStudentInfo.Controls[1].Text;
            teacher.SecondName = PanelStudentInfo.Controls[2].Text;
            PanelStudents.Controls.Clear();
            ShowTeachers();
            PanelStudentInfo.Controls.Clear();
        }
        private void DeleteTeacher_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Teacher teacher = btn.Tag as Teacher;
            school.teachers.Remove(teacher);
            teacher = null;
            PanelStudents.Controls.Clear();
            PanelGroupInfo.Controls.Clear();
            PanelStudentInfo.Controls.Clear();
            ShowTeachers();
        }

        private void ShowTeachers_Click(object sender, EventArgs e)
        {
            PanelStudents.Controls.Clear();
            PanelStudentInfo.Controls.Clear();
            PanelGroupInfo.Controls.Clear();
            ShowTeachers();
        }

        private void BoxSuccess_Click(object sender, EventArgs e)
        {
            BoxSuccess.Items.Clear();
            BoxSuccess.Items.Add("");
            foreach(Subject subject in school.subjects)
            {
                BoxSuccess.Items.Add(subject.name);
            }
        }

        private void BoxNotSuccess_Click(object sender, EventArgs e)
        {
            BoxNotSuccess.Items.Clear();
            BoxNotSuccess.Items.Add("");
            foreach (Subject subject in school.subjects)
            {
                BoxNotSuccess.Items.Add(subject.name);
            }
        }


    }
}
