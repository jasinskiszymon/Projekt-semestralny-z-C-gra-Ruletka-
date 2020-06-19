using System;
using System.ComponentModel;
using System.Collections.Generic;
using ClassLibrary;
using System.Net.Http.Headers;
#pragma warning disable 0436
namespace rouletteApp
{
    class Program
    {
   
        static void Main(string[] args)
        {
            logika gra = new logika();
            
            int attempts = 0;
            int bet;
            int money = 100;
        menu:
            
            int x = logika.losowa();
            

            Console.WriteLine("Wykonał: Szymon Jasiński, index 12274. URL:github.com/jasinskiszymon \n");
            Console.WriteLine("Hej, witaj w prostej symulacji popularnej gry hazardowej jaka jest ruleta.");
            Console.WriteLine("Zasady są proste. Wybierasz z pola menu odpowiadająca ci gre i walczysz!");
            Console.WriteLine("Ile najwiecej pieniędzy udało ci sie zarobić? \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Posiadasz aktualnie: $" + money + "                   Liczba gier: " + attempts + "\n");
            Console.ResetColor();
            Console.WriteLine("                          ----> MENU <----\n");
            Console.WriteLine("Wybierz w jaką gre chcesz zagrać!\n");
            Console.WriteLine("1. |Wybór koloru, czerony-czarny");
            Console.WriteLine("2. |Parzysta-nieparzysta ");
            Console.WriteLine("3. |Przedzaiły liczbowe");
            Console.WriteLine("4. |Historia gier" + "\n");
            Console.WriteLine("Wybierz numer przypisany do gry:");

            int liczba;
            liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Ile pieniędzy chcesz postawić?");
                    bet = Convert.ToInt32(Console.ReadLine());
                    while (bet > money)
                    {
                        Console.WriteLine("Nie masz wystarczającej ilosci pieniędzy");
                        Console.WriteLine("Wciśnij <spacje> by spróbować ponownie.");
                        Console.ReadKey();
                        Console.WriteLine("Podaj kwotę którą chcesz obstawić");
                        bet = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Hej, jaki kolor chcesz postawic?");
                    Console.WriteLine("Czerwony - wpisz |1|");
                    Console.WriteLine("Czarny - wpisz   |2|");
                    int guess = int.Parse(Console.ReadLine());
                    

                    bool check = guess == 1 || guess == 2;
                    if (check == false)
                    {
                        Console.WriteLine("Podales nieprawidłową wartość");
                        Console.ReadKey();
                    }
                    else
                    {
                        string kolor = logika.losowykolor();
                        if ((guess == 1) && (kolor == "Czerwony") || (guess == 2) && (kolor == "Czarny"))
                        {
                            money += bet * 2;
                            attempts += 1;
                            Console.WriteLine("Ruletka wylosowała kolor: " + kolor);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Wygrałes +$" + bet * 2 + "  Aktualnie posiadasz :" + money + "$");
                            Console.ResetColor();
                            Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                            string rezultat = $"Gra Wygrana!, Wygrałeś: + {bet * 2}";
                            gra.DodajDoListy(rezultat);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            money -= bet;
                            Console.WriteLine("Ruletka wylosowała kolor: " + kolor);
                            Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "  Aktualnie posiadasz :" + money + "$"); ;
                            Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                            string rezultat = $"Gra Przegrana!, Przegrałes:  {money -= bet}";
                            gra.DodajDoListy(rezultat);
                            attempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("Ups, niestety skonczyły Ci sie wszystkie pieniądze, jestes bankrutem!.");
                                Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                                Console.ReadKey();
                            }
                        }
                    }
                    Console.Clear();
                    goto menu;


                case 2:
                    Console.Clear();
                    Console.WriteLine("Ile pieniędzy chcesz postawic");
                    bet = Convert.ToInt32(Console.ReadLine());
                    while (bet > money)
                    {
                        Console.WriteLine("Nie masz wystarczającej liczby pieniedzy");
                        Console.WriteLine("Wciśnij <spacje> by spróbować ponownie.");
                        Console.ReadKey();
                        Console.WriteLine("Podaj kwotę którą chcesz obstawić");
                        bet = Convert.ToInt32(Console.ReadLine());
                    }

                    
                    Console.WriteLine("Liczba parzysta - wpisz    |1|");
                    Console.WriteLine("Liczba nieparzysta - wpisz |2|");
                    int guesss = int.Parse(Console.ReadLine());

                    bool even = x % 2 == 0;
                    if ((((guesss == 1) && (even == true))) || (((guesss == 2) && (even == false))))
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("Ruletka wylosowała: " + x);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Wygrałes +$" + bet * 2 + "  Aktualnie posiadasz :" + money + "$");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                        string rezultat = $"Gra Wygrana!, Wygrałeś: + {bet * 2}";
                        gra.DodajDoListy(rezultat); ;
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        money -= bet;
                        Console.WriteLine("Ruletka wylosowała: " + x);
                        Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "  Aktualnie posiadasz :" + money + "$");
                        Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                        string rezultat = $"Gra Przegrana!, Przegrałes:  {money -= bet}";
                        gra.DodajDoListy(rezultat);
                        attempts += 1;
                        Console.ReadKey();
                        if (money == 0)
                        {
                            Console.WriteLine("Ups, niestety skonczyły Ci sie wszystkie pieniądze, jestes bankrutem!.");
                            Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                            Console.ReadKey();
                        }
                    }

                    Console.Clear();
                    goto menu;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ile pieniędzy chcesz obstawić?");
                    bet = Convert.ToInt32(Console.ReadLine());
                    while (bet > money)
                    {
                        Console.WriteLine("Nie masz wystarczającej liczby pieniędzy!");
                        Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                        Console.ReadKey();
                        Console.WriteLine("Podaj kwotę którą chcesz obstawić");
                        bet = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Przedział 1-50 - wpisz   |1|");
                    Console.WriteLine("Przedział 51-100 - wpisz |2|");
                    int guesse = int.Parse(Console.ReadLine());

                    if ((guesse == 1) && (x > 0) && (x < 51)) 
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("Ruletka wylosowała: " + x);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Wygrałes +$" + bet * 2 + "  Aktualnie posiadasz :" + money + "$");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij < spacje > by kontynułować.");
                        string rezultat = $"Gra Wygrana!, Wygrałeś: + {bet * 2}";
                        gra.DodajDoListy(rezultat);
                        Console.ReadKey();
                    }

                    else if ((guesse == 2) && ((x > 51) && (x < 100)))
                    {
                        Console.WriteLine("Ruletka wylosowała: " + x);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Wygrałes +$" + bet * 2 + "!  Aktualnie posiadasz :" + money + "$");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij < spacje > by kontynułować.");
                        money += bet * 2;
                        attempts += 1;
                        string rezultat = $"Gra Wygrana!, Wygrałeś: + {bet * 2}";
                        gra.DodajDoListy(rezultat);
                        Console.ReadKey();
                    }

                    else
                    {
                        money -= bet;
                        Console.WriteLine("Ruletka wylosowała: " + x);
                        Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "  Aktualnie posiadasz :" + money + "$");
                        Console.WriteLine("Wciśnij < spacje > by kontynułować.");
                        string rezultat = $"Gra Przegrana!, Przegrałes:  {money -= bet}";
                        gra.DodajDoListy(rezultat);
                        attempts += 1;
                        Console.ReadKey();
                        if (money == 0)
                        {
                            Console.WriteLine("Ups, niestety skonczyły Ci sie wszystkie pieniądze, jestes bankrutem!.");
                            Console.WriteLine("Wciśnij < spacje > by kontynułować.");
                            Console.ReadKey();
                        }
                    }
                    Console.Clear();
                    goto menu;


                  case 4:
                    Console.Clear();

                    gra.WyswietlListe();
                    Console.WriteLine("Wciśnij < spacje > by kontynułować.");
                    Console.ReadKey();
                    goto menu;
            }
        }
    }
}


