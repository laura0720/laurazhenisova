using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //file v kotorom est stroka s chislami

            FileStream fs = new FileStream(@"C:\Users\User\Downloads\far2.0\far2.0\PT2016\laura.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //file gde vyvodim otvet
            FileStream fs1 = new FileStream(@"C:\Users\User\Downloads\far2.0\far2.0\PT2016\laura1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs); //schityvaet informaciyu v file
            StreamWriter sr1 = new StreamWriter(fs1);
            bool prime = true;
            int sum = 0;
            int mini = 0;
            string[] line = sr.ReadLine().Split(); //razdelyaet mejdu chislami 

            // proverka i perevod v int
            int[] x = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                int x[i] = int.Parse(line[i]);

                for (int j = 2; j < x; i++) //probegaemsya po stroke
                {
                    if (x % j == 0)
                    {
                        sum++;
                    } if (sum < 1)
                    {
                        if (prime == true)
                        {
                            mini = x;
                        } else if (x < mini)
                        {
                            mini = x;
                        }



                    }
                }
                Console.WriteLine(mini);
                sr1.WriteLine(mini);
                sr.Close();
                sr1.Close();
                fs.Close();
                fs1.Close();
                Console.ReadKey();


            }
        }
    }
}
