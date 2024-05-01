using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть координати точки A (x, y):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координати точки B (x, y):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координати точки C (x, y):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координати точки D (x, y):");
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            // Перевірка на паралельність сторін
            bool isTrapezoid = (x2 - x1) * (y3 - y2) != (x3 - x2) * (y2 - y1) || (x3 - x2) * (y4 - y3) != (x4 - x3) * (y3 - y2);

            if (isTrapezoid)
            {
                Console.WriteLine("Ці точки можуть бути вершинами трапеції.");
            }
            else
            {
                Console.WriteLine("Ці точки не можуть бути вершинами трапеції.");
            }
        }
    }

}


