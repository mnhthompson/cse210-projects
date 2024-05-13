




public class BreathingActivity:Activity

{

public void BreathingAct()
{

///The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    _name ="Breathing";


/// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    
    
    DisplayStartingMessage( _name, _description);

///After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
    


 DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(double.Parse(_duration));

do{
   Console.WriteLine("");
    Console.Write("Breath in...");

    ShowCountDown(3);

      Console.WriteLine("");
    Console.Write("Breath out...");

 ShowCountDown(6);
}while ( futureTime > startTime);




        
///After each message, the program should pause for several seconds and show a countdown.
///It should continue until it has reached the number of seconds the user specified for the duration.

    Console.WriteLine("Good job");


///The activity should conclude with the standard finishing message for all activities.
    DisplayEndingMessage();

}

///Void Run(){}

}