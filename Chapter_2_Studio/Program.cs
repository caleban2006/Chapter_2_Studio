using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Chapter_2_Studio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isNum = true;
            int radius = 0;
            do
            {
                Console.WriteLine("Enter a radius of a circle:");
                string userInput = Console.ReadLine();
                isNum = Int32.TryParse(userInput, out radius);
                radius ++;
                } while (radius < 0);        
                if (isNum == true)
                {
                    Console.WriteLine($"The area of this circle is: {Circle.GetArea(radius)}");
                    Console.WriteLine($"The circumference this circle is: {Circle.GetCircumference(radius)}");
                    Console.WriteLine($"The diameter this circle is: {Circle.GetDiameter(radius)}");

                    Console.WriteLine("Please enter the miles per gallon that your vehicle uses:");

                    string mpgUserInput = Console.ReadLine();
                    double mpg = double.Parse(mpgUserInput);
                    double gasUsed = Math.Round(Circle.GetCircumference(radius) / mpg, 3);

                    Console.WriteLine($"You would use {gasUsed} gallons of gas!");
                }
                else
                {
                    Console.WriteLine("ERROR! INVALID ENTRY!");
                }
        }
    }
}