using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleAreaTestApp;

namespace RectangleTestSuite {

	[TestClass]
	public class UnitTestArea {

		[TestMethod]
		public void TestArea() {
			Rectangle rect1 = new Rectangle(2,4);
			var result = rect1.GetArea();
			Assert.AreEqual(8, result, "wrong area");

			Rectangle rect2 = new Rectangle(500, 500);
			var result2 = rect2.GetArea();
			Assert.AreEqual(250000, result2, "wrong area");

		}
	}
}
