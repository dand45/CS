using System;

namespace HelloWorld
{
    class Program
    {   
        //KONSTATNTA PHI
        public const float pi = 3.14f;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            string lontong = "Gedang Goreng";
            string lontong2 = "Goreng Gedang";
            Console.WriteLine(lontong + lontong2);
        operasi:
            //OPERASI
            float r, L;

            Console.Write("r = ");
            r = Convert.ToSingle(Console.ReadLine());
            L = pi * r * r;
            Console.WriteLine("L = {0}\n", System.Math.Round(L,2));
            //BEFORE EXIT

            goto operasi;
            //Console.ReadKey(true);
            //OR Console.ReadLine();
        }
    }
}
