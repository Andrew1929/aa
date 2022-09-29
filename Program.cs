using System;

namespace OOP_LB_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            OOP_LB_3._1.Rectangle rectangle = new Rectangle(10,15);
            rectangle.AreaCalculator();
            rectangle.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
