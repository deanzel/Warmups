using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

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
            Console.WriteLine(prog.RotateLeft2("kawaii"));
            Console.WriteLine(prog.RotateRight2("Swagerific"));
            Console.WriteLine(prog.TakeOne("Cleveland", false));
            Console.WriteLine(prog.MiddleTwo("DeanChoi"));
            Console.WriteLine(prog.EndsWithLy("Holy Moly"));
            Console.WriteLine(prog.FrontAndBack("LeBronJames", 3));
            Console.WriteLine(prog.TakeTwoFromPosition("Danking", 2));
            Console.WriteLine(prog.HasBad("xbadassery"));
            Console.WriteLine(prog.AtFirst("hello"));
            Console.WriteLine(prog.LastChars("YOLO", "totally"));
            Console.WriteLine(prog.ConCat("abcd", "defg"));
            Console.WriteLine(prog.SwapLast("coding"));
            Console.WriteLine(prog.FrontAgain("edited"));
            Console.WriteLine(prog.MinCat("Hello", "java"));
            Console.WriteLine(prog.TweakFront("abedcf"));
            Console.WriteLine(prog.StripX("xHxix"));

            //Conditionals Warmups
            Console.WriteLine("\nDean's Conditionals Warmups:\n");
            Console.WriteLine(prog.AreWeInTrouble(true, true));
            Console.WriteLine(prog.CanSleepIn(true, false));


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

        //9. RotateLeft2
        public string RotateLeft2(string str)
        {
            return string.Format("{0}{1}", str.Substring(2, str.Length - 2), str.Substring(0, 2));
        }

        //10. RotateRight2
        public string RotateRight2(string str)
        {
            return string.Format("{0}{1}", str.Substring(str.Length - 2, 2), str.Substring(0, str.Length - 2));
        }

        //11. TakeOne (used ToCharArray method for fun instead of SubString)
        public char TakeOne(string str, bool fromFront)
        {
            char[] strArray = str.ToCharArray();
            if (fromFront == true)
            {
                char firstLetter = strArray[0];
                return firstLetter;
            }

            else
            {
                char lastLetter = strArray[str.Length - 1];
                return lastLetter;
            }
        }

        //12. MiddleTwo
        public string MiddleTwo(string str)
        {
            return string.Format(str.Substring(str.Length/2 - 1, 2));
        }

        //13. EndsWithLy
        public bool EndsWithLy(string str)
        {
            if (str.EndsWith("ly"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //14. FrontAndBack
        public string FrontAndBack(string str, int n)
        {
            return String.Format("{0}{1}", str.Substring(0, n), str.Substring(str.Length - 3, n));
        }

        //15. TakeTwoFromPosition
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n > str.Length - 2 || n < 0)
            {
                return String.Format(str.Substring(0, 2));
            }
            else
            {
                return String.Format(str.Substring(n, 2));
            }
        }

        //16. HasBad
        public bool HasBad(string str)
        {
            if (str.IndexOf("bad") == 0 || str.IndexOf("bad") == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //17. AtFirst
        public string AtFirst(string str)
        {
            if (str.Length == 1)
            {
                return String.Format("{0}@", str.Substring(0, 1));
            }
            else if (str.Length == 0)
            {
                return String.Format("@@");
            }
            else
            {
                return String.Format(str.Substring(0, 2));
            }
        }

        //18. LastChars
        public string LastChars(string strA, string strB)
        {
            if (strA == "" && strB != "")
            {
                return String.Format("@{0}", strB.Substring(strB.Length - 1));
            }
            else if (strB == "" && strA != "")
            {
                return String.Format("{0}@", strA.Substring(0, 1));
            }
            else
            {
                return String.Format("{0}{1}", strA.Substring(0, 1), strB.Substring(strB.Length - 1));
            }
        }

        //19. Concat
        public string ConCat(string a, string b)
        {
            if (a.Substring(a.Length - 1) == b.Substring(0, 1))
            {
                return String.Format(String.Concat(a, b.Substring(1)));
            }
            else
            {
                return String.Format(String.Concat(a, b));
            }
        }

        //20. SwapLast
        public string SwapLast(string str)
        {
            return String.Format("{0}{1}{2}", str.Substring(0, str.Length - 2), str.Substring(str.Length - 1),
                str.Substring(str.Length - 2, 1));
        }

        //21. FrontAgain
        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == str.Substring(str.Length - 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //22. MinCat
        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return String.Format("{0}{1}", a.Substring(a.Length - b.Length), b);
            }
            else if (b.Length > a.Length)
            {
                return String.Format("{0}{1}", a, b.Substring(b.Length - a.Length));
            }
            else
            {
                return String.Concat(a, b);
            }
        }

        //23. TweakFront
        public string TweakFront(string str)
        {
            if (str.Substring(0, 2) == "ab")
            {
                return String.Format(str);
            }
            else if (str.Substring(0, 1) == "a")
            {
                return String.Format("a{0}", str.Substring(2));
            }
            else if (str.Substring(1, 1) == "b")
            {
                return String.Format(str.Substring(1));
            }
            else
            {
                return String.Format(str.Substring(2));
            }
        }

        //24. StripX
        public string StripX(string str)
        {
            if (str.Substring(0, 1) == "x" && str.Substring(str.Length - 1) == "x")
            {
                return String.Format(str.Substring(1, str.Length - 2));
            }
            else if (str.Substring(0, 1) == "x")
            {
                return String.Format(str.Substring(1));
            }
            else if (str.Substring(str.Length - 1) == "x")
            {
                return String.Format(str.Substring(0, str.Length - 1));
            }
            else
            {
                return String.Format(str);
            }
        }

        //Conditionals Warmups

        //1. MischieviousChildren
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if ((aSmile == true && bSmile == true) || (aSmile == false && bSmile == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //2. SleepingIn
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday == false || isVacation == true)
            {
                return true;
            }
            return false;
        }

        //3. SumDouble
    }
}
