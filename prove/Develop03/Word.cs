

using System.Diagnostics.Metrics;

public class Word

{

    public string _text;

    public bool _ishidden;




    public void Hide( string _text)
    
    {
        if( _ishidden == false)
        {

        _text = "______";

                
        }
     
    }


    void Show()

    {

        _text=_text;
    }

     public bool IsHidden()

    {
            if (_text == "______")

                {bool _ishidden = true;}

            else

               { bool _ishidden = false;}

            return _ishidden;

        }




    ///string GetDisplayText()
    ///
    ///string word()

  





}