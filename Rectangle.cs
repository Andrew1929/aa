using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB_3._1
{
    class Rectangle
    {
        public double Area { get; }
        public double Perimeter { get; }
        private double side1;
        private double side2;
        public Rectangle (double side1, double side2)
        {
            
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
           double Area = side1 * side2;
            Console.WriteLine($"First side: {side1}, Second side: {side2}\n" +
                $"Area = first side * second side : {side1} * {side2} = {Area}");
            return Area;
        }
        public double PerimeterCalculator()
        {
            double Perimeter = side1 * 2 + side2 * 2;
            Console.WriteLine($"First side: {side1}, Second side: {side2}\n" +
               $"Perimetr = first side * 2 + second side * 2 : {side1} * 2 + {side2} * 2 = {Perimeter}");
            return Perimeter;
        }
    }
}
