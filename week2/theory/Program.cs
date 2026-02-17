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
    }
}
