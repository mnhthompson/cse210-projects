using System;
 using System.Data;

public class SimpleGoal : Goal

/// Provide for simple goals that can be marked complete and the user gains some value.
///For example, if you run a marathon you get 1000 points.
///


{
    public bool _isComplete;

    public DataTable Goals(string _name,string _description, string _points, string _type, DataTable _goals)
    {

    DataRow _simple = _goals.NewRow();
        Console.WriteLine("");

        _type = "Simple";

        _simple["Type"] = _type;

    Console.WriteLine("What is the Name of your goal?");

    _name = Console.ReadLine();

    _simple["Name"] = _name;

    Console.WriteLine("Describe your goal?");

    _description = Console.ReadLine();

    _simple["Description"] = _description;

    Console.WriteLine("What is it's point value?");

    _points = Console.ReadLine();

    _simple["Points"] = _points;

    _simple["Complete"] = 0;

    _simple["Complete_Amount"] = "N/A";

    _simple["Bonus_Points"] = "N/A";


    _goals.Rows.Add(_simple);

    return _goals;
        

    }

    

    public DataTable IsComplete( DataTable _goals, int complete)
    {

        _goals.Rows[complete].SetField("Complete", 1);

        return _goals;
        

    }



    ///string GetStringRepresentation();{    }
    ///void RecordEvent();{    }


}