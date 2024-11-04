using System.Numerics;
using System.Threading.Channels;
//See https://aka.ms/new-console-template for more information
//zadanie1(); // wywolanie metody


//koniec main


//void zadanie1()
//{
//    double a = DoubleInput();
//    double b = DoubleInput();
//    double c = DoubleInput();
//    double x1, x2, delta;
//    if (a == 0)
//    {
//        Console.WriteLine("To nie jest rownanie kwadratowe");
//    }
//    else
//    {
//        delta = (Math.Pow(b, 2) - (4 * a * c));
//        Console.WriteLine($"Delta: {delta}");
//        if (delta > 0)
//        {
//            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
//            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
//            Console.WriteLine($"Dwa rozwiazania, x1 = {x1}, x2={x2}");
//        }
//        else if (delta == 0)
//        {
//            x1 = -b / (2 * a);
//            Console.WriteLine($"Jedno rozwiazanie  x={x1}");
//        }
//    }


//}
//double DoubleInput()
//{
//    Console.WriteLine("Podaj Liczbę:");
//    double value = Convert.ToDouble(Console.ReadLine());
//    return value;

//}








//----------------------------------------------------------------------------------------------------------------------------------
//ZADANIE2
//while (true)
//{
//    menu();
//}
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


//static void Total()
//{
//    Console.WriteLine("Podaj dwie liczby: a i b");
//    double a = GetInput();
//    double b = GetInput();
//    Console.WriteLine($"Wynik dodawania: {a + b}");
//}

//static void Difference()
//{
//    Console.WriteLine("Podaj dwie liczby: a i b");
//    double a = GetInput();
//    double b = GetInput();
//    Console.WriteLine($"Wynik odejmowania: {a - b}");
//}

//static void ProductNumber()
//{
//    Console.WriteLine("Podaj dwie liczby: a i b");
//    double a = GetInput();
//    double b = GetInput();
//    Console.WriteLine($"Wynik iloczynu: {a * b}");
//}

//static void QuotienNumber()
//{
//    Console.WriteLine("Podaj dwie liczby: a i b");
//    double a = GetInput();
//    double b = GetInput();
//    if (b != 0)
//    {
//        Console.WriteLine($"Wynik ilorazu: {a / b}");
//    }
//    else {
//        Console.WriteLine("Nie dzielimy przez zero");    
//    }

//}

//static void PotentationNumber() {
//    Console.WriteLine("Podaj dwie liczby: a i b");
//    double a = GetInput();
//    double b = GetInput();
//    Console.WriteLine($"Wynik potęgowania: {Math.Pow(a, b)}");
//}

//static void SquareNumber()
//{
//    Console.WriteLine("Podaj liczbę wiekszą bądź równą 0: ");
//    double a = GetInput();
//    Console.WriteLine($"Wynik pierwiastkowania: {Math.Sqrt(a)}");

//}


//static void Trigonometry()
//{
//    Console.WriteLine("Kąt podaj w radianach: ");
//    double kt = GetInput();
//    Console.WriteLine($"Sinus: {Math.Sin(kt)}");
//    Console.WriteLine($"Cosinus: {Math.Cos(kt)}");
//    Console.WriteLine($"Tangens: {Math.Tan(kt)}");
//}

//void Close()
//{
//    Console.WriteLine("Koniec programu");
//    System.Environment.Exit(1);
//}

//static double GetInput()
//{
//    Console.WriteLine("Podaj liczbę:");
//    return Convert.ToDouble(Console.ReadLine());

//}

// ----------------------------------------------------------------------------------------------------------------------------------
//ZADANIE3


//zadanie3();

//Menu();
//static void Menu()
//{
//    double[] realNumbers = new double[10];

//    Console.WriteLine("Wpisz 10 liczb rzeczywistych:");
//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write($"Liczba {i + 1}: ");
//        realNumbers[i] = Convert.ToDouble(Console.ReadLine());
//    }

//for (int i = 0; i < realNumbers.Length; i++)
//{
//    Console.WriteLine(realNumbers[i]);

//}


//    do
//    {
//        Console.WriteLine("-------------------------------MENU-------------------------\n1. Wyświetlanie tablicy od pierwszego do ostatniego indeksu\n2. Wyświetlanie tablicy od pierwszego do ostatniego indeksu\n3. Wyświetlanie elementów o nieparzystych indeksach" + "\n4. Wyświetlanie elementów o parzystych indeksach\n5. Wyjście");

//        Console.WriteLine("Wybierz opcję: ");
//        int choice = Convert.ToInt32(Console.ReadLine());

//        if (choice == 1)
//        {
//            Console.WriteLine("Wyświetlanie tablicy od pierwszego do ostatniego indeksu: ");
//            for (int i = 0; i < realNumbers.Length; i++)
//            {
//                Console.WriteLine($"Index {i}: {realNumbers[i]}");
//            }
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine("Wyświetlanie tablicy od ostatniego do pierwszego indeksu: ");
//            for (int i = realNumbers.Length - 1; i >= 0; i--)
//            {
//                Console.WriteLine($"Index {i}: {realNumbers[i]}");
//            }
//        }
//        else if (choice == 3)
//        {
//            Console.WriteLine("Wyświetlanie elementów o nieparzystych indeksach: ");
//            for (int i = 1; i < realNumbers.Length; i += 2)
//            {
//                Console.WriteLine($"Index {i}: {realNumbers[i]}");
//            }

//        }
//        else if (choice == 4)
//        {
//            Console.WriteLine("Wyświetlanie elementów o parzystych indeksach: ");
//            for (int i = 0; i < realNumbers.Length; i += 2)
//            {
//                Console.WriteLine($"Index {i}: {realNumbers[i]}");
//            }
//        }
//        else if (choice == 5)
//        {
//            Console.WriteLine("Koniec programu.");
//            System.Environment.Exit(1);
//        }
//        else
//        {
//            Console.WriteLine("Źle wybrana opcja, wybierz jeszcze raz");
//        }
//    }while (true);
//}


// ----------------------------------------------------------------------------------------------------------------------------------
//ZADANIE4

//zadanie4();
//static void zadanie4()
//{
//    int[] Numbers = new int[10];



//    Console.WriteLine("Wpisz 10 liczb rzeczywistych:");
//        for (int i = 0; i < 10; i++)
//       {
//           Console.Write($"Liczba {i + 1}: ");
//           Numbers[i] = Convert.ToInt32(Console.ReadLine());
//       }


//    for (int i = 0; i < Numbers.Length; i++)
//    {
//        Console.WriteLine(Numbers[i]);

//    }

//    do
//    {
//        Console.WriteLine("-------------------------------MENU-------------------------\n1. Obliczanie sumy elementów tablicy\n2. Obliczanie iloczynu elementów tablicy\n3. Wyznaczenie średniej wartości" + "\n4. Wyznaczenie minimalnej wartości\n5. Wyznaczenie maksymalnej wartości\n6. Wyjście");

//        Console.WriteLine("Wybierz opcję: ");
//        int choice = Convert.ToInt32(Console.ReadLine());
//        int result = 0;
//        if(choice == 1)
//        {
//            Console.WriteLine("Obliczanie sumy elementów tablicy: ");
//            for (int i = 0; i < Numbers.Length; i++)
//            {
//                result += Numbers[i];
//            }
//            Console.WriteLine($"Suma elementów tablicy wynosi: {result}");
//        }

//        else if(choice == 2)
//        {   
//            Console.WriteLine("Obliczanie iloczynu elementów tablicy: ");
//            long Multiplication = 1;
//            foreach(int eleme in Numbers)
//            {
//                Multiplication *= eleme;
//            }
//            Console.WriteLine($"Iloczyn elementów tablicy wynosi: {Multiplication}");

//        }else if(choice == 3)
//        {
//            Console.WriteLine("Wyznaczenie średniej wartości: ");
//            foreach(int elem in Numbers)
//            {
//                result += elem;
//            }
//            Console.WriteLine($"Średnia wartość tablicy wynosi: {result/Numbers.Length}");



//        }else if(choice == 4)
//        {
//            Console.WriteLine("Wyznaczenie minimalnej wartości: ");
//            Array.Sort(Numbers);
//            int Minimum = Numbers[0];
//            Console.WriteLine($"Minimalna wartość z tablicy wynosi: {Minimum}");

//        }else if (choice == 5)
//        {
//            Console.WriteLine("Wyznaczenie maksymalnej wartości: ");
//            Array.Sort(Numbers);
//            int Maximum = Numbers[Numbers.Length - 1];
//            Console.WriteLine($"Maksymalna wartość z tablicy wynosi: {Maximum}");

//        }
//        else if (choice == 6)
//        {
//            Console.WriteLine("Koniec programu.");
//            System.Environment.Exit(1);
//        }
//        else
//        {
//            Console.WriteLine("Źle wybrana opcja, wybierz jeszcze raz");
//        }

//    } while (true);
//}

// ----------------------------------------------------------------------------------------------------------------------------------
//ZADANIE5

//zadanie5();

//static void zadanie5()
//{

//    Console.WriteLine("Liczby od 20 do 0  z wyłączeniem liczb {2, 6, 9, 15, 19}: ");
//    for(int i = 20;  i >= 0; i--)
//    {
//        if(i == 2 || i == 6 || i ==9 || i ==15 || i == 19)
//        {
//            continue;
//        }
//        Console.WriteLine(i);

//    }
//}

