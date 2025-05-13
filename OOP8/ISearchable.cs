using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP8
{
    internal interface ISearchable
    {
        bool Matches(string name, string surname, string group);
    }
}
