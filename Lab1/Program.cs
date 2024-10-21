using System.Numerics;
using System.Threading.Channels;

zadanie1(); // wywolanie metody


//koniec main


void zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();
    double x1, x2, delta;
    if (a == 0)
    {
        Console.WriteLine("To nie jest rownanie kwadratowe");
    }
    else
    {
        delta = (Math.Pow(b, 2) - (4 * a * c));
        Console.WriteLine($"Delta: {delta}");
        if (delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Dwa rozwiazania, x1 = {x1}, x2={x2}");
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"Jedno rozwiazanie  x={x1}");
        }
    }


}
double DoubleInput()
{
    Console.WriteLine("Podaj Liczbę:");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;

}

// See https://aka.ms/new-console-template for more information

//void menu()
//{
//    Console.WriteLine("-----------------------Kalkulator-----------------\n1. Suma\n2. Roznica\n3. Iloczyn" + "\n4. Iloraz\n5. Potegowanie\n7. Trygonometria\n8. Wyjscie");

//    Console.WriteLine("wybierz opcje: ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice)
//    {
//        case 1: Total(); break;
//        case 2: Difference(); break;
//        case 3: ProductNumber(); break;
//        case 4: PotentationNumber(); break;
//        case 5: QuotienNumber(); break;
//        case 6: SquareNumber(); break;
//        case 7: Trigonometry(); break;
//        case 8: Close(); break;

//        default: Console.WriteLine("Bledne dane, sprobuj jeszcze raz!");
//            break;

//    }
//}


//void Close()
//{
//    Console.WriteLine("Koniec programu");
//    System.Environment.Exit(1);
//}