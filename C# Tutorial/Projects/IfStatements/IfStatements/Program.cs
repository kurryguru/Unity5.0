using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main (string[] args)	//Main method called when program starts.
		{
			
			Console.WriteLine ("How old are you?");
			int age = Convert.ToInt32 (Console.ReadLine ());
			if (age < 18) {
				Console.WriteLine ("That's too bad! You will have to wait a couple of years.");
			} else if (age == 18) {
				Console.WriteLine ("Phew, barely made it!");
			} else {
				Console.WriteLine ("You are allowed to enter.");
			}
			Console.ReadKey ();
		}
	}
}
