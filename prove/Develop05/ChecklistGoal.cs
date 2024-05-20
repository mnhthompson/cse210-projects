using System;
 using System.Data;

///Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
///For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.

public class ChecklistGoal : Goal


{

    private int _amountComplete;

    public int _target;

    public int _bonus;

    public DataTable Goals(string _name,string _description, string _points, int _target, int _amountComplete, int _bonus, DataTable _goals)
    {
        Console.WriteLine("");

    
        DataRow _check = _goals.NewRow();
        Console.WriteLine("");

        _type = "Check";

        _check["Type"] = _type;

    Console.WriteLine("What is the Name of your goal?");

    _name = Console.ReadLine();

    _check["Name"] = _name;

    Console.WriteLine("Describe your goal?");

    _description = Console.ReadLine();

    _check["Description"] = _description;

    Console.WriteLine("What is it's point value?");

    _points = Console.ReadLine();

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

    DataTable IsComplete( DataTable _goals, int complete)
    {


         int Cherry = int.Parse(_goals.Rows[complete]["Complete"].ToString());
    

            int old =Cherry;
            
            int current = 0;


            do{
            
                current+=1;

            _goals.Rows[complete].SetField("Complete", current);

            

            }while( current >= old);


         return _goals;

            

    }

    ///string GetDetailsString();{  }

    ///string GetStringRepresentation();{    }

    ///void RecordEvent();    {    }


}