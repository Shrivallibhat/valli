using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,revs = " ";
            Console.WriteLine("enter string");
            s = Console.ReadLine();
            for (int i=s.Length-1;i>=0;i--)//string reverse
            {
                revs += s[i].ToString();
            }
            if(revs==s)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is nor palindrome");
            }
            Console.ReadKey();
        }
    }
}
