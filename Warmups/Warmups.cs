﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Warmup
    {
        private static void Main(string[] args)
        {
            Warmup prog = new Warmup();
            Console.WriteLine("Dean's Strings Warmups:\n");
            //Strings Warmups
            Console.WriteLine(prog.SayHi("Dean"));
            Console.WriteLine(prog.Abba("YOLO", "BRO"));
            Console.WriteLine(prog.MakeTags("tagz", "Contento"));
            Console.WriteLine(prog.InsertWord("[[]]", "DANK"));
            Console.WriteLine(prog.MultipleEndings("Super"));
            Console.WriteLine(prog.FirstHalf("WhereAreYou?"));
            Console.WriteLine(prog.TrimOne("Danking"));
            Console.WriteLine(prog.LongInMiddle("Baller", "time"));
            Console.WriteLine(prog.Rotateleft2("kawaii"));

            Console.ReadLine();
        }

        //1. SayHi
        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        //2. Abba
        public string Abba(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);
        }

        //3. MakeTags
        public string MakeTags(string tag, string content)
        {
            return string.Format("<{0}>{1}</{0}>", tag, content);
        }

        //4. InsertWord
        public string InsertWord(string container, string word)
        {
            return string.Format("{0}{1}{4}{2}{3}", container[0], container[1], container[2],
                container[3], word);
        }

        //5. MultipleEndings
        public string MultipleEndings(string str)
        {
            return string.Format("{0}{1}{0}{1}{0}{1}", str[str.Length - 2], str[str.Length - 1]);
        }

        //6. FirstHalf
        public string FirstHalf(string str)
        {
            return string.Format("{0}", str.Substring(0, str.Length/2));
        }

        //7. TrimOne
        public string TrimOne(string str)
        {
            return string.Format("{0}", str.Substring(1, str.Length - 2));
        }

        //8. LongInMiddle
        public string LongInMiddle(string a, string b)
        {
            //string answer;
            if (a.Length > b.Length)
            {
                return string.Format("{1}{0}{1}", a, b);
            }

            else
            {
                return string.Format("{0}{1}{0}", a, b);
            }
        }

        //9. Rotateleft2
        public string Rotateleft2(string str)
        {
            return string.Format("{0}{1}", str.Substring(2, str.Length - 2), str.Substring(0, 2));
        }
    }
}
