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

            Ristkylik uusRistkylik = new Ristkylik(6,5);

            Console.WriteLine(uusRistkylik.arvutaPindala());
            //string kysimus = "Palun sisesta oma vanus: ";
            //int vanus = kysiKasutajaltArv(kysimus);

            //bool taisealine = kasOnTaisealine(vanus);

            //Console.WriteLine(taisealine ? "Oled täisealine :) " : "Ei ole veel täisealine :(");


            Console.ReadLine();

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

        //Luua meetod, mis küsib kasutajalt vanust ning tagastab, kas tegemist on täisealise kasutajaga
        static bool kasOnTaisealine(int vanus)
        {
            return vanus > 17;
        }
       

    }
}
