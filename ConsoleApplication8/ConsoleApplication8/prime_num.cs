using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            for (int i = 0; i < a.Length; i++)
            {
                int is_prime = int.Parse(a[i]);
                int sum = 0;
                for (int j = 2; j < is_prime; j++)
                {
                    if (is_prime % j == 0)
                        sum++;

                }
                if (sum < 1)
                    Console.WriteLine(is_prime);
            }
            Console.ReadKey();
        }
    }
}
