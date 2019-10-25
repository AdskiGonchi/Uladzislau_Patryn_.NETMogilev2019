using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayData();            
        }

        static void DisplayData()
        {
            int amountOfNubers;
            int counter = 0;

            Console.Write("Введите натуральное число: ");
            amountOfNubers = int.Parse(Console.ReadLine());
            
            for(int x = 0; x < amountOfNubers; x++)
            {
                if (x != 0)
                {
                    Console.Write(", ");
                }
                Console.Write("{0}",counter);
                counter += 2;
            }
        }
    }
}
