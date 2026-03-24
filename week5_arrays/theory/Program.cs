namespace theory;

class Program
{
    static void Main(string[] args)
    {
        // string[] goats = {"T-rex", "Connie", "Clyde"};

        // for (int i = 0; i < goats.Length; i++)
        // {
        //     Console.WriteLine(goats[i]);
        // }

        // foreach(string goat in goats)
        // {
        //     Console.WriteLine(goat);
        // }

        // Console.WriteLine("# Students?");
        // int amountOfStudents = Convert.ToInt16(Console.ReadLine());

        // double[] grades = new double[amountOfStudents];

        // // populate the grades array 
        // for (int i = 0; i < grades.Length; i++)
        // {
        //     Console.WriteLine($"Grade for student {i + 1}");
        //     grades[i] = Convert.ToDouble(Console.ReadLine());
        // }

        // // calculate the avg 
        // double total = 0;

        // foreach (double grade in grades)
        // {
        //     total += grade;
        // }

        // double avg = total / grades.Length;
        // Console.WriteLine($"Avg is {avg}");



        // OMG 2D ARRAYS 

        double[,] gradebook = new double[3, 4];

        // Student 1 
        gradebook[0,0] = 10;
        gradebook[0,1] = 10;
        gradebook[0,2] = 10;
        gradebook[0,3] = 5;

        // Student 2 
        gradebook[1, 0] = 20;
        gradebook[1, 1] = 15;
        gradebook[1, 2] = 13.5;
        gradebook[1, 3] = 10;

        // Student 3
        gradebook[2, 0] = 20;
        gradebook[2, 1] = 15;
        gradebook[2, 2] = 13.5;
        gradebook[2, 3] = 10;

        // Only focus on the positions, later populate them 
        int amountOfStudents = gradebook.GetLength(0); 
        int amountOfGrades = gradebook.GetLength(1); 

        // for (int studentIndex = 0; studentIndex < amountOfStudents; studentIndex++)
        // {
        //     for (int gradeIndex = 0; gradeIndex < amountOfGrades; gradeIndex++)
        //     {
        //         gradebook[studentIndex, gradeIndex] = double.Parse(Console.ReadLine());
        //     }
        // }

        // for (int rowIndex = 0; rowIndex < amountOfStudents; rowIndex++)
        // {
        //     double studentTotal = 0;

        //     for (int columnIndex = 0; columnIndex < amountOfGrades; columnIndex++)
        //     {
        //         studentTotal += gradebook[rowIndex, columnIndex];
                
        //     }

        //     double avg = studentTotal / amountOfGrades;
        //     Console.WriteLine($"Student total is {avg}");
        //     Console.WriteLine("--------------");
        // }

        for (int gradeIndex = 0; gradeIndex < amountOfGrades; gradeIndex++)
        {
            double totalGrade = 0;
            for (int studentIndex = 0; studentIndex < amountOfStudents; studentIndex++)
            {
                totalGrade += gradebook[studentIndex, gradeIndex];
            }

            double avgTest = totalGrade / amountOfStudents;

            Console.WriteLine(avgTest);
        }
    }
}
