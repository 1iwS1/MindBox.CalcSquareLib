using MindBox.CalcSquareLib.Abstractions;


namespace MindBox.CalcSquareLib.Models
{
    public class Triangle : IShape, ITriangleShape
  {
    public double[] Sides { get; private set; }

    public Triangle(double[] sides)
    {
      if (sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
      {
        throw new ArgumentException($"'{nameof(sides)}' must be more than 0");
      }

      if (!(sides[0] + sides[1] >= sides[2]
        && sides[1] + sides[2] >= sides[0]
        && sides[2] + sides[0] >= sides[1]))
      {
        throw new ArgumentException("Such a triangle does not exist");
      }

      Sides = sides;
    }

    public double GetSquare()
    {
      double semiperimeter = 0.5 * (Sides[0] + Sides[1] + Sides[2]);

      return Math.Round(Math.Sqrt(semiperimeter * (semiperimeter - Sides[0]) * (semiperimeter - Sides[1]) * (semiperimeter - Sides[2])));
    }

    public bool IsRight()
    {
      Array.Sort(Sides);

      return (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2));
    }
  }
}
