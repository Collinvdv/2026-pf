namespace recap;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List<string> children = new List<string>();

        // // How to populate: 
        // Console.WriteLine("How many children do you have?");
        // int amountOfChildren = Convert.ToInt16(Console.ReadLine());

        // for(int i = 1; i <= amountOfChildren; i++)
        // {
        //     Console.WriteLine($"The name of kid {i}");
        //     children.Add(Console.ReadLine());
        // }

        // string[] newKiddos = {"Mohammed", "Fatima"};
        // children.AddRange(newKiddos);

        // // print
        // foreach(string kiddo in children)
        // {
        //     Console.WriteLine(kiddo);
        // }

        // // print
        // Console.WriteLine($"The amount of children is: {children.Count}");

        Dictionary<string, int> poopCalculator = new Dictionary<string, int>();

        poopCalculator.Add("renske", 20);
        poopCalculator.Add("boris", 10);

        poopCalculator["renske"] = 21;

        // looping over the keys 
        foreach(string name in poopCalculator.Keys)
        {
            Console.WriteLine($"{name} has pooped {poopCalculator[name]}");
        }

        int totalPoops = 0 ;
        foreach(int amountOfPoop in poopCalculator.Values)
        {
            totalPoops += amountOfPoop;
        }
        Console.WriteLine($"OMG, they pooped in total {totalPoops}");

        foreach(KeyValuePair<string,int> person in poopCalculator)
        {
            Console.WriteLine($"{person.Key} has pooped {person.Value}");
        }


    }
}
