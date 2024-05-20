using System;
 using System.Data;

public class EternalGoal:Goal

///Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
///For example, every time you read your scriptures you get 100 points.


{

            

        public EternalGoal(string kind, string name, string description, int points): base(kind, name, description, points)
    {

     }



    ///***********************************************************************************************************************************************************
            


        override public DataTable  Goals(DataTable _goals)
        {

            DataRow _eternal = _goals.NewRow();
            Console.WriteLine("");

            _kind = "Eternal";

            _eternal["Type"] = _kind;

        Console.WriteLine("What is the Name of your goal?");

        _name = Console.ReadLine();

        _eternal["Name"] = _name;

        Console.WriteLine("Describe your goal?");

        _description = Console.ReadLine();

        _eternal["Description"] = _description;

        Console.WriteLine("What is it's point value?");

        string points = Console.ReadLine();

         _points = int.Parse(points);

        _eternal["Points"] = _points;

        _eternal["Complete"] = "N/A";

        _eternal["Complete_Amount"] = 0;

        _eternal["Bonus_Points"] = "N/A";


        _goals.Rows.Add(_eternal);

        return _goals;

        }


       

         public override void  IsComplete( DataTable _goals,int complete)
        {

           
         int Cherry =  int.Parse(_goals.Rows[complete]["Complete_Amount"].ToString());
    

            int old =Cherry;
            
            int current = 0;

            do
            {
                 current =+ 1;

            _goals.Rows[complete].SetField("Complete_Amount", current);

            

             }while( current >= old);


        }



    ///string GetStringRepresentation();{    }
    /// void RecordEvent();        {        }


}