using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP8
{
    public partial class FormSubject : Form
    {
        public School school;
        public InterfaceManager im = new InterfaceManager();
        public FormSubject(School sc)
        {
            InitializeComponent();
            school = sc;
            ShowSubjects();
        }
        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            string subjectname = SubjectNameText.Text;
            school.AddSubject(subjectname);
            ShowSubjects();
        }
        private void ShowSubjects()
        {
            PanelSubjects.Controls.Clear();
            int subject_counter = 0;
            foreach (Subject s in school.subjects)
            {
                    Button viewButton, deleteButton;
                    Label nameLabel;
                    nameLabel = im.CreateLabel(s.name, 15, 17 + subject_counter * 30);

                    viewButton = im.CreateButton("Переглянути", 150, 15 + subject_counter * 30, 80, 23);
                    viewButton.Tag = s;
                    viewButton.Click += new EventHandler(ShowSubject_Click);

                    deleteButton = im.CreateButton("Видалити", 250, 15 + subject_counter * 30, 80, 23);
                    deleteButton.Tag = s;
                    deleteButton.Click += new EventHandler(DeleteSubject_Click);

                    PanelSubjects.Controls.Add(nameLabel);
                    PanelSubjects.Controls.Add(viewButton);
                    PanelSubjects.Controls.Add(deleteButton);
                    subject_counter++;
            }
        }
        private void ShowSubject_Click(object sender, EventArgs e)
        {
            Button btn =sender as Button;
            Subject subject = btn.Tag as Subject;
            FormGrades form = new FormGrades(school, subject);
            form.Show();
        }
        private void DeleteSubject_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Subject subject = btn.Tag as Subject; 
            school.RemoveSubject(subject);
            ShowSubjects();
        }
    }
}

