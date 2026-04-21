namespace inclass_assignments;

class Program
{
    static void Main(string[] args)
    {
        // 1. Sum of Array
        // Goal: Calculate the sum of all elements in an array
        // Input/Output
        // I: array
        // O: sum
        // Test Scenarios
        // I:
        // 1 2 3 4 5
        // O:
        // 15

        // // Step 1: ask for a string of numbers, .Split(' ') them by space and convert them to the correct time
        // string[] numbersStr = Console.ReadLine().Split(' ');
        // double[] numbers = Array.ConvertAll(numbersStr, double.Parse);

        // // Step 2: loop over the array and summarize them
        // double sum = 0;

        // foreach(double number in numbers)
        // {
        //     sum += number;
        // }

        // Console.WriteLine(sum);

        // I:
        // 10 20 30
        // O:
        // 60






        // 2. Find Maximum
        // Goal: Find the largest number in an array

        // Input/Output
        // I: array
        // O: max

        // Test Scenarios
        // I:
        // 3 7 2 9 4
        // O:
        // 9

        // I:
        // -5 -2 -9
        // O:
        // -2

        // string[] numbersStr = "3 7 2 9 4".Split(' ');
        // double[] numbers = Array.ConvertAll(numbersStr, double.Parse);

        // Approach 1: using .Max();
        // double max = numbers.Max();
        // Console.WriteLine(max);

        // Approach 2: Array.Sort()
        // Array.Sort(numbers);
        // Console.WriteLine(numbers[numbers.Length - 1]);

        // Approach 3: using for and if statements 
        // double max = numbers[0];

        // foreach(double number in numbers)
        // {
        //     if (number > max)
        //     {
        //         max = number;
        //     }
        // }

        // Console.WriteLine(max);
        // int amountOfStudents = 3;
        // int amountOfGrades = 5;
        // int[,] gradebook = {
        //     {10, 16, 4, 6, 7},
        //     {1, 20, 20, 20, 20},
        //     {17, 7, 8, 20, 0}
        // };

        // Print2DArray(gradebook);

        // 7. Row Sum (2D Array)

        // Goal: Print sum of each row

        // Input/Output
        // I: matrix
        // O: row sums

        // Test Scenarios
        // I:
        // 1 2 3
        // 4 5 6

        // O:
        // 6 15
        // int [,] data =
        // {
        //     { 1, 2, 3},
        //     { 4, 5, 6}

        // };

        // for (int rowIndex = 0; rowIndex < data.GetLength(0); rowIndex++)
        // {
        //     double rowTotal = 0;
        //     // row 0
        //     for (int columnIndex = 0; columnIndex < data.GetLength(1); columnIndex++)
        //     {
        //         rowTotal += data[rowIndex, columnIndex];
        //     }

        //     Console.WriteLine(rowTotal);
        // }

        // 5. Cinema Seats (2D)

        // Goal: Count how many seats are occupied

        // Context: Cinema seating (1 = occupied, 0 = free)

        // Input/Output
        // I: matrix
        // O: occupied seats

        // Test Scenarios
        // I:
        // 1 0 1
        // 0 1 1
        // string [,] cinema =
        // {
        //     {"x", "O", "x"},
        //     {"O", "x", "x"}
        // };

        // int totalOccieped = 0;
        // int totalEmpty = 0;

        // foreach (string seat in cinema)
        // {
        //     if (seat == "x")
        //     {
        //         totalOccieped++;
        //     } else
        //     {
        //         totalEmpty++;
        //     }
        // }

        // Console.WriteLine($"{totalOccieped} seats are occieped {totalEmpty} are empty");
        // O:
        // 


        // Accountancy 

        // Q1: 1000 2000 3000
        // Q2: 8000
        // Q3: 500 600 700
        // Q4: -10000

        // Step 1, create a stagged array 
        int[][] data = new int [4][];

        data[0] = new int[] {1000, 2000, 3000};

        data[1] = new int [1];
        data[1][0] = 8000;

        data[2] = new int[] {500, 600, 700};
        data[3] = new int[] {-10000};

        // Step 2, give me the total result per quarter
        int finalTotal = 0;
        for (int quarterIndex = 0; quarterIndex < data.Length; quarterIndex++)
        {
            int quarterTotal = 0;

            for (int i = 0; i < data[quarterIndex].Length; i++)
            {
                quarterTotal += data[quarterIndex][i];
                finalTotal += data[quarterIndex][i];
            }

            Console.WriteLine($"quarterTotal: {quarterTotal}");
        }

        Console.WriteLine($"finalTotal: {finalTotal}");

        var data = [
            [1000, 2000, 3000], 
            [800],
            [1000, 4000]
        ];

        // Step 3, what profit do I have?

    }

    static void Print2DArray(int[,] _array)
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                Console.Write(_array[i, j] + " ");
            }
            Console.WriteLine(); // next row
        }
    }
}




















// 3. Reverse Array

// Goal: Reverse the array

// Input/Output
// I: array
// O: reversed array

// Test Scenarios
// I:
// 1 2 3 4
// O:
// 4 3 2 1

// I:
// 5 10 15
// O:
// 15 10 5






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













// 5. Cinema Seats (2D)

// Goal: Count how many seats are occupied

// Context: Cinema seating (1 = occupied, 0 = free)

// Input/Output
// I: matrix
// O: occupied seats

// Test Scenarios
// I:
// 1 0 1
// 0 1 0

// O:
// 3

// I:
// 0 0
// 0 0

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








// 3. Best-Selling Day Over Multiple Weeks

// Goal: Find which weekday performed best across multiple weeks.

// Context:
// A store tracks daily sales over several weeks.
// Each row in a 2D array is one week, with 7 columns for the days.

// Task:
// Add the sales per weekday across all weeks and print the weekday with the highest total sales.

// Input/Output
// I: multiple weeks of sales
// O: best-selling weekday overall

// Test Scenarios
// I:
// 100 200 150 300 250 400 350
// 120 180 160 280 270 390 360

// O:
// Saturday