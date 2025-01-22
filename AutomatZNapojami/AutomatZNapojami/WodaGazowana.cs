using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{

    //Klasa do wody gazowanej, ktora bedzie dziedziczyc po NapojGazowany
    internal class WodaGazowana:NapojGazowany
    {
        public WodaGazowana(string nazwa, double cena, int ilosc):base(nazwa, cena, ilosc, true) {}

        //Metoda bedzie zwracac info o produkcie i dodatkowo z info, ze jest to woda gazowana
        public override string OpisProduktu()
        {
            return base.OpisProduktu() + " (woda gazowana)";
        }
    }
}
