using System;
 using System.Data;

public class SimpleGoal : Goal;

/// Provide for simple goals that can be marked complete and the user gains some value.
///For example, if you run a marathon you get 1000 points.
///
/// 1, Marathon, a lot of running, Simple, 1000, [ ]

{
public bool _isComplete;

public void  SimpleGoal(string _name,string _description, string _points, string _type, DataTable _goals);
{

DataRow _simple = _goals.NewRow();
    Console.WriteLine("");

    _type = "Simple";

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

_goals["Complete"] = 0;

_goals["Complete_Amount"] = "N/A";

_goals["Bonus_Points"] = "N/A";


_goals.Rows.Add(_simple);

 return _goals;
    

}

void RecordEvent();
{

}

bool override IsComplete( DataTable _goals);
{

    _goals.Rows[rowIndex].SetField("Complete", 1);

     
      

}



///string GetStringRepresentation();{    }


}