using System;

class main 
{
    public static void Main()
    {
        viagem canada = new viagem(1560, 34, 30);
        double velo_media = canada.velo_media();

        Console.WriteLine($"{velo_media:0.0000}");
    }
}

class viagem
{
    private double Kilometros;
    private double Tempo;

    public viagem(double kilometros, double horas, double minutos)
    {

        Kilometros = kilometros;
        Tempo = horas + (minutos/60);
    }
    public double velo_media()
    {
        // v = s/t
        return Kilometros / Tempo;
    }
    
}