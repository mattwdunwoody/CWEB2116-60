using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class demoOperations
	{
		static void MainOld(string[] args)
		{
			Console.WriteLine("OOP - C# Demo");
			Console.WriteLine("-------------");

			Console.WriteLine("1. Numerical Operations");
			Console.WriteLine("2. String Operations");
			Console.WriteLine("\nEnter your option: ");

			int userInput = Convert.ToInt16(Console.ReadLine());

			if (userInput == 1)
			{
				NumericalOperations numericalObj = new NumericalOperations();

				Console.WriteLine(" 1. Integer");
				Console.WriteLine(" 2. Float");
				Console.WriteLine("\nEnter your option: ");

				int numericalOperationChoice = Convert.ToInt16(Console.ReadLine());

				Console.WriteLine("Enter the number to check: ");

				if (numericalOperationChoice == 1)
				{
					int userNumber = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Previous value= " + numericalObj.previousValue(userNumber));
					Console.WriteLine("Next value= " + numericalObj.nextValue(userNumber));
				}
				else
				{
					float userNumber = float.Parse(Console.ReadLine());
					Console.WriteLine("Previous value= " + numericalObj.previousValue(userNumber));
					Console.WriteLine("Next value= " + numericalObj.nextValue(userNumber));
				}
				numericalObj.display();
			}
			else
			{
				Console.WriteLine("String Operations");
				String str1, str2, str3 = null;

				Console.WriteLine("\nEnter the first string:");
				str1 = Console.ReadLine();

				Console.WriteLine("\nEnter the second string:");
				str2 = Console.ReadLine();

				Console.WriteLine("Would you like to add one more string (y/n): ");
				String extraStringOption = Console.ReadLine();

				if (extraStringOption.ToUpper() == "Y")
				{
					Console.WriteLine("Enter the string 3: ");
					str3 = Console.ReadLine();
				}
				StringOperations stringObj = new StringOperations();
				if (str3 != null)
				{
					Console.WriteLine("\nJoin result = " + stringObj.joinStrings(str1, str2, str3));
				}
				else
				{
					Console.WriteLine("\nJoin result = " + stringObj.joinStrings(str1, str2));
				}
				stringObj.display();
			}

			Console.ReadLine();
		}
	}
}
