using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxi_mini1
{
    class Program
    {

        static void Main(string[] args)
        {
            //file v kotorom est stroka s chislami
            FileStream fs = new FileStream(@"C:\Users\User\Downloads\far2.0\far2.0\PT2016\laura.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(fs); //schityvaet informaciyu v file
            string[] line = sr.ReadLine().Split(); //razdelyaet mejdu chislami 
            // proverka i perevod v int
            int[] x = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                x[i] = int.Parse(line[i]);
            }
            int maxi = 0;
            int mini = 0;
            //probegaemsya po dline
            for (int i = 0; i < line.Length; i++)
            {
                if (x[i] > maxi)
                {
                    maxi = x[i];
                }
                if (x[i] < mini)
                {
                    mini = x[i];
                }
            }
            Console.WriteLine("Maximum number is {0}", maxi);
            Console.WriteLine("Minimum number is {1}", mini);
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }


    }
}
