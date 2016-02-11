using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Complex
    {
        public int a, b; //sozdanie classa complex
        public Complex(int a, int b)
        {
            this.a = a; // dobavlenie ekzemplyarov klassa
            this.b = b;
        }
        public override string ToString()
        {
            return a + "*" + b; //vozvrashenie znacheniya
        }
        public static Complex operator +(Complex a1, Complex a2) //peregruzka operatora
        {
            Complex a3 = new Complex(a1.a * a2.a, a1.b * a2.b); //dobavlenie complex vyzvav konstruktor
            return a3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex m = new Complex(12, 9);//dobavlenie complex cherez konstr
            Complex n = new Complex(12, 11);
            Complex s = m + n; // vychislenie summy
            Console.WriteLine(s); //vyvod
            Console.ReadKey();
        }
    }
}
