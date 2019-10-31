using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] Array = new int[length];
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i+1);
                Array[i] = int.Parse(Console.ReadLine());
            }

            MaxElement(Array);
            MinElement(Array);
            SummarizeArrayElements(Array);
            DifferensMaxMinArrayElements(Array);
            IncreaseArray(Array);

        }
        
        static void MaxElement(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Максимальный элемент массива равен: " +max);
        }

        static void MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Минимальный элемент массива равен: " + min);
        }

        static void SummarizeArrayElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("Сумма элементов массива равна: " + sum);
        }

        static void DifferensMaxMinArrayElements(int[] array)
        {
            int differens;
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }                                
            }

            differens = max - min;
            Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + differens);
        }

        static void IncreaseArray(int[] array)
        {            
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] += max;
                }
                else
                {
                    array[i] -= min;
                }
            }
            Console.WriteLine("Массив после изменения: " );
            for(int i = 0; i < array.Length; i++)
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
