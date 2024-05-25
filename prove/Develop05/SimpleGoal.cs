using System;
 using System.Data;

public class SimpleGoal : Goal

/// Provide for simple goals that can be marked complete and the user gains some value.
///For example, if you run a marathon you get 1000 points.
///


{

 
        public SimpleGoal(string kind, string name, string description, int points): base(kind, name, description, points)
    { 

    
    }


    ///***********************************************************************************************************************************************************

    override public DataTable Goals(DataTable _goals)
    {

    DataRow _simple = _goals.NewRow();
        Console.WriteLine("");

        _kind = "Simple";

        _simple["Type"] = _kind;

    Console.WriteLine("What is the Name of your goal?");

    _name = Console.ReadLine();

    _simple["Name"] = _name;

    Console.WriteLine("Describe your goal?");

    _description = Console.ReadLine();

    _simple["Description"] = _description;

    Console.WriteLine("What is it's point value?");

    string points = Console.ReadLine();

     _points = int.Parse(points);

    _simple["Points"] = _points;

    _simple["Complete"] = 0;

    _simple["Complete_Amount"] = -1;

    _simple["Bonus_Points"] = -1;


    _goals.Rows.Add(_simple);

    return _goals;
        

    }

    

    override public void IsComplete( DataTable _goals, int complete)
    {

        _goals.Rows[complete].SetField("Complete", 1);

       


    }



    ///string GetStringRepresentation(){    }
    ///void RecordEvent(){    }


}