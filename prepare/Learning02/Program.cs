using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Astronaut";
        job1._company = "Nasa";
        job1._startYear = 1999;
        job1._endYear = 2019;

        Job job2 = new Job();

        job2._jobTitle = "Villian";
        job2._company = "Detective Comics";
        job2._startYear = 1939;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        
        myResume._name = "Joe Chill";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}