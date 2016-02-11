using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void FStack (string path) //nazvanie funkcii
        {
            Stack<string> dirs = new Stack<string>(20);// sozdanie stack
            dirs.Push(path);// put' papki


            while (dirs.Count > 0)// poka stack ne pustoi
            {
                string currentDir = dirs.Pop();// beret put' posled papki
                string[] subDirs = Directory.GetDirectories(currentDir);// dobavlenie putei papok 
                string[] files = Directory.GetFiles(currentDir); // dobavlenie failov
                Console.WriteLine(currentDir); // vyvod papok 
                foreach (string file in files) //proverka failov
                {
                    Console.WriteLine(file);// vyvod failov v papkah 

                }
                foreach (string str in subDirs) // probegaemsya po papkam
                    dirs.Push(str);// v stack dobavlyayutsya puti dannyh papok

                }
        }
        static void Main(string[] args)
        {
            FStack(@"C:\Users\User\Desktop\PT_Laura"); //ukazan put' kakoi-libo papki
            Console.ReadKey(); //schityvanie
        }
    }
    }

