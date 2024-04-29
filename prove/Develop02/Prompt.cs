
public class Prompt
    {

/// X Your list of prompts must contain at least five different prompts.
        public List<string> _ideas =new List<string>(6)
        {
            "What was the best part of your day?",
            "what was the strongest emotion you felt?",
            "If i could redo one thing i would redo?",
            "what was the most intresting person i saw today?",
            "what did i eat?",
            "how was the weather?"
        };


        public  string getrandomprompt()

        {
            
            Random rnd = new Random();
            int random = rnd.Next(1, 7);

            string prompt_random = _ideas [random];

            
        return prompt_random;
        
        }

   

        




    }