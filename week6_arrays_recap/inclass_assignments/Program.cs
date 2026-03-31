namespace inclass_assignments;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


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

// I:
// 2 2
// 3 3
// 4 4

// O:
// 4 6 8






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