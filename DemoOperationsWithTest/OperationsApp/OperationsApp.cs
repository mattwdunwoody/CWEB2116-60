using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsApp
{
	class OperationsApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DIVISION");
			performOperations operation1 = new performOperations();
			operation1.performDivide();
			Console.ReadLine();

			Console.WriteLine("MULTIPLICATION");
			performOperations operation2 = new performOperations();
			operation1.performMultiply();
			Console.ReadLine();

			Console.WriteLine("ADDITION");
			performOperations operation3 = new performOperations();
			operation1.performAdd();
			Console.ReadLine();

			Console.WriteLine("SUBTRACTION");
			performOperations operation4 = new performOperations();
			operation1.performSubtract();
			Console.ReadLine();

			Console.WriteLine("MODULUS");
			performOperations operation5 = new performOperations();
			operation1.performModulus();
			Console.ReadLine();
		}
	}
}
