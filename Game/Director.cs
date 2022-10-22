namespace Unit3.Game{
    class Director{

        public void playGame(){
            Jumper jumper = new Jumper();
            Word word = new Word();
            Display display = new Display();
            string keyword = "";
            keyword = word.selectRandomWord();
                while(jumper.getLifePoints() >= 0){
                    if (display.getCharList() == keyword){
                        jumper.setLifePoints(-1);
                        display.winDisplay();
                    }else if (display.getCharList() != keyword && jumper.getLifePoints() == 0){
                        jumper.setLifePoints(-1);
                        Console.WriteLine("Sorry you died!");
                        display.displayDude(0);
                    }else{
                        display.displayDude(jumper.getLifePoints());
                        jumper.readUserInput(keyword);
                        int index = jumper.getWordIndex();
                        if (index >= 0){
                            display.setWordList(index, keyword[index]);
                        }
                    }
                }
                Console.WriteLine("Do you want to play again? [y/n]");
                string input = Console.ReadLine();
                if(input == "y"){
                    keyword = word.selectRandomWord();
                    jumper.setLifePoints(5);
                    playGame();
                }
        }
    }
}