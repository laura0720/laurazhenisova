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

            FileStream fs = new FileStream("laura.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //file gde vyvodim otvet
            FileStream fs1 = new FileStream("laura1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs); //schityvaet informaciyu v file
            StreamWriter sr1 = new StreamWriter(fs1); //zapisyvaet info
            string[] line = sr.ReadLine().Split();//razdelyaet mejdu chislami
            int mini = int.Parse(line[0]);
            for (int i = 0; i < line.Length; i++) // proverka i perevod v int
            { 
            
                int x = int.Parse(line[i]);
                int sum = 0;
                bool pr = false;
                

                for (int j = 2; j < x; j++) //probegaemsya po stroke
                {
                    if (x % j == 0)
                    {
                        sum++;
                    } if (sum < 1)
                    {
                             pr = true;
                        } if (pr)
                    {
                        if (mini > x)
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

