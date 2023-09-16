using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class DetailedView : IDrawingView
    {
        public List<string> displayCircle(double radius)
        {
            List<string> result = new List<string>();
            result.Add("Detailed View of Circle");

            if(radius > 0)
            {
                double area = Math.PI * Math.Pow(radius, 2);
                result.Add($"Drawing Circle with radius {radius} units");
                result.Add($"Area of Circle = {area} sq.units");
            }
            else
            {
                result.Add($"ERROR: Invalid radius of Circle ({radius})");
            }
            return result;
        }

        public List<string> displaySquare(double length)
        {
            List<string> result = new List<string>();
            result.Add("Detailed View of Square");

            if (length > 0)
            {
                double area = Math.Pow(length, 2);
                result.Add($"Drawing Square with length {length} units");
                result.Add($"Area of Square = {area} sq.units");
            }
            else
            {
                result.Add($"ERROR: Invalid length of Square ({length})"); 
            }
            return result;
        }
    }
}
