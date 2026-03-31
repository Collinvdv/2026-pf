namespace inclass_assignments;

class Program
{
    static void Main(string[] args)
    {
        // Read 5 numbers give the total (store everything in an array)
        // I: 4
        // I: 8
        // I: 6
        // I: 10
        // I: 20
        // O: Total is 48


        // // init + decl or an array 
        // double[] grades = new double[5];

        // // populate the array 
        // for (int i = 0; i< grades.Length; i++)
        // {
        //     grades[i] = Convert.ToDouble(Console.ReadLine());
        // }
        
        // // calculate the total 
        // double total = 0;

        // for (int i = 0; i< grades.Length; i++)
        // {
        //     total += grades[i];
        // }

        // Console.WriteLine(total);




         // Accountancy
        // Quarter1: 1500 -1000 -300
        // Quarter2: 1700 -800 -300e
        // Quarter3: 5000 -1000 300
        // Quarter4: 1500 1000 -300
        //
        // O: Result quarter 1 is 200
        // O: Result quarter 2 is 600
        // O: Result quarter 3 is 4300
        // O: Result quarter 4 is 2200
        // O: Total result is 7300
        //
        double[,] accountancy =
        {
            {1500, -1000, -300}, // quarter1,
            {1700, -800, -300}, // quarter2,
            {5000, -1000, 300}, // quarter3,
            {1500, 1000, -300}, // quarter4,
        };

        // Quarter total calculcalotr 
        for (int rowIndex = 0; rowIndex < accountancy.GetLength(0); rowIndex++)
        {
            Console.WriteLine($"---------Quarter {rowIndex + 1}---------");
            double total = 0;
            for (int columnIndex = 0; columnIndex < accountancy.GetLength(1); columnIndex++ )
            {
                total += accountancy[rowIndex, columnIndex];
            }
            Console.WriteLine($"Total: {total}");
        }

        // Total of the year 
        Console.WriteLine("----- year statistics -----");
        double yearProfit = 0;
        double totalCosts = 0;
        double totalIncome = 0;
        foreach (double amount in accountancy)
        {
            if (amount < 0) totalCosts += amount;
            if (amount > 0) totalIncome += amount;
            yearProfit += amount;
        }
        Console.WriteLine($"Income total: {totalIncomegs}");
        Console.WriteLine($"Costs total: {totalCosts}");
        Console.WriteLine($"Profit: {yearProfit}");


        // Best day of the week
        // Monday = 5.5
        // Tuesday = 10
        // Wednesday = 7
        // Thursday = 12
        // Friday = 15
        // Saturday = 22
        // Sunday = 10
        //



        // Accountancy
        // Quarter1: 1500 -1000 -300
        // Quarter2: 1700 -800 -300
        // Quarter3: 5000 -1000 300
        // Quarter4: 1500 1000 -300
        //
        // O: Result quarter 1 is 200
        // O: Result quarter 2 is 600
        // O: Result quarter 3 is 4300
        // O: Result quarter 4 is 2200
        // O: Total result is 7300
        //




//         3. Title: Calculate the Sum

// Goal: Practice looping through an array and adding values.

// Instructions:
// Create an array with 5 integers. Calculate the total sum of all numbers and show the result.

// Input/Output:
// O: The sum is ...

// Test Scenarios:
// 1.
// Array: 1, 2, 3, 4, 5
// O: The sum is 15

// Array: 10, 10, 10, 10, 10
// O: The sum is 50

// Array: 7, 1, 9, 2, 6
// O: The sum is 25
    }
}
