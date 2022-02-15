using System;

class main
{
    public static void Main()
    {
      Retangulo x = new Retangulo();
      x.Base = 3;
      x.Altura = 4;

      Console.WriteLine(x.Base);
      Console.WriteLine(x.Altura);

      Console.WriteLine(x.Area);
      Console.WriteLine(x.Diagonal);
    }
}
class Retangulo
{
    private double b;
    private double h;

    public double Base
    {
      get { return b; }
      set { if (value > 0) b = value; }
    }
    public double Altura
    {
      get { return h; }
      set { if (value > 0) h = value; }
    }
    public double Area
    {
      get { return b * h / 2; }
    }
    public double Diagonal
    {
      get {return Math.Sqrt((b*b) + (h*h));}
    }
}