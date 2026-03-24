namespace recap;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // for 
        
        double sum = 0;

        for(int i = 1; i <= 10; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum / 10);

        // while
        string password = Console.ReadLine();

        while (password != "apple")
        {
            password = Console.ReadLine();
        }

        Console.WriteLine("YIHAAAAH YOU KNOW THE PASSWORD");
    }
}














//04 Roman to decimal

//Read in a roman numeral n and convert it to a decimal number.
//(M = 1000,
//D = 500, C = 100, L = 50, X = 10, V = 5 and I = 1)

//Example: n = DXII --> 500 + 10 + 1 + 1 = 512 
//(tip: work with the length of a word and ElementAt())

//Input/Output
//input:
//DXII
//output:
//512

//input:
//MDCCXXXIIII
//output:
//1734