using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IF_ELSE
{
    class program
    {
        private static void Main(String[] args)
        {
            Lontong();
            start:
            Console.Write("Masukkan nilai =  ");
            int nilai = int.Parse(Console.ReadLine());
            string cate = null;

            if(nilai>100){
                Console.WriteLine("Input Salah,ULANGI");
                goto start;
            }else if (nilai == 100){
                cate = "Excellent!";    
            }else if(nilai>90){
                cate = "Nice!";
            }else if (nilai > 80){
                cate = "Good!";
            }
            else if (nilai > 75){
                cate = "Passed!";
            }
            else if (nilai < 0) {
                cate = "Anda hutang nilai!!";
            }else
            {
                cate = "Repeat please!";
            }

            Console.WriteLine(cate);
            int a = int.Parse(Console.ReadLine());
            switch (a) { 
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    goto start;
                    break;
                default:
                    break;
            }

            goto start;
            Console.ReadKey(true);
        }

        static void Lontong() {
            Console.WriteLine("Success!");
        }
   }
}
