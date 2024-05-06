using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;


/// ***CREATIVITY***Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.***CREATIVITY***


///If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
///
///When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)
///
///Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.



///Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference (for example "John 3:16"), and to represent a word in the scripture.


class Program
{




    static void Main(string[] args)
    {

         Reference reference1 = new Reference();
        

            string forward = "";

            bool end = false;

            List<Word> _words = new List<Word>();
            List<Word> _hiddenwords = new List<Word>();

            Word.Scripture(_words);
            Reference.ReferenceBuilder(reference1);
            
            do{

            GetDisplayText( );
            
            ///If the user types quit, the program should end.
            //////Prompt the user to press the enter key or type quit.
            Console.WriteLine("Press enter to Continue or type quit to finish");
            
            forward =Console.ReadLine();

            end = IsCompletelyHidden(end);

            HideRandomWords(_words);

            ///Clear the console screen and display the complete scripture, including the reference and the text.
            Console.Clear();


            }
            while( forward.ToLower() !="quit" &&  end != true );

///***********************************************************************************************************************************************

        

///The program should continue prompting the user and hiding more words until all words in the scripture are hidden.

            void HideRandomWords(List<Word>_words)

            {
               
               Word.HideRandom(_words);

                
            }



///Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
///Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").

             void GetDisplayText()

            {
                List<string> display =new List<string>();

                Reference referenceDis = new Reference();

                referenceDis = reference1;

             string Cone = Reference.GetDisplayTextRefrence(reference1);

             string Cream = Word.GetDisplayWord(_words);

               

            
           
            
            Console.WriteLine($"{Cone} {Cream}");
            

         
            }
    

        
        
 ///When all words in the scripture are hidden, the program should end.

       bool IsCompletelyHidden(bool end)
        {

            end = Word.IsCompHidden(_words, end);

            return end;

        }






    }

    
}