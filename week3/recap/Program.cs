namespace recap;

class Program
{
    static void Main(string[] args)
    {
        // // Types
        // string firstname = "Collin";
        // firstname = "Sharon";
        // int age = 34;
        // double height = 1.94;
        // Boolean isMarried = true;
        // char firstLetter = 'a';

        // // Arithmetic unary operators 
        // age++;
        // ++age;
        // age = age + 1;
        // age += 1;

        // height = height + 2;

        // // ReadLine, Read, Write, WriteLine
        // Console.WriteLine("Hello");
        // string username = Console.ReadLine();
        // double age = Convert.ToDouble(Console.ReadLine());
        // char letter = Console.Read();

        // // Comparison operator
        // double number1 = 10;
        // double number2 = 20;

        // Console.WriteLine(number1 < number2);
        // Console.WriteLine(number1 <= number2);
        // Console.WriteLine(number1 != number2);
        // Console.WriteLine(number1 == number2);
        // Console.WriteLine(number1 >= number2);
        // Console.WriteLine(number1 > number2);

        // Converting


        // Objective calculate BMI (BMI = kg/m2) 
        // O: Enter your weight (kg): 
        // I: 70
        // O: Enter your height (m): 
        // I: 1.75
        // O: Your BMI is 22.86
        Console.WriteLine("Enter your weight (kg):");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height (m):");
        double height = Convert.ToDouble(Console.ReadLine());

        // kg/m2
        double bmi =  weight / (height * height);

        Console.WriteLine($"Your BMI is {bmi}");
    }
}
