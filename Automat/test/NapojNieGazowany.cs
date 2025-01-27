using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //dodatkowa klasa, ktora będzie mogla sobie dziedziczyc po Napojach i podac rodzaj napoju
    internal class NapojNieGazowany : Napoj
    {
        public NapojNieGazowany(string nazwa, double cena, int ilosc) : base(nazwa, cena, ilosc) { }



        //Nadpisuje metode z klasy bazowej Napoj i dodaje info o napoju niegazowanym
        public override string OpisProduktu()
        {
            return base.OpisProduktu() + " (napój niegazowany)";
        }
    }
}
