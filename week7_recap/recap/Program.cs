using System.Diagnostics;

namespace recap;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // string[] children = new string[2];

        // children[0] = "Renske";
        // children[1] = "Boris";

        // Console.WriteLine(children.Length);
        // Console.WriteLine(children.GetType());
        // for (int i = 0; i < children.Length; i++)
        // {
        //     Console.WriteLine($"Child {i + 1} name : {children[i]}");
        // }

        // foreach(string name in children)
        // {
        //     Console.WriteLine(name);
        // }

        // string phrase = "Once I make my move, the Queen will take me. Then you're free to check the king.";

        // // STEP 1: I want to have a array with seperate words from the phrase
        // string[] words = phrase.Split(' ');

        // // STEP 2.1: Loop over every word
        // // foreach (string word in words)
        // for(int wordIndex = 0; wordIndex < words.Length; wordIndex++)
        // {
        //     string word = words[wordIndex];

        //     // STEP 2.2: Reverse the word
        //     string reversedWord = "";

        //     for (int i = word.Length - 1; i >= 0; i--)
        //     {
        //         reversedWord += word[i];
        //     }

        //     // Step 2.2: Save it back to words
        //     words[wordIndex] = reversedWord;
        // }

        // // Step 3: print out the words by using .Join
        // Console.WriteLine(String.Join(' ', words));


        // // Step 1: read in a string that contains numbers
        // string[] input = Console.ReadLine().Split(' ');

        // // Step 2: converting to an array of numbers 
        // int[] numbers = new int[input.Length];

        // for(int i = 0; i < input.Length; i++)
        // {
        //     numbers[i] = Convert.ToInt32(input[i]);
        // }

        // // Step 3: looping over all of them and checking if they are even, if they are do + 1
        // int counter = 0;

        // foreach(int number in numbers)
        // {
        //     if (number % 2 == 0)
        //     {
        //         counter ++;
        //     }
        // }

        // // Step 4: output
        // Console.WriteLine(counter);



        // kaplekar number 
        // 45 is a Kaprekar number because 45^2 = 2025, and 20 + 25 = 45.

        // step 1: is reading a number
        int number = Convert.ToInt16("297");

        // step 2: calculating powerTo 
        double powerTo = Math.Pow(number, 2); //2025

        // step 3: split them up (will use a string for this)
        string powerToStr = Convert.ToString(powerTo); //"2025"
        int middle = powerToStr.Length / 2;
        string part1 = "";
        string part2 = "";

        for(int i = 0; i < powerToStr.Length; i++)
        {
            if (i < middle)
            {
                part1 += powerToStr[i];
            } else
            {
                part2 += powerToStr[i];
            }
        }


        Console.WriteLine(part1);
        Console.WriteLine(part2);

        // step 4: add them up and compare them 
        int check = Convert.ToInt16(part1) + Convert.ToInt16(part2);

        if (check == number)
        {
            Console.WriteLine("kapelar");
        } else
        {
            Console.WriteLine("not a kapelar");
        }
    }
}





// 4. Count Even Numbers

// Goal: Count how many even numbers are in the array

// Input/Output
// I: array
// O: count

// Test Scenarios
// I:
// 1 2 3 4 5 6
// O:
// 3

// I:
// 1 3 5
// O:
// 0








// 1. Best-Selling Day of One Week

// Goal: Find the day with the highest sales in one week.

// Context:
// A store keeps track of sales for 7 days.
// The student receives sales numbers in an array in this order:
// Monday Tuesday Wednesday Thursday Friday Saturday Sunday

// Task:
// Print the name of the day with the highest sales.

// Input/Output
// I: 7 sales numbers
// O: best-selling day

// Test Scenarios
// I:
// 120 95 140 180 210 300 250

// O:
// Saturday

// I:
// 500 400 450 300 200 100 50

// O:
// Monday



// BLACK JACK! 




// PREV EXAM 
// Read in a number and calculate whether or not the given number is a Kaprekar number. Kaprekar numbers are numbers whose square, when divided into two parts and added, gives back the original number. If the squared result contains an odd number of digits, the 2nd number always contains more digits than the first one. If your number is a Kaprekar number, than you output should be "Kaprekar number", otherwise "NO kaprekar number".

 

// INPUT
// string —> question name
// int —> number


// OUTPUT
// string --> Kaprekar number or not

 

// EXAMPLES
// input
// 45

// output
// Kaprekar number

// explanation
// 45 is a Kaprekar number because 45^2 = 2025, and 20 + 25 = 45.

 

// input
// B1
// 4186

// output
// NO kaprekar number

// explanation
// 4186 is not a Kaprekar number because 4186^2 = 17.522.596, and 1752 + 2596 = 4348.