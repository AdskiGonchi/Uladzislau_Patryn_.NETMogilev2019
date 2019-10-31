using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] Array = new int[length];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }

            IncreaseArrayElementsByFive(Array);
        }               

        static void IncreaseArrayElementsByFive(int [] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

            Console.WriteLine("Массив после увеличения: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(array[i]);
            }
        }
    }
}
