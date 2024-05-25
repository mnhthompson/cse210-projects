using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> exercise = new List<Activity>();
        
        Run run = new Run("May 24th 2024", 15, 3.8);

        exercise.Add(run);

        Bike Bicycles = new Bike("May 24th 2024", 20, 12);

        exercise.Add(Bicycles);

        Swim swim = new Swim("May 24th 2024", 40, 15);

        exercise.Add(swim);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Activity Create in exercise) 
        {
            Console.WriteLine(Create.Summary());
            Console.WriteLine();
        }
    }
}