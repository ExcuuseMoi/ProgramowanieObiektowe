using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatZNapojami
{

    //dodatkowa klasa, ktora bedzie dziedziczyc po NapojGazowany i pozwoli okreslic, czy napoj jest typu zero
    internal class NapojSlodzony:NapojGazowany
    {
        public bool CzyJestSlodzony { get; set; }


        public NapojSlodzony(string nazwa, double cena, int ilosc, bool czyjestslodzony):base(nazwa, cena, ilosc, true) 
        {
            CzyJestSlodzony = czyjestslodzony;
        }

        //metoda bedzie zwracac opis napoju i dodatkowo info, czy jest to napoj zero, czy normalnie slodzony
        public override string OpisProduktu()
        {
            string rodzajSlodzonegoNapoju;
            if (CzyJestSlodzony)
            {
                rodzajSlodzonegoNapoju = "normalnie slodzony";
            }
            else
            {
                rodzajSlodzonegoNapoju = "zero";
            }
            return $"{Nazwa} {rodzajSlodzonegoNapoju} - {Cena:C2} (napój gazowany)";
        }
    }
}
