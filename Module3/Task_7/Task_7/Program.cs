using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResult();
        }

        static void DisplayResult()
        {
            int arrayLength;

            Console.Write("Введите количество элементов массива: ");
            arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Введите {0} элемент массива: ", x + 1);
                numbers[x] = int.Parse(Console.ReadLine());
            }

            Console.Write("Введенный вами массив: ");
            for (int x = 0; x < numbers.Length; x++)
            {
                if (x != 0)
                {
                    Console.Write(",");
                }
                Console.Write(numbers[x]);
            }

            Console.WriteLine();
            Console.Write("Числа массива, перед которыми стоят меньшие числа: ");
            int count=0;
            for (int x = 0; x < numbers.Length-1; x++)
            {
                if (numbers[x + 1] > numbers[x])
                {
                    if (count != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(numbers[x + 1]);
                    count++;
                }
            }
            
        }
    }
}
