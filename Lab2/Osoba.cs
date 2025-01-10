using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;


        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }


        public string Imie
        {
            get { return imie; }
            set
            {
                if (value.Length < 2)
                {

                    throw new ArgumentException($"Imie musi skladac sie minimum z dwoch znakow");
                }
                imie = value;
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length < 2)
                {

                    throw new ArgumentException($"Nazwisko musi skladac sie minimum z dwoch znakow");
                }
                nazwisko = value;
            }
        }

        public int Wiek
        {
            get { return wiek; }

            set
            {
                if (wiek <= 0)
                {
                    throw new ArgumentException($"Wiek musi byc liczba dodatnia");
                    wiek = value;
                }
            }
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imie: {imie}, Nazwisko: {nazwisko}, Wiek: {wiek}");
        }
    }
}
