using System;

class Program
{
   
    static void Main(string[] args)
    {
        
        Assignment assign1 = new Assignment("Tim Drake", "Calculus");

        MathAssignment assign2 = new MathAssignment("Jason Todd", "Subtracting", "26-G", "75-98=");

        WritingAssignment assign3 = new WritingAssignment("Dick Grayson", "Gotham Statistics", "The Corrlation between Super Crimanals and Super Heros");


        Console.WriteLine(assign1.GetSummary());

        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}
