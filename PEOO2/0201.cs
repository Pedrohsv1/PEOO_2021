using System;

class main
{
  public static void Main (string[] args)
  {
    Circulo x = new Circulo(4);
    double a = x.CalcArea();
    double c = x.CalcCirncunferencia();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine(a);
    Console.WriteLine(c);
    Console.WriteLine("------------------------------------------");
  }
}

class Circulo
{
  private double raio;
  double PI = 3.14f;


    public void SetRaio(double raio) 
    {
        this.raio = raio;
    }
    public double GetRaio(double raio) 
    {
        return raio;
    }
    public double CalcArea()
    {
        return PI * Math.Pow(raio, 2);
    }
    public double CalcCirncunferencia()
    {
        return PI*(2*raio);
    }
        public Circulo(double raio)
    {
        this.raio = raio;
    }

}