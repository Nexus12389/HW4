using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_Dario_Juric_10._06._2014
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApplication1
    {
        class Student : Person, IComparable<Student>
        {
            public string email { get; set; }
            private string Location;
            public string location
            {
                get
                {
                    if (Location == "SA")
                    {
                        return "Sarajevo";
                    }
                    else if (Location == "TZ")
                    {
                        return "Tuzla";
                    }
                    else
                    {
                        return "Other";
                    }
                }
                set
                {
                    if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo")
                    {
                        Location = "Sarajevo";
                    }
                    else if (value == "TZ" || value == "TUZLA" || value == "Tuzla")
                    {
                        Location = "Tuzla";
                    }
                    else
                    {
                        Location = "NA";
                    }
                }
            }

            public Student()
                : base("StudSAName", "StudSALastName")
            {
                this.email = "snsl@aubih.edu.ba";
                this.location = "Sarajevo";
            }

            ~Student()
            {

            }

            public Student(string name, string lastname, string email)
                : base(name, lastname)
            {
                this.email = email;
                this.location = "Sarajevo";
            }

            public bool setName(string input)
            {
                if (input.Length <= 2)
                {
                    Console.WriteLine("Name must be at least two characters long");
                    return false;
                }

                char[] values = input.ToCharArray();
                foreach (char cha in values)
                {
                    if (!char.IsLetter(cha))
                    {
                        Console.WriteLine("Name can only have letters");
                        return false;
                    }
                }

                if (char.IsUpper(values[0]))
                {
                    Console.WriteLine("Name must start with an uppercase letter");
                    return false;
                }

                return true;
            }

            public string getStudentInfo()
            {
                return base.getPersonInfo() + ", " + this.email + ", " + this.location;
            }

            public override string ToString()
            {
                return getStudentInfo();
            }

            public int CompareTo(Student student)
            {
                return this.email.CompareTo(student.email);
            }
        }
    }

}
