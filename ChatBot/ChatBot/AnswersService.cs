using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChatBot
{
    public class UpseqAnswersService : IAnswersService
    {
        private List<string> _answers = new List<string>();
        private int _counter = 0;

        public void LoadContent(string fileContent)
        {
            string[] lines = fileContent.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
            _answers.AddRange(lines);
        }

        public string TakeAnswer()
        {
            string result = String.Empty;


            if (_counter == _answers.Count())
                _counter = 0;
               
            result = _answers[_counter];
            _counter++;
            return result;
        }
    }
}
