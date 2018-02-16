using System;
using System.Text;
using System.Collections.Generic;

namespace RepeatCounters.Models
{
    public class RepeatCounter
    {
        private string _inputWord;
        private string _inputSentence;

        public RepeatCounter(string inputWord, string inputSentence)
        {
            _inputWord = inputWord.ToLower();
            _inputSentence = inputSentence.ToLower();
        }

        public int FindRepeats()
        {
            int numberOfRepeats = 0;
            string[] splitSentence = _inputSentence.Split();
            foreach (string word in splitSentence)
            {
                if (word == _inputWord)
                {
                    numberOfRepeats += 1;
                }
            }
            return numberOfRepeats;
        }
    }
}
