using NUnit.Framework;
using System;

namespace ChatBot.Tests
{
    [TestFixture]
    public class AnswersServiceTests
    {
        [Test]
        public void TakeAnswerTest()
        {
            //arrange

            string fileContent = "> cat answers.txt " + "\n> Привет! Как жизнь? ";
            string[] lines = fileContent.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
            IAnswersService service = new UpseqAnswersService();

            //act

            service.LoadContent(fileContent);

            string actual = service.TakeAnswer();
            string actual2 = service.TakeAnswer();
            string actual3 = service.TakeAnswer();
            string expected = lines[0];
            string expected2 = lines[1];
            string expected3 = lines[0];

            //assert

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}