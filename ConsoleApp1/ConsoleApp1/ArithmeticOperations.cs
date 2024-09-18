using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class ArithmeticOperations : NumericalOperations
	{
		int num1;
		int num2;

		public ArithmeticOperations(int num1)
		{
			this.num1 = num1;
			this.num2 = previousValue(num1);
		}

		public ArithmeticOperations(int num1, int num2)
		{
			this.num1 = num1;
			this.num2 = num2;
		}
		public int addNums()
		{
			return num1 + num2;
		}

		public int subtract()
		{
			return num1 - num2;
		}

		public int multiply()
		{
			return num1 * num2;
		}

		public int divide()
		{
			return num1 / num2;
		}

		public int modulus()
		{
			return num1 % num2;
		}

	}
}
