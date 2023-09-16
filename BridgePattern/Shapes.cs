using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Shapes
    {
        protected IDrawingView view;

        public Shapes(IDrawingView _view) 
        {  
            this.view = _view; 
        }

        public abstract List<string> display(List<double> values);
    }
}
