
public class Library

/// Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
/// 
/// Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.

{
    public List<string> _script =new List<string>

    {
        "Alma ~33~3~-1~ Do ye remember to have read what Zenos, the prophet of old, has said concerning prayer or worship?",
        "Alma ~33~6~7~ And again, O God, when I did turn to my house thou didst hear me in my prayer. And when I did turn unto my closet, O Lord, and prayed unto thee, thou didst hear me.",
        "Alma ~34~18~19~ Yea, cry unto him for mercy; for he is mighty to save.Yea, humble yourselves, and continue in prayer unto him."

    };




     public string getrandomscript()

        {
            
            Random rnd = new Random();
            int random = rnd.Next(0, 3);

            string script_random = _script [random];

            
        return script_random;
        
        }


}