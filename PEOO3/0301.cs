
using System;
using System.Diagnostics;

class main 
{
    public static void Main()
    {
        Retangulo teste402 = new Retangulo();

        teste402.SetBase(3);
        teste402.SetAltura(5);

        Console.WriteLine(teste402);
    }
}


    class Retangulo
{
    private double b;
    private double h;
    public void SetBase(double b) 
    {
        this.b = b;
    }
    public void SetAltura(double h) 
    {
        this.h = h;
    }
    public double GetBase() 
    {
        return b;
    }
    public double GetAltura() 
    {
        return h;
    }
    public double CalcArea() 
    {
        return b*h;
    }
    public double CalcDiagonal()
    {
        return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    }
    public override string ToString()
    {
        return $"base = {b}\naltura = {h}";
    }
}
