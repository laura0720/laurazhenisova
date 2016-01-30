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
            string[] a = Console.ReadLine().Split(); // sozdanie string dlya vvedeniya chisel i dlya togo chtoby prochitat
            for (int i = 0; i < a.Length; i++) //probegaet po stroke
            {
                int is_prime = int.Parse(a[i]); //perevod is string v int
                int sum = 0;
                for (int j = 2; j < is_prime; j++) //proverka so 2 chisla
                {
                    if (is_prime % j == 0) //esli chislo delitsya bez ostatka to kolvo prime chisel uvelichivaetsya
                        sum++; //t.e prime eto chislo kotoroe delitsya na samu sebya i na 1

                }
                if (sum < 1)//kolvo ne dolzhno byt' menshe 1
                    Console.WriteLine(is_prime); // vyvod prostyh chisel
            }
            Console.ReadKey();
        }
    }
}
