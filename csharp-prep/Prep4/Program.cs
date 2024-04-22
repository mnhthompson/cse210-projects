using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
         List<int> numberslist = new List<int>();

          int addnumber = -1;
        while (addnumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string number = Console.ReadLine();
            addnumber = int.Parse(number);
            
            if (addnumber != 0)
            {
                numberslist.Add(addnumber);
            }
        }

        int sumnumber = 0;

        foreach (int number in numberslist)
        {
            sumnumber += number;
        }

        Console.WriteLine($"The sum is: {sumnumber}");

        float averagenumber = ((float)sumnumber) / numberslist.Count;
        Console.WriteLine($"The average is: {averagenumber}");

        int maxnumber= numberslist[0];


        foreach (int number in numberslist)
        {
            if (number>maxnumber)

            maxnumber=number;

           
        }

        Console.WriteLine($"The max is: {maxnumber}");

    }
}