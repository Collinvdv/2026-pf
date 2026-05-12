namespace test;

// input
// 12 + 34 * 56 = 204
// output
// The expression is missing digits: 789

class Program
{
    static void Main(string[] args)
    {
        string input = "12 + 34 * 56 = 204";

        // from input I only want to have the numvers 
        string inputOnlyNumers = "";

        foreach (char character in input)
        {
            if (Char.IsDigit(character))
            {
                inputOnlyNumers += character;
            }
        }

        string missingDigits = "";
        for (int i =0; i<=9;i++)
        {
            if (!inputOnlyNumers.Contains(Convert.ToString(i)))
            {
                missingDigits += Convert.ToString(i);
            }
        }

        Console.WriteLine(missingDigits);


        // option 1: best one
        // string digits = "0123456789";
        // string missingDigits = "";

        // foreach(char digit in digits)
        // {
        //     if (!input.Contains(digit))
        //     {
        //         missingDigits += digit;
        //     }
        // }

        // if (missingDigits.Length == 0)
        // {
        //     Console.WriteLine("No missing digits");
        // } else
        // {
        //     Console.WriteLine($"The expression is missing digits: {missingDigits}");
        // }
    }
}
