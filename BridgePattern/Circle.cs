using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Circle : Shapes
    {
        public Circle(IDrawingView view) : base(view) { }

        public Circle() : base(new DetailedView()) { }

        public override List<string> display(List<double> values)
        {
            List<string> result = new List<string>();

            if(values.Count != 0) 
            {
                result.Add($"ERROR: Received more than 1 argument for Circle to display");
                return result;
            }
            else
            {
                return base.view.displayCircle(values[0]); 
            }
        }
    }
}
