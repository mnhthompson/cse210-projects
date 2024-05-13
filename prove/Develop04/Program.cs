using System;
using System.ComponentModel.Design;



/// Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
///Avoid duplicating code in classes where it could instead be placed in a base class.
///Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.

///Creativity***Saving and loading a log file.




class Program
{
    static void Main(string[] args)
    {
        string Menu ="-1";

        do
        {

        /// Have a menu system to allow the user to choose an activity.
        Console.WriteLine("Please Pick an Activity");
        Console.WriteLine("");
        Console.WriteLine("1. Reflecting!");
        Console.WriteLine("2. Breathing Practice!");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. QUIT");
        Menu = Console.ReadLine();

        if (Menu == "1")
        {
            ReflectingActivity.ReflectingAct();
        }
        else if (Menu == "2")
        {
            BreathingActivity.BreathingAct();
        }
        else if (Menu == "3")
        {
            ListingActivity.ListingAct();
        }
        else if (Menu == "4")
        {
            Console.WriteLine("good Byte");
        }

      
        } while(Menu !="4");
   
    }
}