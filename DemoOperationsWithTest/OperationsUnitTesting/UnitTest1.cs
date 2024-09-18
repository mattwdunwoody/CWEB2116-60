using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperationsUnitTesting
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void DivideTest()
		{
			//Arrange
			int expected = 4;
			int numerator = 20;
			int denominator = 5;

			//Act
			int actual = OperationsLibrary.operations.Divide(numerator, denominator);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void MultiplyTest()
		{
			//Arrange
			int expected = 30;
			int numA = 10;
			int numB = 3;

			//Act
			int actual = OperationsLibrary.operations.Multiply(numA, numB);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void AddTest()
		{
			//Arrange
			int expected = 4;
			int numA = 2;
			int numB = 2;

			//Act
			int actual = OperationsLibrary.operations.Add(numA, numB);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SubtractTest()
		{
			//Arrange
			int expected = 2;
			int numA = 6;
			int numB = 4;

			//Act
			int actual = OperationsLibrary.operations.Subtract(numA, numB);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ModulusTest()
		{
			//Arrange
			int expected = 3;
			int numA = 31;
			int numB = 7;

			//Act
			int actual = OperationsLibrary.operations.Modulus(numA, numB);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
