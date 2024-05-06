

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




    ///string GetDisplayText()
    ///
    ///string word()

  





}