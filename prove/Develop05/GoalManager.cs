

using System.Security.Cryptography.X509Certificates;
 using System.Data;
 using System.Text

public class GoalManager;

{



public int _score;

public void GoalOrg()
{

    

    DataTable _goals = new DataTable();
    

    

    _goals.Columns.Add("Name");
    _goals.Columns.Add("Description");
    _goals.Columns.Add("Type");
    _goals.Columns.Add("Complete");
    _goals.Columns.Add("Complete_Amount");
    _goals.Columns.Add("Points");
    _goals.Columns.Add("Bonus_Points");

    string menu = "-1";
    do{
    Console.WriteLine("1. Display Goals & Check Score");
    Console.WriteLine("2. Create Goals");
    Console.WriteLine("3. Record Events");
    Console.WriteLine("4. Save Progress");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Exit");
    menu = Console.ReadLine();

    if (menu == "1")
    {
        ListGoals( _goals);
       
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
    else
    {Console.WriteLine("INVALID SELECTION");}
    }while(menu != "6");

}


/// Display the user's score.
/// Creative**** Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.

void DisplayPlayerInfo(int _score, DataTable _goals);
{

    Console.WriteLine($"Score:{_score}");


}
/// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
///
public void ListGoals(DataTable _goals, int _score);
{
    {

                        foreach (string line in  lines)
                    {
                        
                        
                        string[] parts = line.Split(",");


                        string _name = parts[0];
                        string _description = parts[1];                        
                        string _type = parts[2];
                        string _complete = parts[3];
                        string _completeAmount = parts[4];
                        string _points = parts[5];
                        string _bonuspoints = parts[6];

                        

                                if( _goals.Rows[line]["Type"] = "Simple" );
                                {
                                    int complete = int.Parse(parts[4]);
                                    int points = int.Parse(parts[5]);

                                    int _score =+ complete * points;
                                    
                                }

                                else if( _goals.Rows[line]["Type"] = "Simple" );
                                {
                                        if  ( 1 == int.Parse(parts[3]) );
                                    int points = int.Parse(parts[5]);

                                    int _score =+ points;
                                }
                                

                                else if( _goals.Rows[line]["Type"] = "Check" );
                                {
                                    int  top = int.Parse(parts[3]);
                                    int  bottom = int.Parse(parts[4]);
                                    

                                    if  ( top == bottom) ;
                                    {

                                        int complete = int.Parse(parts[3]);
                                        int points = int.Parse(parts[5]);
                                        int bonus = int.Parse(parts[6]);

                                        int _score =+ (complete * points) + bonus;
                                    }

                                    else
                                    {
                                        
                                        int complete = int.Parse(parts[3]);
                                        int points = int.Parse(parts[5]);

                                        int _score =+ (complete * points);
                                    }

                                
                                


      
    }
         Console.WriteLine($"{_name}{_description}{_type}{_complete}{_completeAmount}{_points}{_bonuspoints}");
                                              

                    }
                    Console.WriteLine($"Score:{_score}");
    

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
        Eupdate.IsComplete(_goals, complete);
    }

    else if( _goals.Rows[complete]["Type"] = "Simple" );
    {
        var Supdate = new SimpleGoal();
        Supdate.IsComplete(_goals, complete);
    }

    else if( _goals.Rows[complete]["Type"] = "Check" );
    {
        var Cupdate = new ChecklistGoal();
        Cupdate.IsComplete(_goals, complete);
    }



}
/// Allow the user's goals and their current score to be saved and loaded.
static void SaveGoals(DataTable _goals);
{
    Console.WriteLine("Please input filename");
    string filename = Console.ReadLine();

    StringBuilder glue = new StringBuilder(); 

IEnumerable<string> columnNames = _goals.Columns.Cast<DataColumn>().
                                  Select(column => column.ColumnName);
glue.AppendLine(string.Join(",", columnNames));

foreach (DataRow row in _goals.Rows)
{
    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
    glue.AppendLine(string.Join(",", fields));
}

File.WriteAllText(filename, glue.ToString());

    
 

}
 static void  LoadGoals(DataTable _goals);
{
          
        

        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        
                foreach (string line in  lines)
                    {
                        DataRow _load = _goals.NewRow();
                        
                        string[] parts = line.Split(",");


                        _load["Name"] = parts[0];
                        _load["Description"] = parts[1];                        
                        _load["Type"] = parts[2];
                        _load["Complete"] = parts[3];
                        _load["Complete_Amount"] = parts[4];
                        _load["Points"] = parts[5];
                        _load["Bonus_Points"] = parts[6];

                        _goals.Rows.Add(_load);
                                              

                    }

                    


 return _goals;

}




}

///void Start(); {}
///void ListGoalDetails();{}