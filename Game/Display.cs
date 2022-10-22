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

        public string getCharList(){
          string charTotal = String.Join("",word);
          return charTotal;
        }

        public void winDisplay(){
            Console.WriteLine("You win!");
        }
      
        public void displayDude(int lifePoints){
              
              switch(lifePoints)
                  {
                    case 0:
                    
                          Console.WriteLine(@"
                          /   /
                         x ---
                          \   \
                         ^^^^^^^^");
                              break;                   
                      case 1:
                          printWordList();
                          Console.WriteLine(@"
                           \   /
                             0
                           / | \
                            / \
                            
                          ^^^^^^^");
                          break;
                      case 2:
                          printWordList();
                          Console.WriteLine(@"
                          
                          \     /
                           \   /
                             0
                           / | \
                            / \     
                            
                          ^^^^^^^");
                              break;
                      case 3:
                          printWordList();
                          Console.WriteLine(@"
                           
                        
                         | _____ |
                          \     /
                           \   /
                             0
                           / | \
                            / \     
                            
                          ^^^^^^^");
                              break;
                      case 4:
                          printWordList();
                          Console.WriteLine(@"
                           
                          /     \
                         | _____ |
                          \     /
                           \   /
                             0
                           / | \
                            / \     
                            
                          ^^^^^^^");
                              break;
                      case 5:
                          printWordList();
                          Console.WriteLine(@"
                           _____
                          /     \
                         | _____ |
                          \     /
                           \   /
                             0
                           / | \
                            / \     
                          ^^^^^^^");    
                        break;

                      default:
                          Console.WriteLine(@"
                          ~~~~~~~
                           _____        *****
                          /     \     **     **
                         | _____ |      *****
                          \     /
                           \   /
                             0
                           / | \
                            / \     
                          ^^^^^^^");
                          break;

                  }
          }
    }
}