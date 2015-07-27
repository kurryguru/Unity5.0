using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main (string[] args)	//Main method called when program starts.
		{
			Double num01;
			Double num02;

			Console.Write ("Type a number to be multiplied: ");	//Enter first number.
			num01 = Convert.ToDouble (Console.ReadLine ());	//Enter first number.

			Console.Write ("Type another number to be multiplied: ");	//Enter second number.
			num02 = Convert.ToDouble (Console.ReadLine ()); //Enter second number.

			Console.WriteLine ("The result is: " + num01 * num02); //Multiplication Result
			Console.ReadKey ();	//Multiplication Result
		}
	}
}
