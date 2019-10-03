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
            goto main;
        }

        //METHOD DARI C
        protected static void temp_c() {
            main:
            double c=0, f=0, k=0, r=0;
            pilihan:
            Console.WriteLine("UBAH KE :::");
            Console.Write("1. R\t2. F\t3. K ");
            int pilih_ke = int.Parse(Console.ReadLine());
            Console.WriteLine();
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

            //KE R
            ke_r:
            Console.Write("C = ");
            c = double.Parse(Console.ReadLine());
            r = c * 0.8;
            Console.Write("R = " + System.Math.Round(r,2));
            goto ulangan;

            //KE F
            ke_f:
            Console.Write("C = ");
            c = double.Parse(Console.ReadLine());
            f = (c * 1.8)+32;
            Console.Write("F = " + System.Math.Round(f, 2));
            goto ulangan;

            //KE K
            ke_k:
            Console.Write("C = ");
            c = double.Parse(Console.ReadLine());
            k = c + 273.15;
            Console.Write("K = "+System.Math.Round(k,2));
            goto ulangan;

            //ULANGI
            ulangan:
            Console.Write("\n\nUlangi?\n1. Ya\t2. Dari Awal  ");
            char ulang = char.Parse(Console.ReadLine());
            Console.WriteLine();
            if (ulang == '1')
            {
                goto main;
            }
            else if (ulang == '2')
            {
                
            }
            else
            {
                Console.WriteLine("INPUT SALAH!\n");
                goto ulangan;
            }

        }
    }
}