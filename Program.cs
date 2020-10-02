using System;

namespace OperatorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit typing - string variableName = "Hello";
            //inferred typing - var varName = "Hello";

            var a = 17;
            var b = 4;

            var div = a / b;

            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            var r = 20;
            var pi = Math.PI;
            //these are not needed with the method used below. r would have to be removed from console.write line because it 
            //no longer exists. 
            var areaOfCircle = pi * (r * r);
            // var areaOfCircle = CalculateArea(20);
            // use a method because if you had to do info for multiple circles you wouldn't want to
            // have to type in everytime. just use the method. 

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}");
            //Console.WriteLine($"The area of the circle with radius of {radius} is {areaOfCircle}");

            var radius = double.Parse(Console.ReadLine());
            //above allows user to input radius (normally above console write line just taking notes here)
            // a try parse can handle if people enter jibberish. like "xdhasu" insead of "20"
            //double realRadius;
            //var radius = double.TryParse(Console.ReadLine(), out realRadius);

            var areOfCircle = CalculateArea(radius);
            //above calculates area of the cricle. 

            //there is no prompt for user input. that can be added like
            //Console.Writeline("What is the radius of your circle?");

            //this is the formula for an area calculator app. add in graphics and this could be used for a phone, etc. 

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
