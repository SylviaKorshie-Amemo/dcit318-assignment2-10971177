using System;

namespace Interface
{
    interface IMovable
    {
        public static void Move(); 

        class Car:IMovable
        {
            public static void Move()
            {
                Console.WriteLine("Car is moving");
            }
        }

        class Bicycle:IMOvable
        {
            public static void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }
        }

        public class Program
        {
            static void main(string[] args)
            {
                Car car = new Car();
                car.Move();

                Bicycle bicycle = new Bicycle();
                bicycle.Move();
            }
        }
    }
}
