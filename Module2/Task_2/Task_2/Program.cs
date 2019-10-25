using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsOld;

            Console.Write("Введите целое число: ");
            yearsOld = int.Parse(Console.ReadLine());

            if (yearsOld % 2 == 0 && yearsOld > 18)
            {
                Console.WriteLine("Поздравляю с 18-и летием!!!");
            }
            else if (yearsOld % 2 == 1 && yearsOld < 18 && yearsOld > 13)
            {
                Console.WriteLine("Поздравляю с переходом в старшую школу!!!");
            }

        }
    }
}
