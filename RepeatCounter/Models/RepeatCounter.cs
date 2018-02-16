using System;
using System.Text;
using System.Collections.Generic;

namespace RepeatCounter.Models
{
    public class RepeatCounter
    {
        private string _inputWord;
        private string _inputSentence;

        public RepeatCounter(string inputWord, string inputSentence)
        {
            _inputWord = inputWord;
            _inputSentence = inputSentence;
        }
    }
}
