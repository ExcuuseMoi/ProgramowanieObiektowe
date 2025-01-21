using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    internal class Napoj
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int IloscNaStanie { get; set; }


        //kontruktor przypisuje wartosci do wlasciwosci Nazwa, Cena itd
        public Napoj(string nazwa, double cena, int ilosc) 
        {
            Nazwa = nazwa;
            Cena = cena;
            IloscNaStanie = ilosc;
        }
        
        //Metoda zwraca nazwe i aktualna cene napoju. C2 - format waluty + 2 miejsca po przecinku
        public virtual string OpisProduktu()
        {
            return $"{Nazwa} - {Cena:C2}";
        }
    }
}
