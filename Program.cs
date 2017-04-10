using System;

namespace SimpleCalculator
{
	class MainClass
	{
		// Main Method
		public static void Main(string[] args)
		{
			// Declarations
			string x = "0";
			string y = "0";
			string operation = "A";
			double xVal = 0.0;
			double yVal = 0.0;
			double z = 0.0;

			// Greeting
			Console.WriteLine("Welcome to my simple calculator.");
			Console.WriteLine("Please enter 2 values and select an operation.");
			Console.WriteLine("");

			// Read in values
			Console.WriteLine("Value 1: ");
			x = Console.ReadLine();
			bool xRes = double.TryParse(x, out xVal);
			while (xRes == false)
			{
				Console.WriteLine("String is not a number. Try again!");
				Console.WriteLine("Value 1: ");
				x = Console.ReadLine();
				xRes = double.TryParse(x, out xVal);
			}
			Console.WriteLine("Value 2: ");
			y = Console.ReadLine();
			bool yRes = double.TryParse(y, out yVal);
			while (yRes == false)
			{
				Console.WriteLine("String is not a number. Try again!");
				Console.WriteLine("Value 2: ");
				y = Console.ReadLine();
				yRes = double.TryParse(y, out yVal);
			}

			// Select an operation
			Console.WriteLine("Select an Operation:");
			Console.WriteLine("Press A for Addition");
			Console.WriteLine("Press S for Subtraction");
			Console.WriteLine("Press M for Multiplication");
			Console.WriteLine("Press D for Division");
			operation = Console.ReadLine();

			// Sending selected operation to method
			switch (operation.ToUpper())
			{
				case "A":
					z = Add(xVal, yVal);
					break;
				case "D":
					z = Divide(xVal, yVal);
					break;
				case "S":
					z = Subtract(xVal, yVal);
					break;
				case "M":
					z = Multiply(xVal, yVal);
					break;
				default:
					Console.WriteLine("Please choose a valid operation.");
					continue;
			}
			
			// Print result
			Console.WriteLine("Result: " + z);

		}

		// Add Method
		static double Add(double value1, double value2)
		{
			double sum = 0.0;
			sum = value1 + value2;
			return sum;
		}

		// Subtract Method
		static double Subtract(double value1, double value2)
		{
			double answer = 0.0;
			answer = value1 - value2;
			return answer;
		}

		// Multiply Method
		static double Multiply(double value1, double value2)
		{
			double product = 0.0;
			product = value1 * value2;
			return product;
		}

		// Divide Method
		static double Divide(double value1, double value2)
		{
			double result = 0.0;
			result = value1 / value2;
			return result;
		}

	}
}
