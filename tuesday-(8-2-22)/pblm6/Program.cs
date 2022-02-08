using System;
public class CheckPalindromeRecursively
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        Console.WriteLine(IsPalindrome(text));
    }

    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
        {
            return true;
        }
        else
        {
            if (text[0] != text[text.Length - 1])
            {
                return false;
            }
            else
            {
                return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}