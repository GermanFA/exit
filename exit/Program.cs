using System;

namespace exit
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Привет";

            Console.WriteLine(str);

            while (str != "exit")

            {
                Console.WriteLine("Введите слово:");
                str = Console.ReadLine();

            }

        }
    }
}
