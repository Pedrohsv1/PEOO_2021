using System;

class main 
{
    public static void Main()
    {
        cinema resenha = new cinema("SegUndA", 18);

        double[] valores = resenha.preco();

        foreach (double valor in valores)
        {
            Console.WriteLine($"{valor:0.00}");
        }
    }
}

class cinema
{
    string dia;
    int horario;

    public cinema(string dia, int horario)
    {
        dia = dia.ToLower();
        this.dia = dia;
        this.horario = horario;
    }
    public double[] preco()
    {
        double[] v = new double[2];
        if (dia == "segunda" || dia == "terça" || dia == "quinta" || dia == "quarta")
        {
            v[0] = 16.00;
            v[1] = 8.00;
        }
        if (dia == "sexta" || dia == "sábado" || dia == "domingo" )
        {
            if (horario >= 17)
            {
                v[0] = 20.00*1.5;
                v[1] = 10.00*1.5;
            }
            else
            {
                v[0] = 20.00;
                v[1] = 10.00;
            }
            
        }
        return v;
        
    }
}