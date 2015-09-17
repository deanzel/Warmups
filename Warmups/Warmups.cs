using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Warmup
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Dean's Strings Warmups:\n");
            SayHi("Dean");
            Abba("Hello", "Goodbye");
            MakeTags("tag", "Things");
            InsertWord("<<>>", "YOLO");
            MultipleEndings("Hello");

            Console.ReadLine();

        }

        public static void SayHi(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }

        public static void Abba(string a, string b)
        {
            Console.WriteLine("{0}{1}{1}{0}", a, b);
        }

        public static void MakeTags(string tag, string content)
        {
            Console.WriteLine("<{0}>{1}</{0}>", tag, content);
        }

        public static void InsertWord(string container, string word)
        {
            Console.WriteLine("{0}{1}{4}{2}{3}", container[0], container[1], container[2], container[3], word);
        }

        public static void MultipleEndings(string str)
        {
            Console.WriteLine("{0}{1}{0}{1}{0}{1}", str[str.Length - 2], str[str.Length - 1]);

        }
    }
}

