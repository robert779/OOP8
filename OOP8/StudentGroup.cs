using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
namespace OOP8
{

	public class StudentGroup
	{
		private string groupname;
        private string faculty = "ФІОТ";
        private string specialty = "121 Інженерія програмного забезпечення";
        private int course = 1;
        public string Groupname
        {
            get { return groupname; }
            set { groupname = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public int Course
        {
            get { return course; }
            set {
                if (value >= 1 && value <= 4)
                {
                    course = value;
                }
                else
                {
                    value = 1;
                }
            }
        }
        public List<Student> students = new List<Student>();
		public StudentGroup(string name)
		{
			groupname = name;
		}
		public void AddStudent(Student student)
		{
			students.Add(student);
			this.SortStudents();
		}
		public void SortStudents()
		{
            students = students.OrderBy(s => s.Surname).ToList();
        }
		public float GetAverage(School school)
		{
			float sum = 0;
			int count = 0;
			foreach (Student student in students)
			{
				sum += student.GetRating();
				count++;
			}
			if(count == 0)
			{
				return 0;
			}
			return sum / count;
		}
	}
}
