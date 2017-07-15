using System;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var example = new Example();

			Console.WriteLine(string.Format("{0} world", example.ExampleText));

			Console.Read();
		}
	}
}
