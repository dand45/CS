using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Not_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
        main:
            Console.Write("INPUT A NUMBER : ");
            string num1 = Console.ReadLine();

            try
            {
                int num2 = int.Parse(num1);
            }
            catch (FormatException) {
                Console.WriteLine("\n{0}WRONG!\n");
            }
            Console.WriteLine(num1);
            goto main;
        }
    }
}
