namespace MindBox.CalcSquareLib
{
  public interface IShape
  {
    double GetSquare();
    virtual bool IsRight() => false;
  }
}