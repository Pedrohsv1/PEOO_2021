using System;

class main
{
  public static void Main (string[] args)
  {
    Circulo x = new Circulo(4);
    double a = x.area();
    double c = x.circunferencia();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine(a);
    Console.WriteLine(c);
    Console.WriteLine("------------------------------------------");
  }
}

class Circulo
{
  private double raio;
  private double PI = 3.14f;

    public Circulo(double raio)
    {
        this.raio = raio;
    }
    public double area()
    {
        return PI * Math.Pow(raio, 2);
    }
    public double circunferencia()
    {
        return PI*(2*raio);
    }

}

