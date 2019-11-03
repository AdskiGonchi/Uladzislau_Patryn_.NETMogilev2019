using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SummarizeThreeNumbers();
            SummarizeTwoNumbers();
            SummarizeThreeDoubleNumbers();
            ConcatTwoStrings();
            SummarizeTwoArrays();

        }

        static void SummarizeThreeNumbers()
        {
            Console.WriteLine("Сложение трех целых чисел.");
            int result = 0;
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int threedNumber = int.Parse(Console.ReadLine());
            result = firstNumber + secondNumber + threedNumber;
            Console.WriteLine("Результат равен: " + result);
            Console.WriteLine();
        }

        static void SummarizeTwoNumbers()
        {
            Console.WriteLine("Сложение двух целых чисел.");
            int result = 0;
            Console.Write("Введите первое число: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondNumber = int.Parse(Console.ReadLine());
            result = firstNumber + secondNumber;
            Console.WriteLine("Результат равен: " + result);
            Console.WriteLine();
        }

        static void SummarizeThreeDoubleNumbers()
        {
            Console.WriteLine("Сложение трех дробных чисел.");
            double result = 0;
            Console.Write("Введите первое число: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double threedNumber = double.Parse(Console.ReadLine());
            result = firstNumber + secondNumber + threedNumber;
            Console.WriteLine("Результат равен: " + result);
            Console.WriteLine();
        }

        static void ConcatTwoStrings()
        {
            Console.WriteLine("Сложение двух строк");
            string result = null;
            Console.Write("Введите первую строку: ");
            string firstString = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondString = Console.ReadLine();
            result = String.Concat(firstString, secondString);
            Console.WriteLine("Результат: " + result);
            Console.WriteLine();
        }

        static void SummarizeTwoArrays()
        {
            Console.WriteLine("Суммирование двух массивов");
            Console.Write("Введите длину первого массива: ");
            int length1 = int.Parse(Console.ReadLine());
            int[] Array1 = new int[length1];
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i + 1);
                Array1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Введите длину второго массива: ");
            int length2 = int.Parse(Console.ReadLine());
            int[] Array2 = new int[length2];
            for (int i = 0; i < Array2.Length; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i + 1);
                Array2[i] = int.Parse(Console.ReadLine());
            }

            if (Array1.Length > Array2.Length)
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    if (i >= Array2.Length)
                    {
                        continue;
                    }
                    Array1[i] += Array2[i];
                }

                Console.WriteLine("Результат: ");
                for (int i = 0; i < Array1.Length; i++)
                {
                    if (i != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(Array1[i]);
                }
            }
            else
            {
                for (int i = 0; i < Array2.Length; i++)
                {
                    if (i >= Array1.Length)
                    {
                        continue;
                    }
                    Array2[i] += Array1[i];
                }

                Console.WriteLine("Результат: ");
                for (int i = 0; i < Array2.Length; i++)
                {
                    if (i != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(Array2[i]);
                }
            }

        }
    }
}

