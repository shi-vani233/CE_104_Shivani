using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
[assembly: AssemblyVersion("1.0.0.0")]


namespace lab_3
{
    public class calc
    {
        public int addition(int x, int y)
        {
            Console.WriteLine("new version");
            return x + y;
        }
        public int multiplication(int x, int y)
        {
            return x * y;
        }
    }
}
