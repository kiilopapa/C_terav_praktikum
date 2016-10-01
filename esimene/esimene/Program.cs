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


            int tegevus = kysiKasutajaltArv("Vali programm:\n\n1 - faren->kelvin \n2 - celsius->faren\n3 - täisealisese kontroll\n4 - kolmnurga kontroll\n0 - Välju");

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
                default:
                    break;

            }
            
         


            Console.ReadKey();


            int laius = kysiKasutajaltArv("Sisesta ristküliku laius: ");
            int pikkus = kysiKasutajaltArv("Sisesta risküliku pikkus: ");
            Ristkylik uusRistkylik = new Ristkylik(laius, pikkus);

            Console.WriteLine("Ristküliku pindala on : " + uusRistkylik.arvutaPindala());
            


            Console.ReadLine();

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
