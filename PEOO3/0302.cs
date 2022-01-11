
using System;

class main 
{
    public static void Main()
    {

    }
}
class Frete
{
    double distancia;
    double peso;

    public Frete(double distancia, double peso)
    {
        this.distancia = distancia;
        this.peso = peso;
    }

    public void SetDistancia(double d) 
    {
        this.distancia = d;
    }
    public void SetPeso(double p)
    {
        this.peso = p;
    }
    public double GetDistancia() 
    {
        return distancia;
    }
    public double GetPeso()
    {
        return peso; 
    }
    public double CalcFrete()
    {
        return (peso/distancia) * 0.01;
    }
    public override string ToString()
    {
        return $"Distância = {distancia:0.00} Km\nPeso = {peso:0.00}";
    }