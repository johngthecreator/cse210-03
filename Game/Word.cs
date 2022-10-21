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
                "there",
                "their",
                "about",
                "would",
                "these",
                "other",
                "words",
                "could",
                "write",
                "first",
                "water",
                "after",
                "where",
                "right",
                "think",
                "three",
                "years",
                "place",
                "sound",
                "great",
                "again"
                };
            var random = new Random();
            int index = random.Next(words.Count);
            return setSelectedWord(words[index]);
        }
        public void getSelectedWord(){
            Console.WriteLine(selectedWord);
        }

        public bool checkUserInput(char userInput, string selectedWord){
            Display dis = new Display();
            if (selectedWord.Contains(userInput)){
                return true;
            }else{
                return false;
                
            }
            
            
        }
    }
}