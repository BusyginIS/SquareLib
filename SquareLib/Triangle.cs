using System;

namespace SquareLib.Triangle
{
	public class Triangle : IFigure
	{
		public double a { get; }
		public double b { get; }
		public double c { get; }
		public bool isRectangularTriangle { get; }

		public Triangle(double a, double b, double c)
		{
			if (a > 0 && b > 0 && c > 0)
			{
				if (2 * Math.Max(a, Math.Max(b, c)) > a + b + c) throw new Exception("Несоответствие свойству неравенства треугольника");
				this.a = a;
				this.b = b;
				this.c = c;
				isRectangularTriangle = GetIsRectangularTriangle();
			}
			else throw new Exception("Одна из сторон меньше нуля");
		}
		public double GetSquare()
		{
			var cathetus = GetCathetus(a, b, c);
			var halfPerimeter = (a + b + c) / 2;
			if (isRectangularTriangle)
				return (cathetus[0] * cathetus[1]) / 2;
			return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
		}
		private bool GetIsRectangularTriangle() 
			=> Math.Pow(Math.Max(a, Math.Max(b, c)), 2) - Math.Pow(GetCathetus(a, b, c)[0], 2) - Math.Pow(GetCathetus(a, b, c)[1], 2) == 0;
		private double[] GetCathetus(double a, double b, double c)
		{
			if (Math.Max(a, Math.Max(b, c)) == a) return new double[] { b, c };
			if (Math.Max(a, Math.Max(b, c)) == b) return new double[] { a, c };
			if (Math.Max(a, Math.Max(b, c)) == c) return new double[] { a, b };
			return null;
		}
	}
}
