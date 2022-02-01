using System;

namespace age
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter age :");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("person is allowed foe voting:" + age);

            }
            else
            {
                Console.WriteLine("user is nor allowed to vote:" + age);
            }
        }
    }
}
