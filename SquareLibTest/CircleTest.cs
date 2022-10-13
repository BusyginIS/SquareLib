using System;
using NUnit.Framework;
using SquareLib.Circle;

namespace Tests
{
	public class CircleTest
	{
		[Test]
		public void GetSquareTest()
		{
			//Arrange
			var radius = 2;
			var circle = new Circle(radius);
			//Act
			var square = circle.GetSquare();
			//Assert
			Assert.AreEqual(square, Math.PI * Math.Pow(radius, 2));
		}

		[Test]
		public void RadiusEqualZeroTest()
		{
			//Assert
			Assert.Catch<Exception>(() => new Circle(0));
		}

		[Test]
		public void RadiusLessZeroTest()
		{
			//Assert
			Assert.Catch<Exception>(() => new Circle(-1));
		}
	}
}