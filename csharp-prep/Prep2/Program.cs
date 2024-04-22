using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What percentage did you get?");
        string percent = Console.ReadLine();

        int x = int.Parse(percent);

        string alpha = "";


        if (x >= 90)
        {
             alpha = ("A");
        }
          

        else if (x >= 80)
            {
             alpha = ("B");}

        else if (x >= 70)
            {
             alpha = ("C");}

        else if (x >= 60)
            {
             alpha = ("D");}
        else 
            {
             alpha = ("F");}

        Console.WriteLine($"Your Letter grade is: {alpha}");

        if (x >= 70)
            {Console.WriteLine("You pass");}


        else 
           {Console.WriteLine("You fail"); }
    }
}