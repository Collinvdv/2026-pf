namespace theory;

class Program
{
    static void Main(string[] args)
    {
        // Da Club 
        // Bouncer: only let people when they are older or equal then 18
        double age = Convert.ToDouble(Console.ReadLine());

        // An expression only has
        // >, >=, <, <=, ==, !=
        // if (age < 18)
        // {
        //     // true lane
        //     Console.WriteLine("2 young");
        // } else
        // {
        //     if (age >= 40)
        //     {
        //         // True lane
        //         Console.WriteLine("2 old");
        //     } else
        //     {
        //         // False lane
        //         Console.WriteLine("enter the club");
        //     }
        // }

        if (age < 18) {
            Console.WriteLine("2 young");
        } else if (age >= 40) {
            Console.WriteLine("2 old");
        } else {
            Console.WriteLine("Enter the club");
        }


        // O: Give me a color
        // I: yellow 
        // O: Lemon

        // O: Give me a color
        // I: green 
        // O: Lime

        // O: Give me a color
        // I: red 
        // O: Strawberry
        Console.WriteLine("Give me a color");
        string color = Console.ReadLine();

        if (color == "yellow")
        {
            Console.WriteLine("Lemon");
        } else if (color == "green")
        {
            Console.WriteLine("Lime");
        } else {
            Console.WriteLine("Strawberry");
        }

        // && AND operator
        // || OR operator 

        // Club I only want people to be older then 18 and younger then 40
        int age2 = Convert.ToInt16(Console.ReadLine());

        if (age >= 18 || age <= 40)
        {
            Console.WriteLine("Enter the club");
        } else
        {
            Console.WriteLine("Go away");
        }
    }
}
