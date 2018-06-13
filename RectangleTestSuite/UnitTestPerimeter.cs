using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleAreaTestApp;

namespace RectangleTestSuite {

	[TestClass]
	public class UnitTestPerimeter {

		[TestMethod]
		public void TestMethodPerimeter() {

			Rectangle rect1 = new Rectangle(2, 4);
			var result = rect1.GetPerimeter();
			Assert.AreEqual(12, result, "wrong area");

			Rectangle rect2 = new Rectangle(500, 500);
			var result2 = rect2.GetPerimeter();
			Assert.AreEqual(2000, result2, "wrong area");
		}
	}
}
