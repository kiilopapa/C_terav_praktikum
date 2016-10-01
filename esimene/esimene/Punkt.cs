using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Punkt
    {
        private int _x;
        private int _y;

        public Punkt (int x, int y)
        {
            _x = x;
            _y = y;
        }

        public double kaugusNullist()
        {
            double dx = System.Convert.ToDouble(Math.Abs(_x - 0));
            double dy = System.Convert.ToDouble(Math.Abs(_y - 0));
            return Math.Sqrt(dx * dx + dy * dy);
        }

        internal void teataAndmed()
        {
            Console.WriteLine("x="+_x+"; y="+_y);
        }

        public double kaugusTeisestPunnktist(Punkt p)
        {
            double dx = System.Convert.ToDouble(Math.Abs(_x - p._x));
            double dy = System.Convert.ToDouble(Math.Abs(_y - p._y));
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public bool kasOnAlgusPunkt()
        {
            return _x == 0 &&_y == 0;
        }
    }
}
