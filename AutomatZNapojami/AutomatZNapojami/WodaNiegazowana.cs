using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{
    //Klasa do wody niegazowanej, ktora bedzie dziedziczyc po NapojNieGazowany
    internal class WodaNiegazowana:NapojNieGazowany
    {
        public WodaNiegazowana(string nazwa, double cena, int ilosc):base(nazwa, cena, ilosc, "woda niegazowana") { }


        //Metoda bedzie zwracac info o produkcie i dodatkowo z info, ze jest to woda niegazowana
        public override string OpisProduktu()
        {
            return $"{Nazwa} - {Cena:C2} (woda niegazowana)";
        }
    }
}
