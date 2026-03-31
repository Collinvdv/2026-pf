namespace recap;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("How many goats do you have?");
        // int amountOfGoats = Convert.ToInt16(Console.ReadLine());
        // string[] goats = new string[amountOfGoats];

        // for(int i = 0; i < goats.Length; i++)
        // {
        //     Console.WriteLine($"What is the name of goat nbr {i + 1}");
        //     goats[i] = Console.ReadLine();
        // }
        
        // foreach(string goat in goats)
        // {
        //     Console.WriteLine(goat);
        // }

        // [] -> length
        // [,] -> getLength(0), getLength(1)
        // [][] -> length 
        //
        // S1: 10 20
        // S2: 20
        // S3: 10 15 

        int[][] gradebook = new int [3][];

        // populate first student
        gradebook[0] = new int[2];
        gradebook[0][0] = 10;
        gradebook[0][1]= 20;

        gradebook[1] = new int[1];
        gradebook[1][0] = 20;

        gradebook[2] = new int[2];
        gradebook[2][0] = 10;
        gradebook[2][1] = 15;

        for (int rowIndex = 0; rowIndex < gradebook.Length; rowIndex++)
        {
            Console.WriteLine("Student with index " + rowIndex);

            for(int gradeIndex = 0; gradeIndex < gradebook[rowIndex].Length; gradeIndex++)
            {
                Console.WriteLine(gradebook[rowIndex][gradeIndex]);
            }

        }
    }
}
