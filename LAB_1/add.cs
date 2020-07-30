using System;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int i, j, sum = 0;
		Console.WriteLine("enter first number");
                i = int.Parse(Console.ReadLine());
		Console.WriteLine("enter second number");
                j = int.Parse(Console.ReadLine());
                sum = i + j;
                Console.WriteLine("sum is " + sum);

            
        }
    }
}