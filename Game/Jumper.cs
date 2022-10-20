namespace Unit3.Game{
    class Jumper{
        private int lifePoints = 5;

        public void readUserInput(){ 
            Word check = new Word();
            check.selectRandomWord();
            check.getSelectedWord();
            Console.WriteLine(getLifePoints());
            Console.Write("Guess a letter [a-z]:");

            try{
                char input = Console.ReadLine()[0];
                hitPoints(check.checkUserInput(input));;                
            }
            catch(Exception){    
                check.checkUserInput('0');
            }            
        }
        public int getLifePoints(){
            return lifePoints;
        }

        private void hitPoints(bool hit){
            // Keep track of hit points
            if (hit == false){
                lifePoints--;
            }
        }
    }
}