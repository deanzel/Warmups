﻿using System;
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

    }
}



