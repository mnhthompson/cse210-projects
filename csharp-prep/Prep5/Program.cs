using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();
        int usernumber = PromptUserNumber();

        int squared = SquareNumber(usernumber);

        DisplayResult(username, squared);


    }

        
        static void DisplayWelcome()

        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()

        {
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();

            return name;

        }


        static int PromptUserNumber()

        {
        Console.Write("Please input your desired number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
        }


        static int SquareNumber(int number)

        {
              int square = (number) * (number);
              return square;

        }



        static void DisplayResult(string name, int square)

        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }




    
}