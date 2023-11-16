namespace SquareCalculator.Abstractions;

/// <summary>
/// Базовый интерфейс для каждой фигуры.
/// </summary>
public interface IFigure
{
	/// <summary>
	/// Метод расчета площади фигуры.
	/// </summary>
	/// <returns>Возвращает значение площади фигуры.</returns>
	public double CalculateSquare();
}
