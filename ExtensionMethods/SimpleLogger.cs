using System;

namespace ExtensionMethods
{
    public class SimpleLogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }

        public void Log(string text, string messageType)
        {
            Console.WriteLine($"{messageType}: {text}");
        }
    }

    
}
