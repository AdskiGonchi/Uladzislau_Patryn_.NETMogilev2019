using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Увеличение трех переменных на 10");
            int a = 15;
            int b = 10;
            int c = 20;
            Console.WriteLine("Переменные до увеличения: {0},{1},{2}", a, b, c);
            IncreaseByTen(ref a, ref b, ref c);
            Console.WriteLine("Переменные после увеличения: {0},{1},{2}", a, b, c);
            Console.WriteLine();


            Console.WriteLine("Нахождение длины окружности и площади круга");
            double radius = 5;
            double area = 0;
            double length = 0;
            Console.WriteLine("Радиус, площадь и длина до нахождения значений: {0},{1},{2}", radius, area, length);
            CircleAreaAndLength(radius, ref area, ref length);
            Console.WriteLine("Радиус, площадь и длина после нахождения значений: {0},    {1},   {2}", radius, area, length);
            Console.WriteLine();


            Console.WriteLine("Нахождение минимального, максимального и суммы всех элементов массива");
            int max;
            int min;
            int sum;
            Console.Write("Введите длину массива: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }
            MaxMinSumArrayElements(array, out min, out max, out sum);
            Console.WriteLine("Макимальный, минимальный и сумма элементов массива: {0},{1},{2}", max, min, sum);
        }

        static void IncreaseByTen(ref int a,ref int b,ref int c)
        {
            a += 10;
            b += 10;
            c += 10;
        }

        static void CircleAreaAndLength(double radius,ref double area,ref double length)
        {
            area = Math.PI * radius * radius;
            length = 2 * Math.PI * radius;
        }

        static void MaxMinSumArrayElements(int[] array, out int min, out int max, out int sum)
        {
            min = array[0];
            max = array[0];
            sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

                sum += array[i];
            }
        }
    }
}
