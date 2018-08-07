using System;

namespace Loop_2_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            int x = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 2; i < 21; i++)
            {
                Console.WriteLine(i * x);
                sum = sum + i * x;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
}
