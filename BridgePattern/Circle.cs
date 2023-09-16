using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Circle : Shapes
    {
        private readonly double _radius ;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_view"></param>
        public Circle(IDrawingView _view , double radius) : base(_view) 
        {
            if (radius > 0)
            {
                this._radius = radius;
            }
            else
            {
                throw new ArgumentException("Invalid radius of circle");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Circle(double radius) : base(new DetailedView()) 
        {
            if (radius > 0)
            {
                this._radius = radius;
            }
            else
            {
                throw new ArgumentException("Invalid radius of circle");
            }
        }

        public override List<string> Display()
        {
            List<string> result;

            result = base.view.DisplayCircle(this._radius);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            return result;
        }
    }
}
