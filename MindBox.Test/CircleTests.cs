using MindBox.CalcSquareLib.Abstractions;
using MindBox.CalcSquareLib.Models;


namespace MindBox.Test
{
    [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void SquareChecking_5()
    {
      // Act
      IShape circle = new Circle(5);

      // Assert
      Assert.AreEqual(79, circle.GetSquare());
    }

    [TestMethod]
    public void SquareChecking_1()
    {
      // Act
      IShape circle = new Circle(1);

      // Assert
      Assert.AreEqual(3, circle.GetSquare());
    }

    [TestMethod]
    public void SquareChecking_10_2()
    {
      // Act
      IShape circle = new Circle(10.2);

      // Assert
      Assert.AreEqual(327, circle.GetSquare());
    }

    [TestMethod]
    public void IncorrectInput_0()
    {
      // Act
      IShape circle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => circle = new Circle(0));
    }

    [TestMethod]
    public void IncorrectInput_negative()
    {
      // Act
      IShape circle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => circle = new Circle(-5));
    }
  }
}