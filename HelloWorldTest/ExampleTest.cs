using System;
using System.Collections.Generic;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTest
{
	[TestClass]
	public class ExampleTest
	{
		[TestMethod]
		public void ExampleText_Get_ReturnHello()
		{
			var example = new Example();
			Assert.AreEqual("Hello", example.ExampleText);
		}

		[TestMethod]
		public void GetValidDoubles_EmptyList_ReturnEmptyList()
		{
			var example = new Example();
			var results = example.GetValidDoubles(new List<string>());
			Assert.IsTrue(results.Count == 0);
		}

		[TestMethod]
		public void GetValidDoubles_AString_ReturnEmptyList()
		{
			var example = new Example();
			var results = example.GetValidDoubles(new List<string> { "Test" });
			Assert.IsTrue(results.Count == 0);
		}

		[TestMethod]
		public void GetValidDoubles_ADoubleString_ReturnCorrectDouble()
		{
			var example = new Example();
			var results = example.GetValidDoubles(new List<string> { "1.0" });
			Assert.IsTrue(results.Count == 1);
			Assert.AreEqual(1.0, results[0]);
		}
	}
}
