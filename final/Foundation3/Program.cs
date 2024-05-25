using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("234 Cyprus Rd", "San antonia", "Texas", "USA");
        Lecture lecture = new Lecture("Hunting the Bat'", "How to stop batman", "May 24, 2024", "2 AM", address1, "Joe Chill", 50);

        Console.WriteLine();
        Console.WriteLine("Event 1");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(lecture.CreateStandard());
        Console.WriteLine();
        Console.WriteLine(lecture.CreateLecture());
        Console.WriteLine();
        Console.WriteLine(lecture.CreateShortLecture());

        Address address2 = new Address("234 Oak Rd", "San antonia", "Texas", "USA");
        Reception reception = new Reception("Speedrunners United", "Can he do it ", "May 24, 2024", "2 PM", address2, "Gamerdude@Gmail.com");

        Console.WriteLine();
        Console.WriteLine("Event 2");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(reception.CreateStandard());
        Console.WriteLine();
        Console.WriteLine(reception.CreateReception());
        Console.WriteLine();
        Console.WriteLine(reception.CreateShortReception());

        Address address3 = new Address("234 Cherry Rd", "San antonia", "Texas", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Festival of lights", "The 20th Anviersary", "May 24, 2024", "2 PM", address3, "Hail");

        Console.WriteLine();
        Console.WriteLine("Event 3");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.CreateStandard());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.CreateOutdoorGathering());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.CreateShortOutdoorGathering());


    }
}