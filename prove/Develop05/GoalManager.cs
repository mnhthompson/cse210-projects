

using System.Security.Cryptography.X509Certificates;
 using System.Data;

public class GoalManager;

{



public int _score;

public void GoalOrg()
{

    

    public DataTable _goals = new DataTable();
    DataTable MyTableByName = new DataTable("MyTableName");

    

    _goals.Columns.Add("Name");
    _goals.Columns.Add("Description");
    _goals.Columns.Add("Type");
    _goals.Columns.Add("Complete");
    _goals.Columns.Add("Complete_Amount");
    _goals.Columns.Add("Points");
    _goals.Columns.Add("Bonus_Points");

    string menu = "-1";
    do{
    Console.WriteLine("1. Display Goals");
    Console.WriteLine("2. Create Goals");
    Console.WriteLine("3. Record Events");
    Console.WriteLine("4. Save Progress");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Check Score");
    Console.WriteLine("7. Exit");
    menu = Console.ReadLine();

    if (menu == "1")
    {
        ListGoalNames();
        ListGoalDetails();
    }

    else if (menu == "2")
    {
        CreateGoal();
    }

    else if (menu == "3")        
    {
        RecordEvent();
    }
    else if (menu == "4")
    {
        SaveGoals(_goals);
    }
    else if (menu == "5")
    {
        LoadGoals(_goals);
    }
        else if (menu == "6")
    {
        DisplayPlayerInfo(_goals);
    }
    else
    {Console.WriteLine("INVALID SELECTION");}
    }while(menu != "7");

}


/// Display the user's score.
/// Creative**** Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.

void DisplayPlayerInfo(int _score, DataTable _goals);
{

    Console.WriteLine($"Score:{_score}");


}
/// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
///
public void ListGoals();
{
    {
    

    }

}

/// Allow the user to create new goals of any type.
void CreateGoal();
{
    string goalmenu = "-1";

    do{
    Console.WriteLine("1. Simple Goals");
    Console.WriteLine("2. Eternal Goals");
    Console.WriteLine("3. Checklist Goals");
    Console.WriteLine("4. Exit");
    goalmenu = Console.ReadLine();

    if (goalmenu == "1")
    {
        
                 var Screate = new SimpleGoal();
        Screate.SimpleGoal();
    }

    else if (goalmenu == "2")
    {
        
                 var Ecreate = new EternalGoal();
        Ecreate.EternalGoal();
    }

    else if (goalmenu == "3")        
    {
         var Ccreate = new ChecklistGoal();
        Ccreate.ChecklistGoal();
    }
    else
    {Console.WriteLine("INVALID SELECTION");}
    }while(goalmenu != "4");
}
/// Allow the user to record an event (meaning they have accomplished a goal and should receive points).
///
public void RecordEvent(DataTable _goals);
{
    Console.WriteLine("Please input Goals Number");
    string complete = Console.ReadLine();

    
    if( _goals.Rows[complete] ["Type"] = "Eternal" );
    {
        var Eupdate = new EternalGoal();
        Eupdate.IsComplete();
    }

    else if( _goals.Rows[complete]["Type"] = "Simple" );
    {
        var Supdate = new SimpleGoal();
        Supdate.IsComplete();
    }

    else if( _goals.Rows[complete]["Type"] = "Check" );
    {
        var Cupdate = new ChecklistGoal();
        Cupdate.IsComplete();
    }



}
/// Allow the user's goals and their current score to be saved and loaded.
static void SaveGoals(List<Goal> _goals);
{

    string filename = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal Goal in _goals)
                
                { outputFile.WriteLine($"{_goals},~,{_score}");}               

            }

}
 static void  LoadGoals(List<Goal> _goals);
{
          
        

        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        
                foreach (string line in  lines)
                    {
                        Goal _goalload = new Goal();

                        string[] parts = line.Split("~");

                        string _Lgoal = parts[0];

                        string _Lscore = parts[1];

                        

                        _goals=_Lgoal;
                        _score= _Lscore;
                       


                        _goals.Add(_goalload);
                                              

                    }

                    
                    return _goals;


}



}

///void Start(); {}
///void ListGoalDetails();{}