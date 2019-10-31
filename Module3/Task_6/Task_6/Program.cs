using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeSign();
        }

        static void ChangeSign()
        {
            int arrayLength;

            Console.Write("Введите количество элементов массива: ");
            arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Введите {0} элемент массива: ", x+1);
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

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] > 0)
                {
                    numbers[x] -= 2 * numbers[x];
                }
                else
                {
                    numbers[x] += -2 * numbers[x];
                }
            }

            Console.Write("Измененный массив: ");
            for (int x = 0; x < numbers.Length; x++)
            {
                if (x != 0)
                {
                    Console.Write(",");
                }
                Console.Write(numbers[x]);
            }
        }
    }
}
