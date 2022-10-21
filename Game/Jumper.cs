namespace Unit3.Game{
    class Jumper{
        private int lifePoints = 5;

        public void readUserInput(string keyword){ 
            Word check = new Word();
            Display display = new Display();
            Console.WriteLine(keyword);
            Console.WriteLine(getLifePoints());
            Console.Write("Guess a letter [a-z]:");

            try{
                char input = Console.ReadLine()[0];
                hitPoints(check.checkUserInput(input, keyword));
                int wordIndex = keyword.IndexOf(input);
                display.setWordList(wordIndex, keyword[wordIndex]);
                display.displayDude(lifePoints);               
            }
            catch(Exception){    
                check.checkUserInput('0', keyword);
                display.displayDude(lifePoints);
            }            
        }
        public int getLifePoints(){
            return lifePoints;
        }

        public void setLifePoints(){
            lifePoints = 5;
        }

        private void hitPoints(bool hit){
            // Keep track of hit points
            if (hit == false){
                lifePoints--;
            }
        }
    }
}