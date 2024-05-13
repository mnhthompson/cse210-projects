using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;



/// Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
///Avoid duplicating code in classes where it could instead be placed in a base class.
///Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.

///Creativity***Saving and loading a log file.***




class Program
{
    static void Main(string[] args)
    {
        string Menu ="-1";
        
        List<Log> _log = new List<Log>();

        do
        {

        /// Have a menu system to allow the user to choose an activity.
        Console.WriteLine("Please Pick an Activity");
        Console.WriteLine("");
        Console.WriteLine("1. Reflecting!");
        Console.WriteLine("2. Breathing Practice!");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Save File");
        Console.WriteLine("5. Load File");
        Console.WriteLine("6. Display");
        Console.WriteLine("7. QUIT");
        Menu = Console.ReadLine();

         

        if (Menu == "1")
        {
            var Refelct = new ReflectingActivity();

            Refelct.ReflectingAct(_log);
            
        }
        else if (Menu == "2")
        {
            var Breathing = new BreathingActivity();

           Breathing.BreathingAct(_log);
        }
        else if (Menu == "3")
        {
            var Listing= new ListingActivity();

            Listing.ListingAct(_log);
        }
        else if (Menu == "4")
        {
            Console.WriteLine("Save : Please provide filename");
            savefile(_log);
        }
        else if (Menu == "5")
        {
            Console.WriteLine("load : Please provide filename");
            loadfile(_log);
        }
        else if (Menu == "6")
        {
            ///var Log = new Log();

            Console.WriteLine("Display");

            foreach (Log Log in _log)
            {
                Log.Display();
            }   

        }
        else if (Menu == "7")
        {
            Console.WriteLine("good Byte");
        }

      
        } while(Menu !="7");
   
    }

    static List<Log> loadfile(List<Log> _log )

    {
      
      
        

        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        
                foreach (string line in  lines)
                    {
                        Log _logload = new Log();

                        string[] parts = line.Split("~");

                        string _Ldate = parts[0];

                        string _Lname = parts[1];

                        string _Lduration = parts[2];

                        _logload._date=_Ldate;
                        _logload._name= _Lname;
                        _logload._duration=_Lduration;


                        _log.Add(_logload);
                                              

                    }

                    
                    return _log;


    }

       static void savefile( List<Log> _log )

    {
            
        
            string filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (Log Log in _log)
                        
                        { outputFile.WriteLine($"{Log._date},~,\"{Log._name}\",~,{Log._duration}");}               

                    }
    }

public static void LogAdd(List<Log> _log,string _name,string _duration)

{
    Log Logadd = new Log();

    DateTime theCurrentTime = DateTime.Now;
    Logadd._date = theCurrentTime.ToShortDateString();

    Logadd._name=_name;

    Logadd._duration=_duration;


   

    
    _log.Add(Logadd);

    
}


}


