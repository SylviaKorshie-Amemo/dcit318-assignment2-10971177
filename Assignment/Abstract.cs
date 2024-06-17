using System;

namespace Assignment
{
    abstract class Shape
    {

        public abstract double GetArea();

    }

    class Circle : Shape
    {

        public double Radius { get; set; }

        public override double GetArea()
		{
			return Math.PI* Math.Pow(Radius, 2);
        }
    }
        

   class Rectangle : Shape
    {
        public double length { get; set; }

        public double width { get; set; }

        public override double GetArea()
        {
            return length * width;

        }

    }
    public class Program
        { 
            static void main(string[] args)
            {
                Circle circle = new Circle { Radius = 5 };

                Console.WriteLine($"Circle Area: {circle.GetArea():F2}");

                Rectangle rectangle = new Rectangle { length = 4, width = 3 };

                Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
            }

        }
}