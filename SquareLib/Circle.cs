using System;

namespace SquareLib.Circle
{
	public class Circle: IFigure
	{
		public double radius { get; }
		public Circle(double radius)
		{
			if (radius > 0) this.radius = radius;
			else throw new Exception("Радиус меньше нуля");
		}
		public double GetSquare()
		{
			return Math.PI * Math.Pow(radius, 2);
		}
	}
}
