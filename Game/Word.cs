using System;
using System.Collections.Generic;
namespace Unit3.Game{
    class Word{
        private string selectedWord = "";
        private void setSelectedWord(string genWord){
            selectedWord = genWord;
        }
        public void selectRandomWord(){
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
            setSelectedWord(words[index]);
        }
        public void getSelectedWord(){
            Console.WriteLine(selectedWord);
        }

        public void checkUserInput(char userInput){
            if (selectedWord.Contains(userInput)){
                int wordIndex = selectedWord.IndexOf(userInput);
                // call caleb's method
                Console.WriteLine(wordIndex);
                Console.WriteLine(selectedWord[wordIndex]);
            }
        }
    }
}