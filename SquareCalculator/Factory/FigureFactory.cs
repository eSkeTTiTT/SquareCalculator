using SquareCalculator.Abstractions;
using SquareCalculator.Figures;
using SquareCalculator.Models.Enums;

namespace SquareCalculator.Factory;

/// <summary>
/// Фабрика для создания фигур.
/// </summary>
public sealed class FigureFactory
{
	/// <summary>
	/// Метод создания фигуры.
	/// </summary>
	/// <param name="figureType">Тип фигуры, которую необходимо создать.</param>
	/// <param name="values">Значение сторон, которые необходимы для создания фигуры.</param>
	/// <returns>Возвращает объект <see cref="IFigure"/> созданной фигуры для дальнейших маннипуляций.</returns>
	public static IFigure CreateFigure(FigureType figureType, params double[] values) =>
		figureType switch
		{
			FigureType.Circle => new Circle(values),
			FigureType.Triangle => new Triangle(values),
			_ => throw new ArgumentException($"Невалидное значение для типа {typeof(FigureType).FullName}.", nameof(figureType)),
		};
}
