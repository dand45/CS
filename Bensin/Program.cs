using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bensin
{
    class Program
    {
        static void Main(string[] args)
        {
        mainprog:
            const double harga_liter = 7600;
        pilihan_input:
            Console.Write("PILIH JUMLAH\n1.BENSIN\t2.UANG  ");
            byte pilihan = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == 1) {
                goto bensin;
            }
            else if (pilihan == 2)
            {
                goto uang;
            }
            else {
                Console.WriteLine("INPUT SALAH !\n");
                goto pilihan_input;
            }

        bensin:
            Console.Write("LITER = ");
            double liter_input = double.Parse(Console.ReadLine());
            double harga_final = System.Math.Round( (harga_liter * liter_input),0);
            Console.WriteLine("HARGA = " + harga_final);
            goto exit;

        uang:
            Console.Write("UANG  = ");
            double uang_input = double.Parse(Console.ReadLine());
            double liter_final = System.Math.Round((uang_input/harga_liter),2);
            Console.WriteLine("LITER = " + liter_final);
            goto exit;

        exit:
            Console.WriteLine();
            Console.ReadKey(true);
            goto mainprog;
        }
    }
}
