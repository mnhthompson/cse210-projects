



public class Activity

{

public string _name;

public string _description;

public string _duration;

public DateTime _date;





///Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds. Then, it should tell the user to prepare to begin and pause for several seconds.

public void DisplayStartingMessage(string _name,string _description)
{
    Console.WriteLine($"Welcome to the {_name}");

    Console.WriteLine($"{_description}");

    Console.WriteLine("how long, in second, would you like your session?");

    _duration = Console.ReadLine();
}

///Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
public void DisplayEndingMessage()
{
        Console.WriteLine($"Good job compleating the {_name} you took {_duration} Seconds");
         Thread.Sleep(5000);
}
///Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
public void ShowSpinner(int seconds)
{
    Console.Write("|");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Write("/");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Write("-");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Write("\\");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Write("|");
    Thread.Sleep(500);
    Console.Write("\b \b");
     Console.Write("/");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Write("-");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Write("\\");

}
public void ShowCountDown(int seconds)
{

    for (int i = seconds; i>0; i--)

    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}


}


///Activity(){}