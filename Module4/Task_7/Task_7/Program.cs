using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Выберите тип сортировки 1)по возростанию 2)по убыванию");
            Console.Write("Введите число соответствующее типу: ");
            int type = int.Parse(Console.ReadLine());

            SortArray(ref array,type);

            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(array[i]);
            }
        }

        static void SortArray(ref int[] array, int type)
        {
            int temp = 0;
            int step;
            if (type == 1)
            {
                for (step = array.Length / 2; step > 0; step /= 2)
                {
                    for (int i = step; i < array.Length; i++)
                    {
                        temp = array[i];
                        for (int j = i; j >= step; j -= step)
                        {
                            if (temp < array[j - step])
                            {
                                array[j] = array[j - step];
                                array[j - step] = temp;
                            }
                            else goto loop1;
                        }
                    loop1:;
                    }

                }
            }

            if (type == 2)
            {
                for (int i = array.Length; i >= 1; i--)
                {
                    for (int j = 0; j < i ; j++)
                    {
                        
                        if (array[i-1] > array[i - j-1])
                        {
                            temp = array[i - j-1];
                            array[i - j-1] = array[i-1];
                            array[i-1] = temp;
                        }
                    }
                }
            }
        }
    }
}
