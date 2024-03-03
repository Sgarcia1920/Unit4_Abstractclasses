using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4_Abstractclasses
{
	internal class Parallelogram:Figure
	{
		protected double b_ase;

		public double Base
		{
			get { return b_ase; }
			set { b_ase = value; }
		}

		protected double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

	   public Parallelogram()
		{
			this.b_ase = 0;
			this.height = 0;
		}
		public Parallelogram(double b, double h)
		{
			this.b_ase = b;
			this.height = h;
		}

		public override double CalculateArea()
		{
			return  (b_ase * height) ;
		}
		public override string ToString()
		{
			return "The Result is " + CalculateArea();
		}
	}

}

