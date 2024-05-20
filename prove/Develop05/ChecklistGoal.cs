using System;
 using System.Data;

///Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
///For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.

class ChecklistGoal : Goal;


{

public int _amountComplete;

public int _target;

public int _bonus;

public void  ChecklistGoal(string _name,string _description, string _points, int _target, int _amountComplete, int _bonus, DataTable _goals);
{
    Console.WriteLine("");

  
    DataRow _check = _goals.NewRow();
    Console.WriteLine("");

    _type = "Check";

    _goals["Type"] = _type;

Console.WriteLine("What is the Name of your goal?");

_name = Console.ReadLine();

_goals["Name"] = _name;

Console.WriteLine("Describe your goal?");

_description = Console.ReadLine();

_goals["Description"] = _description;

Console.WriteLine("What is it's point value?");

_points = Console.ReadLine();

_goals["Points"] = _points;

Console.WriteLine("What is it's Bonus point value?");

_bonus = Console.ReadLine();

_goals["Bonus_Points"] = _bonus;

_goals["Complete"] = 0;

Console.WriteLine("How many times?");

_target = Console.ReadLine();

_goals["Complete_Amount"] = int.Parse(_target);


_goals.Rows.Add(_check);


 return _goals;


}


void RecordEvent();
{

}

bool override IsComplete( DataTable _goals);
{
    if (_amountComplete == _target)
    {///award bonus
    
    }

}

///string GetDetailsString();{  }

///string GetStringRepresentation();{    }


}