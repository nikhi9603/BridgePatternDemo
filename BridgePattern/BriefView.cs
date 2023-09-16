using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class BriefView : IDrawingView
    {
        public List<string> DisplayCircle(double radius)
        {
            List<string> result = new List<string> { "Brief View of Circle" };

            result.Add($"Drawing Circle with radius {radius} units");
            return result;
        }

        public List<string> DisplaySquare(double length)
        {
            List<string> result = new List<string> { "Brief View of Square" };

            result.Add($"Drawing Square with length {length} units");
            return result;
        }
    }
}
