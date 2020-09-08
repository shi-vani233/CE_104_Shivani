using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task1
{
    class lab7_1
    {
        static void Main(string[] args)
        {
            var numlist = Enumerable.Range(1, 100).ToList();

            var odd = numlist.Where(n => n % 2 != 0).ToList();
            Console.WriteLine("Odd numbers");
            foreach (var num in odd)
            {
                Console.WriteLine(num);
            }

            var even = numlist.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers");
            foreach (var num in even)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("All numbers");
            foreach (var num in numlist)
            {
                Console.WriteLine(num);
            }

            int min = (from num in numlist select num).Min();
            Console.WriteLine("Minimum Number is: " + min);

            int max = (from num in numlist select num).Max();
            Console.WriteLine("Maximum Number is: " + max);

            double avg = (from num in numlist select num).Average();
            Console.WriteLine("Average value is: " + avg);

            Console.ReadKey();
        }
    }
}
