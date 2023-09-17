/******************************************************************************
* Filename    = IDrawingView.cs
*
* Author      = Nikhitha Atyam
*
* Product     = BridgePatternDemo
* 
* Project     = BridgePattern
*
* Description = IDrawingView contains display menthods of each shape (interface methods needed to be implemented by each view)
*****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// IDrawingView contains display menthods of each shape (interface methods needed to be implemented by each view)
    /// IMPLEMENTATION of bridge pattern
    /// </summary>
    public interface IDrawingView
    {
        /// <summary>
        /// Function to visualize square
        /// </summary>
        /// <param name="length">length of square</param>
        /// <returns>Returns a list of strings stating the visualization of square</returns>
        List<string> DisplaySquare(double length);


        /// <summary>
        /// Function to visualize circlw
        /// </summary>
        /// <param name="radius">radius of circle</param>
        /// <returns>Returns a list of strings stating the visualization of circle</returns>
        List<string> DisplayCircle(double radius);
    }
}
