using System.Collections.Generic;

namespace HelloWorld
{
	public class Example
	{
		private string example;

		public Example()
		{
			this.example = "Hello";
		}

		public string ExampleText
		{
			get { return this.example; }
		}
		
		public IList<double> GetValidDoubles(IList<string> inputs)
		{
			var doubles = new List<double>();

			foreach (var input in inputs)
			{
				if (double.TryParse(input, out double d))
				{
					doubles.Add(d);
				}
			}

			return doubles;
		}
	}
}
