using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Auto : Mootorsõiduk
    {
        bool uksedAvatud = false;
        public Auto() : base(100)
        {
        }
        public void avaUksed()
        {
            this.stop();
            this.uksedAvatud = true;
        }
        public void sulgeUksed()
        {
            this.uksedAvatud = false;
        }

        public new void kiirenda(int kiirus)
        {
            if (!uksedAvatud) base.kiirenda(kiirus);
            else Console.WriteLine("Ei saa kiirendada, uksed on avatud");
        }
        public new string hetkeSeis()
        {
            return this.uksedAvatud ? "uksed avatud, "+ base.hetkeSeis() : "Uksed kinni " +base.hetkeSeis();
        }

        public override string ToString()
        {
            return this.hetkeSeis();
        }
    }
}
