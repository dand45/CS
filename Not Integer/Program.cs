using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Not_Integer
{
    class Program/////sddxgfhjsdassdfgh
    {
        static void Main(string[] args)
        {
        main:
            
            int temp = 0;
            string num1 = null;

            do
            {
                Console.Write("INPUT A NUMBER : ");
                num1 = Console.ReadLine();

                try
                {
                    int.Parse(num1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("SORRY WRONG == {0}",num1);            
                }
            } while (!int.TryParse(num1, out temp));

            Console.WriteLine("INPUT = {0}", num1);
            Console.ReadKey(true);
        }
    }
}
