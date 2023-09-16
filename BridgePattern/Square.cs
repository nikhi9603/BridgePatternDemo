/******************************************************************************
* Filename    = Square.cs
*
* Author      = Nikhitha Atyam
*
* Product     = BridgeDesignPatternDemo
* 
* Project     = BridgePattern
*
* Description = Square class implements its construction & Visualization of Square 
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// Square class implements its construction & Visualization of Square 
    /// REFINED ABSTRACTION of bridge pattern
    /// </summary>
    public class Square : Shapes
    {
        // length of square
        private readonly double _length;

        /// <summary>
        /// Construction of square by handling errors
        /// </summary>
        /// <param name="_view">Visualization View</param>
        /// <param name="length">Length of square</param>
        /// <exception cref="ArgumentException">Invalid length of square</exception>
        public Square(IDrawingView _view , double length) : base(_view) 
        {
            if (length > 0)
            {
                _length = length;
            }
            else
            {
                throw new ArgumentException("Invalid length of square");
            }
        }

        // Constructor if no view is given => DetailedView is considered as default
        public Square(double length) : base(new DetailedView()) 
        {
            if (length > 0)
            {
                _length = length;
            }
            else
            {
                throw new ArgumentException("Invalid length of square");
            }
        }


        /// <summary>
        /// Visualization of Square
        /// </summary>
        /// <returns>Returns of list of statements stating visualization of square</returns>
        public override List<string> Display()
        {
            List<string> result;
            result =  base.view.DisplaySquare(_length);

            foreach(string str in result)
            {
                Console.WriteLine(str);
            }
            return result;
        }
    }
}
