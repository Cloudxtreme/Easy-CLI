using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIFoundation
{
    /// <summary>
    /// Some useful text functions
    /// </summary>
    public sealed class T
    {
        /// <summary>
        /// Output text with CRLF
        /// </summary>
        /// <param name="text"></param>
        public static void PrintLn(String text)
        {
            System.Console.WriteLine(text);
        }

        /// <summary>
        /// Output text without CRLF
        /// </summary>
        /// <param name="text"></param>
        public static void Print(String text)
        {
            System.Console.Write(text);
        }

        /// <summary>
        /// Print out blank line with CRLF
        /// </summary>
        public static void Blank()
        {
            T.PrintLn("");
        }

        /// <summary>
        /// Wrapper for System.Console.ReadLine()
        /// </summary>
        /// <returns></returns>
        public static String ReadLine()
        {
            String input = System.Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Print out the colorful command prompt
        /// </summary>
        public static void Prompt()
        {
            C.fore("Green");
            T.Print("!#");
            C.fore("Cyan");
            T.Print("> ");
            C.reset();
        }
    }
}
