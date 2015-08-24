using System;
namespace FirstConsoleProject

{

	class MainClass

	{

		public static void Main (string[] args) // this is a method called "Main". It is called when the program starts.

		{
			Random numberGenerator = new Random ();

			int num01 = numberGenerator.Next(1,12);
			int num02 = numberGenerator.Next(1,12);
			Console.WriteLine ("What is " + num01 + " times " + num02 + "?");
			int answer = Convert.ToInt32 (Console.ReadLine ());
			if (answer == num01 * num02) {

				Console.WriteLine ("Well done! Your answer is correct.");

			} else {

				int respondIndex = numberGenerator.Next (1, 4);
				int incorrectAnswer = (num01 * num02) - answer;

				switch (respondIndex) {
				case 1:
					Console.WriteLine ("Are you even trying?");
					break;
				case 2:
					Console.WriteLine ("The answer was incorrect.");
					break;
				case 3:
					Console.WriteLine ("You can do better than that.");
					break;
				}

			}
			Console.ReadKey();

		}

	}

}