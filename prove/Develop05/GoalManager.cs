

using System.Security.Cryptography.X509Certificates;
 using System.Data;
 using System.Text;

public class GoalManager

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
        CreateGoal(_goals);
    }

    else if (menu == "3")        
    {
        RecordEvent(_goals);
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
/// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
///
public void ListGoals(DataTable _goals)
{
    {



            for(int i = 0; i < _goals.Rows.Count; i++)
        {

            string _checker =  _goals.Rows[i]["Type"].ToString();            
            
            string[] parts = _checker.Split(",");


            string _name = parts[0];
            string _description = parts[1];                        
            string _kind = parts[2];
            string _complete = parts[3];
            string _completeAmount = parts[4];
            string _points = parts[5];
            string _bonuspoints = parts[6];


            Console.WriteLine($"{_name}{_description}{_kind}{_complete}{_completeAmount}{_points}{_bonuspoints}");
                                              

                    }


            for (int i = 0; i < _goals.Rows.Count; i++) 
            {  

                string _decker =  _goals.Rows[i]["Type"].ToString();
                string[] frags = _decker.Split(",");


                if( _decker == "Eternal" )
                {
                    int complete = int.Parse(frags[4]);
                    int points = int.Parse(frags[5]);

                    int _score =+ complete * points;
                    
                }

                else if( _decker == "Simple" )
                {
                        if  ( 1 == int.Parse(frags[3]) );
                    int points = int.Parse(frags[5]);

                    int _score =+ points;
                }
                

                else if( _decker == "Check" )
                {
                    int  top = int.Parse(frags[3]);
                    int  bottom = int.Parse(frags[4]);
                    

                    if  ( top == bottom) 
                    {

                        int complete = int.Parse(frags[3]);
                        int points = int.Parse(frags[5]);
                        int bonus = int.Parse(frags[6]);

                        int _score =+ (complete * points) + bonus;
                    }

                    else
                    {
                        
                        int complete = int.Parse(frags[3]);
                        int points = int.Parse(frags[5]);

                        int _score =+ (complete * points);
                    }    
                    
                }
        
                    Console.WriteLine($"Score:{_score}");
    

    }
    }

}

/// Allow the user to create new goals of any type.
    void CreateGoal(DataTable _goals)
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
            
            Goal Screate = new SimpleGoal(kind,  name,  description,  points, isComplete);
            Screate.Goals(_goals);
        }

        else if (goalmenu == "2")
        {
            Goal Ecreate = new EternalGoal(kind,  name,  description,  points, isComplete);
            Ecreate.Goals(_goals);
        }

        else if (goalmenu == "3")        
        {
            Goal Ccreate = new ChecklistGoal(kind,  name,  description,  points, amountComplete, target,  bonus );
            Ccreate.Goals(_goals);
        }
        else
        {Console.WriteLine("INVALID SELECTION");}
        }while(goalmenu != "4");
    }
/// Allow the user to record an event (meaning they have accomplished a goal and should receive points).
///
    public static void RecordEvent(DataTable _goals)
    {




        Console.WriteLine("Please input Goals Number");
        string _complete = Console.ReadLine();

        int complete= int.Parse( _complete );

        string _checker =  _goals.Rows[complete] ["Type"].ToString();
        
        if( _checker == "Eternal" )
        {
            Goal Eupdate = new EternalGoal(kind,  name,  description,  points, _isComplete);
            Eupdate.IsComplete(_goals, complete);
        }

        else if( _checker == "Simple" )
        {
            Goal Supdate = new SimpleGoal(kind,  name,  description,  points, _isComplete);
            Supdate.IsComplete(_goals, complete);
        }

        else if( _checker == "Check" )
        {
            Goal Cupdate = new ChecklistGoal(kind,  name,  description,  points, _amountComplete, _target,  _bonus );
            Cupdate.IsComplete(_goals, complete);
        }



    }
/// Allow the user's goals and their current score to be saved and loaded.
static void SaveGoals(DataTable _goals)
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
 static DataTable  LoadGoals(DataTable _goals)
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


///void Start(); {}
///void ListGoalDetails();{}

}

