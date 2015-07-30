using System;
namespace FirstConsoleProject

{

	class MainClass

	{

		public static void Main (string[] args) // this is a method called "Main". It is called when the program starts.

		{
			Random numberGenerator = new Random ();

			int num01 = numberGenerator.Next();
			int num02 = 4;
			Console.WriteLine ("What is " + num01 + " times " + num02 + "?");
			int answer = Convert.ToInt32 (Console.ReadLine ());
			if (answer == num01 * num02) {

				Console.WriteLine ("Well done! Your answer is correct.");

			} else {

				Console.WriteLine ("Are you even trying?");

			}
			Console.ReadKey();

		}

	}

}