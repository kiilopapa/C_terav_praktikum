using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Kompleksarv
    {
        double _reaalosa;
        double _iosa;

        public Kompleksarv(double r, double i)
        {
            _reaalosa = r;
            _iosa = i;
        }

        public double reaal()
        {
            return _reaalosa;
        }

        public double imaginaar()
        {
            return _iosa;
        }
        public static Kompleksarv liida (Kompleksarv a, Kompleksarv b)
        {
            return new Kompleksarv(a._reaalosa + b._reaalosa, a._iosa + b._iosa);
        }
        public static Kompleksarv lahuta(Kompleksarv a, Kompleksarv b)
        {
            return new Kompleksarv(a._reaalosa - b._reaalosa, a._iosa - b._iosa);
        }

    }
}
