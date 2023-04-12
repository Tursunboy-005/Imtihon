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
            Console.WriteLine("Enter str : ");
            string str = Console.ReadLine();

            int counter = 1;

            char[] array = str.ToCharArray();

            Array.Sort(array);
            Console.WriteLine(array);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{array[i - 1]} - {counter}");
                    counter = 1;
                }
            }

            Console.ReadLine();
        }
    }
}