using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
	class Animal
	{
		public virtual void sound()
		{
			Console.WriteLine("Animal makes a sound");
		}
	}

	class Dog : Animal
	{
		public override void sound()
		{
			Console.WriteLine("Dog barks");
		}
	}

	class Cat : Animal
	{
		public override void sound()
		{
			Console.WriteLine("Cat meows");
		}
	}
}
