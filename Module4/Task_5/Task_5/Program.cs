using System;

namespace Task_5
{
    enum Operation
    {
        Add=1,
        Subtract,
        Multiply,
        Divide
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDays();
           
            MathOperation(10, 15, Operation.Add);
           
        }

        static void MathOperation(double a, double b, Operation type)
        {            
            double result=0;
            switch (type)
            {
                case Operation.Add:
                    result = a + b;
                    break;
                case Operation.Subtract:
                    result = a - b;
                    break;
                case Operation.Multiply:
                    result = a * b;
                    break;
                case Operation.Divide:
                    result = a / b;
                    break;
            }
            Console.WriteLine("Результат вычисления равен: "+result);
            
        }

        static void CalculateDays()
        {
            Console.Write("Введите номер месяца в году: ");
            double x = double.Parse(Console.ReadLine());
            double days;
            days = 28 + (x + Math.Floor(x / 8)) % 2 + 2 % x + 2 * Math.Floor(1 / x);
            int intdays = Convert.ToInt32(days);
            Console.WriteLine("В данном месяце {0} дней", intdays);
        }
    }
}