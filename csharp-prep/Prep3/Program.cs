using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    
    
        string response = "yes";

        while (response == "yes")
        {

            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);


            Console.WriteLine($"What is the magic number? {magic}");
            Console.WriteLine($"What is your guess? ");
            string guess = Console.ReadLine();

            int number = int.Parse(guess);

            if (magic==number)

            {Console.WriteLine("You guessed it!");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();}


            else if (magic>number)

            {Console.WriteLine("Higher");}

            else if (magic<number)

            {Console.WriteLine("Lower");}

            





       
        }


    
    }
}