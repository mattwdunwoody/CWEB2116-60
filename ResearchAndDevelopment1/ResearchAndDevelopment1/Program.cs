using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndDevelopment1
{
	class Program
	{
		static void Main(string[] args)
		{
			//get user input
			Console.Write("Enter your name: ");
			String user_name = Console.ReadLine();

			Console.Write("Enter your age: ");
			int user_age = Convert.ToInt16(Console.ReadLine());

			Console.Write("Enter your hobby: ");
			String user_hobby = Console.ReadLine();

			//create a user
			User user = new User(user_name, user_age, user_hobby);

			//display just name and age
			user.DisplayInfo(user_name, user_age);

			//display name, age, and hobby
			user.DisplayInfo(user_name, user_age, user_hobby);

			//calculate years until retirement
			int user_years_until_retire = 65 - user_age;

			//display with years until retirement
			user.DisplayInfo(user_name, user_age, user_hobby, user_years_until_retire);

			Console.ReadKey();
		}
	}
}
