using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class BankAccount
    {
        public decimal Saldo { get; private set; }
        public string Wlasciciel;



        public BankAccount(string wlasciciel, decimal saldo)
        {
            Wlasciciel = wlasciciel;
            Saldo = saldo;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota nie moze byc ujemna.");
            Saldo += kwota;
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
                throw new ArgumentException("Kwota nie moze byc ujemna.");
            if (kwota > Saldo)
                throw new ArgumentException("Nie masz tyle pieniedzy na koncie.");
            Saldo -= kwota;

            
        }

    }
}
