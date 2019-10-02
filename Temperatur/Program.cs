using System;
namespace konversiTemperatur {
    public class suhu {
        public static void Main(string[] args) {
            Console.WriteLine("Konversi Temperatur");
            Console.WriteLine("===================\n");
            //----------
            main:
            Console.WriteLine("Dari :::");
            Console.Write("1. C\t2. R\t3. F\t4. K  ");
            int pilih_dari = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //SWITCH pilih_dari
            switch (pilih_dari) { 
                case 1:
                    temp_c();
                    break;
            }
            
            //ULANGI
            ulangan:
            Console.Write("Ulangi? (y/n) ");
            char ulang = char.Parse(Console.ReadLine());
            if (ulang=='y') {
                goto main;
            }
            else if (ulang == 'n')
            {
                Environment.Exit(0);
            }
            else {
                Console.WriteLine("INPUT SALAH!\n");
                goto ulangan:
            }
        }

        //METHOD DARI C
        public static void temp_c() {
            Console.Write("test temp_c");
        }
    }
}