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

            
            int attempts = 0;
            int bet;
            int money = 100;
            List<string> licznik_wygranych = new List<string>();
        menu:
            
            int x = logika.losowa();
            

            Console.WriteLine("Roulette by github.com/user/LunaMoon\n");
            Console.WriteLine("Hej, witaj w prostej aplikacji ktora pozwala zasymulowac ruletke.");
            Console.WriteLine("Posiadasz akrualnie: $" + money + "      Liczba gier: " + attempts + "\n");
            Console.WriteLine("                  **MENU**              ");
            Console.WriteLine("Wybierz w jaka gre chcesz zagrac");
            Console.WriteLine("1. Red-black");
            Console.WriteLine("2. Pazysta-nieparzysta ");
            Console.WriteLine("3. Przedzaiły");
            Console.WriteLine("4. Historia gier");

            int liczba;
            liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {

                case 1:
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
                    Console.WriteLine("Czarny - wpisz |2|");
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
                            licznik_wygranych.Add("Gra Wygrana " + bet * 2);
                            Console.WriteLine("Ruletka wylosowała kolor: " + kolor);
                            Console.WriteLine("Wygrałes +$" + bet * 2 + "! i aktualnie posiadasz :" + money + "$");
                            Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                            licznik_wygranych.Add("Gra Wygrana " + bet * 2);
                            Console.ReadKey();
                        }
                        else
                        {
                            money -= bet;
                            Console.WriteLine("Ruletka wylosowała kolor: " + kolor);
                            Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "!");
                            Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                            attempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("Skoczyła sie cala kasiorka :/.");
                                Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                                Console.ReadKey();
                            }
                        }
                    }
                    Console.Clear();
                    goto menu;


                case 2:
                    Console.WriteLine("ile kasiorki chcesz postawic?");
                    bet = Convert.ToInt32(Console.ReadLine());
                    while (bet > money)
                    {
                        Console.WriteLine("You dont have enough money!");
                        Console.WriteLine("Wciśnij <spacje> by spróbować ponownie.");
                        Console.ReadKey();
                        Console.WriteLine("Podaj kwotę którą chcesz obstawić");
                        bet = Convert.ToInt32(Console.ReadLine());
                    }

                    //guess verifier
                    //to mozna w innym podprogramie a potem wywołac.
                    Console.WriteLine("liczba parzysta- wpisz 1");
                    Console.WriteLine("liczba nieparzysta- wpisz 2");
                    int guesss = int.Parse(Console.ReadLine());

                    bool even = x % 2 == 0;
                    if ((((guesss == 1) && (even == true))) || (((guesss == 2) && (even == false))))
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("The roulette rolled: " + x);
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                        licznik_wygranych.Add("Gra Wygrana " + bet * 2);
                        Console.ReadKey();
                       
                    }
                    else
                    {
                        money -= bet;
                        Console.WriteLine("The roulette rolled: " + x);
                        Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "!");
                        Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                        attempts += 1;
                        Console.ReadKey();
                        if (money == 0)
                        {
                            Console.WriteLine("Skoczyła sie cala kasiorka :/.");
                            Console.WriteLine("Wciśnij <spacje> by kontynułować.");
                            Console.ReadKey();
                        }
                    }

                    Console.Clear();
                    goto menu;
                case 3:
                    Console.WriteLine("ile kasiorki chcesz postawic?");
                    bet = Convert.ToInt32(Console.ReadLine());
                    while (bet > money)
                    {
                        Console.WriteLine("You dont have enough money!");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadKey();
                        Console.WriteLine("Enter an amount to bet");
                        bet = Convert.ToInt32(Console.ReadLine());
                    }

                    //guess verifier
                    //to mozna w innym podprogramie a potem wywołac.

                    Console.WriteLine("przedział 1-50- wpisz 1");
                    Console.WriteLine("przedział 51-100- wpisz 2");
                    int guesse = int.Parse(Console.ReadLine());

                    if ((guesse == 1) && (x > 0) && (x < 51)) 
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("The roulette rolled: " + x);
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");
                        licznik_wygranych.Add("Gra Wygrana " + bet * 2);
                        Console.ReadKey();
                    }

                          

                    else if ((guesse == 2) && ((x > 51) && (x < 100)))
                    {
                        Console.WriteLine("The roulette rolled: " + x);
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");
                        money += bet * 2;
                        attempts += 1;
                        licznik_wygranych.Add("Gra Wygrana " +bet * 2);
                        Console.ReadKey();
                        

                    }

                    else
                    {
                        money -= bet;
                        Console.WriteLine("The roulette rolled: " + x);
                        Console.WriteLine("You lost! -$" + bet + "!");
                        Console.WriteLine("<Press enter to continue>");
                        attempts += 1;
                        Console.ReadKey();
                        if (money == 0)
                        {
                            Console.WriteLine("You are out of money.");
                            Console.WriteLine("<Press enter to continue>");
                            
                        }
                    }
                    Console.Clear();
                    goto menu;


                  case 4:
                    
                    
                    for (int i = 0; i < licznik_wygranych.Count; i++)
                    {
                        Console.WriteLine($"{licznik_wygranych[i]}");
                    }
                        
                    

                    Console.ReadKey();
                    goto menu;
            }
        }
    }
}
