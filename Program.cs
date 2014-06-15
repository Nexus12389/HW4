using homework_Dario_Juric_10._06._2014.ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework_Dario_Juric_10._06._2014
{
    class Program
    {


        static void Main(string[] args)
        {

            Student info = new Student {
                new Student("StudentName1","StudentLastName1","1@aubih.edu.ba"),
                new Student("StudentName2","StudentLastName2","2@aubih.edu.ba"),
                new Student("StudentName2","StudentLastName3","3@aubih.edu.ba"),
                new Student("StudentName2","StudentLastName4","4@aubih.edu.ba"),
                new Student("StudentName2","StudentLastName5","5@aubih.edu.ba"),
            };

            foreach(string inf in info) {
                Console.WriteLine(inf);
            }





        }

    }

}
