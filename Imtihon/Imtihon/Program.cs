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
            str = str.Substring(0, str.Length - 2)  + str.Substring(in, 1).ToUpper();
            Console.WriteLine(str);
            string[] strings = str.Split(' ');

            Console.ReadLine();

        }
    }
}
