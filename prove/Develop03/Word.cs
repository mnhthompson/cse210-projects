

using System.Diagnostics.Metrics;

public class Word

{

    public string _text;

    public bool _ishidden;




    public string Hide( string _text , bool _ishidden)
    
    {
        if( _ishidden == false)
        {

        _text = "______";
    
        }

        return _text;     
    }


 
     public bool IsHidden( string _text , bool _ishidden)

    {
            if (_text == "______")

                {_ishidden = true;}

            else

               {_ishidden = false;}

            return _ishidden;

        }





  

             public static string GetDisplayWord(List<Word> _words)

            {
                string cream ="";

                List<string> display =new List<string>();


                foreach (var item in _words)
                {
                 display.Add(item._text);
                 }

            
           
            
            cream = string.Join(" ",display);

            return cream;
            

         
            }


              public static List<Word> Scripture(List<Word> _words )
            {

                string textlist = "";

                Library question = new Library();
                    
                string fullscript = question.getrandomscript();

                string[] parts = fullscript.Split("~");    
                          
                string script = parts[4];

                textlist = script;
                        
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


  





}