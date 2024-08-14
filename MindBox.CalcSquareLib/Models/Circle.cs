using MindBox.CalcSquareLib.Abstractions;


namespace MindBox.CalcSquareLib.Models
{
    public class Circle : IShape
  {
    public double Radius { get; private set; }

    public Circle(double radius)
    {
      if (radius <= 0)
      {
        throw new ArgumentException($"'{nameof(radius)}' must be more than 0");
      }

      Radius = radius;
    }

    public double GetSquare()
    {
      return Math.Round(Math.PI * Math.Pow(Radius, 2));
    }
  }
}
