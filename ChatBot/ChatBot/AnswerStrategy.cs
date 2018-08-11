using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public abstract class AnswerStrategy
    {

        protected string answersFileContent;
        public AnswerStrategy(string answersFilePath)
        {
            answersFileContent = File.ReadAllText(answersFilePath);
        }
        public abstract string GetAnswer();
    }

    public class UpseqStrategy : AnswerStrategy
    {
        private IAnswersService _answersService;
        public UpseqStrategy(string answersFilePath) : base(answersFilePath)
        {
            _answersService = new UpseqAnswersService();
        }

        public override string GetAnswer()
        {
            string result = String.Empty;
            _answersService.LoadContent(answersFileContent);
            result = _answersService.TakeAnswer();
            return result;
        }
    }

    public class RandStrategy : AnswerStrategy
    {
        public RandStrategy(string answersFilePath) : base(answersFilePath)
        {
        }

        public override string GetAnswer()
        {
            throw new NotImplementedException();
        }
    }


    public class DownseqStrategy : AnswerStrategy
    {
        public DownseqStrategy(string answersFilePath) : base(answersFilePath)
        {
        }

        public override string GetAnswer()
        {
            throw new NotImplementedException();
        }
    }
}
