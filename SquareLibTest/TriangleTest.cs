using System;
using System.Reflection.Metadata.Ecma335;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SquareLib.Triangle;

namespace Tests
{
	public class TriangleTest
	{
		[Test]
		public void GetSquareTest()
		{
			//Arrange
			var triangle = new Triangle(3, 5, 4);

			//Act
			var square = triangle.GetSquare();

			//Assert
			Assert.AreEqual(square, 6);
		}

		[Test]
		public void IncorrectSidesTest()
		{
			//Assert
			Assert.Catch<Exception>(() => new Triangle(1, 5, 3));
		}

		[Test]
		public void IsRectangularTriangleTest()
		{
			//Arrange
			var triangle = new Triangle(3, 4, 5);

			//Act
			var isRectangular = triangle.isRectangularTriangle;

			//Assert
			Assert.AreEqual(isRectangular, true);
		}
	}
}