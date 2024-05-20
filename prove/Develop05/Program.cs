using System;


///Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
///
/// Use polymorphism by having derived classes override base class methods where appropriate.
///
/// Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
///
/// Creative**** i used a DataTable

class Program
{
    static void Main(string[] args)
    {
       
          var Start = new GoalManager();

            Start.GoalOrg();
    }
}