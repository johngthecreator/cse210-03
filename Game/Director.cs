namespace Unit3.Game{
    class Director{
        public void Main(){               
        }

        public void playGame(){
                Jumper jumper = new Jumper();
                Word word = new Word();
                Display display = new Display();
                bool play = true;
                string keyword = "";
                while(play){
                    keyword = word.selectRandomWord();
                    display.displayDude(5);
                    while(jumper.getLifePoints() > 0){
                        jumper.readUserInput(keyword);
                    }
                    Console.WriteLine("Do you want to play again? [y/n]");
                    string input = Console.ReadLine();
                    if(input == "y"){
                        play = true;
                        keyword = word.selectRandomWord();
                        jumper.setLifePoints();

                    }
                    else{
                        play = false;
                    }
                }
            }
    }
}