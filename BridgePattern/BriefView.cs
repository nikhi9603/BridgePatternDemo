/******************************************************************************
* Filename    = BriefView.cs
*
* Author      = Nikhitha Atyam
*
* Product     = BridgeDesignPatternDemo
* 
* Project     = BridgePattern
*
* Description = BriefView implements Visualisation of Shapes in a less detailed manner
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// BriefView implements Visualisation of Shapes in a less detailed manner
    /// </summary>
    public class BriefView : IDrawingView
    {
        /// <summary>
        /// Function has to draw circle. Due to complexity of drawing circle, considered displaying properties of circle instead
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <returns>Brief description of circle</returns>
        public List<string> DisplayCircle(double radius)
        {
            List<string> result = new List<string> { "Brief View of Circle" , $"Drawing Circle with radius {radius} units" };
            return result;
        }


        /// <summary>
        /// Function has to draw square. Due to complexity of drawing square, considered displaying properties of square instead
        /// </summary>
        /// <param name="length">length of square</param>
        /// <returns>Brief description of square</returns>
        public List<string> DisplaySquare(double length)
        {
            List<string> result = new List<string> { "Brief View of Square" , $"Drawing Square with length {length} units"};
            return result;
        }
    }
}
