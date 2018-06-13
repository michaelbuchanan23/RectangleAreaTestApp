using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaTestApp {
	public class Rectangle : Quadrilateral {

		public override int GetArea() {
			return this.side1 * this.side2;
		}


		public Rectangle (int length, int width) {
			this.side1 = length;
			this.side2 = width;
			this.side3 = length;
			this.side4 = width;
		}

		public Rectangle() { }
	}
}
