using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        private string imie;
        private string nazwisko;
        List<int> oceny = new List<int>();


        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public double SredniaOcen()
        {
            return Math.Round((double) oceny.Average(), 2);
        }


        public void DodajOcene(int ocena)
        {
            if (ocena >= 0 && ocena <= 6)
            {
                this.oceny.Add(ocena);
            }
            else { Console.WriteLine("Podano zla ocene. Ocena musi byc z przedzialu od 0 do 6"); }
        }


        public void DaneStudenta()
        {
            Console.WriteLine($"Imię: {this.imie}, Nazwisko: {this.nazwisko}, Średnia ocen: {SredniaOcen()}");
        }

    }
}
