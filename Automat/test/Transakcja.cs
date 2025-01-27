using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Transakcja
    {
        public DateTime Data { get; set; } 
        public string Produkt { get; set; } 
        public double Kwota { get; set; } 

        
        public Transakcja(string produkt, double kwota)
        {
            Data = DateTime.Now;
            Produkt = produkt;
            Kwota = kwota;
        }
    }
}
