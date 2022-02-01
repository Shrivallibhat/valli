using System;

namespace Nullabletypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse("45");
            int number2;
            bool result = int.TryParse("95", out number2);
            Console.WriteLine(number2);
            if (result)
            {
                Console.WriteLine("is num");
            }
        }
    }
}
