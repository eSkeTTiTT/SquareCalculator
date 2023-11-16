using SquareCalculator.Abstractions;

namespace SquareCalculator.Figures;

/// <summary>
/// Представляет фигуру - Круг.
/// </summary>
internal sealed class Circle : FigureBase
{
	/// <summary>
	/// Радиус круга.
	/// </summary>
	private double Radius { get; init; }

	/// <summary>
	/// Конструктор.
	/// </summary>
	/// <param name="values">Значение сторон, которые необходимы для создания фигуры.</param>
	public Circle(params double[] values)
		: base(1, values)
    {
		Radius = values[0];
    }

	/// <summary>
	/// Внутренний метод расчета площади фигуры.
	/// </summary>
	/// <returns>Возвращает значение площади фигуры.</returns>
	protected override double CalculateSquareInternal() =>
		Math.PI * Radius * Radius;
}
