using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleAreaTestApp;

namespace RectangleTestSuite {
	[TestClass]
	public class UnitTestRectangleConstructor {
		[TestMethod]
		public void TestMethodRectangleConstrutor() {

			//attempt to create an invalid rectangle
			var rect = new Rectangle(-1, 3);

			//check to make sure Rectangle is not created
			Assert.IsNotInstanceOfType(rect, typeof(Rectangle), "a rectangle was created when it shouldn't be");
		}
	}
}
