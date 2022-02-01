using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;
            Console.Write("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;
            Console.Write("the factorial of {0} is:{1}\n", num, f);
        }
    }
}
