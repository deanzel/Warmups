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

        //9. RotateLeft2
        [TestCase("kawaii", "waiika")]
        public void RotateLeft2(string a, string expected)
        {
            string result = Testwarmup.RotateLeft2(a);
            Assert.AreEqual(result, expected);
        }

        //10. RotateRight2
        [TestCase("Swagerific", "icSwagerif")]
        public void RotateRight2(string a, string expected)
        {
            string result = Testwarmup.RotateRight2(a);
            Assert.AreEqual(result, expected);
        }

        //11. TakeOne (used ToCharArray method for fun instead of SubString)
        [TestCase("Cleveland", true, 'C')]
        [TestCase("Cleveland", false, 'd')]
        public void TakeOne(string a, bool fromFront, char expected)
        {
            char result = Testwarmup.TakeOne(a, fromFront);
            Assert.AreEqual(result, expected);
        }

        //12. MiddleTwo
        [TestCase("DeanChoi", "nC")]
        public void MiddleTwo(string a, string expected)
        {
            string result = Testwarmup.MiddleTwo(a);
            Assert.AreEqual(result, expected);
        }

        //13. EndsWithLy
        [TestCase("Holy Moly", true)]
        public void EndsWithLy(string a, bool expected)
        {
            bool result = Testwarmup.EndsWithLy(a);
            Assert.AreEqual(result, expected);
        }

        //14. FrontAndBack
        [TestCase("LeBronJames", 3, "LeBmes")]
        public void FrontAndBack(string a, int n, string expected)
        {
            string result = Testwarmup.FrontAndBack(a, 3);
            Assert.AreEqual(result, expected);
        }

        //15. TakeTwoFromPosition
        [TestCase("Danking", 2, "nk")]
        [TestCase("Danking", 6, "Da")]
        public void TakeTwoFromPosition(string a, int n, string expected)
        {
            string result = Testwarmup.TakeTwoFromPosition(a, n);
            Assert.AreEqual(result, expected);
        }

        //16. HasBad
        [TestCase("xbadassery", true)]
        [TestCase("goinghard", false)]
        public void HasBad(string a, bool expected)
        {
            bool result = Testwarmup.HasBad(a);
            Assert.AreEqual(result, expected);
        }

        //17. AtFirst
        [TestCase("hello", "he")]
        [TestCase("h", "h@")]
        public void AtFirst(string a, string expected)
        {
            string result = Testwarmup.AtFirst(a);
            Assert.AreEqual(result, expected);
        }

        //18. LastChars
        [TestCase("YOLO", "totally", "Yy")]
        [TestCase("h", "", "h@")]
        [TestCase("", "D", "@D")]
        public void LastChars(string a, string b, string expected)
        {
            string result = Testwarmup.LastChars(a, b);
            Assert.AreEqual(result, expected);
        }

        //19. ConCat
        [TestCase("abcd", "defg", "abcdefg")]
        [TestCase("abcd", "efgh", "abcdefgh")]
        public void ConCat(string a, string b, string expected)
        {
            string result = Testwarmup.ConCat(a, b);
            Assert.AreEqual(result, expected);
        }

        //20. SwapLast
        [TestCase("coding", "codign")]
        public void SwapLast(string a, string expected)
        {
            string result = Testwarmup.SwapLast(a);
            Assert.AreEqual(result, expected);
        }

        //21. FrontAgain
        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain(string a, bool expected)
        {
            bool result = Testwarmup.FrontAgain(a);
            Assert.AreEqual(result, expected);
        }

        //22. MinCat
        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCat(string a, string b, string expected)
        {
            string result = Testwarmup.MinCat(a, b);
            Assert.AreEqual(result, expected);
        }

        //23. TweakFront
        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abedcf", "abedcf")]
        public void TweakFront(string a, string expected)
        {
            string result = Testwarmup.TweakFront(a);
            Assert.AreEqual(result, expected);
        }

        //24. StripX
        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripX(string a, string expected)
        {
            string result = Testwarmup.StripX(a);
            Assert.AreEqual(result, expected);
        }

        //Conditionals Tests:

        //1. MischieviousChildren
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTrouble(bool a, bool b, bool expected)
        {
            bool result = Testwarmup.AreWeInTrouble(a, b);
            Assert.AreEqual(result, expected);
        }

        //2. SleepingIn
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepIn(bool a, bool b, bool expected)
        {
            bool result = Testwarmup.CanSleepIn(a, b);
            Assert.AreEqual(result, expected);
        }

        //3. SumDouble
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expected)
        {
            int result = Testwarmup.SumDouble(a, b);
            Assert.AreEqual(result, expected);
        }

        //4. Diff21
        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int a, int expected)
        {
            int result = Testwarmup.Diff21(a);
            Assert.AreEqual(result, expected);
        }

        //5. ParrotTrouble
        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble(bool a, int b, bool expected)
        {
            bool result = Testwarmup.ParrotTrouble(a, b);
            Assert.AreEqual(result, expected);
        }

        //6. Makes10
        [TestCase(9, 10, true)]
        [TestCase(9, 8, false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool expected)
        {
            bool result = Testwarmup.Makes10(a, b);
            Assert.AreEqual(result, expected);
        }

        //7. NearHundred
        [TestCase(103, true)]
        [TestCase(198, true)]
        [TestCase(89, false)]
        public void NearHundred(int a, bool expected)
        {
            bool result = Testwarmup.NearHundred(a);
            Assert.AreEqual(result, expected);
        }

        //8. PosNeg
        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        [TestCase(5, 10, false, false)]
        [TestCase(-1, 1, true, false)]
        public void PosNeg(int a, int b, bool c, bool expected)
        {
            bool result = Testwarmup.PosNeg(a, b, c);
            Assert.AreEqual(result, expected);
        }

        //9. NotString
        [TestCase("candy", "not candy")]
        [TestCase("not bad", "not bad")]
        [TestCase("danknot", "not danknot")]
        public void NotString(string a, string expected)
        {
            string result = Testwarmup.NotString(a);
            Assert.AreEqual(result, expected);
        }

        //10. MissingChar
        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar(string a, int b, string expected)
        {
            string result = Testwarmup.MissingChar(a, b);
            Assert.AreEqual(result, expected);
        }

        //11. FrontBack
        [TestCase("deanzel", "leanzed")]
        [TestCase("code", "eodc")]
        [TestCase("ab", "ba")]
        [TestCase("a", "a")]
        public void FrontBack(string a, string expected)
        {
            string result = Testwarmup.FrontBack(a);
            Assert.AreEqual(result, expected);
        }

        //12. Front3
        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Dankness", "DanDanDan")]
        [TestCase("at", "atatat")]
        public void Front3(string a, string expected)
        {
            string result = Testwarmup.Front3(a);
            Assert.AreEqual(result, expected);
        }

        //13. BackAround
        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround(string a, string expected)
        {
            string result = Testwarmup.BackAround(a);
            Assert.AreEqual(result, expected);
        }

        //14. Multiple3or5
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5(int a, bool expected)
        {
            bool result = Testwarmup.Multiple3or5(a);
            Assert.AreEqual(result, expected);
        }

        //15. StartHi
        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHi(string a, bool expected)
        {
            bool result = Testwarmup.StartHi(a);
            Assert.AreEqual(result, expected);
        }

        //16. IcyHot
        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHot(int a, int b, bool expected)
        {
            bool result = Testwarmup.IcyHot(a, b);
            Assert.AreEqual(result, expected);
        }

        //17. Between10and20
        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20(int a, int b, bool expected)
        {
            bool result = Testwarmup.Between10and20(a, b);
            Assert.AreEqual(result, expected);
        }

        //18. HasTeen
        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeen(int a, int b, int c, bool expected)
        {
            bool result = Testwarmup.HasTeen(a, b, c);
            Assert.AreEqual(result, expected);
        }

        //19. SoAlone
        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAlone(int a, int b, bool expected)
        {
            bool result = Testwarmup.SoAlone(a, b);
            Assert.AreEqual(result, expected);
        }

        //20. RemoveDel
        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDel(string a, string expected)
        {
            string result = Testwarmup.RemoveDel(a);
            Assert.AreEqual(result, expected);
        }

        //21. IxStart
        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart(string a, bool expected)
        {
            bool result = Testwarmup.IxStart(a);
            Assert.AreEqual(result, expected);
        }

        //22. StartOz
        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oboe", "o")]
        [TestCase("Dean", "De")]
        public void StartOz(string a, string expected)
        {
            string result = Testwarmup.StartOz(a);
            Assert.AreEqual(result, expected);
        }

        //23. Max
        [TestCase(1, 2, 3, 3)]
        [TestCase(2, 5, 1, 5)]
        [TestCase(21, 5, 6, 21)]
        public void Max(int a, int b, int c, int expected)
        {
            int result = Testwarmup.Max(a, b, c);
            Assert.AreEqual(result, expected);
        }

        //24. Closer
        [TestCase(13, 7, 0)]
        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        public void Closer(int a, int b, int expected)
        {
            int result = Testwarmup.Closer(a, b);
            Assert.AreEqual(result, expected);

        }

        //25. EEEEEEE
        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotE(string a, bool expected)
        {
            bool result = Testwarmup.GotE(a);
            Assert.AreEqual(result, expected);
        }

        //26. EndUp
        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUp(string a, string expected)
        {
            string result = Testwarmup.EndUp(a);
            Assert.AreEqual(result, expected);
        }

        //27. EveryNth
        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth(string a, int b, string expected)
        {
            string result = Testwarmup.EveryNth(a, b);
            Assert.AreEqual(result, expected);
        }
    }
}



