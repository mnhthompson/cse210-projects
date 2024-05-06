using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;





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

            Scripture(_words);
            reference();
            
            do{

            GetDisplayText( reference1);
            
            ///If the user types quit, the program should end.
            //////Prompt the user to press the enter key or type quit.
            Console.WriteLine("Press enter to Continue or type quit to finish");
            
            forward =Console.ReadLine();

            HideRandomWords();

            ///Clear the console screen and display the complete scripture, including the reference and the text.
            Console.Clear();

            end = IsCompletelyHidden();

            }
            while( forward.ToLower() !="quit" &&  end != true );

///***********************************************************************************************************************************************



             static List<Word> Scripture(List<Word> _words )
            {

                string textlist = "";

                Library question = new Library();
                    
                string fullscript = question.getrandomscript();

                string[] parts = fullscript.Split("~");    
                          
                string script = parts[4];

                textlist = script;
                        
 
                             
                Console.WriteLine(textlist);


                    string[] frags = textlist.Split(" "); 

                   List<string> _port =new List<string>();    
                    
                    
                    foreach (var frag in frags)
                    {         
                        _port.Add(frag);                  
                    }


                    foreach (var item in _port)
                    {
                        Word text = new Word(); 

                        string june = item;

                        text._text = june;

                        text._ishidden = false;

                        _words.Add(text);


                    }
                                   


            return _words;
            }

///*************************************************************************
             Reference reference()
            {

                Library question = new Library();
                    
                string fullscript = question.getrandomscript();

                string[] lines = fullscript.Split("~");

              
                string book = lines[0];
                string chapter = lines[1];
                string sverse = lines[2];
                string everse = lines[3];
    
                reference1._book = book;
                reference1._chapter =  int.Parse(chapter);
                reference1._verse = int.Parse(sverse);
                reference1._endverse = int.Parse(everse);         

          
            return reference1;
            }
///*************************************************************************

///The program should continue prompting the user and hiding more words until all words in the scripture are hidden.

            List<Word> HideRandomWords()

            {
                int counter = 0;

                do{
                Word lexicon = new Word();

                Random rnd = new Random();
                int random = rnd.Next(0, _words.Count);

                lexicon = _words[random];

                 lexicon.Hide(lexicon._text);
                 lexicon.IsHidden();               

                _hiddenwords.Add(lexicon);

                Console.WriteLine("hi");


                counter+=1;

                }
                while (counter != 5);

                return _words;
            }



///Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
///Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").

             void GetDisplayText(Reference reference1)

            {
                List<string> display =new List<string>();

                Reference referenceDis = new Reference();

                referenceDis = reference1;

                foreach (var item in _words)

                 display.Add(item._text);

                    
                



            if (referenceDis._endverse != -1 )
            {
                Console.WriteLine($"{referenceDis._book} {referenceDis._chapter}:{referenceDis._verse}-{referenceDis._endverse} {string.Join(" ",display)}");
            }

            else
            {

                Console.WriteLine($"{referenceDis._book} {referenceDis._chapter}:{referenceDis._verse} {string.Join(" ",display)}");

            }
            }
    

        
        
 ///When all words in the scripture are hidden, the program should end.

        bool IsCompletelyHidden()
        {
            
            if ( _hiddenwords.Count == _words.Count)

                {bool end = true;}

            else

               { bool end = false;}

            return end;

        }






    }

    
}