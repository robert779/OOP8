using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    public class Subject
    {
        public string name;
        public List<Student> students;
        public int gradecount = 0;
        public Subject(string name)
        {
            this.name = name;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
            student.AddSubject(this);
            for (int i = 0; i < this.gradecount; i++)
            {
                Grade grade = new Grade("-", 0);
                student.grades[this].Add(grade);
            }
            SortStudents();
        }
        private void SortStudents()
        {
            students = students.OrderBy(s => s.Surname).OrderBy(s => s.group.Groupname).ToList();
        }
        public void AddGrade()
        {
            foreach (Student student in students)
            {
                Grade grade = new Grade("-", 0);
                student.grades[this].Add(grade);
            }
            gradecount++;
        }
        public void DeleteGrade()
        {
            if (gradecount > 0)
            {
                foreach (Student student in students)
                {
                    student.grades[this].RemoveAt(student.grades[this].Count - 1);
                }
                gradecount--;
            }
        }
    }
}
