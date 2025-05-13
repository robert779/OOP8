using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    public class Teacher : Person
    {
        public List<Subject> subjects = new List<Subject>();
        public Teacher(string n, string sn, string s)
        {
            Name = n;
            Surname = sn;
            SecondName = s;
        }
        public string GetInitials()
        {
            return $" {this.Surname} {this.Name[0]}.{this.SecondName[0]}.";
        }
    }
}
