using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Mootorsõiduk
    {
        private int _kiirus = 0;
        private int _maksKiirus = 20;

        public Mootorsõiduk(int makskiirus)
        {
            _maksKiirus = makskiirus;
        }

        public void kiirenda()
        {
            _kiirus = _kiirus + 10;
        }

        public void kiirenda(int kiirus)
        {
            if (_kiirus+kiirus<_maksKiirus)
            {
                _kiirus = _kiirus + kiirus;
            }
            else
            {
                _kiirus = _maksKiirus;
            }
        }

        public void stop()
        {
            _kiirus = 0;
        }

        public string hetkeSeis()
        {
            return _kiirus > 0 ? "Auto kiirus on " + _kiirus : "Auto seisab";
        }
        public override string ToString()
        {
            return hetkeSeis();
        }
    }

}
