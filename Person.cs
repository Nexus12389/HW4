using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_Dario_Juric_10._06._2014
{
    class Person
    {
        public string name, lastName;

        Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;

        }
        public string getPersonInfo() { return name + ", " + lastName; }
    }

}
