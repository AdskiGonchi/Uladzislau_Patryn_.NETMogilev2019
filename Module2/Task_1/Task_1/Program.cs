using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbOfCompanies;
            double tax;
            double income = 500;
            double totalTax;

            Console.Write("Введите количество компаний: ");
            numbOfCompanies = double.Parse(Console.ReadLine());
            Console.Write("Введите налог в процентах: ");
            tax = double.Parse(Console.ReadLine());

            totalTax = numbOfCompanies * tax * income / 100;
            Console.WriteLine("Государство получит суммарный налог: {0} ",totalTax);
        }
    }
}
