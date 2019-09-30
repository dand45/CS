using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Login() {
            basebase:
            Console.Write("Username: ");
            string uname = Console.ReadLine();
            password:
            Console.Write("Password: ");
            string pass = Console.ReadLine();

            if (uname == "traperwaze")
            {
                if (pass == "kentuts")
                {
                    Console.WriteLine("SUCCESS\n");
                }
                else
                {
                    Console.WriteLine("PASSWORD SALAH!\n");
                    goto password;
                }
            }
            else {
                Console.WriteLine("Username Tidak Ada!\n");
                goto basebase;
            }
        }

        static void Main(string[] args)
        {
            Login();
            //LOGIN FIXED AND NEXT::::::
            bool lamp = false;
            AWAL:
            Console.Write("Input (0/1): ");
            byte lamp_switch = byte.Parse(Console.ReadLine());
            
            if (lamp_switch == 0) {
                lamp = false;
            }
            else if (lamp_switch == 1)
            {
                lamp = true;
            }
            else {
                Console.WriteLine("Input Salah\n");
                goto AWAL;
            }
            //ON OR OFF
            if (lamp)
            {
                Console.WriteLine("ON");
            }
            else {
                Console.WriteLine("OFF");
            }
            //GO BACK TO SAKLAR
            goto AWAL;
        }
    }
}
