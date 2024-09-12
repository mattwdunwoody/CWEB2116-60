using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class NumericalOperations
	{
		int numberInt = 0;
		float numberFloat = 0.0f;
		public int previousValue(int number)
		{
			numberInt = number;
			return number - 1;
		}

		public int nextValue(int number)
		{
			numberInt = number;
			return number + 1;
		}

		public float previousValue(float number)
		{
			numberFloat = number;
			return number - 0.1f;
		}

		public float nextValue(float number)
		{
			numberFloat = number;
			return number + 0.1f;
		}

		public void display()
		{
			Console.WriteLine("\nNumericalOperations class processed:");
			Console.WriteLine(" Integer number= " + numberInt);
			Console.WriteLine(" Float number= " + numberFloat);
		}
	}
}
