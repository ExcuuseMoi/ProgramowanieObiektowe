using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
 
    internal class Automat
    {
        private List<Napoj> napoje; 
        private List<Moneta> monety; 
        private List<Transakcja> transakcje; 
        private double wrzuconeMonety; 
        private PlikManager plikManager; 

        
        public Automat()
        {
            napoje = new List<Napoj>();
            monety = new List<Moneta>();
            transakcje = new List<Transakcja>();
            wrzuconeMonety = 0;
            plikManager = new PlikManager();

            WczytajDane();
        }

        
        public void Uruchom()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Wyświetl napoje");
                Console.WriteLine("2. Wrzuć monetę");
                Console.WriteLine("3. Kup napój");
                Console.WriteLine("4. Menu administracyjne");
                Console.WriteLine("5. Wyjdź");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        WyswietlNapoje();
                        break;
                    case "2":
                        WrzucMonete();
                        break;
                    case "3":
                        KupNapoj();
                        break;
                    case "4":
                        MenuAdministracyjne();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór!");
                        break;
                }

                Console.WriteLine("Naciśnij Enter, aby kontynuować...");
                Console.ReadLine();
            }
        }

       
        private void WyswietlNapoje()
        {
            Console.WriteLine("Dostępne napoje:");
            for (int i = 0; i < napoje.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {napoje[i].OpisProduktu()} (dostępnych: {napoje[i].Ilosc})");
            }
        }

       
        private void WrzucMonete()
        {
            Console.WriteLine("Dostępne monety: 1 zł, 2 zł, 5 zł");
            Console.Write("Wrzuć monetę (wpisz nominał, np. 1, 2, 5): ");
            if (double.TryParse(Console.ReadLine(), out double moneta))
            {
                if (moneta == 1 || moneta == 2 || moneta == 5)
                {
                    wrzuconeMonety += moneta;
                    Console.WriteLine($"Wrzucono: {moneta:C2}");
                    Console.WriteLine($"Aktualna kwota: {wrzuconeMonety:C2}");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy nominał! Akceptowane monety: 1 zł, 2 zł, 5 zł.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowa kwota!");
            }
        }

        
        private void KupNapoj()
        {
            WyswietlNapoje();
            Console.Write("Wybierz numer napoju: ");
            if (int.TryParse(Console.ReadLine(), out int numer) && numer > 0 && numer <= napoje.Count)
            {
                Napoj wybranyNapoj = napoje[numer - 1];

                if (wybranyNapoj.Ilosc > 0 && wrzuconeMonety >= wybranyNapoj.Cena)
                {
                    wybranyNapoj.Ilosc--;
                    wrzuconeMonety -= wybranyNapoj.Cena;
                    transakcje.Add(new Transakcja(wybranyNapoj.Nazwa, wybranyNapoj.Cena));
                    Console.WriteLine($"Wydano: {wybranyNapoj.OpisProduktu()}");
                    Console.WriteLine($"Pozostało: {wrzuconeMonety:C2}");

                    
                    ZapiszDane();
                }
                else if (wybranyNapoj.Ilosc == 0)
                {
                    Console.WriteLine("Brak produktu w automacie!");
                }
                else
                {
                    Console.WriteLine("Niewystarczająca ilość środków!");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór!");
            }
        }

        
        private void WczytajDane()
        {
            
            var linieNapoje = plikManager.WczytajZPliku("napoje.txt");
            foreach (var linia in linieNapoje)
            {
                var dane = linia.Split(';');
                string nazwa = dane[0];
                double cena = double.Parse(dane[1]);
                int ilosc = int.Parse(dane[2]);
                string rodzaj = dane[3];

                if (rodzaj == "gazowany")
                {
                    napoje.Add(new NapojGazowany(nazwa, cena, ilosc));
                }
                else if (rodzaj == "niegazowany")
                {
                    napoje.Add(new NapojNieGazowany(nazwa, cena, ilosc));
                }
            }

           
            var linieTransakcje = plikManager.WczytajZPliku("transakcje.txt");
            foreach (var linia in linieTransakcje)
            {
                var dane = linia.Split(';');
                string produkt = dane[0];
                double kwota = double.Parse(dane[1]);
                transakcje.Add(new Transakcja(produkt, kwota));
            }
        }

        
        private void ZapiszDane()
        {
            //zapisywanie napoji
            List<string> linieNapoje = new List<string>();
            foreach (var napoj in napoje)
            {
                string rodzaj = napoj is NapojGazowany ? "gazowany" : "niegazowany";
                linieNapoje.Add($"{napoj.Nazwa};{napoj.Cena};{napoj.Ilosc};{rodzaj}");
            }
            plikManager.ZapiszDoPliku("napoje.txt", linieNapoje);

           //zapisywanie transakcji
            List<string> linieTransakcje = new List<string>();
            foreach (var transakcja in transakcje)
            {
                linieTransakcje.Add($"{transakcja.Produkt};{transakcja.Kwota}");
            }
            plikManager.ZapiszDoPliku("transakcje.txt", linieTransakcje);
        }

        
        private void MenuAdministracyjne()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Dodaj napój");
                Console.WriteLine("2. Usuń napój");
                Console.WriteLine("3. Wyświetl transakcje");
                Console.WriteLine("4. Wróć");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        DodajNapoj();
                        break;
                    case "2":
                        UsunNapoj();
                        break;
                    case "3":
                        WyswietlTransakcje();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór!");
                        break;
                }

                Console.WriteLine("Naciśnij Enter, aby kontynuować...");
                Console.ReadLine();
            }
        }

        private void DodajNapoj()
        {
            Console.Write("Podaj nazwę napoju: ");
            string nazwa = Console.ReadLine();
            Console.Write("Podaj cenę napoju: ");
            double cena = double.Parse(Console.ReadLine());
            Console.Write("Podaj ilość napoju: ");
            int ilosc = int.Parse(Console.ReadLine());
            Console.Write("Podaj rodzaj napoju (gazowany/niegazowany): ");
            string rodzaj = Console.ReadLine();

            if (rodzaj.ToLower() == "gazowany")
            {
                napoje.Add(new NapojGazowany(nazwa, cena, ilosc));
            }
            else if (rodzaj.ToLower() == "niegazowany")
            {
                napoje.Add(new NapojNieGazowany(nazwa, cena, ilosc));
            }
            else
            {
                Console.WriteLine("Nieprawidłowy rodzaj napoju!");
                return;
            }

            
            ZapiszDane();
            Console.WriteLine("Dodano napój!");
        }

        
        private void UsunNapoj()
        {
            WyswietlNapoje();
            Console.Write("Wybierz numer napoju do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int numer) && numer > 0 && numer <= napoje.Count)
            {
                napoje.RemoveAt(numer - 1);
                Console.WriteLine("Napój został usunięty.");

                
                ZapiszDane();
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór!");
            }
        }

        
        private void WyswietlTransakcje()
        {
            Console.WriteLine("Historia transakcji:");
            foreach (var transakcja in transakcje)
            {
                Console.WriteLine($"{transakcja.Data} - {transakcja.Produkt} - {transakcja.Kwota:C2}");
            }
        }
    }
}

