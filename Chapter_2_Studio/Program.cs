using System;

namespace Chapter_2_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius of a circle:");

            string userInput = Console.ReadLine();
            double radius = double.Parse(userInput);
            double area = Math.PI * Math.Pow(radius, 2);
            double roundedArea = Math.Round(area, 3);

            Console.WriteLine($"The area of a circle with a radius of {radius} is: {roundedArea}");


        }
    }
}
