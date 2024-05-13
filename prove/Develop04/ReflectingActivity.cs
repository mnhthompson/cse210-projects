

/// <summary>
/// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.


///It should continue showing random questions until it has reached the number of seconds the user specified for the duration.

/// </summary>


class ReflectingActivity:Activity

{

private List<string> _prompts = new List<string>
{
"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."
};

///After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:
private List<string> _questions = new List<string>
{
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
};


public  void  ReflectingAct(List<Log> _log)
{

    ///The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
   
    _description="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    /// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    _name="Reflecting";
    DisplayStartingMessage( _name, _description);


///After the starting message, select a random prompt to show the user
    DisplayPrompt();
    Console.WriteLine("Please Reflect");
///It should continue showing random questions until it has reached the number of seconds the user specified for the duration.

DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(double.Parse(_duration));

do{
    startTime = DateTime.Now;
    ///After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
    DisplayQuestion();
    ShowSpinner(5);
}while ( futureTime > startTime);






///The activity should conclude with the standard finishing message for all activities.
    DisplayEndingMessage();

    Program.LogAdd(_log,_name,_duration);

  
}

void Run()
{


}

private string GetRandomPrompt()
{
      
            Random rnd = new Random();
            int random = rnd.Next(0, _prompts.Count);

            string prompt_random = _prompts [random];

            
        return prompt_random;

}

private string GetRandomQuestion()
{
      
            Random rnd = new Random();
            int random = rnd.Next(0, _questions.Count);

            string questions_random = _questions [random];

            
        return questions_random;

}

private void DisplayPrompt()
{
    string prompt = GetRandomPrompt();
    Console.WriteLine($"{prompt}");
}

private void DisplayQuestion()
{
    string questions = GetRandomQuestion();
    Console.WriteLine($"{questions}");
}



}