using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIFoundation
{
    /// <summary>
    /// Some useful color functions
    /// </summary>
    public sealed class C
    {
        /// <summary>
        /// Set the color back to system default
        /// </summary>
        public static void reset() { Console.ResetColor(); }

        /// <summary>
        /// Set the Console.ForeroundColor or exit with error
        /// </summary>
        /// <param name="color">Color to be set</param>
        public static void fore(String color)
        {
            try
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            }
            catch (System.ArgumentException e)
            {
                C.reset();
                C.fore("Red");
                System.Console.WriteLine("No such color (" + color + ")!");
                C.reset();
            }
        }

        /// <summary>
        /// Set the foreground color once, output text and reset
        /// </summary>
        /// <param name="color"></param>
        public static void foreOnce(String color, String text)
        {
            try
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                System.Console.WriteLine(text);
                C.reset();
            }
            catch (System.ArgumentException e)
            {
                C.reset();
                C.fore("Red");
                System.Console.WriteLine("No such color (" + color + ")!");
                C.reset();
            }
        }

        /// <summary>
        /// Set the Console.BackgroundColor
        /// </summary>
        /// <param name="color">Color to be set</param>
        public static void back(String color)
        {
            try
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            }
            catch (System.ArgumentException e)
            {
                C.reset();
                C.fore("Red");
                System.Console.WriteLine("No such color (" + color + ")!");
                C.reset();
            }
        }

        /// <summary>
        /// Set backgroudn color once, output text and reset
        /// </summary>
        /// <param name="color"></param>
        public static void backOne(String color, String text)
        {
            try
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                System.Console.WriteLine(text);
                C.reset();
            }
            catch (System.ArgumentException e)
            {
                C.reset();
                C.fore("Red");
                System.Console.WriteLine("No such color (" + color + ")!");
                C.reset();
            }
        }
    }
}