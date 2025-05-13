using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    public class School
    {
        public List<StudentGroup> groups = new List<StudentGroup>();
        public List<Subject> subjects = new List<Subject>();
        public List<Teacher> teachers = new List<Teacher>();
        public StudentGroup AddGroup(string name)
        {
            StudentGroup group = new StudentGroup(name);
            groups.Add(group);
            this.SortGroups();
            return group;
        }
        public Teacher AddTeacher(string name, string surname, string secondname)
        {
            Teacher teacher = new Teacher(name, surname, secondname);
            teachers.Add(teacher);
            this.SortTeachers();
            return teacher;
        }
        public Subject AddSubject(string name)
        {
            Subject subject = new Subject(name);
            subjects.Add(subject);
            this.SortSubjects();
            return subject;
        }
        public void RemoveGroup(StudentGroup group)
        {
            if (groups.Contains(group))
            {
                groups.Remove(group);
                group = null;
            }
        }
        public void RemoveSubject(Subject subject)
        {
            if (subjects.Contains(subject))
            {
                subjects.Remove(subject);
                foreach (Teacher teacher in teachers)
                {
                    if(teacher.subjects.Contains(subject))
                    {
                        teacher.subjects.Remove(subject);
                    }
                }
                subject = null;
            }
        }
        public void SortGroups()
        {
            groups = groups.OrderBy(g => g.Groupname).ToList();
        }
        public void SortTeachers()
        {
            teachers = teachers.OrderBy(t => t.Surname).ToList();
        }
        public void SortSubjects()
        {
            subjects = subjects.OrderBy(s => s.name).ToList();
        }
        public void SaveData()
        {
            string pathGroups = "!groups.txt";
            string pathStudents = "!students.txt";
            string pathSubjects = "!subjects.txt";
            string pathTeachers = "!teachers.txt";
            using (StreamWriter writer = new StreamWriter(pathGroups))
            {
                foreach (StudentGroup group in this.groups)
                {
                    writer.WriteLine(group.Groupname);
                    writer.WriteLine(group.Faculty);
                    writer.WriteLine(group.Specialty);
                    writer.WriteLine(group.Course);
                }
            }
            using (StreamWriter writer = new StreamWriter(pathStudents))
            {
                foreach (StudentGroup group in this.groups)
                {
                    foreach (Student student in group.students)
                    {
                        writer.WriteLine(student.Name);
                        writer.WriteLine(student.Surname);
                        writer.WriteLine(student.SecondName);
                        writer.WriteLine(student.group.Groupname);
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(pathSubjects))
            {
                writer.WriteLine(this.subjects.Count);
                foreach (Subject subject in this.subjects)
                {
                    writer.WriteLine(subject.name);
                    writer.WriteLine(subject.students.Count);
                    writer.WriteLine(subject.gradecount);
                    foreach (Student student in subject.students)
                    {
                        writer.WriteLine(student.Surname);
                        writer.WriteLine(student.Name);
                        writer.WriteLine(student.SecondName);
                        writer.WriteLine(student.group.Groupname);
                        foreach (Grade grade in student.grades[subject])
                        {
                            writer.WriteLine(grade.description);
                            writer.WriteLine(grade.value);
                        }
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(pathTeachers))
            {
                writer.WriteLine(this.teachers.Count);
                foreach (Teacher teacher in this.teachers)
                {
                    writer.WriteLine(teacher.Name);
                    writer.WriteLine(teacher.Surname);
                    writer.WriteLine(teacher.SecondName);
                    writer.WriteLine(teacher.subjects.Count);
                    foreach (Subject subject in teacher.subjects)
                    {
                        writer.WriteLine(subject.name);
                    }
                }
            }
        }
        public void GetData()
        {
            string pathGroups = "!groups.txt";
            string pathStudents = "!students.txt";
            string pathSubjects = "!subjects.txt";
            string pathTeachers = "!teachers.txt";
            using (StreamReader reader = new StreamReader(pathGroups))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    StudentGroup group = this.AddGroup(line);
                    group.Faculty = reader.ReadLine();
                    group.Specialty = reader.ReadLine();
                    group.Course = int.Parse(reader.ReadLine());
                }
            }
            using (StreamReader reader = new StreamReader(pathStudents))
            {
                string name, surname, secondname, groupname;
                while ((name = reader.ReadLine()) != null)
                {
                    surname = reader.ReadLine();
                    secondname = reader.ReadLine();
                    groupname = reader.ReadLine();
                    StudentGroup group = this.groups.FirstOrDefault(g => g.Groupname == groupname);
                    Student student = new Student(name, surname, secondname, group);
                    group.AddStudent(student);
                }
            }
            using (StreamReader reader = new StreamReader(pathSubjects))
            {
                int gradecount, studentcount;
                string subjectname, studentname, studentsurname, studentsecondname, groupname, gradedescription;
                float gradedata;
                int subjectscount = int.Parse(reader.ReadLine());
                for (int i = 0; i < subjectscount; i++)
                {
                    subjectname = reader.ReadLine();
                    studentcount = int.Parse(reader.ReadLine());
                    gradecount = int.Parse(reader.ReadLine());
                    Subject subject = this.AddSubject(subjectname);
                    for (int j = 0; j < studentcount; j++)
                    {
                        studentsurname = reader.ReadLine();
                        studentname = reader.ReadLine();
                        studentsecondname = reader.ReadLine();
                        groupname = reader.ReadLine();
                        StudentGroup foundgroup = this.groups.FirstOrDefault(g =>
                        g.Groupname == groupname);
                        Student foundStudent = foundgroup.students.FirstOrDefault(s =>
                        s.Name == studentname &&
                        s.Surname == studentsurname && s.SecondName == studentsecondname);
                        subject.AddStudent(foundStudent);
                        for (int k = 0; k < gradecount; k++)
                        {
                            gradedescription = reader.ReadLine();
                            gradedata = float.Parse(reader.ReadLine());
                            Grade grade = new Grade(gradedescription, gradedata);
                            foundStudent.AddGrade(subject, grade);
                        }
                    }
                    subject.gradecount = gradecount;
                }
            }
            using (StreamReader reader = new StreamReader(pathTeachers))
            {
                int teachercount, subjectcount;
                string name, surname, secondname, subjectname;
                teachercount = int.Parse(reader.ReadLine());
                for (int i = 0; i < teachercount; i++)
                {
                    name = reader.ReadLine();
                    surname = reader.ReadLine();
                    secondname = reader.ReadLine();
                    subjectcount = int.Parse(reader.ReadLine());  
                    Teacher teacher = this.AddTeacher(name,surname,secondname);
                    for( int j = 0; j < subjectcount; j++)
                    {
                        subjectname  = reader.ReadLine();
                        Subject foundsubject = this.subjects.FirstOrDefault(s =>s.name == subjectname);
                        teacher.subjects.Add(foundsubject);
                    }
                }
            }
        }

    }
}
