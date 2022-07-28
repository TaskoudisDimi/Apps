using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrambler.Data;

namespace WordUnscrambler.Workers
{
    public class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {

            var matchedWords = new List<MatchedWord>();

            foreach(var scrambled in scrambledWords)
            {
                foreach(var word in wordList)
                {
                    if (scrambled.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambled, word));
                    }
                    else
                    {
                        var scrambledWordArray = scrambled.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordArray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambled, word));

                        }

                    }
                }
            }


            return matchedWords;
            
        }


        private MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord();
            matchedWord.ScrambledWord = scrambledWord;
            matchedWord.Word = word;
            return matchedWord;

        }
    }
}









