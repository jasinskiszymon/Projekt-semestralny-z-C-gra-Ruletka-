using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;

namespace rouletteApp
{
    class Program
    {
        static int menu()
        {
            Console.WriteLine("podaj numer:");
            int numer = int.Parse(Console.ReadLine());
            return numer;

        }
        static void Main(string[] args)
        {

            

            string[] color = { "Red", "Black" };
            string guess;
            int attempts = 0;
            int bet;
            int money = 100;

        menu:
            Random ran = new Random();
            int roll = ran.Next(0, 100);
            var r = new Random();
            Console.WriteLine("Roulette by github.com/user/LunaMoon\n");
            Console.WriteLine("Hej, witaj w prostej aplikacji ktora pozwala zasymulowac ruletke.");
            Console.WriteLine("Posiadasz akrualnie: $" + money + "      Liczba gier: " + attempts + "\n");
            Console.WriteLine("                  **MENU**              ");
            Console.WriteLine("Wybierz w jaka gre chcesz zagrac");
            Console.WriteLine("1. Red-black");
            Console.WriteLine("2. Pazysta-nieparzysta ");
            Console.WriteLine("3. Przedzaiły");

            int liczba;
            liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 1:
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
                    Random randomowy = new Random();
                    Console.WriteLine("hej, podaj jaki kolor chcesz obstawic, czerwony czy czarny :D ?");
                    guess = Console.ReadLine();
                    guess.ToLower();
                    //guess verifier
                    //to mozna w innym podprogramie a potem wywołac.
                    bool check = guess == "1" || guess == "2" || guess == "przedzial-0-50" || guess == "przedzial-50-100" || guess == "RED" || guess == "BLACK";



                    if (check == false)
                    {
                        Console.WriteLine("podales nieprawidlowa wartosc");
                        Console.ReadKey();
                    }
                    else
                    {
                        string ranColor = color[r.Next(color.Length)];
                        if ((guess == "RED") && (ranColor == "Red") || (guess == "BLACK") && (ranColor == "Black"))
                        {
                            money += bet * 2;
                            attempts += 1;
                            Console.WriteLine("Ruletka wylosowała kolor: " + ranColor);
                            Console.WriteLine("Wygrałes +$" + bet * 2 + "! i aktualnie posiadasz :" + money + "$");
                            Console.WriteLine("<kliknij enter by kontynułowac>");
                            Console.ReadKey();
                        }
                        else
                        {
                            money -= bet;
                            Console.WriteLine("Ruletka wylosowała kolor: " + ranColor);
                            Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "!");
                            Console.WriteLine("<Press enter to continue>");
                            attempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("Skoczyła sie cala kasiorka :/.");
                                Console.WriteLine("<Press enter to continue>");
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
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadKey();
                        Console.WriteLine("Enter an amount to bet");
                        bet = Convert.ToInt32(Console.ReadLine());
                    }




                    //guess verifier
                    //to mozna w innym podprogramie a potem wywołac.





                    Console.WriteLine("liczba pazysta- wpisz 1");
                    Console.WriteLine("liczba niepazysta- wpisz 2");
                    guess = Console.ReadLine();
                    guess.ToLower();
                    bool even = roll % 2 == 0;
                    if ((((guess == "1") && (even == true))) || (((guess == "2") && (even == false))))
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("The roulette rolled: " + roll);
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");
                        Console.ReadKey();
                    }
                    else
                    {
                        money -= bet;
                        Console.WriteLine("The roulette rolled: " + roll);
                        Console.WriteLine("Niestety przegrałes i tracisz:! -$" + bet + "!");
                        Console.WriteLine("<Press enter to continue>");
                        attempts += 1;
                        Console.ReadKey();
                        if (money == 0)
                        {
                            Console.WriteLine("Skoczyła sie cala kasiorka :/.");
                            Console.WriteLine("<Press enter to continue>");
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
                    guess = Console.ReadLine();
                    guess.ToLower();
                    if ((guess == "1") && ((roll > 0) && (roll < 19)))
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("The roulette rolled: " + roll);
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");

                        Console.ReadKey();
                    }
                    else if ((guess == "2") && ((roll > 18) && (roll < 37)))
                    {
                        Console.WriteLine("The roulette rolled: " + roll);
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");
                        money += bet * 2;
                        attempts += 1;
                        Console.ReadKey();


                    }

                    else
                    {
                        money -= bet;
                        Console.WriteLine("The roulette rolled: " + roll);
                        Console.WriteLine("You lost! -$" + bet + "!");
                        Console.WriteLine("<Press enter to continue>");
                        attempts += 1;
                        Console.ReadKey();
                        if (money == 0)
                        {
                            Console.WriteLine("You are out of money.");
                            Console.WriteLine("<Press enter to continue>");
                            Console.ReadKey();
                        }
                    }
                    Console.Clear();
                    goto menu;

            }
        }
    }
}


