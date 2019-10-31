using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteDigit();
        }
        static void DeleteDigit()
        {
            int number;
            int deleteDigit;
            int numberOfDigits=0;
            int result = 0;

            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Введите удаляемую из числа цифру: ");
            deleteDigit = int.Parse(Console.ReadLine());
            Console.Write("Число после удаления цифры: ");

            int temp = number;
            while (temp > 0)
            {
                numberOfDigits++;
                temp /= 10;
            }

            temp = number;
            int count = 0;
            int[] digits = new int[numberOfDigits];
            while (temp > 0)
            {
                digits[numberOfDigits-1 - count] = temp % 10;
                temp /= 10;
                count++;
            }

            temp = 0;
            int factor = 1;
            for(int i = 0; i < numberOfDigits; i++)
            {
                if (digits[numberOfDigits - 1 - i] == deleteDigit) continue;
                temp = digits[numberOfDigits - 1-i] * factor;
                result += temp;
                factor *= 10;
            }
            Console.WriteLine(result);
        }
    }
}
