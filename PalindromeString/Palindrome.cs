namespace PalindromeString
{
    public static class Palindrome
    {
        public static bool CheckPalindrome(string str)
        {
            for(int i=0, j= str.Length - 1; i<j ; i++,j--)
            {
                if(str[i]!=str[j]) return false;
            }
            return true;
        }
    }
}
