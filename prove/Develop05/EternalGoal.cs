using System;
 using System.Data;

class EternalGoal : Goal;

///Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
///For example, every time you read your scriptures you get 100 points.


{

            private int _amountComplete;


        public void  EternalGoal(string _name,string _description, string _points, DataTable _goals);
        {

            DataRow _eternal = _goals.NewRow();
            Console.WriteLine("");

            _type = "Eternal";

            _eternal["Type"] = _type;

        Console.WriteLine("What is the Name of your goal?");

        _name = Console.ReadLine();

        _eternal["Name"] = _name;

        Console.WriteLine("Describe your goal?");

        _description = Console.ReadLine();

        _eternal["Description"] = _description;

        Console.WriteLine("What is it's point value?");

        _points = Console.ReadLine();

        _eternal["Points"] = _points;

        _eternal["Complete"] = "N/A";

        _eternal["Complete_Amount"] = 0;

        _eternal["Bonus_Points"] = "N/A";


        _goals.Rows.Add(_eternal);

        return _goals;

        }


       

        bool override IsComplete( DataTable _goals,int complete);
        {

            int old = _goals.Rows[complete] ["Complete_Amount"];
            int current = -1;


            do
            {
                 current =+ 1;

            _goals.Rows[complete].SetField("Complete_Amount", current);

            

             }while( current >= old);

        }



    ///string GetStringRepresentation();{    }
    /// void RecordEvent();        {        }


}