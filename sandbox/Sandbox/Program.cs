using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _words = new List<string>();

        string cookie;
        string cookie2;
        string cookie3;

        string textlist = "Hello Sandbox World!";

         string[] frags = textlist.Split(" ");

         foreach ( var line in frags)
         {
                cookie=frags[0];
                cookie2=frags[1];
                cookie3=frags[2];

             _words.Add(cookie);
             _words.Add(cookie2);
             _words.Add(cookie3);
             
                
        }

                Console.WriteLine(_words);



         
                    
        Console.WriteLine(frags);  

        
    }
}