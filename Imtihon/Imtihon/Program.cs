using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matn kiriting ");
            string str = Console.ReadLine();
            string[] strings = str.Split(' ');

           
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Substring(0, 1).ToUpper()  + strings[i].Substring(1);

                Console.Write($"{strings[i]} ");
            }
            Console.ReadLine();
        }
    }
}
