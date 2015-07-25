using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main (string[] args)	//Main method called when program starts.
		{
			int num01;
			int num02;

			Console.Write ("Type a number to be multiplied: ");
			num01 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Type another number to be multiplied: ");
			num02 = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("The result is: " + num01 * num02);
			Console.ReadKey ();
		}
	}
}
