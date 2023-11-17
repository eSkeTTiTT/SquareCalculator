using SquareCalculator.Factory;
using SquareCalculator.Models.Enums;

#nullable disable

namespace SquareCalculatorTests
{
	/// <summary>
	/// Тесты для библиотеки расчета площади фигур.
	/// </summary>
	public class SquareCalculatorTests
	{
		#region Circle tests

		/// <summary>
		/// Данные для инициализации круга - Null.
		/// </summary>
		[Fact]
		public void CircleValuesIsNull() =>
			// Assert
			Assert.Throws<ArgumentNullException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Circle, null));

		/// <summary>
		/// Длина параметров для инициализации круга меньше необходимых.
		/// </summary>
		[Fact]
		public void CircleValuesLengthLess() =>
			// Assert
			Assert.Throws<ArgumentOutOfRangeException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Circle, Array.Empty<double>()));

		/// <summary>
		/// Длина параметров для инициализации круга больше необходимых.
		/// </summary>
		[Fact]
		public void CircleValuesLengthMore() =>
			// Assert
			Assert.Throws<ArgumentOutOfRangeException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Circle, new[] { 1d, 2d }));

		/// <summary>
		/// Отрицательные значения для инициализации круга.
		/// </summary>
		[Fact]
		public void CircleNegativeValues() =>
			// Assert
			Assert.Throws<InvalidDataException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Circle, -1));

		/// <summary>
		/// Расчет площади круга.
		/// </summary>
		[Fact]
		public void CircleSquareCalculation()
		{
			// Arrange
			var values = 4d;

			// Act
			var result = FigureFactory
				.CreateFigure(FigureType.Circle, values)
				.CalculateSquare();

			// Assert
			Assert.Equal(Math.PI * 4d * 4d, result);
		}

		#endregion

		#region Triangle tests

		/// <summary>
		/// Данные для инициализации треугольника - Null.
		/// </summary>
		[Fact]
		public void TriangleValuesIsNull() =>
			// Assert
			Assert.Throws<ArgumentNullException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Triangle, null));

		/// <summary>
		/// Длина параметров для инициализации треугольника меньше необходимых.
		/// </summary>
		[Fact]
		public void TriangleValuesLengthLess() =>
			// Assert
			Assert.Throws<ArgumentOutOfRangeException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Triangle, Array.Empty<double>()));

		/// <summary>
		/// Длина параметров для инициализации треугольника больше необходимых.
		/// </summary>
		[Fact]
		public void TriangleValuesLengthMore() =>
			// Assert
			Assert.Throws<ArgumentOutOfRangeException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Triangle, new[] { 3d, 4d, 5d, 10d }));

		/// <summary>
		/// Отрицательные значения для инициализации треугольника.
		/// </summary>
		[Fact]
		public void TriangleNegativeValues()
		{
			// Asserts
			Assert.Throws<InvalidDataException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Triangle, -3d, 4d, 5d));
			Assert.Throws<InvalidDataException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Triangle, 3d, -4d, 5d));
			Assert.Throws<InvalidDataException>(
				testCode: () => FigureFactory.CreateFigure(FigureType.Triangle, 3d, 4d, -5d));
		}

		/// <summary>
		/// Расчет площади треугольника.
		/// </summary>
		[Fact]
		public void TriangleSquareCalculation()
		{
			// Arrange
			var values = new[] { 3d, 4d, 5d };

			// Act
			var result = FigureFactory
				.CreateFigure(FigureType.Triangle, values)
				.CalculateSquare();

			// Assert
			Assert.Equal(6d, result);
		}

		#endregion
	}
}