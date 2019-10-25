using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        static double Function(double x)
        {
            return Math.Pow(x, 3) - Math.Sin(x);
        }

        static void FirstTask()
        {
            double accuracy = 0.0001;
            double a = 0.5, b = 1;

            Console.WriteLine("Концы отрезков: {0} {1} ", a, b);
            Console.WriteLine("Значение точности: " + accuracy);

            double x;
            do
            {
                x = (a + b) / 2;
                if (Function(x) * Function(a) > 0)
                {
                    a = x;
                }
                else
                {
                    b = x;
                }
            }
            while ((b - a) > accuracy);

            Console.WriteLine("Решение уравнения: " + x);
        }

        static void SecondTask()
        {
            int arraySize;
            int count = 1;
            int i = 0, j = 0, t = 0;

            Console.Write("Введите размерность массива N*N: ");
            arraySize = int.Parse(Console.ReadLine());
            int[,] array = new int[arraySize, arraySize];
            
            

            while (i < array.Length)
            {
                for (j = t; j < arraySize - t; j++)
                {
                    i++;
                    array[t, j] = count;
                    count++;
                }

                for (j = t + 1; j < arraySize - t; j++)
                {
                    i++;
                    array[j, arraySize - t - 1] = count;
                    count++;
                }

                for (j = arraySize - t - 2; j >= t; j--)
                {
                    i++;
                    array[arraySize - t - 1, j] = count;
                    count++;
                }

                for (j = arraySize - t - 2; j > t; j--)
                {
                    i++;
                    array[j, t] = count;
                    count++;
                }

                t++;
            }
            Console.WriteLine("Заполнеyный массив: ");
            for (i = 0; i < arraySize; i++)
            {
                for(j = 0; j < arraySize; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
