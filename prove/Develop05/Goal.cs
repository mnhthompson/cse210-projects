using System;
 using System.Data;

public abstract class Goal;

{

    private string _type;

    public string _shortName;

    public string _description;

    public string _points;


     void  Goal(string _name,string _description, string _points);
    {

    }

     void RecordEvent();
    {

    }

     bool  IsComplete();
    {

    }

    ///string GetDetailsString();{  }

    ///string GetStringRepresentation();{    }
}

