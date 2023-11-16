using SquareCalculator.Abstractions;

namespace SquareCalculator.Figures;

/// <summary>
/// Представляет фигуру - Треугольник.
/// </summary>
internal sealed class Triangle : FigureBase
{
	#region Properties

	/// <summary>
	/// Признак того, что треугольник прямоугольный.
	/// </summary>
	private bool _isRightTriangle;

	/// <summary>
	/// Первая сторона треугольника.
	/// </summary>
	private double FirstSide { get; init; }

	/// <summary>
	/// Вторая сторона треугольника.
	/// </summary>
	private double SecondSide { get; init; }

	/// <summary>
	/// Третья сторона треугольника.
	/// </summary>
	private double ThirdSide { get; init; }

	#endregion

	/// <summary>
	/// Конструктор.
	/// </summary>
	/// <param name="values">Значение сторон, которые необходимы для создания фигуры.</param>
	public Triangle(params double[] values)
		: base(3, values)
    {
		FirstSide = values[0];
		SecondSide = values[1];
		ThirdSide = values[2];
		_isRightTriangle = CheckForRightTriangle();
	}

	/// <summary>
	/// Метод проверки того, является ли треугольник прямоугольным?
	/// </summary>
	/// <returns>Возвращает результат проверки.</returns>
	private bool CheckForRightTriangle()
	{
		// Гипотенуза
		var maxSide = new[] {FirstSide, SecondSide, ThirdSide }.Max();

		// a^2 + b^2 = c^2 => a^2 + b^2 + c^2 = c^2 + c^2
		return maxSide * maxSide + maxSide * maxSide
			== FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
	}

	/// <summary>
	/// Внутренний метод расчета площади фигуры.
	/// </summary>
	/// <returns>Возвращает значение площади фигуры.</returns>
	protected override double CalculateSquareInternal()
	{
		// Полупериметр
		var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

		// Формула Герона
		return Math.Sqrt(halfPerimeter
			* (halfPerimeter - FirstSide)
			* (halfPerimeter - SecondSide)
			* (halfPerimeter - ThirdSide));
	}
}
