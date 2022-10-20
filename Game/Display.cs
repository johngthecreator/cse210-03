namespace Unit3.Game{
    class Display{

        static int Life = 3;
        private List<char> word = new List<char>{'_', '_', '_', '_', '_'};

        public void setWordList(int loc, char letter){
            word[loc] = letter;
        }

        public void printWordList(){
            foreach(char letters in word){
                Console.Write(letters);
            }
        }
      
  static void Main(String[] Args){
         switch(Life)
            {
               case 9:
                     Console.WriteLine("_ _ _ _ _");
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
               case 8:
                     Console.WriteLine("_ _ _ _ _");
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
                  
               case 7:
                     Console.WriteLine("_ _ _ _ _");
                     Console.WriteLine(@"
                      -----
                     \     /
                      \   /
                        0
                      / | \
                       /  \
                      
                     ^^^^^^^");
                        break;
               case 6:
                     Console.WriteLine("_ _ _ _ _");
                     Console.WriteLine(@"
                     \     /
                      \   /
                        0
                      / | \
                       /  \
                      
                     ^^^^^^^");
                        break;
               case 5:
                     Console.WriteLine("_ _ _ _ _");
                     Console.WriteLine(@"
                      \   /
                        0
                      / | \
                       /  \
                      
                     ^^^^^^^");
                     break;
               case 4:
                     Console.WriteLine("_ _ _ _ _");
                     Console.WriteLine(@"
                        0
                      / | \
                       /  \
                      
                     ^^^^^^^");
                        break;
               case 3:
                     Console.WriteLine("                    _ _ _ _ _");
                     Console.WriteLine(@"
                        x
                      / | \
                       /  \
                      
                     ^^^^^^^");
                        break;
            }
    }

    }
}