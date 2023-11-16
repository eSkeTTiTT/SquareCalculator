using SquareCalculator.Factory;
using SquareCalculator.Models.Enums;

var circle = FigureFactory.CreateFigure(FigureType.Circle, 4);
var triangle = FigureFactory.CreateFigure(FigureType.Triangle, 3, 4, 5);

Console.WriteLine($"Площадь круга: {circle.CalculateSquare()}");
Console.WriteLine($"Площадь треугольника: {triangle.CalculateSquare()}");
