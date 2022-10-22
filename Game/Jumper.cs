namespace Unit3.Game{
    class Jumper{
        private int lifePoints = 5;
        private int wordIndex = 0;

        public void readUserInput(string keyword){ 
            Word check = new Word();
            Console.WriteLine($"You have {getLifePoints()} lives left...");
            Console.Write("Guess a letter [a-z]:");

            try{
                char input = Console.ReadLine()[0];
                hitPoints(check.checkUserInput(input, keyword));
                int index = keyword.IndexOf(input);
                wordIndex = index;
            }
            catch(Exception){    
                check.checkUserInput('0', keyword);
                wordIndex = -1;
            }            
        }
        public int getLifePoints(){
            return lifePoints;
        }

        public void setLifePoints(int life){
            lifePoints = life;
        }

        public int getWordIndex(){
            return wordIndex;
        }

        public void hitPoints(bool hit){
            // Keep track of hit points
            if (hit == false){
                lifePoints--;
            }
        }
    }
}