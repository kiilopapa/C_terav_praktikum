using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Veoauto : Auto
    {
        private bool _kallutab = false;

        public Veoauto() : base(70)
        {
        }
        public void hakkaKallutama()
        {
            this.stop();
            this._kallutab = true;
        }
        public new void kiirenda(int kiirus)
        {
            if (_kallutab) Console.WriteLine("Ei saa kiirendada, kallutab!");
            else base.kiirenda(kiirus);

        }

        public new string hetkeSeis()
        {
            return _kallutab ? "Kallutab, " + base.hetkeSeis() : base.hetkeSeis();
        }

        public override string ToString()
        {
            return hetkeSeis();
        }
    }
}
