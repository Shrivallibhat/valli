using System;

namespace greatest_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            // set the value of the three numbers
            num1 = 12;
            num2 = 60;
            num3 = 18;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}

