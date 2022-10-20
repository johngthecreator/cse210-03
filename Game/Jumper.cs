namespace Unit3.Game{
    class Jumper{
        private int lifePoints = 5;

        public void readUserInput(){ 
            Word check = new Word();
            Console.Write("Guess a letter [a-z]:");

            try{
                char input = Console.ReadLine()[0];
                hitPoints(check.checkUserInput(input));;                
            }
            catch(Exception e){    
                check.checkUserInput('0');
            }            
        }

        private void hitPoints(bool hit){
            // Keep track of hit points
            if (hit == false){
                lifePoints--;
            }
        }
    }
}