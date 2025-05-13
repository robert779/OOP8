using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    public class Person
    {
        private string name;
        private string secondname;
        private string surname;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SecondName
        {
            get { return secondname; }
            set { secondname = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
    }
}
