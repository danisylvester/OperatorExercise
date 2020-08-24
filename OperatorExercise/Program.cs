using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) 
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("...................................................");
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
            Console.WriteLine("...................................................");

            int i = 3;
            int j = 4;
            int k = ++i * j++;
            Console.WriteLine(k);
        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }

    }
}
