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
            Console.Write("\n\nUlangi? (y/n) ");
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
                goto ulangan;
            }
        }

        //METHOD DARI C
        protected static void temp_c() {
            pilihan:
            Console.WriteLine("UBAH KE :::");
            Console.Write("1. R\t2. F\t3. K");
            int pilih_ke = int.Parse(Console.ReadLine());
            switch (pilih_ke) { 
                case 1:
                    goto ke_r;
                    break;
                case 2:
                    goto ke_f;
                    break;
                case 3:
                    goto ke_k;
                    break;
                default:
                    goto pilihan;
                    break;
            }


        }
    }
}