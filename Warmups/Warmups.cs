using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
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
            //Console.WriteLine("Dean's Strings Warmups:\n");
            //Strings Warmups
            //Console.WriteLine(prog.SayHi("Dean"));
            //Console.WriteLine(prog.Abba("YOLO", "BRO"));
            //Console.WriteLine(prog.MakeTags("tagz", "Contento"));
            //Console.WriteLine(prog.InsertWord("[[]]", "DANK"));
            //Console.WriteLine(prog.MultipleEndings("Super"));
            //Console.WriteLine(prog.FirstHalf("WhereAreYou?"));
            //Console.WriteLine(prog.TrimOne("Danking"));
            //Console.WriteLine(prog.LongInMiddle("Baller", "time"));
            //Console.WriteLine(prog.RotateLeft2("kawaii"));
            //Console.WriteLine(prog.RotateRight2("Swagerific"));
            //Console.WriteLine(prog.TakeOne("Cleveland", false));
            //Console.WriteLine(prog.MiddleTwo("DeanChoi"));
            //Console.WriteLine(prog.EndsWithLy("Holy Moly"));
            //Console.WriteLine(prog.FrontAndBack("LeBronJames", 3));
            //Console.WriteLine(prog.TakeTwoFromPosition("Danking", 2));
            //Console.WriteLine(prog.HasBad("xbadassery"));
            //Console.WriteLine(prog.AtFirst("hello"));
            //Console.WriteLine(prog.LastChars("YOLO", "totally"));
            //Console.WriteLine(prog.ConCat("abcd", "defg"));
            //Console.WriteLine(prog.SwapLast("coding"));
            //Console.WriteLine(prog.FrontAgain("edited"));
            //Console.WriteLine(prog.MinCat("Hello", "java"));
            //Console.WriteLine(prog.TweakFront("abedcf"));
            //Console.WriteLine(prog.StripX("xHxix"));

            //Conditionals Warmups
            //Console.WriteLine("\nDean's Conditionals Warmups:\n");
            //Console.WriteLine(prog.AreWeInTrouble(true, true));
            //Console.WriteLine(prog.CanSleepIn(true, false));
            //Console.WriteLine(prog.SumDouble(2, 2));
            //Console.WriteLine(prog.Diff21(23));
            //Console.WriteLine(prog.ParrotTrouble(true, 6));
            //Console.WriteLine(prog.Makes10(1, 9));
            //Console.WriteLine(prog.NearHundred(198));
            //Console.WriteLine(prog.PosNeg(-4, -5, true));
            //Console.WriteLine(prog.NotString("candy"));
            //Console.WriteLine(prog.MissingChar("kitten", 1));
            //Console.WriteLine(prog.FrontBack("deanzel"));
            //Console.WriteLine(prog.Front3("Microsoft"));
            //Console.WriteLine(prog.BackAround("Hello"));
            //Console.WriteLine(prog.Multiple3or5(10));
            //Console.WriteLine(prog.StartHi("high up"));
            //Console.WriteLine(prog.IcyHot(120, -1));
            //Console.WriteLine(prog.Between10and20(12, 99));
            //Console.WriteLine(prog.HasTeen(20, 19, 10));
            //Console.WriteLine(prog.SoAlone(13, 13));
            //Console.WriteLine(prog.RemoveDel("adeldank"));
            //Console.WriteLine(prog.IxStart("mix booze"));
            //Console.WriteLine(prog.StartOz("ozymandias"));
            //Console.WriteLine(prog.Max(1, 3, 2));
            //Console.WriteLine(prog.Closer(13, 7));
            //Console.WriteLine(prog.GotE("Heelle"));
            //Console.WriteLine(prog.EndUp("hi there"));
            //Console.WriteLine(prog.EveryNth("Miracle", 2));

            //Loops Warmups
            //Console.WriteLine("Dean's Loops Warmups:\n");
            //Console.WriteLine(prog.StringTimes("Yolo", 3));
            //Console.WriteLine(prog.FrontTimes("Chocolate", 3));
            //Console.WriteLine(prog.CountXX("xxxDx"));
            //Console.WriteLine(prog.DoubleX("axxbb"));
            //Console.WriteLine(prog.EveryOther("Heeololeo"));
            //Console.WriteLine(prog.StringSplosion("Code"));
            //Console.WriteLine(prog.CountLast2("axxxaaxx"));
            //Console.WriteLine(prog.Count9(new int[] {1, 9, 9, 3, 9}));
            //Console.WriteLine(prog.ArrayFront9(new int[] {1, 2, 9, 3, 4}));
            //Console.WriteLine(prog.Array123(new int[] {1, 1, 2, 3, 1}));
            //Console.WriteLine(prog.SubStringMatch("xxcaazz", "xxbaaz"));
            //Console.WriteLine(prog.StringX("xxHxix"));
            //Console.WriteLine(prog.AltPairs("Chocolate"));
            //Console.WriteLine(prog.DoNotYak("yak123ya"));
            //Console.WriteLine(prog.Array667(new int[] {6, 7, 2, 6}));
            //Console.WriteLine(prog.NoTriples(new int[] {1, 1, 2, 2, 2, 1}));
            //Console.WriteLine(prog.Pattern51(new int[] {1, 2, 7, 1, 1}));

            //Logic Warmups
            //Console.WriteLine("Dean's Logic Warmups:\n");
            //Console.WriteLine(prog.GreatParty(50, false));
            //Console.WriteLine(prog.CanHazTable(5, 10));
            //Console.WriteLine(prog.PlayOutside(95, true));
            //Console.WriteLine(prog.CaughtSpeeding(65, false));
            //Console.WriteLine(prog.SkipSum(9, 4));
            //Console.WriteLine(prog.AlarmClock(1, false));
            //Console.WriteLine(prog.LoveSix(1, 5));
            //Console.WriteLine(prog.InRange(11, true));
            //Console.WriteLine(prog.SpecialEleven(23));
            //Console.WriteLine(prog.Mod20(20));
            //Console.WriteLine(prog.Mod35(10));
            //Console.WriteLine(prog.AnswerCell(true, false, false));
            //Console.WriteLine(prog.TwoIsOne(3, 1, 2));
            //Console.WriteLine(prog.AreInOrder(1, 2, 4, false));
            //Console.WriteLine(prog.InOrderEqual(2, 5, 11, false));
            //Console.WriteLine(prog.LastDigit(23, 19, 13));
            //Console.WriteLine(prog.RollDice(3, 3, false));

            //Arrays Warmups
            Console.WriteLine("Dean's Arrays Warmups:\n");
            //Console.WriteLine(prog.FirstLast6(new int[] {6, 1, 2, 3}));
            //Console.WriteLine(prog.SameFirstLast(new int[] {1, 2, 3, 1}));
            //Console.WriteLine(prog.MakePi(3));
            //Console.WriteLine(prog.CommonEnd(new int[] {1, 2, 3}, new int[] {7, 3}));
            //Console.WriteLine(prog.Sum(new int[] {1, 2, 3}));
            //Console.WriteLine(prog.RotateLeft(new int[] { 1, 2, 3 }));
            //Console.WriteLine(prog.Reverse(new int[] {1, 2, 3, 4}));
            
            //Rest didn't need or display a Console.WriteLine
            Console.ReadLine();
        }

        //Strings Warmups:

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



        //Conditionals Warmups:

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
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return a*4;
            }
            else
            {
                return a + b;
            }
        }

        //4. Diif21
        public int Diff21(int n)
        {
            if (n > 21)
            {
                return (n - 21)*2;
            }
            else
            {
                return 21 - n;
            }
        }

        //5. ParrotTrouble
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking == true && (hour < 7 || hour > 20))
            {
                return true;
            }
            return false;
        }

        //6. Makes10
        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10 || a + b == 10)
            {
                return true;
            }
            return false;
        }

        //7. NearHundred
        public bool NearHundred(int n)
        {
            int dif100 = Math.Abs(100 - n);
            int dif200 = Math.Abs(200 - n);
            if (dif100 <= 10 || dif200 <= 10)
            {
                return true;
            }
            return false;
        }

        //8. PosNeg
        public bool PosNeg(int a, int b, bool negative)
        {
            if (negative == true)
            {
                if (a < 0 && b < 0)
                {
                    return true;
                }
                return false;
            }
            else if (a < 0 && b > 0)
            {
                return true;
            }
            else if (a > 0 && b < 0)
            {
                return true;
            }
            else return false;
        }

        //9. NotString
        public string NotString(string s)
        {
            if (s.StartsWith("not") == true)
            {
                return String.Format(s);
            }
            else
            {
                return String.Format("not {0}", s);
            }
        }

        //10. MissingChar
        public string MissingChar(string str, int n)
        {
            return String.Format(str.Remove(n, 1));
        }

        //11. FrontBack
        public string FrontBack(string str)
        {
            if (str.Length <= 1)
            {
                return String.Format(str);
            }
            return String.Format("{0}{1}{2}", str[str.Length - 1], str.Substring(1, str.Length - 2), str[0]);
        }

        //12. Front3
        public string Front3(string str)
        {
            if (str.Length >= 3)
            {
                return String.Format("{0}{0}{0}", str.Substring(0, 3));
            }
            else
            {
                return String.Format(str + str + str);
            }
        }

        //13. BackAround
        public string BackAround(string str)
        {
            return String.Format("{0}{1}{0}", str[str.Length - 1], str);
        }

        //14. Multiple3or5
        public bool Multiple3or5(int number)
        {
            if (number%3 == 0 || number%5 == 0)
            {
                return true;
            }
            else return false;
        }

        //15. StartHi
        public bool StartHi(string str)
        {
            if (str.Length == 2)
            {
                if (str == "hi")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (str.Substring(0, 3) == "hi ")
            {
                return true;
            }
            return false;
        }

        //16. IcyHot
        public bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0))
            {
                return true;
            }
            return false;
        }

        //17. Between10and20
        public bool Between10and20(int a, int b)
        {
            if ((a <= 20 && a >= 10) || (b <= 20 && b >= 10))
            {
                return true;
            }
            return false;
        }

        //18. HasTeen
        public bool HasTeen(int a, int b, int c)
        {
            if ((a <= 19 && a >= 13) || (b <= 19 && b >= 13) || (c <= 19 && c >= 13))
            {
                return true;
            }
            return false;
        }

        //19. SoAlone
        public bool SoAlone(int a, int b)
        {
            if (((a <= 19 && a >= 13) && (b > 19 || b < 13)) || ((b <= 19 && b >= 13) && (a > 19 || a < 13)))
            {
                return true;
            }
            return false;
        }

        //20. RemoveDel
        public string RemoveDel(string str)
        {
            if (str.IndexOf("del") == 1)
            {
                return String.Format("{0}{1}", str.Substring(0, 1), str.Substring(4));
            }
            return str;
        }

        //21. IxStart
        public bool IxStart(string str)
        {
            if (str.Substring(1, 2) == "ix")
            {
                return true;
            }
            return false;
        }

        //22. StartOz
        public string StartOz(string str)
        {
            if (str.Substring(0, 2) == "oz")
            {
                return "oz";
            }
            else if (str.Substring(0, 1) == "o")
            {
                return "o";
            }
            else if (str.Substring(1, 1) == "z")
            {
                return "z";
            }
            else
            {
                return String.Format(str.Substring(0, 2));
            }
        }

        //23. Max
        public int Max(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if
                (b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        //24. Closer
        public int Closer(int a, int b)
        {
            if (Math.Abs(10 - a) > Math.Abs(10 - b))
            {
                return b;
            }
            else if (Math.Abs(10 - b) > Math.Abs(10 - a))
            {
                return a;
            }
            return 0;
        }

        //25. EEEEEEE
        public bool GotE(string str)
        {
            char[] array = str.ToCharArray();
            int numE = 0;

            foreach (char c in array)
            {
                if (c == 'e')
                {
                    numE++;
                }
            }

            if (numE <= 3 && numE >= 1)
            {
                return true;
            }
            return false;
        }

        //26. EndUp
        public string EndUp(string str)
        {
            if (str.Length > 3)
            {
                return String.Format("{0}{1}", str.Substring(0, str.Length - 3), str.Substring(str.Length - 3).ToUpper());
            }
            else
            {
                return str.ToUpper();
            }
        }

        //27. EveryNth
        public string EveryNth(string str, int n)
        {
            string finalString = str.Substring(0, 1);

            for (int i = n; i < str.Length; i += n)
            {
                finalString += str.Substring(i, 1);
            }

            return finalString;
        }




        //Loops Warmups:

        //1. StringTimes
        public string StringTimes(string str, int n)
        {
            string finalString = "";

            for (int i = 1; i <= n; i++)
            {
                finalString += str;
            }
            return finalString;
        }

        //2. FrontTimes
        public string FrontTimes(string str, int n)
        {
            string finalString = "";

            if (str.Length > 3)
            {
                for (int i = 1; i <= n; i++)
                {
                    finalString += str.Substring(0, 3);
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    finalString += str;
                }
            }

            return finalString;
        }

        //3. CountXX
        public int CountXX(string str)
        {
            int x = 0;
            int xCount = 0;

            while (x < str.Length - 1)
            {
                if (str.Substring(x, 2) == "xx")
                {
                    xCount++;
                }
                x++;
            }
            return xCount;
        }

        //4. DoubleX
        public bool DoubleX(string str)
        {
            if (str.Substring(str.IndexOf('x'), 2) == "xx")
            {
                return true;
            }
            return false;
        }

        //5. EveryOther
        public string EveryOther(string str)
        {
            string finalString = "";

            for (int i = 0; i < str.Length; i += 2)
            {
                finalString += str.Substring(i, 1);
            }
            return finalString;
        }

        //6. StringSplosion
        public string StringSplosion(string str)
        {
            string finalString = "";

            for (int i = 0; i < str.Length; i++)
            {
                finalString += str.Substring(0, i + 1);
            }
            return finalString;
        }

        //7. CountLast2
        public int CountLast2(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == str.Substring(str.Length - 2, 2))
                {
                    count++;
                }
            }
            return count;
        }

        //8. Count9
        public int Count9(int[] numbers)
        {
            int count = 0;

            foreach (int i in numbers)
            {
                if (i == 9)
                {
                    count++;
                }
            }
            return count;
        }

        //9. ArrayFront9
        public bool ArrayFront9(int[] numbers)
        {

            for (int i = 0; i < 4; i++)
            {
                if (numbers[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }

        //10. Array123
        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 2] == 3 && numbers[i + 1] == 2 && numbers[i] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        //11. SubStringMatch
        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            int i = 0;

            while (i < a.Length - 1 && i < b.Length - 1)
            {
                if (a.Substring(i, 2) == b.Substring(i, 2))
                {
                    count++;
                }
                i++;
            }
            return count;
        }

        //12. StringX
        public string StringX(string str)
        {
            string finalString = "";

            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 1) != "x")
                {
                    finalString += str.Substring(i, 1);
                }
            }

            return String.Format("{0}{1}{2}", str.Substring(0, 1), finalString, str.Substring(str.Length - 1, 1));
        }

        //13. AltPairs
        public string AltPairs(string str)
        {
            string finalString = "";

            for (int i = 0; i < str.Length - 1; i += 4)
            {
                finalString += str.Substring(i, 2);
            }
            if (str.Length%4 == 1)
            {
                finalString += str.Substring(str.Length - 1);
            }
            return finalString;
        }

        //14. DoNotYak
        public string DoNotYak(string str)
        {
            string finalString = "";

            for (int i = 0; i < str.Length - 3; i++)
            {
                if (str[i] == 'y' && str[i + 2] == 'k')
                {
                    finalString += "";
                    i += 2;
                }
                else finalString += str.Substring(i, 1);
            }
            if (str[str.Length - 3] == 'y' && str[str.Length - 1] == 'k')
            {
                return finalString;
            }
            else
            {
                finalString += str.Substring(str.Length - 3);
            }
            return finalString;

        }

        //15. Array667
        public int Array667(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    count++;
                }
            }
            return count;
        }

        //16. NoTriples
        public bool NoTriples(int[] numbers)
        {
            bool hasNoTriples = true;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    hasNoTriples = false;
                    break;
                }
            }
            return hasNoTriples;
        }

        //17. Pattern51
        public bool Pattern51(int[] numbers)
        {
            bool hasPattern = false;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == (numbers[i + 1] - 5) && numbers[i] == (numbers[i + 2] + 1))
                {
                    hasPattern = true;
                    break;
                }
            }
            return hasPattern;
        }




        //Logic Warmups:

        //1. GreatParty
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend == false)
            {
                if (cigars >= 40 && cigars <= 60)
                {
                    return true;
                }
                return false;
            }
            if (cigars >= 40)
            {
                return true;
            }
            return false;
        }

        //2. CanHazTable
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else if (yourStyle >= 8 || dateStyle > 8)
            {
                return 2;
            }
            return 1;
        }

        //3. PlayOutside
        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer == true)
            {
                if (temp >= 60 && temp <= 100)
                {
                    return true;
                }
                return false;
            }
            if (temp >= 60 && temp <= 90)
            {
                return true;
            }
            return false;
        }

        //4. CaughtSpeeding
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday == true)
            {
                if (speed <= 65)
                {
                    return 0;
                }
                if (speed <= 85 && speed > 65)
                {
                    return 1;
                }
                return 2;
            }
            if (speed <= 60)
            {
                return 0;
            }
            if (speed <= 80 && speed > 60)
            {
                return 1;
            }
            return 2;
        }

        //5. SkipSum
        public int SkipSum(int a, int b)
        {
            if (a + b >= 10 && a + b <= 19)
            {
                return 20;
            }
            return a + b;
        }

        //6. AlarmClock
        public string AlarmClock(int day, bool vacation)
        {
            if (vacation == true)
            {
                if (day == 0 || day == 6)
                {
                    return "off";
                }
                return "10:00";
            }
            if (day == 0 || day == 6)
            {
                return "10:00";
            }
            return "7:00";
        }

        //7. LoveSix
        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6)
            {
                return true;
            }
            if (a + b == 6 || Math.Abs(a - b) == 6)
            {
                return true;
            }
            return false;
        }

        //8. InRange
        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode == true)
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }
                return false;
            }
            if (n >= 1 && n <= 10)
            {
                return true;
            }
            return false;
        }

        //9. SpecialEleven
        public bool SpecialEleven(int n)
        {
            if (n%11 == 0 || n%11 == 1)
            {
                return true;
            }
            return false;
        }

        //10. Mod20
        public bool Mod20(int n)
        {
            if (n%20 == 1 || n%20 == 2)
            {
                return true;
            }
            return false;
        }

        //11. Mod35
        public bool Mod35(int n)
        {
            if ((n%3 == 0 && n%5 != 0) || (n%5 == 0 && n%3 != 0))
            {
                return true;
            }
            return false;
        }

        //12. AnswerCell
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }
            if (isMom)
            {
                return true;
            }
            if (!isMorning)
            {
                return true;
            }
            return false;
        }

        //13. TwoIsOne
        public bool TwoIsOne(int a, int b, int c)
        {
            if ((a == b + c) || (b == a + b) || (c == a + b))
            {
                return true;
            }
            return false;
        }

        //14. AreInOrder
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (bOk)
            {
                if (c > b)
                {
                    return true;
                }
            }
            if (b > a && c > b)
            {
                return true;
            }
            return false;
        }

        //15. InOrderEqual
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
            {
                if (a <= b && b <= c)
                {
                    return true;
                }
            }
            if (a < b && b < c)
            {
                return true;
            }
            return false;
        }

        //16. LastDigit
        public bool LastDigit(int a, int b, int c)
        {
            if (a%10 == b%10 || a%10 == c%10 || b%10 == c%10)
            {
                return true;
            }
            return false;
        }

        //17. RollDice
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == 6 && die2 == 6)
                {
                    return 7;
                }
                if (die1 == die2)
                {
                    return die1 + die2 + 1;
                }
            }
            return die1 + die2;
        }



        //Arrays Warmups:

        //1. FirstLast6
        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }
            return false;
        }

        //2. SameFirstLast
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1)
            {
                if (numbers[0] == numbers[numbers.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }

        //3. MakePi
        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            int[] piArray = new int[n];
            string piIterated = "";

            for (int i = 0; i < n; i++)
            {
                double digitD = pi*Math.Pow(10, i);
                int digitI = (int) Math.Floor(digitD);
                int digitIm = digitI%10;
                piArray[i] = digitIm;
            }
            return piArray;
        }

        //4. CommonEnd
        public bool CommonEnd(int[] a, int[] b)
        {
            if ((a[0] == b[0]) || (a[a.Length - 1] == b[b.Length - 1]))
            {
                return true;
            }
            return false;
        }

        //5. Sum
        public int Sum(int[] numbers)
        {
            int sumAll = 0;

            foreach (int i in numbers)
            {
                sumAll += i;
            }
            return sumAll;
        }

        //6. RotateLeft
        public int[] RotateLeft(int[] numbers)
        {
            int[] LeftArray = new int[numbers.Length];

            LeftArray[numbers.Length - 1] = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                LeftArray[i] = numbers[i + 1];
            }
            return LeftArray;
        }

        //7. Reverse
        public int[] Reverse(int[] numbers)
        {
            int[] ReverseArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                ReverseArray[i] = numbers[numbers.Length - 1 - i];
            }
            return ReverseArray;
        }

        //8. HigherWins
        public int[] HigherWins(int[] numbers)
        {
            int[] NewArray = new int[numbers.Length];

            if (numbers[0] >= numbers[numbers.Length - 1])
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    NewArray[i] = numbers[0];
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    NewArray[i] = numbers[numbers.Length - 1];
                }
            }
            return NewArray;
        }

        //9. GetMiddle
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] NewArray = new int[2];
            NewArray[0] = a[1];
            NewArray[1] = b[1];
            return NewArray;
        }

        //10. HasEven
        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //11. KeepLast
        public int[] KeepLast(int[] numbers)
        {
            int[] NewArray = new int[numbers.Length*2];

            for (int i = 0; i < (numbers.Length*2) - 1; i++)
            {
                NewArray[i] = 0;
            }
            NewArray[(numbers.Length*2) - 1] = numbers[numbers.Length - 1];

            return NewArray;
        }

        //12. Double23
        public bool Double23(int[] numbers)
        {
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    count2++;
                }
                if (numbers[i] == 3)
                {
                    count3++;
                }
            }
            if (count2 == 2 || count3 == 2)
            {
                return true;
            }
            return false;
        }

        //13. Fix23
        public int[] Fix23(int[] numbers)
        {
            int[] NewArray = new int[3];
            NewArray = numbers;
            if (numbers[0] == 2 && numbers[1] == 3)
            {
                NewArray[1] = 0;
            }
            if (numbers[1] == 2 && numbers[2] == 3)
            {
                NewArray[2] = 0;
            }
            return NewArray;
        }

        //14. Unlucky1
        public bool Unlucky1(int[] numbers)
        {
            if (numbers.Length == 2)
            {
                if (numbers[0] == 1 && numbers[1] == 3)
                {
                    return true;
                }
                return false;
            }

            if ((numbers[0] == 1 && numbers[1] == 3) || (numbers[1] == 1 && numbers[2] == 3) ||
                (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3))
            {
                return true;
            }
            return false;
        }

        //15. Make2
        public int[] Make2(int[] a, int[] b)
        {
            int[] NewArray = new int[2];

            if (a.Length >= 2)
            {
                NewArray[0] = a[0];
                NewArray[1] = a[1];
            }
            if (a.Length == 1)
            {
                NewArray[0] = a[0];
                NewArray[1] = b[0];
            }
            if (a.Length == 0)
            {
                NewArray[0] = b[0];
                NewArray[1] = b[1];
            }
            return NewArray;
        }
    }
}