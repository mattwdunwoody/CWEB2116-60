using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class StringOperations
	{
		String s1;
		String s2;
		String s3;

		public String joinStrings(String s1, String s2)
		{
			this.s1 = s1;
			this.s2 = s2;
			return s1 + " " + s2;
		}

		public String joinStrings(String s1, String s2, String s3)
		{
			this.s1 = s1;
			this.s2 = s2;
			this.s3 = s3;
			return s1 + " " + s2 + " " + s3;
		}
		public void display()
		{
			Console.WriteLine("\nStringOperations class processed:");
			Console.WriteLine(" String1 = " + s1);
			Console.WriteLine(" String2 = " + s2);
			Console.WriteLine(" String3 = " + s3);
		}
	}
}
