using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    //dodatkowa klasa, ktora będzie mogla sobie dziedziczyc po Napojach i podac rodzaj napoju
    internal class NapojNieGazowany : Napoj
    {
        public string Rodzaj {  get; set; } 


        public NapojNieGazowany(string nazwa, double cena, int ilosc, string rodzaj):base(nazwa, cena, ilosc) 
        {
            Rodzaj = rodzaj;
        }

        //Nadpisuje metode z klasy bazowej Napoj i dodaje info o rodzaju napoju
        public override string OpisProduktu()
        {
            return base.OpisProduktu() + $" ({Rodzaj})";
        }
    }
}
