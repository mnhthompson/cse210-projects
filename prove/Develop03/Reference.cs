


public class Reference

{

    private string _book;

    private int _chapter;

    private int _verse;

    private int _endverse;

   

  public static string GetDisplayTextRefrence(Reference reference1)


            {
                List<string> display =new List<string>();

                Reference referenceDis = new Reference();

                referenceDis = reference1;

                string cone="";

                

            if (referenceDis._endverse != -1 )
            {
                cone = $"{referenceDis._book} {referenceDis._chapter}:{referenceDis._verse}-{referenceDis._endverse}";
            }

            else
            {

                cone = $"{referenceDis._book} {referenceDis._chapter}:{referenceDis._verse}";

            }

            return cone;

            }
   
 
  
     public static Reference ReferenceBuilder(Reference reference1)
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
            
            }
 