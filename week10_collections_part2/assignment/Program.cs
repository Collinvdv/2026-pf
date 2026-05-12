
//
// POOPCALCULATOR 
// O: [LIST] [POOP] [STOP] [WINNER]
//
namespace assignment;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionairy 
        Dictionary<string, int> poopCalculator = new Dictionary<string, int>();

        while(true)
        {
            Console.WriteLine("Type a cmd [stop] [list] [winner] [poop]");
            string cmd = Console.ReadLine().ToLower().Trim();

            switch(cmd)
            {
                case "stop":
                    break;
                case "delete":
                    Console.WriteLine("-- which baby you want to delete?");
                    string babyDeleteName = Console.ReadLine().ToLower();

                    poopCalculator.Remove(babyDeleteName);
                    Console.WriteLine($"-- {babyDeleteName} has been removed from the list");
                    break;
                case "list":
                    Console.WriteLine("-- we list the babies and their poop");
                    foreach(KeyValuePair<string, int> babyInformation in poopCalculator)
                    {
                        Console.WriteLine($"{babyInformation.Key} has pooped {babyInformation.Value} times");
                    }
                    break;
                case "winner":
                    // What is the maximum poop somebody has in my list? 

                    Console.WriteLine("-- who pooped the most");
                    int maxAmountOfPoops = poopCalculator.Values.Max();

                    for(int i = 0; i < poopCalculator.Count(); i++)
                    {
                        if (poopCalculator.ElementAt(i).Value == maxAmountOfPoops)
                        {
                            Console.WriteLine($"Omg, {poopCalculator.ElementAt(i).Key} has pooped {maxAmountOfPoops}");
                        }
                    }
                    break;
                case "poop":
                    Console.WriteLine("-- damn somebody pooped");
                    Console.WriteLine("-- Who pooped?");
                    string baby = Console.ReadLine().ToLower();

                    if (poopCalculator.ContainsKey(baby))
                    {
                        Console.WriteLine($"--Omg {baby} again, I will add one");
                        poopCalculator[baby]++;
                    } else
                    {
                        Console.WriteLine($"--The first poop of the day for {baby} ");
                        poopCalculator.Add(baby, 1);
                    }
                    break;
                default:
                    Console.WriteLine("--What the hell are you saying?");
                    break;
            }

            if (cmd == "stop") break;
        }
    }
}
