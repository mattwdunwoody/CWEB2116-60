using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	/* 
	Application Development I
	Homework 1
	Matthew Wideman
	9/12/2024
	 */
	class Program
	{
		static void Main(string[] args)
		{
			// Task 1: Output statements
			Console.WriteLine("Hello, my name is Matthew.");
			Console.WriteLine("My favorite color is green.");
			Console.WriteLine("The current year is 2024.");

			// Task 3: Store variables and output them
			int my_age = 20;
			double my_height_meters = 1.8796;
			String favorite_letter = "A";
			bool likes_programming = true;

			Console.WriteLine("\nI am " + my_age + " years old.");
			Console.WriteLine("My height is " + my_height_meters + " meters.");
			Console.WriteLine("My favorite letter is " + favorite_letter + ".");
			Console.WriteLine("Do I like programming? " + likes_programming + ".");

			// Task 4: Store a constant of pi and use it to calculate the area of a circle
			const double pi = 3.14159;

			int circle_radius = 5;

			double circle_area = pi * (circle_radius * circle_radius);

			Console.WriteLine("\nThe area of the circle with radius " + circle_radius + " is " + circle_area + ".");

			// Task 5: Identify and use appropriate data types
			String first_name = "Sarah";
			long population = 1500000;
			double temperature = 23.5;
			bool is_student = true;

			Console.WriteLine("\nThe person's name is " + first_name + ".");
			Console.WriteLine("The population of the city is " + population + ".");
			Console.WriteLine("The tempurature is " + temperature + " degrees Celsius.");
			Console.WriteLine("Is the person a student? " + is_student + ".");

			Console.ReadKey();
		}
	}
}
