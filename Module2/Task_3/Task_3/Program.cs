using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Replace();                       
        }

        static void Replace()
        {
            Console.Clear();

            double var1d=0, var2d=0;
            int var1i=0, var2i=0;
            bool i1 = false, i2 = false, d1 = false, d2 = false;            
            string firstNumber, secondNumber;            
            
            Console.Write("Введите значение первой переменной: ");
            firstNumber = Console.ReadLine();
            if(firstNumber !=null && firstNumber.Contains(',')|| firstNumber != null && firstNumber.Contains('.'))
            {
                if (firstNumber.Contains('.'))
                {
                    firstNumber = firstNumber.Replace('.', ',');
                }
                try
                {
                    var1d = double.Parse(firstNumber);
                    d1 = true;
                }
                catch(FormatException)
                {
                  Console.WriteLine("Ошибка. Необходимо ввести число. Повторите попытку. Для продолжения нажмите любую клавишу...");
                  Console.ReadKey();
                  Replace();
                }
            }
            else
            {
                try
                {
                    var1i = int.Parse(firstNumber);
                    i1 = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Необходимо ввести число. Повторите попытку. Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Replace();
                }
            }
            

            Console.Write("Введите значение второй переменной: ");
            secondNumber = Console.ReadLine();
            if (secondNumber != null && secondNumber.Contains(',') || secondNumber != null && secondNumber.Contains('.'))
            {
                if (secondNumber.Contains('.'))
                {
                    secondNumber = secondNumber.Replace('.', ',');
                }
                try
                {
                    var2d = double.Parse(secondNumber);
                    d2 = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Необходимо ввести число. Повторите попытку. Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Replace();
                }
            }
            else
            {
                try
                {
                    var2i = int.Parse(secondNumber);
                    i2 = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Необходимо ввести число. Повторите попытку. Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Replace();
                }
            }

            if (d1 && d2)
            {
                Console.WriteLine("Введенные переменные после замены мест: {0} и {1} ", var2d,var1d);
            }
            else if (i1 && i2)
            {
                Console.WriteLine("Введенные переменные после замены мест: {0} и {1} ", var2i, var1i);
            }
            else if (i1 && d2)
            {
                Console.WriteLine("Введенные переменные после замены мест: {0} и {1} ", var2d, var1i);
            }
            else if (d1 && i2)
            {
                Console.WriteLine("Введенные переменные после замены мест: {0} и {1} ", var2i, var1d);
            }
        }
    }
}
