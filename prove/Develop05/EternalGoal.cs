using System;
 using System.Data;

class EternalGoal : Goal;

///Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
///For example, every time you read your scriptures you get 100 points.


{

            public int _amountComplete;


        public void  EternalGoal(string _name,string _description, string _points, DataTable _goals);
        {

            DataRow _eternal = _goals.NewRow();
            Console.WriteLine("");

            _type = "Eternal";

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

        _goals["Complete"] = "N/A";

        _goals["Complete_Amount"] = 0;

        _goals["Bonus_Points"] = "N/A";


        _goals.Rows.Add(_eternal);

        return _goals;

        }


        void RecordEvent();
        {

        }

        bool override IsComplete( DataTable _goals);
        {

            _goals.Rows[rowIndex].SetField("Complete_Amount", i++);

        }



    ///string GetStringRepresentation();{    }


}