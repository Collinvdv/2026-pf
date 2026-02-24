namespace inclass_assignment;

class Program
{
    static void Main(string[] args)
    {
        // Objective: Ask the user for their name and age, then calculate their age in 10 years.

        // O: Enter your name: 
        // I: Alice
        // O: Enter your age: 
        // I: 25
        // O: Hello Alice, in 10 years you will be 35 years old.
        // System.Console.WriteLine("Enter your name:");
        // string name = Console.ReadLine();
        // System.Console.WriteLine("Enter your age:");
        // int age = Console.ReadLine();
        // int futureAge = age + 10;
        // System.Console.WriteLine($"Hello {name}, in 10 years you will be {futureAge} years old.");






        // // Objective: Get two numbers from the user and display their sum.
        // // O: Enter the first number: 
        // // I: 8
        // // O: Enter the second number: 
        // // I: 12
        // // O: The sum is: 20
        // // O: The division is: 0.6666666

        // // Declare and init variables
        // Console.WriteLine("Enter the first number: ");
        // double number1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Enter the second number: ");
        // double number2 = Convert.ToDouble(Console.ReadLine());

        // // Logic
        // double sum = number1 + number2;
        // double div = number1 / number2;

        // // Output
        // Console.WriteLine($"The sum is: {sum}");
        // Console.WriteLine($"The division is: {div}");






        // Objective: Convert a temperature from Celsius to Fahrenheit.
        // Temperature in degrees Celsius (°C) * 9/5) + 32
        // O: Enter temperature in Celsius: 
        // I: 25
        // O: 25C is equal to 77F.

        Console.WriteLine(" Enter temperature in Celsius:");
        double temperature = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (temperature * 9 / 5) + 32;

        Console.WriteLine($"{temperature}C is equal to {Math.Round(fahrenheit)}F.");






        // Objective calculate BMI (BMI = kg/m2) 
        // O: Enter your weight (kg): 
        // I: 70
        // O: Enter your height (m): 
        // I: 1.75
        // O: Your BMI is 22.86
    }
}
