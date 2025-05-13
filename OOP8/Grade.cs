using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    public class Grade
    {
        public string description;
        public float value;
        public Grade(string description, float grade)
        {
            this.description = description;
            if (grade < 0)
            {
                this.value = 0;
            }
            else if (grade > 100)
            {
                this.value = 100;
            }
            else
            {
                this.value = grade;
            }
        }
    }
}
