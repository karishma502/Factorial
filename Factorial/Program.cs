using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter no.");
			int Number = Convert.ToInt32(Console.ReadLine());
			int Fact = 1;
			for (int i = 1; i < Number + 1; i++)
			{
				Fact = Fact * i;
			}
			Console.WriteLine("Factorial is"+ Fact);
			Console.Read();
		}
	}
}
