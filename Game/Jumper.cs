namespace Unit3.Game{
    class Jumper{
        // Keep tack of score, get input from user.
        public void readUserInput(){            
            // Ask user to guess a letter
            Console.Write("Guess a letter [a-z]:");

            try{
                char input = Console.ReadLine()[0];
            }
            catch(Exception e){
                
                char input;
            }
            
            //checkUserInput(input);
            
        }
    }
}