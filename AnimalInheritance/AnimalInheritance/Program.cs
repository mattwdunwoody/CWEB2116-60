using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal a = new Animal();
			a.sound();

			Animal adog = new Dog();
			adog.sound();

			Dog dog = new Dog();
			dog.sound();

			Cat cat = new Cat();
			cat.sound();

			Console.ReadKey();
		}
	}
}
