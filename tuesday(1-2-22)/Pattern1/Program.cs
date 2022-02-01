using System;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows=4, k = 1;
            Console.WriteLine("display the pattern:\n");
            Console.Write("\n");
            
            for(i=1;i<=rows;i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}\t", k++);
                Console.Write("\n");
            }
        }
    }
}
