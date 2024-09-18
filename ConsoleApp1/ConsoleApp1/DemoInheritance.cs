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
			String anotherInput;
			ArithmeticOperations arithObj;

			Console.WriteLine("\nInput number to process: ");
			inputNum = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("\nWould you like to provide another input? (y/n): ");
			anotherInput = Console.ReadLine().ToUpper();

			if (anotherInput == "Y")
			{
				Console.WriteLine("Input another number to process: ");
				inputNum2 = Convert.ToInt16(Console.ReadLine());
				arithObj = new ArithmeticOperations(inputNum, inputNum2);
			}
			else
			{
				Console.WriteLine("Processing with previous value...");
				arithObj = new ArithmeticOperations(inputNum);
				inputNum2 = arithObj.previousValue(inputNum);
			}

			additionResult = arithObj.addNums();
			subtractionResult = arithObj.subtract();
			multiplicationResult = arithObj.multiply();
			divisionResult = arithObj.divide();
			modulusResult = arithObj.modulus();

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
