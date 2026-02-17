namespace recap; // namespace you use for projects

// When you open a { we need to close with }
class Program
{
    static void Main(string[] args)
    {
        // BACK AT 9:40
        
        // Declaration + init of variables
        string firstname = "Collin";
        string lastname = "Van der Vorst";
        string fullname = firstname + " " + lastname;
        int age = 34; // integer is used for whole numbers 
        double height = 1.94; // double float
        bool isMarried = true; // boolean only 2 values to be stored true or false

        // Overwriting
        firstname = firstname.ToUpper();

        // I will only add code i here for the first 8 weeks
        Console.WriteLine("Hello, my name is " + fullname); //concat

    }
}
