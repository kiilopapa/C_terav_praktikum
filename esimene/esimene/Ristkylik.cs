using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Ristkylik
    {
        private int _laius;
        private int _pikkus;

        public Ristkylik(int laius, int pikkus)
        {
            _laius = laius;
            _pikkus = pikkus;
        }

        public int arvutaPindala()
        {
            return this._laius*this._pikkus;
        }

        public int arvutaÜmbermõõt()
        {
            return 2 * (_laius + _pikkus);
        }

        public bool kasOnRuut()
        {
            return _laius == _pikkus;
        }

        public bool kasOnVordsed(Ristkylik r2)
        {
            return _laius == r2._laius && _pikkus == r2._pikkus;
            //return this.arvutaPindala() == r2.arvutaPindala();
        }
    }
}
