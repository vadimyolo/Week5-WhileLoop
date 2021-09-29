using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //boolean true/false
            bool loopActive = true;


            while (loopActive)

            {
                Console.WriteLine("Sisesta PIN.");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast.");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti, vale PIN.");
                }
            }

            Console.WriteLine("Kena päeva jätku.");
        }
    }
}