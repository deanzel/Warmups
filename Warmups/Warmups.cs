using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Warmup
    {
        static void Main(string[] args)
        {
            Warmup prog = new Warmup();
            Console.WriteLine("Dean's Strings Warmups:\n");
            //Strings Warmups
            Console.WriteLine(prog.SayHi("Dean"));
            Console.WriteLine(prog.Abba("YOLO", "BRO"));
            Console.WriteLine(prog.MakeTags("tagz", "Contento"));
            Console.ReadLine();
        }

        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        public string Abba(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);
        }

        public string MakeTags(string tag, string content)
        {
            return string.Format("<{0}>{1}</{0}>", tag, content);
        }
    }
}
