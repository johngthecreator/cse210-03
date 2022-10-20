namespace Unit3.Game{
    class Display{

        private List<char> word = new List<char>{'_', '_', '_', '_', '_'};

        public void setWordList(int loc, char letter){
            word[loc] = letter;
        }

        private void printWordList(){
            foreach(char letters in word){
                Console.Write(letters);
            }
        }
      
        public void displayDude(){
              Jumper life = new Jumper();
              switch(life.getLifePoints())
                  {
                    case 5:
                          printWordList();
                          Console.WriteLine(@"
                            -----
                          /     \
                            -----
                          \     /
                            \   /
                              0
                            / | \
                            /  \     
                          ^^^^^^^");    
                        break;
                    case 4:
                          printWordList();
                          Console.WriteLine(@"
                          /     \
                            -----
                          \     /
                            \   /
                              0
                            / | \
                            /  \
                            
                          ^^^^^^^");
                              break;
                        
                    case 3:
                          printWordList();
                          Console.WriteLine(@"
                            -----
                          \     /
                            \   /
                              0
                            / | \
                            /  \
                            
                          ^^^^^^^");
                              break;
                    case 2:
                          printWordList();
                          Console.WriteLine(@"
                          \     /
                            \   /
                              0
                            / | \
                            /  \
                            
                          ^^^^^^^");
                              break;
                    case 1:
                          printWordList();
                          Console.WriteLine(@"
                            \   /
                              0
                            / | \
                            /  \
                            
                          ^^^^^^^");
                          break;
                    // case 4:
                    //       printWordList();
                    //       Console.WriteLine(@"
                    //           0
                    //         / | \
                    //         /  \
                            
                    //       ^^^^^^^");
                    //           break;
                    // case 3:
                    //       printWordList();
                    //       Console.WriteLine(@"
                    //           x
                    //         / | \
                    //         /  \
                            
                    //       ^^^^^^^");
                    //           break;
                  }
          }
    }
}