using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface IDrawingView
    {
        List<string> displaySquare(double length);
        List<string> displayCircle(double radius);
    }
}
