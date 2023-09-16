using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface IDrawingView
    {
        List<string> DisplaySquare(double length);
        List<string> DisplayCircle(double radius);
    }
}
