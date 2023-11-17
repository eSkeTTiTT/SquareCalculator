namespace SquareCalculator.Abstractions;

/// <summary>
/// Базовый класс для каждой фигуры.
/// </summary>
internal abstract class FigureBase : IFigure
{
	#region Properties

	/// <summary>
	/// Рассчитанная площадь - Singleton.
	/// </summary>
	private double? _squareInstance;

	/// <summary>
	/// Длина параметров для инициализации.
	/// </summary>
	protected int ParamsLength { get; init; }

	#endregion

	/// <summary>
	/// Конструктор базового класса.
	/// </summary>
	/// <param name="paramsLength">Длина параметров для инициализации.</param>
	/// <param name="values">Значение сторон, которые необходимы для создания фигуры.</param>
	protected FigureBase(int paramsLength, in double[] values)
	{
		ParamsLength = paramsLength;

		if (values is null)
			throw new ArgumentNullException(nameof(values));

		if (values.Length != ParamsLength)
			throw new ArgumentOutOfRangeException(nameof(values), $"Некорректная длина параметров ({values.Length}) для инициализации фигуры.");

		for (int i = 0; i < ParamsLength; ++i)
			if (values[i] < 0)
				throw new InvalidDataException("Значения для сторон не могут быть меньше нуля.");
	}

	/// <summary>
	/// Метод расчета площади фигуры.
	/// </summary>
	/// <returns>Возвращает значение площади фигуры.</returns>
	public double CalculateSquare() =>
		_squareInstance ??= CalculateSquareInternal();

	/// <summary>
	/// Внутренний метод расчета площади фигуры.
	/// </summary>
	/// <returns>Возвращает значение площади фигуры.</returns>
	protected abstract double CalculateSquareInternal();
}
