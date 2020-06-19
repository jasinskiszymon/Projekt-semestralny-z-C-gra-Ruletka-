using System;
using ClassLibrary;
namespace rouletteApp
{
    class Program
    {
        
        static int losowa()
        {
            Random ran = new Random();
            int roll = ran.Next(0, 100);
            return roll;
        }
        static string losowykolor() {
            string[] color = { "Red", "Black" };
            var r = new Random();
            string ranColor = color[r.Next(color.Length)];
            return ranColor;
        } 

        static void Main(string[] args)
        {
          


            string guess;
            int attempts = 0;
            int bet;
            int money = 100;  
        menu:
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
                    Console.WriteLine("hej, podaj jaki kolor chcesz obstawic, czerwony czy czarny :D ?");
                    guess = Console.ReadLine();
                    guess.ToLower();
                    //guess verifier
                    //to mozna w innym podprogramie a potem wywołac.
                    bool check = guess == "1" || guess == "2" || guess == "RED" || guess == "BLACK";
                    if (check == false)
                    {
                        Console.WriteLine("podales nieprawidlowa wartosc");
                        Console.ReadKey();
                    }
                    else
                    {
                        losowykolor();
                        if ((guess == "RED") && (losowykolor() == "Red") || (guess == "BLACK") && (losowykolor() == "Black"))
                        {
                            money += bet * 2;
                            attempts += 1;
                            Console.WriteLine("Ruletka wylosowała kolor: " + losowykolor());
                            Console.WriteLine("Wygrałes +$" + bet * 2 + "! i aktualnie posiadasz :" + money + "$");
                            Console.WriteLine("<kliknij enter by kontynułowac>");
                            Console.ReadKey();
                        }
                        else
                        {
                            money -= bet;
                            Console.WriteLine("Ruletka wylosowała kolor: " + losowykolor());
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
                    Console.WriteLine("liczba nieparzysta- wpisz 1");
                    Console.WriteLine("liczba parzysta- wpisz 2");
                    guess = Console.ReadLine();
                    guess.ToLower();
                    bool even = losowa() % 2 == 0;
                    if ((((guess == "1") && (even == true))) || (((guess == "2") && (even == false))))
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("The roulette rolled: " + losowa());
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");
                        Console.ReadKey();
                    }
                    else
                    {
                        money -= bet;
                        Console.WriteLine("The roulette rolled: " + losowa());
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
                    if ((guess == "1") && ((losowa() > 0) && (losowa() < 51)))
                    {
                        money += bet * 2;
                        attempts += 1;
                        Console.WriteLine("The roulette rolled: " + losowa());
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");

                        Console.ReadKey();
                    }
                    else if ((guess == "2") && ((losowa() > 51) && (losowa() < 100)))
                    {
                        Console.WriteLine("The roulette rolled: " + losowa());
                        Console.WriteLine("You won! +$" + bet * 2 + "!");
                        Console.WriteLine("<Press enter to continue>");
                        money += bet * 2;
                        attempts += 1;
                        Console.ReadKey();


                    }

                    else
                    {
                        money -= bet;
                        Console.WriteLine("The roulette rolled: " + losowa());
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
