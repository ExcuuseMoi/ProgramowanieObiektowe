using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //dodatkowa klasa, ktora będzie mogla sobie dziedziczyc po Napojach i sprawdzac czy sa gazowanec
    internal class NapojGazowany : Napoj
    {
        public NapojGazowany(string nazwa, double cena, int ilosc) : base(nazwa, cena, ilosc) { }


        //Nadpisuje metode z klasy bazowej Napoj i dodaje info o napoju gazowanym
        public override string OpisProduktu()
        {
            return base.OpisProduktu() + " (napój gazowany)";
        }
    }
}
