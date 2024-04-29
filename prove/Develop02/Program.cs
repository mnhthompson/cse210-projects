using System;
using System.ComponentModel.Design;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

/// journal app <summary>
/// 
/// For this assignment you will write a program to help people record the events of their day by supplying prompts and then 
/// saving their responses along with the question and the date to a file.

/// Contain classes for the major components in the program.
/// Contain at least two classes in addition to the Program class.
/// Demonstrate the principle of abstraction by using member variables and methods appropriately.
/// 
///Improve the process of saving and loading to save as a .csv file that could be opened in Excel 
/// </summary>

class Program
{
    static void Main(string[] args)
/// X Provide a menu that allows the user choose these options
    {
        List<Entry> _entries = new List<Entry>();
                
        string menu = "7";                
        
        do
        {
            Console.WriteLine("Please Select an Option");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            menu = Console.ReadLine();

             
/// X Write a new entry 
            if (menu == "1")
                {
                    Console.WriteLine("Please Write");

                    AddEntry(_entries );

                }
/// X Display the journal
            else if (menu == "2")
                {
                    Console.WriteLine("Display");

                    foreach (Entry Entry in _entries)
                    {
                        Entry.Display();
                    }                   
                }
/// X Save the journal to a file
            else if (menu == "3")
                {
                    Console.WriteLine("Save : Please provide filename");
                    savefile(_entries);    
                }
/// X Load the journal from a file
            else if (menu == "4")
                {
                    Console.WriteLine("Load : Please provide filename");
                    loadfile(_entries);              
                }
            else if (menu == "5")
                {Console.WriteLine("Quit: Good Byte");}

            else 
                {Console.WriteLine("Invalid choice");}

    }while (menu != "5" );




    static void savefile( List<Entry> _entries )

    {
            
        
            string filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (Entry Entry in _entries)
                        
                        { outputFile.WriteLine($"{Entry._date},~,\"{Entry._promptText}\",~,{Entry._entryText}");}               

                    }
    }


    static List<Entry> loadfile(List<Entry> _entries )

    {
      
      
        

        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        
                foreach (string line in  lines)
                    {
                        Entry Entryload = new Entry();

                        string[] parts = line.Split("~");

                        string _Ldate = parts[0];

                        string _LpromptText = parts[1];

                        string _LentryText = parts[2];

                        Entryload._date=_Ldate;
                        Entryload. _promptText= _LpromptText;
                        Entryload._entryText=_LentryText;


                        _entries.Add(Entryload);                      

                    }

                    
                    return _entries;


    }

    static void AddEntry(List<Entry> _entries)

    {

        Entry Entryadd = new Entry();

         DateTime theCurrentTime = DateTime.Now;
                         Entryadd._date = theCurrentTime.ToShortDateString();

                    

                    Prompt question = new Prompt();



                    Entryadd._promptText =  question.getrandomprompt();
                    
                    Entryadd.Display();
                    
                    String juniper = Console.ReadLine();

                    Entryadd._entryText =$"\"{juniper}\"";

                    _entries.Add(Entryadd);


    }


    }
}