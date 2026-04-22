namespace theory;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // EVENT TOOL 
        // ASK THE USER TO TYPE COMMANDS 
        // [stop] -> stop the program
        // [create_event] -> create an event (add .txt file)
        // [delete_event] -> name the event if exists delete file
        // [stats_events] -> give me the information on an event 
        // [list_events] -> what events do we have
        // [help] -> write the commands 
        // [add_participants] -> we say which event, and then add participants
        
        // Ask for commando
        Help();
        Console.WriteLine("Give new cmd:");
        string cmd = Console.ReadLine().ToLower();

        while (cmd != "stop")
        {
            // Execute a cmd 
            switch (cmd)
            {
                case "create_event":
                    CreateEvent();
                    break;
                case "delete_event":
                    // @todo
                    Console.WriteLine("We are going to delete a event");
                    break;
                case "stats_events":
                    // @todo
                    ListEvents();
                    string eventName = Console.ReadLine(); 

                    if (File.Exists(eventName + ".txt"))
                    {
                        string[] participants = File.ReadAllLines(eventName + ".txt");
                        double femaleCounter = 0;
                        double maleCounter = 0;

                        foreach(string participant in participants)
                        {
                            string gender = participant.Split('|')[1].ToLower();

                            if (gender == "female")
                            {
                                femaleCounter++;
                            } else
                            {
                                maleCounter++;
                            }
                        }

                        double percentageMale = maleCounter / participants.Length  * 100;
                        double percentageFemale = femaleCounter / participants.Length  * 100;

                        Console.WriteLine($"Total participants: {participants.Length}");
                        Console.WriteLine($"female percentage is: {percentageFemale}");
                        Console.WriteLine($"Male percentage is: {percentageMale}");
                    } else
                    {
                        Console.WriteLine("---I don't know this event");
                    }
                    Console.WriteLine("We are going to stats a event");
                    break;
                case "list_events":
                    ListEvents();
                    break;
                case "help":
                    Help();
                    break;
                case "add_participants":
                    AddParticipants();
                    break;
                default:
                    Console.WriteLine("--- I don't know the command");
                    break;
            }

            // Ask a new cmd
            Console.WriteLine("Give new cmd:");
            cmd = Console.ReadLine().ToLower();
        }

        // Application has been stopped
        Console.WriteLine("Application has been stopped");
    }

    public static void AddParticipants( )
    {
        Console.WriteLine("What is the event that you want to add participants to?");
        // step 1: list events 
        ListEvents();

        // step 2: user need to pick an event, 
        // and before we can continue we need to check if it is the correct one
        // if not pick new one, if they stey stop the want to exit the add_partipcants flow 
        string eventName = Console.ReadLine(); 
        string[] events = File.ReadAllLines("_events.txt");

        bool isExisting =  FindItemInArray(events, eventName);

        while (isExisting != true && eventName != "stop")
        {
            Console.WriteLine("--- sorry... don't know this event");
            // it is not correct ask it again
            eventName = Console.ReadLine();
            isExisting =  FindItemInArray(events, eventName);
        }
        
        if (eventName == "stop")
        {
            Console.WriteLine("--- user does not want to add participants anymore");
        } else
        {
            if (isExisting)
            {
                // add the actual participants
                Console.WriteLine("--- [add] to add [stop] to stop");
                string userCmd = Console.ReadLine();

                while(userCmd != "stop")
                {
                    // ask for name
                    Console.WriteLine("--- Name of participant:");
                    string name = Console.ReadLine();

                    // ask for gender
                    Console.WriteLine("--- Name of gender (female or male):");
                    string gender = Console.ReadLine();

                    // add them to the correct file
                    StreamWriter str = File.AppendText(eventName + ".txt");

                    str.WriteLine($"{name}|{gender}");
                    str.Close();
                    Console.WriteLine("--- Added the participant to file: " + eventName + ".txt");

                    // add the actual participants
                    Console.WriteLine("--- [add] to add [stop] to stop");
                    userCmd = Console.ReadLine();
                }
            }
        }
    }

    public static bool FindItemInArray(string[] listItems, string itemToBeSearched)
    {
        bool isExisting = false; 

        foreach(string item in listItems)
        {
            if (itemToBeSearched == item)
            {
                isExisting = true;
            }
        }
        
        return isExisting;
    }

    public static void Help()
    {
        Console.WriteLine("Here are all the commands:");
        Console.WriteLine("[stop] -> stop the program");
        Console.WriteLine("[create_event] -> create an event (add .txt file)");
        Console.WriteLine("[delete_event] -> name the event if exists delete file");
        Console.WriteLine("[stats_events] -> give me the information on an event ");
        Console.WriteLine("[list_events] -> what events do we have");
        Console.WriteLine("[help] -> write the commands ");
        Console.WriteLine("[add_participants] -> we say which event, and then add participants");
    }

    public static void CreateEvent()
    {
        // Step 1 
        Console.WriteLine("What is the name of the event?");
        string eventName = Console.ReadLine();

        // Step 2: to check if the event is exists 
        if (File.Exists(eventName + ".txt"))
        {
            Console.WriteLine("--- This file is already existing");
        } else
        {
            // Create the actual event txt file
            StreamWriter str = File.CreateText(eventName + ".txt");
            str.Close();
            Console.WriteLine("--- Added a new txt file");

            // Add the event to a txt file, so later we can print them
            StreamWriter strEvents = File.AppendText("_events.txt");
            strEvents.WriteLine(eventName);
            strEvents.Close();
            Console.WriteLine("--- Added the event to _events.txt");
        }
    }

    public static void ListEvents()
    {
        string eventsText = File.ReadAllText("_events.txt");
        Console.WriteLine(eventsText);
    }
}

