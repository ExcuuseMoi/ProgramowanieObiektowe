using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Sumator
    {
        private List<int> Liczby = new List<int>();

        public Sumator(List<int> liczby) {
            this.Liczby = liczby;
        }

        public int Suma()
        {
            int sum = 0;
            foreach (int num in Liczby)
            {
                sum += num;
            }
            return sum;
        }


        public int SumaPodziel2()
        {
            int suma = 0;
            foreach (int num in Liczby)
            {
                if (num % 2 == 0)
                    suma += num;
            }
            return suma;
        }

        public int IleElementow()
        {
            Console.Write("Ilosc elemetow w tablicy: ");
            return Liczby.Count;
        }


        public void WszystkieElementy()
        {
            foreach (int n in Liczby)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

    }
}
