

using System.Diagnostics;

/// <summary>





/// </summary>
public class ListingActivity:Activity

{

private int _count;

private List<string> _prompts= new List<string>
{
"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"
};


public void ListingAct()
{
    ///The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    _description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    /// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    _name="Listing";
    DisplayStartingMessage(_name,_description);

///After the starting message, select a random prompt to show the user such as:
    GetRandomPrompt();
///After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
    ShowCountDown(5);

 DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(double.Parse(_duration));

do{

///The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
Console.ReadLine();

_count+=1;
 
}while ( futureTime > startTime);

///The activity them displays back the number of items that were entered.
Console.WriteLine($"you listed {_count} items");
///The activity should conclude with the standard finishing message for all activities.
    DisplayEndingMessage();

}
void Run()
{


}

void GetRandomPrompt()
{
      
            Random rnd = new Random();
            int random = rnd.Next(0, _prompts.Count);

            string prompt_random = _prompts [random];

            
        Console.WriteLine($"{prompt_random}");

}

///List<string> GetListFromUser(){}


}