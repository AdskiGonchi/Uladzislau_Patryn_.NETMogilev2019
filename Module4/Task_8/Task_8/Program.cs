using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double accuracy = 0.0001;
            double a = 0.5, b = 1;
            double x = 0;
            Console.WriteLine("Концы отрезков: {0} {1} ", a, b);
            Console.WriteLine("Значение точности: " + accuracy);
            HalfLength(ref a, ref b, ref x, accuracy);
            
            Console.WriteLine("Решение уравнения: " + x);
        }

        static double Function(double x)
        {
            return Math.Pow(x, 3) - Math.Sin(x);            
        }

        static void HalfLength(ref double a, ref double b, ref double x, double accuracy)
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

            if ((b - a) > accuracy)
            {
                HalfLength(ref a,ref  b, ref x, accuracy);
            }
            else return;            
        }
    }
}