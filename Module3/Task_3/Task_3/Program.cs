using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayData();
        }

        static void DisplayData()
        {
            int amountOfNumbers;
            Console.Write("Введите количество выводимых чисел Фибоначи: ");
            amountOfNumbers=int.Parse(Console.ReadLine());

            int firstNumber=0;
            int secondNumber=1;
            int displayNumber=0;

            for(int x = 0; x < amountOfNumbers; x++)
            {
                if (x == 0)
                {
                    displayNumber = firstNumber;
                }

                if (x != 0)
                {
                    Console.Write(", ");
                }

                Console.Write("{0}", displayNumber);

                displayNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = displayNumber;               
                
            }
        }
    }
}
