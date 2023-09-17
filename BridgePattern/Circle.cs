/******************************************************************************
* Filename    = Circle.cs
*
* Author      = Nikhitha Atyam
*
* Product     = BridgePatternDemo
* 
* Project     = BridgePattern
*
* Description = Circle class implements its construction & Visualization of Circle 
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// Circle class implements its construction & Visualization of Circle 
    /// REFINED ABSTRACTION of bridge pattern
    /// </summary>
    public class Circle : Shapes
    {
        // radius of circle
        private readonly double _radius ;

        /// <summary>
        /// Construction of circle by handling errors
        /// </summary>
        /// <param name="_view">Visualization View</param>
        /// <param name="radius">Radius of circle</param>
        /// <exception cref="ArgumentException">Invalid Radius of Circle</exception>
        public Circle(IDrawingView _view , double radius) : base(_view) 
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException("Invalid radius of circle");
            }
        }

        // Constructor if no view is given => DetailedView is considered as default
        public Circle(double radius) : base(new DetailedView()) 
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException("Invalid radius of circle");
            }
        }

        /// <summary>
        /// Visualization of Circle
        /// </summary>
        /// <returns>Returns of list of statements stating visualization of Circle</returns>
        public override List<string> Display()
        {
            List<string> result;

            result = base.view.DisplayCircle(_radius);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            return result;
        }
    }
}
