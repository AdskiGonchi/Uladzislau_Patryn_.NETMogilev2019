using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CountIt();           
           
        }

        static void CountIt()
        {
            int figureType;
            int operationType;
            double sideLength; //или радиус
            double area;
            double perimeter;

            Console.Write("Введите цифру соответствующую необходимой фигуре: 1-треугольник, 2-четырехугольник, 3-круг: ");
            figureType = int.Parse(Console.ReadLine());
            Console.Write("Введите цифру соответствующую необходимому вычислению: 1-площадь, 2-периметр: ");
            operationType = int.Parse(Console.ReadLine());

            switch (figureType)
            {
                case 1:
                    if (operationType == 1)
                    {
                        Console.Write("Введите длину стороны треугольника: ");
                        sideLength=double.Parse(Console.ReadLine());
                        area = (Math.Sqrt(3) * sideLength * sideLength / 4);
                        Console.WriteLine("Площадь треугольника равен: " + area );
                        Console.WriteLine("Периметр четырехугольника равен: " + Math.Sqrt(area)*4);
                        Console.WriteLine("Периметр круга равен: " + Math.Sqrt(area / Math.PI)*2*Math.PI);
                    }
                    else
                    {
                        Console.Write("Введите длину стороны треугольника: ");
                        sideLength = double.Parse(Console.ReadLine());
                        perimeter = sideLength*3;
                        Console.WriteLine("Периметр треугольника равен: " + perimeter);
                        Console.WriteLine("Площадь четырехугольника равна: " + perimeter/4*perimeter/4);
                        Console.WriteLine("Площадь круга равна: " + (perimeter/(2*Math.PI))* (perimeter / (2 * Math.PI))*Math.PI);
                    }
                    break;

                case 2:
                    if (operationType == 1)
                    {
                        Console.Write("Введите длину стороны четырехугольника: ");
                        sideLength = double.Parse(Console.ReadLine());
                        area = sideLength*sideLength;
                        Console.WriteLine("Площадь четырехугольника равна: " + area);
                        Console.WriteLine("Периметр треугольника равен: " + (Math.Sqrt(4 * area / Math.Sqrt(3)))*3);
                        Console.WriteLine("Периметр круга равен: " + Math.Sqrt(area / Math.PI) * 2 * Math.PI);
                    }
                    else
                    {
                        Console.Write("Введите длину стороны четырехугольника: ");
                        sideLength = double.Parse(Console.ReadLine());
                        perimeter = sideLength * 4;
                        Console.WriteLine("Периметр четырехугольника равен: " + perimeter);
                        Console.WriteLine("Площадь треугольника равна: " + Math.Sqrt(3)*(perimeter / 4) * (perimeter / 4)/4);
                        Console.WriteLine("Площадь круга равна: " + (perimeter / (2 * Math.PI)) * (perimeter / (2 * Math.PI)) * Math.PI);
                    }
                    break;

                case 3:
                    if (operationType == 1)
                    {
                        Console.Write("Введите радиус круга: ");
                        sideLength = double.Parse(Console.ReadLine());
                        area = Math.PI*sideLength*sideLength;
                        Console.WriteLine("Площадь круга равна: " + area);
                        Console.WriteLine("Периметр треугольника равен: " + (Math.Sqrt(4 * area / Math.Sqrt(3))) * 3);
                        Console.WriteLine("Периметр четырехугольника равен: " + Math.Sqrt(area) * 4);
                    }
                    else
                    {
                        Console.Write("Введите радиус круга: ");
                        sideLength = double.Parse(Console.ReadLine());
                        perimeter = 2*Math.PI*sideLength;
                        Console.WriteLine("Периметр круга равен: " + perimeter);
                        Console.WriteLine("Площадь треугольника равна: " + Math.Sqrt(3) * (perimeter / 4) * (perimeter / 4) / 4);
                        Console.WriteLine("Площадь четырехугольника равна: " + perimeter / 4 * perimeter / 4);
                    }
                    break;

            }
                        
        }
        
    }
}
