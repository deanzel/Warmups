using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warmups;
using NUnit.Framework;
using System.Threading.Tasks;

namespace WarmupsTests
{
    public class WarmupsTests
    {
        private Warmup _warmup;

        [SetUp]
        public void BeforeEachTest()
        {
            _warmup = new Warmup();
            Console.WriteLine("SetUp Called.");
        }

        [Test]
        public void TestingString(string inputString, string expectedString)
        {
            string resultString = _warump.SayHi(inputString);
            Assert.AreEqual(resultString, expectedString);

        }
        [TestCase("Dean", "Hello Dean!")]



       
    }
}
