using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWCurrencyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold = 0, silver = 0, copper = 0, TotalGold = 0, TotalSilver = 0, TotalCopper = 0;
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("WOW SUPER CURRENCY CALCULATOR (only adds and subtracts, tho)\n\n");
                Console.WriteLine("Current ammount stored: " + TotalGold + "g " + TotalSilver + "s " + TotalCopper + "c\n");
                Console.WriteLine("What do you want to do?\n  1) Add\n  2)Substract\n  3) Exit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Add - How much?:");
                    Console.Write("Gold: ");
                    gold = int.Parse(Console.ReadLine());
                    Console.Write("Silver: ");
                    silver = int.Parse(Console.ReadLine());
                    Console.Write("Copper: ");
                    copper = int.Parse(Console.ReadLine());

                    TotalCopper += copper;

                    if (TotalCopper >= 100)
                    {
                        silver++;
                        TotalCopper -= 100;
                    }

                    TotalSilver += silver;

                    if (TotalSilver >= 100)
                    {
                        gold++;
                        TotalSilver -= 100;
                    }

                    TotalGold += gold;
                }

                if (input == "2")
                {
                    Console.WriteLine("Substract - How much?:");
                    Console.Write("Gold: ");
                    gold = int.Parse(Console.ReadLine());
                    Console.Write("Silver: ");
                    silver = int.Parse(Console.ReadLine());
                    Console.Write("Copper: ");
                    copper = int.Parse(Console.ReadLine());

                    TotalGold -= gold;

                    if (TotalGold < 0)
                        TotalGold = 0;

                    TotalSilver -= silver;

                    if (TotalSilver < 0)
                    {
                        TotalGold--;
                        TotalSilver += 100;
                    }

                    TotalCopper -= copper;

                    if (TotalCopper < 0)
                    {
                        TotalSilver--;
                        TotalCopper += 100;
                    }

                    if (TotalGold <= 0 && TotalSilver <= 0 && TotalCopper <= 0)
                        TotalGold = TotalSilver = TotalCopper = 0;

                }

            } while (input != "3");

            Console.WriteLine("bye bye!!");
            Console.ReadKey();
        }
    }
}
