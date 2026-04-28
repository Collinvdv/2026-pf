namespace theory;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // List<double> gradebook = new List<double>();
        // gradebook.Add(16); // .Add() when you want to add a new item to it
        // gradebook.Add(3); // .Add() when you want to add a new item to it
        // gradebook.Add(20); // .Add() when you want to add a new item to it
        // gradebook.Add(5); // .Add() when you want to add a new item to it
        // gradebook.Add(20); // .Add() when you want to add a new item to it
   
        // gradebook[0] = 17; // to modify the value at a specific index
        // Console.WriteLine(gradebook.Count); // use .Count to know how many items
        
        // Loop over the gradebook and show the grades 
        // O: 1 test has a a score of 16
        // O: 2 test has a a score of 3
        // O: 3 test has a a score of 20
        // O: 4 test has a a score of 5
        // O: 5 test has a a score of 7

        // gradebook.RemoveAll(g => g == 20);

        // for(int i = 0; i < gradebook.Count; i++)
        // {
        //     Console.WriteLine($"{i + 1} test has a a score of {gradebook[i]}");
        // }


        // My battleplan
        // Step 1: create a list of integers numbers 
        List<int> numbers = new List<int>();

        // Step 2: use a while statement when they type stop, exit the while statement. When it is a number .Add() it to the list
        while (true)
        {
            // ask some input
            string input = Console.ReadLine();

            // if the input stop, we want to exit the while statement
            if (input.ToLower() == "stop") break;

            // We didn't execute break, so we will add it to the numbers 
            int number; 
            bool isNumber = int.TryParse(input, out number);

            if (isNumber) {
                numbers.Add(number);
            } else
            {
                Console.WriteLine("Skip not a number");
            }
        }
        
        // Step 3: loop over the list and .Remove(when it is lower then 0), also count them (?)
        List<int> negNumbers = new List<int>();
        List<int> posNumbers = new List<int>();
        for(int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0) {
                negNumbers.Add(numbers[i]);
            } else
            {
                posNumbers.Add(numbers[i]);
            }
        }

        // Step 4: display the end result
        // Output example:
        // Removed: 2
        // Remaining: 12 30 8
        Console.WriteLine($"Removed: {negNumbers.Count}");
        Console.WriteLine($"Remainig: {String.Join(' ', posNumbers)}");
    }
}


// Recap on array's 
        // Objective: store grades of a student in an array 
        // Collin, 16, 3, 20, 5, 7

        // double[] grades = { 16, 3, 20, 5, 7}; // hardcoded version
        // double[] grades = new double[5];
        // grades[0] = 16;
        // grades[1] = 3;
        // grades[2] = 20;
        // grades[3] = 5;
        // grades[4] = 7;

        // New test, collin has 8/20
        // double[] grades2 = new double[6];

        // for(int i = 0; i < grades.Length; i++)
        // {
        //     grades2[i] = grades[i];
        // }

        // grades2[5] = 8;







        // Assignment — Build & Clean a List
        //
        // Goal:
        // Keep reading numbers from the user until they type "stop".
        // After that:
        // - Remove all negative numbers
        // - Show how many numbers were removed
        // - Print the remaining numbers
        //
        // Input example:
        // 12
        // -5
        // 30
        // -150
        // 8
        // stop
        //
        // Output example:
        // Removed: 2
        // Remaining: 12 30 8

        
