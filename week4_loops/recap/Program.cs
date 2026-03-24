namespace recap;

class Program
{
    static void Main(string[] args)
    {
        // Color 
        // I: yellow 
        // O: banana

        // Color 
        // I: green 
        // O: apple

        // string color = Console.ReadLine().ToLower();

        // if (color == "yellow")
        // {
        //     Console.WriteLine("Banana");
        // } else if (color == "green")
        // {
        //     Console.WriteLine("Apple");
        // } else
        // {
        //     Console.WriteLine("I don't know this color");
        // }

        // switch(color)
        // {
        //     case "yellow":
        //         Console.WriteLine("Banana");
        //         break;
        //     case "green":
        //         Console.WriteLine("pple");
        //         break;
        //     default: 
        //         Console.WriteLine("I don't know the color");
        //         break;
        // }




        // I: 14
        // O: No enter

        // I: 18 
        // O: Enter
        // // Convert.ToDouble("18") -> (double)18
        // double age = Convert.ToDouble(Console.ReadLine());
        // char gender = Convert.ToChar(Console.Read()); //'f'
        // Console.WriteLine(Char.IsLower(gender));
        // if (age >= 18 && age <= 30 && (gender == 'f' || gender == 'F'))
        // {
        //     Console.WriteLine("Enter"); 
        // } else
        // {
        //     Console.WriteLine("Don't enter");
        // }

        string ageStr = Console.ReadLine();

        int age;

        bool canIParse = int.TryParse(ageStr, out age);

        if (canIParse)
        {
            Console.WriteLine("Parseable to int");
        } else
        {
            Console.WriteLine("Not parseable to int");
        }


        // Write a program that checks a username and password.
        // If the username is "admin" and the password is "1234", print Access granted. Otherwise print Access denied.

        // O: Username:
        // I: admin
        // O: Password: 
        // I: 1234
        // O: Access granted
        Console.WriteLine("Username");
        string username = Console.ReadLine();
        Console.WriteLine("Password");
        string pass = Console.ReadLine();

        if (username == "admin" && pass == "1234")
        {
            Console.WriteLine("Access granted");
        } else
        {
            Console.WriteLine("Access denied");
        }
    }
}











// Exercise 1 – Discount Check

// Write a program that checks if a customer gets a discount.
// If the purchase amount is 100 or more, the customer gets a discount message. Otherwise, show that there is no discount.

// I: 120
// O: Discount applied

// Exercise 2 – Login Check

// Write a program that checks a username and password.
// If the username is "admin" and the password is "1234", print Access granted. Otherwise print Access denied.

// I:
// Username: admin
// Password: 1234

// O: Access granted