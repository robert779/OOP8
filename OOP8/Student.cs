using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace OOP8
{
	public class Student : Person, ISearchable
	{
		public StudentGroup group;
		public Dictionary<Subject, List<Grade>> grades;
        public Student(string n, string sn,string s, StudentGroup g)
		{
			Name = n;
			Surname = sn;
			SecondName = s;
			group = g;
			grades = new Dictionary<Subject, List<Grade>>();
		}
		public void AddSubject(Subject subject)
		{
            List<Grade> studentgrades = new List<Grade>();
            this.grades.Add(subject, studentgrades);
        }
		public float GetRating()
		{
			float sum = 0;
			int counter = 0;
			foreach(var entry in grades)
			{
				Subject subject = entry.Key;
				sum+= this.GetScore(subject);
				counter++;
            }
			if (counter == 0)
			{
				return 0;
			}
			return sum / counter;
		}
		public float GetScore(Subject subject)
		{
			float sum = 0;
			foreach(Grade g in grades[subject])
			{
				sum += g.value;
			}
			if (sum > 100)
			{
				return 100;
			}
			return sum;
		}
		public void AddGrade(Subject subject, Grade grade)
		{
			List<Grade> g = grades[subject];
			g.Add(grade);
		}
		public bool Matches(string name, string surname, string group)
		{
            bool nameMatch = string.IsNullOrEmpty(name) || this.Name.ToLower().StartsWith(name.ToLower());
			bool surnameMatch = string.IsNullOrEmpty(surname) || this.Surname.ToLower().StartsWith(surname.ToLower());
			bool groupMatch = string.IsNullOrEmpty(group) || this.group.Groupname.ToLower().StartsWith(group.ToLower());
            return nameMatch && surnameMatch && groupMatch;    
        }
		public bool SuccessfullIn(Subject subject)
		{
			if(subject == null|| !grades.ContainsKey(subject))
			{
				return false;
			}
			return GetScore(subject) >=60;
		}
		public bool NotSuccessfullIn(Subject subject)
		{
            if (subject == null || !grades.ContainsKey(subject))
            {
                return false;
            }
            return GetScore(subject) < 60;
        }
    }
}
