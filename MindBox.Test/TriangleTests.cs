using MindBox.CalcSquareLib;
using MindBox.CalcSquareLib.Models;


namespace MindBox.Test
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void SquareChecking_3_4_5()
    {
      // Act
      double[] doubles = { 3, 4, 5 };
      IShape triangle = new Triangle(doubles);

      // Assert
      Assert.AreEqual(6, triangle.GetSquare());
    }

    [TestMethod]
    public void SquareChecking_6_8_9()
    {
      // Act
      double[] doubles = { 6, 8, 9 };
      IShape triangle = new Triangle(doubles);

      // Assert
      Assert.AreEqual(24, triangle.GetSquare());
    }

    [TestMethod]
    public void IsRight_9_12_15()
    {
      // Act
      double[] doubles = { 9, 12, 15 };
      IShape triangle = new Triangle(doubles);

      // Assert
      Assert.IsTrue(triangle.IsRight());
    }

    [TestMethod]
    public void IsNotRight_5_2_4()
    {
      // Act
      double[] doubles = { 5, 2, 4 };
      IShape triangle = new Triangle(doubles);

      // Assert
      Assert.IsFalse(triangle.IsRight());
    }

    [TestMethod]
    public void IncorrectInput_3_4_0()
    {
      // Act
      double[] doubles = { 3, 4, 0 };
      IShape triangle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(doubles));
    }

    [TestMethod]
    public void IncorrectInput_3_0_5()
    {
      // Act
      double[] doubles = { 3, 0, 5 };
      IShape triangle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(doubles));
    }

    [TestMethod]
    public void IncorrectInput_0_4_5()
    {
      // Act
      double[] doubles = { 0, 4, 5 };
      IShape triangle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(doubles));
    }

    [TestMethod]
    public void NonExistentTriangle_1_2_9()
    {
      // Act
      double[] doubles = { 1, 2, 9 };
      IShape triangle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(doubles));
    }

    [TestMethod]
    public void NonExistentTriangle_7_20_5()
    {
      // Act
      double[] doubles = { 7, 20, 5 };
      IShape triangle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(doubles));
    }

    [TestMethod]
    public void NonExistentTriangle_7_5_1()
    {
      // Act
      double[] doubles = { 7, 5, 1 };
      IShape triangle;

      // Assert
      Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(doubles));
    }
  }
}
