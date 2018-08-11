using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Program
    {
        private static AnswerStrategy _answerStrategy;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the chat bot application! Ask your questions!");
            Console.WriteLine("To close the app please type 'exit' ");
            string baseDirPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirPath, "Answers.txt");
            _answerStrategy = new UpseqStrategy(filePath);
            while (true)
            {
                Console.Write("[you]: ");
                string question = Console.ReadLine();
                if (question == "exit")
                    break;
                Console.WriteLine();              
                Console.Write("[bot]: ");
                string answer = _answerStrategy.GetAnswer();
                Console.WriteLine(answer);
            }
        }
    }
}
