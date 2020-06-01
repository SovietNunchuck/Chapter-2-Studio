using System;

namespace Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle in miles:");
            double radius = 0;
            while (radius <= 0)
            {
                radius = double.Parse(Console.ReadLine());
                if (radius > 0)
                {
                    break;
                }
                Console.WriteLine("Please try again:");
            }

            double areaOfCircle = Math.PI * Math.Pow(radius, 2);
            double circumference = Math.PI * radius * 2;
            double diameter = 2 * radius;

            Console.WriteLine("The area of a circle of radius " + radius + " miles is: " + areaOfCircle + " miles.");
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            //ROAD TRIP!
            Console.WriteLine("How many miles does your vehicle get to the gallon (round to the nearest integer)?");
            int mpg = int.Parse(Console.ReadLine());
            double gasGuzzled = circumference / mpg;
            Console.WriteLine("Your vehicle would consume " + gasGuzzled + " gallons of gas going around the circle one time.");
        }
    }
}
