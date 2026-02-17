namespace week1_helloworld;

class Program
{
    static void Main(string[] args)
    {
        /*
            Add a new variable called ln
            O: Hello, my name is Collin Van der Vorst
        */
        string fn = "Collin"; // declared a variable + initialising it
        string ln = "Van der Vorst";
        string fullname = $"{fn} {ln}";
        Console.WriteLine("Hello, my name is {fullname}"); // concat

    }
}
