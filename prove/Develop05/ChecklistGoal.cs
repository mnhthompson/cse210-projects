using System;
 using System.Data;

///Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
///For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.

public class ChecklistGoal : Goal


{

  

    public int _target;

    public int _bonus;



 
    public ChecklistGoal(string kind, string name, string description, int points,int target, int bonus ): base(kind, name, description, points)
    {  

        _bonus=bonus;
        _target=target;
      
    }

    public int Gettarget()
    {
        return _target;
    }

    public int Getbonus()
    {
        return _bonus;
    }




    ///***********************************************************************************************************************************************************

    public override DataTable Goals(DataTable _goals)
    {
        Console.WriteLine("");

    
        DataRow _check = _goals.NewRow();
        Console.WriteLine("");

        _kind = "Check";

        _check["Type"] = _kind;

    Console.WriteLine("What is the Name of your goal?");

    _name = Console.ReadLine();

    _check["Name"] = _name;

    Console.WriteLine("Describe your goal?");

    _description = Console.ReadLine();

    _check["Description"] = _description;

    Console.WriteLine("What is it's point value?");

    string points = Console.ReadLine();

    _points = int.Parse(points);

    _check["Points"] = _points;

    Console.WriteLine("What is it's Bonus point value?");

    string Bonus = Console.ReadLine();

    _bonus = int.Parse(Bonus);

    _check["Bonus_Points"] = _bonus;

    _check["Complete"] = 0;

    Console.WriteLine("How many times?");

    string Target = Console.ReadLine();

    _target = int.Parse(Target);

    _check["Complete_Amount"] = _target;


    _goals.Rows.Add(_check);


    return _goals;


    }

    public override void IsComplete( DataTable _goals, int complete)
    {


         int Cherry = int.Parse(_goals.Rows[complete]["Complete"].ToString());
    

            int old =Cherry;
            
            int current = 0;


            do{
            
                current += 1;

            _goals.Rows[complete].SetField("Complete", current);

            

            }while( current <= old);

            
    }

    ///string GetDetailsString();{  }

    ///string GetStringRepresentation();{    }

    ///void RecordEvent();    {    }


}