using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply();
        }

        static void Multiply()
        {
            int firstDigit;
            int secondDigit;
            int result=0;

            Console.Write("Введите первое число: ");
            firstDigit = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            secondDigit = int.Parse(Console.ReadLine());

            if ((firstDigit > 0) & (secondDigit > 0))
            {
                for(int x = secondDigit; x > 0; x--)
                {
                    result += firstDigit;
                }
            } 
            else if((firstDigit < 0) & (secondDigit < 0))
            {
                for (int x = secondDigit; x < 0; x++)
                {
                    result -= firstDigit;
                }
            }
            else if((firstDigit < 0) & (secondDigit > 0))
            {
                for (int x = secondDigit; x > 0; x--)
                {
                    result += firstDigit;
                }
            }
            else if ((firstDigit > 0) & (secondDigit < 0))
            {
                for (int x = firstDigit; x > 0; x--)
                {
                    result += secondDigit;
                }
            }            

            Console.WriteLine("Результат равен " +result);
        }
    }
}
