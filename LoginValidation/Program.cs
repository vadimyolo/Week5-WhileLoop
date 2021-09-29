using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma kasutaja tunnus.");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta parool.");
            string password = Console.ReadLine();

            int i = 0;

            while (i < 3)
            

            if (userName == "admin" && password == "admin1234")               
            {
                Console.WriteLine("Tere tulemast.");
                break;
            }
            else
            {
                i = i + 1;
                Console.WriteLine($"Lol, vale PIN {3 - i} katset jäänud.");
            }
            Console.WriteLine("Kena päeva jätku.");
        }
    }
}
