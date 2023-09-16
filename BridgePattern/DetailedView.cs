/******************************************************************************
* Filename    = DetailedView.cs
*
* Author      = Nikhitha Atyam
*
* Product     = BridgeDesignPatternDemo
* 
* Project     = BridgePattern
*
* Description = DetailedView implements Visualisation of Shapes in a more detailed manner
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// DetailedView implements Visualisation of Shapes in a more detailed manner
    /// </summary>
    public class DetailedView : IDrawingView
    {
        /// <summary>
        /// Function has to draw circle. Due to complexity of drawing circle, considered displaying properties of circle instead
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <returns>Detailed description of circle</returns>
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



        /// <summary>
        /// Function has to draw square. Due to complexity of drawing square, considered displaying properties of square instead
        /// </summary>
        /// <param name="length">length of square</param>
        /// <returns>Detailed description of square</returns>
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
