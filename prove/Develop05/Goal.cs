using System;
 using System.Data;

public abstract class Goal

{

    public string _type;

    
    public string _name;

    public string _description;

    public int _points;


    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetType()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }


///method
      public abstract bool IsComplete()
    {

    }

    void Goals()
    {
        
    }

    ///string GetDetailsString();{  }

    ///string GetStringRepresentation();{    }
}

