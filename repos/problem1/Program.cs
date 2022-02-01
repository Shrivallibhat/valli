using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
            Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
            Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
        }
    }
}
