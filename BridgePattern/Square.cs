using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Square : Shapes
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_view"></param>
        public Square(IDrawingView _view) : base(_view) { }

        public Square() : base(new DetailedView()) { }

        public override List<string> display(List<double> values)
        {
            List<string> result = new List<string>();

            if (values.Count != 0)
            {
                result.Add($"ERROR: Received more than 1 argument for Square to display");
                return result;
            }
            else
            {
                return base.view.displaySquare(values[0]);
            }
        }
    }
}
