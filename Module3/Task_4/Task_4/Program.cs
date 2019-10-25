using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ReplaceDigits();
        }

        static void ReplaceDigits()
        {
            int number;
            int digit;

            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Число в обратном порядке: ");
            if (number >= 0)
            {
                do
                {
                    digit = number % 10;
                    Console.Write(digit);
                    number /= 10;
                } while (number > 0);
            }
            if (number < 0)
            {
                number *= -1;
                Console.Write("-");
                do
                {
                    digit = number % 10;
                    Console.Write(digit);
                    number /= 10;
                } while (number > 0);
            }
        }
    }
}
