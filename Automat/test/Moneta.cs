using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Moneta
    {
        public double Nominal { get; set; } 
        public int Ilosc { get; set; } 

        
        public Moneta(double nominal, int ilosc)
        {
            Nominal = nominal;
            Ilosc = ilosc;
        }
    }
}
