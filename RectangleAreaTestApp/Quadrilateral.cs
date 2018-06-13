using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaTestApp {
	public class Quadrilateral {

		public int side1 { get; set; }
		public int side2 { get; set; }
		public int side3 { get; set; }
		public int side4 { get; set; }

		public int GetPerimeter() {
			return side1 + side2 + side3 + side4;
		}

		public virtual int GetArea() { //"virtual" so it can be overridden in the rectangle and square class via "override"
			return -1;
		}

		public Quadrilateral(int side1, int side2, int side3, int side4) {
			this.side1 = side1;
			this.side2 = side2;
			this.side3 = side3;
			this.side4 = side4;
		}

		//default constructor
		public Quadrilateral() {}
	}
}
