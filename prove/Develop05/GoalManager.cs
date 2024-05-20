

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
    Console.WriteLine("1. Display Goals");
    Console.WriteLine("2. Create Goals");
///broken
    Console.WriteLine("3. Record Events");
    Console.WriteLine("4. Save Progress");
    Console.WriteLine("5. Load Goals");
///broken
    Console.WriteLine("6. Check Score");
    Console.WriteLine("7. Exit");
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

    else if (menu == "6")
    {
        Score( _goals);
    }

    else
    {Console.WriteLine("INVALID SELECTION");}
    }while(menu != "7");

}


/// Display the user's score.
/// Creative**** Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.
/// Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
///
public void ListGoals(DataTable _goals)
{
    {

            foreach (DataRow dr in _goals.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
              }

             }}
                                                
public void Score(DataTable _goals)
{
    int _score = 0;  

            for (int i = 0; i < _goals.Rows.Count; i++) 
            {  
                

                string _decker =  _goals.Rows[i]["Type"].ToString();

                string _docker =  _goals.Rows[i].ToString();


                string[] frags = _docker.Split(",");

                    int  top = int.Parse(frags[3]);
                    int complete = int.Parse(frags[4]);
                    int points = int.Parse(frags[5]);

                    int bonus = int.Parse(frags[6]);

                                


                if( _decker == "Eternal" )
                {
                     _score =+ complete * points;
                    
                }

                else if( _decker == "Simple" )
                {
                        if  ( top == 1)
                           {

                             _score =+ points;}          
                }
                

                else if( _decker == "Check" )
                {

                    if  ( top == complete) 
                    {
                         _score =+ (complete * points) + bonus;
                    }

                    else
                    {
                        
                        _score =+ (complete * points);
                    }    
                    
                }
        
                    Console.WriteLine($"Score:{_score}");
    

    }
    }



/// Allow the user to create new goals of any type.
    void CreateGoal(DataTable _goals)
    {
        string goalmenu = "-1";
        
      string kind;
        string name;
        string description;
        int points;
        int target;
        int bonus;

        do{


        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");
        Console.WriteLine("4. Exit");
        goalmenu = Console.ReadLine();

        if (goalmenu == "1")
        {
            kind = "null";
            name = "null";
            description= "null";
            points= 0;
            
        Goal Screate = new SimpleGoal(kind,  name,  description,  points);
           Screate.Goals(_goals);
        }

        else if (goalmenu == "2")
        {
            kind = "null";
            name = "null";
            description= "null";
            points= 0;

           Goal Ecreate = new EternalGoal(kind, name ,description ,points );
          Ecreate.Goals(_goals);
        }

        else if (goalmenu == "3")        
        {
            kind = "null";
            name = "null";
            description= "null";
            points= 0;
            target= 0;
            bonus= 0;
           
           Goal Ccreate = new ChecklistGoal(kind,  name,  description,  points, target, bonus );
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

         string kind;
        string name;
        string description;
        int points;
        int target;
        int bonus;

        

        
        Console.WriteLine("Please input Goals Number");
        string _complete = Console.ReadLine();

        int complete= int.Parse( _complete );

        string _checker =  _goals.Rows[complete] ["Type"].ToString();
        
        if( _checker == "Eternal" )
        {
            Console.WriteLine("Eternal");
            kind = "null";
            name = "null";
            description= "null";
            points= 0;

          Goal Eupdate = new EternalGoal(kind,  name,  description,  points);
          Eupdate.IsComplete(_goals, complete);
        }

        else if( _checker == "Simple" )
        {
            Console.WriteLine("Simple");
            kind = "null";
            name = "null";
            description= "null";
            points= 0;

            Goal Supdate = new SimpleGoal(kind,  name,  description,  points);
           Supdate.IsComplete(_goals, complete);
        }

        else if( _checker == "Check" )
        {
            Console.WriteLine("Check");
            kind = "null";
            name = "null";
            description= "null";
            points= 0;
            target= 0;
            bonus= 0;

           Goal Cupdate = new ChecklistGoal(kind,  name,  description,  points, target,  bonus );
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

    Console.WriteLine("Please input filename");

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

