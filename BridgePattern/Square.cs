using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Square : Shapes
    {
        private readonly double _length;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_view"></param>
        public Square(IDrawingView _view , double length) : base(_view) 
        {
            if (length > 0)
            {
                this._length = length;
            }
            else
            {
                throw new ArgumentException("Invalid length of square");
            }
        }

        public Square(double length) : base(new DetailedView()) 
        {
            if (length > 0)
            {
                this._length = length;
            }
            else
            {
                throw new ArgumentException("Invalid length of square");
            }
        }

        public override List<string> Display()
        {
            List<string> result;
            result =  base.view.DisplaySquare(this._length);

            foreach(string str in result)
            {
                Console.WriteLine(str);
            }
            return result;
        }
    }
}
