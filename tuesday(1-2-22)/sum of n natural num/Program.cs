using System;

namespace sum_of_n_natural_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i, sum=0;
            Console.Write("enter the number of terms :");
             n=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("number is:" + n);
            for(i=0;i<=n;i++)
            {
                sum += i;
            }
            Console.Write("\n The sum of natural number is " + sum);
            Console.ReadLine();
        }
    }
}
