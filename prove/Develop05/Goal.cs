using System;
 using System.Data;

public abstract class Goal

{

    public string _kind;

    
    public string _name;

    public string _description;

    public int _points;


    public Goal(string kind, string name, string description, int points)
    {
        _kind = kind;
        _name = name;
        _description = description;
        _points = points;
    }
    public string Getkind()
    {
        return _kind;
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
      public abstract void IsComplete( DataTable _goals, int complete);
 

   public abstract DataTable Goals(DataTable _goals);
   

    ///string GetDetailsString();{  }

    ///string GetStringRepresentation();{    }
}

