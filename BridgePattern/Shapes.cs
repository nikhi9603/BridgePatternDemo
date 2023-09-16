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

        public Shapes(IDrawingView view) 
        {  
            this.view = view; 
        }

        public abstract List<string> Display();
    }
}
