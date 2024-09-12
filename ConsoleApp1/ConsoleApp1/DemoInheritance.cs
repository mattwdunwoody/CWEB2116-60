using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class DemoInheritance
	{
		static void Main(string[] args)
		{
			Console.WriteLine("INHERITANCE - Demo\n---------------------");
			Console.WriteLine("Integer Arithmetic Operations");

			int inputNum, inputNum2 = 0;
			int additionResult, subtractionResult, multiplicationResult, divisionResult, modulusResult = 0;
			ArithmeticOperations arithObj;

			Console.WriteLine("\nInput number to process: ");
			inputNum = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Input another number to process: ");
			inputNum2 = Convert.ToInt16(Console.ReadLine());

			arithObj = new ArithmeticOperations();
			additionResult = arithObj.addNums(inputNum, inputNum2);
			subtractionResult = arithObj.subtract(inputNum, inputNum2);
			multiplicationResult = arithObj.multiply(inputNum, inputNum2);
			divisionResult = arithObj.divide(inputNum, inputNum2);
			modulusResult = arithObj.modulus(inputNum, inputNum2);

			Console.WriteLine("\n--------RESULT------------");
			Console.WriteLine("      Addition: " + inputNum + "+" + inputNum2 + "=" + additionResult);
			Console.WriteLine("   Subtraction: " + inputNum + "-" + inputNum2 + "=" + subtractionResult);
			Console.WriteLine("Multiplication: " + inputNum + "*" + inputNum2 + "=" + multiplicationResult);
			Console.WriteLine("      Division: " + inputNum + "/" + inputNum2 + "=" + divisionResult);
			Console.WriteLine("       Modulus: " + inputNum + "%" + inputNum2 + "=" + modulusResult);
			Console.WriteLine("\n");
			Console.ReadLine();
		}
	}
}
