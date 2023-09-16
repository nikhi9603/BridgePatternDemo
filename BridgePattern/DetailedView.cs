using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class DetailedView : IDrawingView
    {
        public List<string> DisplayCircle(double radius)
        {
            List<string> result = new List<string> { "Detailed View of Circle" };

            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;
            result.Add($"Drawing Circle with radius {radius} units");
            result.Add($"Area of Circle = {area} sq.units");
            result.Add($"Perimeter of Circle = {perimeter} units");
            return result;
        }

        public List<string> DisplaySquare(double length)
        {
            List<string> result = new List<string> { "Detailed View of Square" };

            double area = Math.Pow(length, 2);
            double perimeter = 4 * length;
            result.Add($"Drawing Square with length {length} units");
            result.Add($"Area of Square = {area} sq.units");
            result.Add($"Perimeter of Square = {perimeter} units");
            return result;
        }
    }
}
