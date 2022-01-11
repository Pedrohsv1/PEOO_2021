
using System;

class main 
{
    public static void Main()
    {
        double y, w, z;
        double x1, x2;
        Equacao x = new Equacao(1, 2, 3);

        x.GetABC(out y, out w, out z);
        x.RaizesReais(out x1, out x2);
        Console.WriteLine($"{y} - {w} - {z}");
        Console.WriteLine(x);
        Console.WriteLine($"{x1} - {x2}");

    }
}
class Equacao
{
    private double a;
    private double b;
    private double c;

    public Equacao(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public void SetABC(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public void GetABC(out double a, out double b, out double c)
    {
        a = this.a;
        b = this.b;
        c = this.c;
    }
    public bool RaizesReais(out double x1, out double x2)
    {
        if (Delta() < 0)
        {
            x1 = 0;
            x2 = 0;
            return false;
        }
        else
        {
            x1 = ((-b) + Delta())/(2*a);
            x2 = ((-b) - Delta())/(2*a);
            return true;
        }
        
    }
    public double Delta()
    {
        return Math.Pow(b, 2) + 4 * a * c;
    }
    public override string ToString()
    {
        return $"A = {a}\nB = {b}\nC = {c}";
    }

}