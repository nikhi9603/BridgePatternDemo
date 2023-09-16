/******************************************************************************
* Filename    = Shapes.cs
*
* Author      = Nikhitha Atyam
*
* Product     = BridgeDesignPatternDemo
* 
* Project     = BridgePattern
*
* Description = Shapes class provides an way to select VisualizationView and implements that Visualization
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// Shapes class provides an way to select VisualizationView and implements that Visualization
    /// ABSTRACTION of bridge design pattern
    /// </summary>
    public abstract class Shapes
    {
        protected IDrawingView view;

        /// <summary>
        /// Abstraction provides a way to select Interface which is de-coupled.
        /// </summary>
        /// <param name="view">Here view represents Visulation View</param>
        public Shapes(IDrawingView view) 
        {  
            this.view = view; 
        }

        /// <summary>
        /// Display is the operation which can be called by Client in bridge pattern
        /// </summary>
        /// <returns>Returns a list of strings stating the description of each visualization</returns>
        public abstract List<string> Display();
    }
}
