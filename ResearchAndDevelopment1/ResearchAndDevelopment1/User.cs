using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndDevelopment1
{
	class User
	{
		//initiliate private variables
		private String name;
		private int age;
		private String hobby;

		//construct user
		public User(String name, int age, String hobby)
		{
			this.name = name;
			this.age = age;
			this.hobby = hobby;
		}

		//display variables
		public void DisplayInfo(String user_name, int user_age)
		{
			Console.WriteLine("\nName: " + user_name);
			Console.WriteLine("Age: " + user_age);
		}

		//overload to display hobby
		public void DisplayInfo(String user_name, int user_age, String user_hobby)
		{
			Console.WriteLine("\nName: " + user_name);
			Console.WriteLine("Age: " + user_age);
			Console.WriteLine("Hobby: " + user_hobby);
		}

		//overload to display years until retiring
		public void DisplayInfo(String user_name, int user_age, String user_hobby, int years_until_retire)
		{
			Console.WriteLine("\nName: " + user_name);
			Console.WriteLine("Age: " + user_age);
			Console.WriteLine("Hobby: " + user_hobby);
			Console.WriteLine(user_name + " will retire in " + years_until_retire + " years.");
		}
	}
}
