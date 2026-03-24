namespace inclass_assignment;

class Program
{
    static void Main(string[] args)
    {
        // I: What is your age? 14
        // O: Not an adult





        // I: number 1? 5
        // I: number 2? 6
        // O: number1 is smaller then number2
        // double nbr1 = Convert.ToDouble(Console.ReadLine());
        // double nbr2 = Convert.ToDouble(Console.ReadLine());

        // if (nbr1 == nbr2)
        // {
        //     Console.WriteLine("number1 is equal then number2");
        // } else if (nbr1 < nbr2)
        // {
        //     Console.WriteLine("number1 is smaller then number2");
        // } else
        // {
        //     Console.WriteLine("number1 is bigger then number2");
        // }




        // Application username: collin, password: ilovedspsxoxo
        // I: What is your user? test
        // I: What is your password? password
        // O: Wrong credentials

        // I: What is your user? collin
        // I: What is your password? ilovedspsxoxo
        // O: Enter the application
        // Console.WriteLine("What is your user?");
        // string user = Console.ReadLine();
        // Console.WriteLine("What is your password?");
        // string password = Console.ReadLine();

        // if (user == "collin" && password == "ilovedspsxoxo")
        // {
        //     Console.WriteLine("enter");
        // } else
        // {
        //     Console.WriteLine("go away");
        // }

        // I: 8
        // O: Even

        // I: 9
        // O: Odd
        // Tip: use % 2, it will give you 1 when it is odd, 0 when it is even
        // Console.WriteLine(9 % 2); // 1
        // Console.WriteLine(8 % 2); // 0

        // double nbr = Convert.ToDouble(Console.ReadLine());

        // if ( nbr % 2 == 0)
        // {
        //     Console.WriteLine("Even");
        // } else
        // {
        //     Console.WriteLine("Odd");
        // }

        // Scenario 2: TM IM CALLING
        // Only females from 18 to 25 can enter the special event
        // If they pay more then 50, they could still enter the event
        // Ask for the AGE and the Gender and bribe
        // Example 1
        // I: 18
        // I: 'f'
        // I: 0
        // O: Enter

        // Example 2
        // I: 18
        // I: 'm'
        // I: 100
        // O: Enter

        // Example 2
        // I: 26
        // I: 'f'
        // O: 20
        // O: Don't enter
        // double age = Convert.ToDouble(Console.ReadLine());
        // char gender = Convert.ToChar(Console.Read());
        // double bribeMoney = Convert.ToDouble(Console.ReadLine());

        // // Scenario 1
        // if ( (age >= 18 && age <= 25 && gender == 'f') || bribeMoney > 50)
        // {
        //     Console.WriteLine("Enter");
        // } else
        // {
        //     Console.WriteLine("Don't enter");
        // }

        // // Scenario 2
        // if (age < 18 || age > 25)
        // {
        //     Console.WriteLine("Don't enter");
        // } else
        // {
        //     Console.WriteLine("Enter");
        // }



        // I: yellow
        // O: lemon

        // I: green
        // O: lime

        // I: red
        // O: strawberry

        // I: black
        // I: I don't know the fruit
        // string color = Console.ReadLine();

        // switch (color)
        // {
        //     case "green":
        //         Console.WriteLine("lime");
        //         break;
        //     case "yellow":
        //         Console.WriteLine("lemon");
        //         break;
        //     case "red":
        //         Console.WriteLine("strawberry");
        //         break;
        //     default:
        //         Console.WriteLine("I don't know the fruit for the color " + color);
        //         break;
        // }

        // if (color == "green")
        // {
        //     Console.WriteLine("Lime");
        // } else if(color== "yellow")
        // {
        //     Console.WriteLine()
        // } else
        // {
        //     Console.WriteLine("I don't know the fruit");
        // }
        string numberAsString = Console.ReadLine();
        int x;

        Boolean isThisAInteger = int.TryParse(numberAsString, out x);

        Console.WriteLine(isThisAInteger);
        if (isThisAInteger == true)
        {
            Console.WriteLine("IT IS A NUMBER");
        } else
        {
            Console.WriteLine("Crazy input");
        }
    }
}
