using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class BriefView : IDrawingView
    {
        public List<string> displayCircle(double radius)
        {
            List<string> result = new List<string>();
            result.Add("Brief View of Circle");

            if (radius > 0)
            {
                result.Add($"Drawing Circle with radius {radius} units");
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
            result.Add("Brief View of Square");

            if (length > 0)
            {
                result.Add($"Drawing Square with length {length} units");
            }
            else
            {
                result.Add($"ERROR: Invalid length of Square ({length})");
            }
            return result;
        }
    }
}
