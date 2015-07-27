using System;

namespace ThirdProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
					
			Double number1 = 0.00;
			Double number2 = 0.00;
			string operation = "";

			Console.Write ("Welcome to my calculator!");

			Console.Write ("\nPlease enter the first number: ");
		    number1 = Convert.ToDouble (Console.ReadLine ());

		    Console.Write ("Please enter the second number: ");
		    number2 = Convert.ToDouble(Console.ReadLine ());

			Console.Write ("Please enter the operation, +, -, *, / :");
			operation = Console.ReadLine ();

			if (operation == "+") {
				Console.WriteLine ("The result is " + (number1 + number2));
			}
			else if (operation == "-") {
				Console.WriteLine ("The result is " + (number1 - number2));
			}
			else if (operation == "*") {
				Console.WriteLine ("The result is " + (number1 * number2));
			}
			else if (operation == "/") {
				Console.WriteLine ("The result is " + (number1 / number2));
			}
			else {
				Console.WriteLine ("Please enter a valid operation. Valid operations are : +, -, * and /");
				}
					
			Console.ReadKey();
			Console.WriteLine();
		
		}
	}
}
