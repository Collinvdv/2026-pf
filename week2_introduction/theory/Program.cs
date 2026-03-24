namespace theory;

class Program
{
    static void Main(string[] args)
    {
        char grade = 'A'; // type can only store 1 character use ''
        string fn = "Collin"; // type can store multiple characters use "

        double income = 5000;
        double costs = 4000;
        double profit = income - costs; // operators +, -, * and /

        // add 1
        profit = profit + 1;
        profit++; // add 1
        profit += 1;

        System.Console.WriteLine(7/2.0);

        System.Console.WriteLine(profit);




        /*
            Comparison operatos
            >, <, ==
        */
       int number1 = 10;
       int number2 = 10;

       Console.WriteLine(number1 == number2); // == to check if it is the same
       Console.WriteLine(number1 != number2); // True
       Console.WriteLine(number1 > number2); // Greater then
       Console.WriteLine(number1 >= number2); // Greater or equal then
       Console.WriteLine(number1 < number2); // smaller then
       Console.WriteLine(number1 <= number2); // Smaller or equal then

        int number4 = 300;
        string number4_str = Convert.ToString(number4); // "300""
        char firstNumber = number4_str[0];
        Console.WriteLine(firstNumber);

        Console.WriteLine("Collin");
        Console.Write("C");
        Console.Write("O");
        Console.Write("L");

        int charIndex  = Console.Read();
        Console.WriteLine(charIndex);




       /*
            String operations
       */



        /*
            Char
        */
    }
}
