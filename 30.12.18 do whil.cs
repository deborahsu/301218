using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class Program
	{



		static void Main(string[] args)
		{
			NewMethod1();
			Console.ReadLine();
			NewMethod2();
			Console.ReadLine();
			NewMethod3();
			Console.ReadLine();


		}

		

		private static void NewMethod1()
		{
			for (int i = 2; i <= 200; i = i + 2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("more than 200");
		}


		private static void NewMethod2()
		{
			for (int i = 1120; i >= 7; i = i - 7)
			{
				Console.WriteLine(i);

			}
			Console.WriteLine("less then 7");
			Console.ReadLine();
		}

		private static void NewMethod3()

		{
			int a, b;
			do
			{
				Console.WriteLine("enter 2 numbers");
				a = Convert.ToInt32(Console.ReadLine());
				b = Convert.ToInt32(Console.ReadLine());

			}
			while (a % b != 0);
			Console.WriteLine($"{a} is divided by {b}");
		 }
		

	}
}
