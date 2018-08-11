using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{    
    public interface IAnswersService
    {
        void LoadContent(string fileContent);
        string TakeAnswer();
    }
}
