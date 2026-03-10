using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace theory;

class Program
{
    static void Main(string[] args)
    {
        // For loop
        // When? you now the start and end
        // how? start;expression;step
        // 10... 9... 8... 7.. 1

        // All the even numbers between 1 and 100 ; 
        // O: Start number
        // I: 4
        // O: End number
        // I: 65
        // int start = Convert.ToInt16(Console.ReadLine());
        // int end = Convert.ToInt16(Console.ReadLine());

        // // Check if start is smaller than end
        // if (start < end)
        // {
        //     // I willl count from start to end and do +1
        //     for (int i = start; i <= end; i++)
        //     {
        //         // I will check if the remainder is 0, 
        //         // then it is even
        //         if (i % 2 == 0)
        //         {
        //             Console.WriteLine($"{i}");
        //         }
        //     }
        // }

        // O: 0.1
        // O: 0.2
        // O: 0.3
        // O: 0.4
        // O: 0.5
        // O: 0.6
        // O: 0.7
        // O: 0.8
        // O: 0.9
        // O: 1

        // decimal result = 0m;
        // for (int i = 1; i <= 10; i++)
        // {
        //     result +=0.1m;
        //     Console.WriteLine($"{i} {result}");
        // }

        // Exercise 3
        // I: An integer n
        // O: Print the multiplication table of n from 1 to 10.

        // Example output for n = 3:

        // 3 x 1 = 3
        // 3 x 2 = 6
        // ...
        // 3 x 10 = 30
        // int userNumber = Convert.ToInt16(Console.ReadLine());

        // for(int i = 1; i <= 10; i++)
        // {
        //     int result = i * userNumber;
        //     Console.WriteLine($"{userNumber} x {i} = {result}");
        // }

        // Exercise 6

        // I: An integer n
        // O: Print a triangle of stars with height n.

        // Example for n = 4:

        // ****
        // ***
        // **
        // *

        // 1: *
        // 2: **
        // 3: ***
        // 4: ****

        // int n = 4;

        // // amount of rows
        // for (int row = 1; row <= n; row++)
        // {
        //     // calculate the amount of stars 
        //     // I see the stars are the same as the row number
        //     for (int col = 1; col <= row; col++)
        //     {
        //         Console.Write("*");
        //     }

        //     Console.WriteLine();
        // }

        // int number = 1;

        // while (number <= 10)
        // {
        //     Console.WriteLine(number);

        //     number++;
        // }

        // secret word is knockknock
        // O: Give me the secret word 
        // I: apple
        // O: no, give me the secret word
        // I: banana
        // O: no, give me the secret word
        // I: knockknock
        // O: Enter

        // string secretPassword = Console.ReadLine();

        // while (secretPassword != "knockknock")
        // {
        //     Console.WriteLine("no, give me the secret word");

        //     secretPassword = Console.ReadLine();
        // }

        // Console.WriteLine("Enter");

        // I: 5
        // O: total(5) is not bigger than 100 continue
        // I: 90
        // O: total(95) is not bigger than 100 continue
        // I: 10
        // O: Total is now more than 100

        // double number = Convert.ToDouble(Console.ReadLine());
        // double total = number;

        // do
        // {
        //     Console.WriteLine($"total({total}) is not bigger than 100 continue");
        //     number = Convert.ToDouble(Console.ReadLine());

        //     total += number;
        // } while (total < 100);
 

        // Console.WriteLine("Total is now more than 100");
        int number = Convert.ToInt16(Console.ReadLine()); 
        string numberStr = number.ToString();

        if (number >= 0)
        {            
            for (int i = (numberStr.Length-1); i >= 0; i--)
            {
            Console.Write(numberStr[i]);
            }
        } else
        {
            Console.WriteLine("Negative numver");
        }


    }
}
