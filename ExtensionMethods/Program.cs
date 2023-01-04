using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "This is a demo";
            demo.PrintToConsole();
            SimpleLogger logger = new();
            logger.LogError("Error occured");
            logger.LogWarning("This is a warning");
            GenericClass<string> c = new();
            c.num = "rarg";
            System.Console.WriteLine(c.num);
        }
        
    }

    public class GenericClass<T>
    {
        public T? num { get; set; }
    }

    public static class ExtendSimpleLogger
    {
        public static void LogError(this SimpleLogger logger, string text)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(text, "Error");
            Console.ForegroundColor = defaultColor;
        }

        public static void LogWarning(this SimpleLogger logger, string text)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(text, "Warning");
            Console.ForegroundColor = defaultColor;
        }
    }
}
