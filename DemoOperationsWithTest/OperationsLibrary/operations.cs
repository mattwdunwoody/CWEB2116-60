using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsLibrary
{
	public class operations
	{
		public static int Divide(int numerator, int denominator)
		{
			int result = numerator / denominator;
			return result;
		}

		public static int Multiply(int numA, int numB)
		{
			int result = numA * numB;
			return result;
		}
		public static int Add(int numA, int numB)
		{
			int result = numA + numB;
			return result;
		}
		public static int Subtract(int numA, int numB)
		{
			int result = numA - numB;
			return result;
		}
		public static int Modulus(int numA, int numB)
		{
			int result = numA % numB;
			return result;
		}
	}
}
