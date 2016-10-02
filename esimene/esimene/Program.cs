using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace esimene
{
    class Program
    {
        static void Main(string[] args)
        {


            int tegevus = kysiKasutajaltArv("Vali programm:\n\n1 - faren->kelvin \n2 - celsius->faren\n3 - täisealisese kontroll\n4 - kolmnurga kontroll\n5 - Sonade lugeja\n6 - tagurpidi\n7 - Ristkülik\n8 - Punkt\n9 - Kompleksarv\n10 - Mootorsõiduk\n11 - Auto");

            switch (tegevus)
            {
                case 0:
                    break;
                case 1:
                    String kysiFarenheit = "Sisesta temperatuur farenheiti skaala järgi";
                    double farenheit = kysiKasutajaltKomagaArv(kysiFarenheit);
                    double kelvin = farenheitToKelvin(farenheit);
                    Console.WriteLine(kelvin + "K");
                    break;
                case 2:
                    Double celsius = kysiKasutajaltKomagaArv("Sisesta temperatuur Celsiuse skaala järgi :");
                    double faren = celsiusToFarenheit(celsius);
                    Console.WriteLine(faren + " kraadi Farenheiti");
                    break;
                case 3:
                    string kysimus = "Palun sisesta oma vanus: ";
                    int vanus = kysiKasutajaltArv(kysimus);
                    bool taisealine = kasOnTaisealine(vanus);
                    Console.WriteLine(taisealine ? "Oled täisealine :) " : "Ei ole veel täisealine :(");
                    break;
                case 4:
                    int a1 = kysiKasutajaltArv("Sisesta 1. arv: ");
                    int a2 = kysiKasutajaltArv("Sisesta 2. arv: ");
                    int a3 = kysiKasutajaltArv("Sisesta 3. arv: ");
                    bool kolmnurk = kasOnKolmmnurk(a1, a2, a3);
                    Console.WriteLine(kolmnurk ? "Tegemist on kolmnurgaga " : "Ei ole kolmnurk ");
                    break;
                case 5:
                    string sisend = kysiLause();
                    int sonadeArv = mituSona(sisend);
                    Console.WriteLine(sonadeArv);
                    break;
                case 6:
                    string sisse = kysiLause();
                    string tagurpidi = pooraUmber(sisse);
                    Console.WriteLine(tagurpidi);
                    break;
                case 7:
                    int laius = kysiKasutajaltArv("Sisesta ristküliku laius: ");
                    int pikkus = kysiKasutajaltArv("Sisesta risküliku pikkus: ");
                    Ristkylik uusRistkylik = new Ristkylik(laius, pikkus);
                    Console.WriteLine("Ristküliku pindala on : " + uusRistkylik.arvutaPindala());
                    break;
                case 8:
                    int x = kysiKasutajaltArv("Sisesta x koordinaat: ");
                    int y = kysiKasutajaltArv("Sisesta y koordinaat: ");
                    Punkt punkt = new Punkt(x, y);
                    Console.WriteLine("Kaugus nullist: " + punkt.kaugusNullist());
                    Console.WriteLine(punkt.kasOnAlgusPunkt() ? "Punkt on koordinaatide alguspunkt. " : "Punkt ei ole koordinaatide alguspunkt");
                    punkt.teataAndmed();
                    Punkt p = new Punkt(3, 3);
                    Console.WriteLine("Kaugus punktist p: " +punkt.kaugusTeisestPunnktist(p));
                    break;
                case 9:
                    Kompleksarv a = new Kompleksarv(3, 4);
                    Kompleksarv b = new Kompleksarv(2, 2);
                    Kompleksarv c = Kompleksarv.liida(a, b);
                    Console.WriteLine(c.reaal() + " i"+c.imaginaar());
                    Kompleksarv d = Kompleksarv.lahuta(a, b);
                    Console.WriteLine(d.reaal() + " i" + d.imaginaar());
                    break;
                case 10:
                    Mootorsõiduk kiireSoiduk = new Mootorsõiduk(248);
                    Console.WriteLine(kiireSoiduk.ToString());
                    kiireSoiduk.kiirenda();
                    kiireSoiduk.kiirenda(25);
                    Console.WriteLine(kiireSoiduk.hetkeSeis());
                    kiireSoiduk.kiirenda(300);
                    Console.WriteLine(kiireSoiduk.ToString());
                    kiireSoiduk.stop();
                    Console.WriteLine(kiireSoiduk.ToString());
                    break;
                case 11:
                    Auto auto = new Auto();
                    Console.WriteLine(auto.ToString());
                    auto.kiirenda(140);
                    Console.WriteLine(auto.ToString());
                    auto.avaUksed();
                    Console.WriteLine(auto.ToString());
                    auto.kiirenda(100);
                    Console.WriteLine(auto.ToString());
                    auto.sulgeUksed();
                    Console.WriteLine(auto.ToString());
                    break;
                default:
                    break;

            }
            
         


            Console.ReadKey();



        }

        private static string pooraUmber(string sisse)
        {
            string tagurpidi = "";
            for (int i = sisse.Length-1; i > -1; i--) {
                tagurpidi = tagurpidi + sisse[i];
            }
            return tagurpidi;
        }

        private static string kysiLause()
        {
            Console.WriteLine("Kirjuta lause: ");
            return Console.ReadLine();


        }

        private static int mituSona(string sisend)
        {
            string s = sisend.Trim();
            if (s.Length < 1) return 0;
            int count = 1;
            for (int i = 0; i < sisend.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    count++;
                }
                i++;
            }

            return count;
        }

        private static bool kasOnKolmmnurk(int a1, int a2, int a3)
        {
            return a1+a2>a3 && a2+a3>a1 && a1+a3>a2;
        }

        static double celsiusToFarenheit(double celsius)
        {
            return celsius*9/5+32;
        }

        static double farenheitToKelvin(double f)
        {
            return (f - 32) * 5 / 9 + 273.15;
        }

        //1. Mida peaks meetod tagastama?
        //int
        //2. Mis on meetodi nimi ?
        //küsiKasutajaltArv
        //3. Kas meetod vajab sisendparameetreid
        // jah, text mis kirjutatakse eraanile
        static int kysiKasutajaltArv(string text)
        {
            Console.WriteLine(text);
            string vastus = Console.ReadLine();

            int a;
            if (int.TryParse(vastus, out a) == true)
                return a;
          
            return kysiKasutajaltArv(text);         
        }

        static double kysiKasutajaltKomagaArv(string text)
        {
            Console.WriteLine(text);
            string vastus = Console.ReadLine();

            double a;
            if (double.TryParse(vastus, out a) == true)
                return a;

            return kysiKasutajaltKomagaArv(text);
        }
        //Luua meetod, mis küsib kasutajalt vanust ning tagastab, kas tegemist on täisealise kasutajaga
        static bool kasOnTaisealine(int vanus)
        {
            return vanus > 17;
        }
     

    }
}
