using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task2
{
    class lab7_2
    {
        static void Main(string[] args)
        {
            var namelist = new List<string>() { "Om", "Tia", "Shivangi", "Karan", "Ted", "siya", "bela", "Dhruvit", "kiya", "parth" };

            var q1 = from n in namelist where ((n.StartsWith("K")) || (n.StartsWith("k"))) select n;
            Console.WriteLine("all names with the first letter ‘K’.");
            foreach (string name in q1)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("all names whose string length is less than 4.");
            var q2 = from n in namelist where (n.Length <= 4) select n;
            foreach (string name in q2)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("all names whose string length is equal to 3.");
            var q3 = from n in namelist where (n.Length == 3) select n;
            foreach (string name in q3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("all names in Ascending order.");
            var q4 = from n in namelist orderby (n) select n;
            foreach (string name in q4)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}