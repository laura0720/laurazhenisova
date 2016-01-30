using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Student //sozdanie classa student
    {
        public string Name;//dobavlenie metodov
        public string Faculty;
        public string ID;
        public double GPA;
        public Student(string Name, string Faculty, string ID, double GPA) //konstruktor
        {
            this.Name = Name;
            this.Faculty = Faculty;
            this.ID = ID;
            this.GPA = GPA;
        }
        public override string ToString() //vyvod metodov
        {
            return Name + " " + Faculty + " " + ID + " " + GPA;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Laura", "FIT", "15BD02028", 4.0); //zapolnenie
            Console.WriteLine(s); //vyvod
            Console.ReadKey();

        }
    }
}
