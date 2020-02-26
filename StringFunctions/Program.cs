using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ryan";

            string quote = "A man said, \"What up, my dude\".\nI was \\ like\tYOOOOOOOO!!";
            Console.WriteLine(quote);

            // Use @ to tell C# to ignore escape sequences.
            string filename = @"C:\Users\Ryan";
            Console.WriteLine(filename);

            bool tOrf = name.Contains("s");
            Console.WriteLine(tOrf);

            tOrf = name.EndsWith("n");
            Console.WriteLine(tOrf);

            Console.WriteLine(filename.Length);

            Console.WriteLine(name.ToUpper());

            Console.WriteLine(name.ToLower() + "\n\n\n");

            // Strings are immutable.  When you 'change' a string, you are really creating a new string.
            // StringBuilder fixes this.

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ryan");
            Console.WriteLine(sb);

            Console.Read();

        }
    }
}
