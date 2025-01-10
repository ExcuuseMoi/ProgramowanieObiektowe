using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Licz
    {
        private int value;



        public Licz(int cyfra)
        {
            value = cyfra;
        }

        public void Dodaj(int dodawanie)
        {
            value += dodawanie;
        }

        public void Odejmij(int odejmowanie)
        {
            value -= odejmowanie;
        }

        public void Wypisanie() { 
        Console.WriteLine($"Wynik: {value}");
        }
    }
}
