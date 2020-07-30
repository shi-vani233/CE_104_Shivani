using System;
using addition;
namespace driver
{
	public class driver_class
	{
		static void Main(string[] args)
		{
            		addition_class c = new addition_class();
			int ans = c.addition(2, 3);
            		Console.WriteLine(ans);
			Console.ReadKey();
		}
	}
}