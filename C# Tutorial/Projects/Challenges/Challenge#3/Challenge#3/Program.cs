using System;

namespace Challenge3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("I will now give you a math question. Answer with an integer. <Press any button to continue.>"); //Directions
			Console.ReadKey ();

			Console.WriteLine ("25 to the 2nd power to the 1/2th power."); //Math Question
			int answer = Convert.ToInt32 (Console.ReadLine ());

			if (answer == 25) {																	//Else-If Statements
				Console.WriteLine ("You are a math genius.");
			} else if (answer < 25) {
				Console.WriteLine ("Your only a few numbers below the answer. Keep trying.");
			} else if (answer > 25) {
				Console.WriteLine ("You are a couple numbers above the acutal answer, try again.");
			}
		}
	}
}