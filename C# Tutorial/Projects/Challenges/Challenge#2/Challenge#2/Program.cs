using System;

namespace Challenge2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num01;
			double num02;

			Console.Write ("Type a number to be divided: ");
			num01 = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("Type another number to be divisor: ");
			num02 = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine (num01 + " divided by " + num02 + " is equal to: " + num01 / num02);
			Console.ReadKey ();
		}
	}
}
