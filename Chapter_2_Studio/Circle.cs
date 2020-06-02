using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_2_Studio
{
    class Circle
    {
        public static double GetArea(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 3);
        }

        public static double GetDiameter(double radius)
        {
            return Math.Round((2 * radius), 3);
        }

        public static double GetCircumference(double radius)
        {
            return Math.Round((2 * Math.PI * radius), 3);
        }
    }
}
