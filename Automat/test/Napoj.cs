using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Napoj
    {
        public string Nazwa { get; set; } 
        public double Cena { get; set; } 
        public int Ilosc { get; set; } 

        
        public Napoj(string nazwa, double cena, int ilosc)
        {
            Nazwa = nazwa;
            Cena = cena;
            Ilosc = ilosc;
        }


        //metoda zwraca nazwe i aktualna cene napoju. C2 - format waluty + 2 miejsca po przecinku
        public virtual string OpisProduktu()
        {
            return $"{Nazwa} - {Cena:C2}";
        }
    }
}
