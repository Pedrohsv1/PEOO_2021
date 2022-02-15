using System;

class main 
{
  public static void Main()
  {
    Frete x = new Frete();
    x.Distancia = 122.5;
    x.Peso = 21.3;

    Console.WriteLine(x);
  }
}

class Frete
{
  private double distancia;
  private double peso;

  public double Distancia
  {
    get {return distancia;}
    set {if (value > 0) distancia = value;}
  }
  public double Peso
  {
    get {return peso;}
    set {if (value > 0) peso = value;}
  }
  public double ValorFrete
  {
    get {return (0.01*peso)*distancia;}
  }
  public override string ToString()
  {
    return $"D = {distancia} || P = {peso} || Valor Frete = {this.ValorFrete:0.00} R$";
  }
}