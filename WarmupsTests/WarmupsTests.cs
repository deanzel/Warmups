using System;
using Warmups;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupsTests
{

    [TestFixture]
    public class WarmupsTests
    {
        private Warmup Testwarmup;
         
        [SetUp]
        public void BeforeEachTest()
        {
            Testwarmup = new Warmup();
            Console.WriteLine("SetUp Called.");
        }

        //Strings Tests:

        //1. SayHi Test Case
        [TestCase("Dean", "Hello Dean!")]
        public void SayHi(string inputString, string expectedString)
        {
            string resultString = Testwarmup.SayHi(inputString);
            Assert.AreEqual(resultString, expectedString);
        }

        //2. Abba Test Case
        [TestCase("YOLO", "BRO", "YOLOBROBROYOLO")]
        public void Abba(string a, string b, string expectedString)
        {
            string resultString = Testwarmup.Abba(a, b);
            Assert.AreEqual(resultString, expectedString);
        }

        //3. MakeTags Test Case
        [TestCase("tagz", "Contento", "<tagz>Contento</tagz>")]
        public void MakeTags(string tag, string content, string expected)
        {
            string resultString = Testwarmup.MakeTags(tag, content);
            Assert.AreEqual(resultString, expected);
        }

        //4. InsertWord
        [TestCase("[[]]", "DANK", "[[DANK]]")]
        public void InsertWord(string a, string b, string expected)
        {
            string result = Testwarmup.InsertWord(a, b);
            Assert.AreEqual(result, expected);
        }
        //5. MultipleEndings
        [TestCase("Super", "ererer")]
        public void MultipleEndings(string a, string expected)
        {
            string result = Testwarmup.MultipleEndings(a);
            Assert.AreEqual(result, expected);
        }
        //6. FirstHalf
        [TestCase("WhereAreYou?", "WhereA")]
        public void FirstHalf(string a, string expected)
        {
            string result = Testwarmup.FirstHalf(a);
            Assert.AreEqual(result, expected);
        }
        //7. TrimOne
        [TestCase("Danking", "ankin")]
        public void TrimOne(string a, string expected)
        {
            string result = Testwarmup.TrimOne(a);
            Assert.AreEqual(result, expected);
        }
        //8. LongInMiddle
        [TestCase("Baller", "time", "timeBallertime")]
        public void LongInMiddle(string a, string b, string expected)
        {
            string result = Testwarmup.LongInMiddle(a, b);
            Assert.AreEqual(result, expected);
        }
        //9. Rotateleft2
        [TestCase("kawaii", "waiika")]
        public void Rotateleft2(string a, string expected)
        {
            string result = Testwarmup.Rotateleft2(a);
            Assert.AreEqual(result, expected);
        }
    }
}



