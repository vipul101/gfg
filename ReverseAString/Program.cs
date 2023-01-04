namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "this is a string";
            System.Console.WriteLine(str);
            str = str.ReverseKrdo();
            System.Console.WriteLine(str);

        }
    }

    public static class ExtensionMethods
    {
        public static string ReverseKrdo(this string text)
            {
                char[] charArray = text.ToCharArray();
                for(int i=0,j = text.Length - 1;i<j;i++,j--)
                {
                    charArray[i] = text[j];
                    charArray[j] = text[i];
                }
                string result = new string(charArray);
                return result;
            }
    }
    
}
