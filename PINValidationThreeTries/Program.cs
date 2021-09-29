using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool loopActive = true;
            int i = 0;
            

            while (i < 3)

            {
                Console.WriteLine("Sisesta PIN.");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast.");
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Lol, vale PIN {3 - i} katset jäänud.");
                }
            }

            Console.WriteLine("Kena päeva jätku bozo."); 
                

        }
    }
}
        
    

