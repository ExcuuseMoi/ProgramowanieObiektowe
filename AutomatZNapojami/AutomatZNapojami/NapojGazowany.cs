using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    internal class NapojGazowany:Napoj
    {
        //dodatkowa klasa, ktora będzie mogla sobie dziedziczyc po Napojach i sprawdzac czy sa gazowane
        public bool CzyJestGazowany {  get; set; }


        public NapojGazowany(string nazwa, double cena, int ilosc, bool czyjestgazowany):base(nazwa, cena, ilosc) 
        {
            CzyJestGazowany = czyjestgazowany;
        }

        //Nadpisuje metode z klasy bazowej Napoj i dodaje info o napoju gazowanym
        public override string OpisProduktu()
        {
            return base.OpisProduktu() + " (napój gazowany)";
        }


    }
}
