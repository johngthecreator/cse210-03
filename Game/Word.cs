using System;
using System.Collections.Generic;
namespace Unit3.Game{
    class Word{
        private string selectedWord = "";
        private string setSelectedWord(string genWord){
            selectedWord = genWord;
            return selectedWord;
        }
        public string selectRandomWord(){
            List<string> words = new List<string>{
                "which",
                "their",
                "about",
                "would",
                "other",
                "words",
                "could",
                "write",
                "first",
                "water",
                "after",
                "right",
                "think",
                "years",
                "place",
                "sound",
                "great",
                };
            var random = new Random();
            int index = random.Next(words.Count);
            return setSelectedWord(words[index]);
        }
        public void getSelectedWord(){
            Console.WriteLine(selectedWord);
        }

        public bool checkUserInput(char userInput, string selectedWord){
            if (selectedWord.Contains(userInput)){
                return true;
            }else{
                return false;
                
            }
        }
    }
}