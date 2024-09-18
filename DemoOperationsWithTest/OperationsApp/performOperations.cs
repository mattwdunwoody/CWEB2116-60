using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsApp
{
	class performOperations
	{
		public void performDivide()
		{
			Console.Write("Enter numerator: ");
			int numerator = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter denominator: ");
			int denominor = Convert.ToInt32(Console.ReadLine());

			int res = OperationsLibrary.operations.Divide(numerator, denominor);
			Console.Write("Result = " + res);
		}

		public void performMultiply()
		{
			Console.Write("Enter first number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			int res = OperationsLibrary.operations.Multiply(numA, numB);
			Console.Write("Result = " + res);
		}
		public void performAdd()
		{
			Console.Write("Enter first number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			int res = OperationsLibrary.operations.Add(numA, numB);
			Console.Write("Result = " + res);
		}

		public void performSubtract()
		{
			Console.Write("Enter first number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			int res = OperationsLibrary.operations.Subtract(numA, numB);
			Console.Write("Result = " + res);
		}
		public void performModulus()
		{
			Console.Write("Enter first number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			int res = OperationsLibrary.operations.Modulus(numA, numB);
			Console.Write("Result = " + res);
		}
	}
}
