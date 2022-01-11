using System;

class main 
{
    public static void Main()
    {
        double[] v = {30, 25, 69, 50};
        disciplina aluno1 = new disciplina(v, 100);

        double media1 = aluno1.Media();
        double media1_final = aluno1.Media_Final();

        Console.WriteLine(media1);
        Console.WriteLine(media1_final);

    }
}

class disciplina 
{
    private double[] notas = new double[4];
    private double prova_final;

    public disciplina(double[] notas, double prova_final)
    {
        this.notas = notas;
        this.prova_final = prova_final;
    }
    public disciplina(double[] notas)
    {
        this.notas = notas;
    }
    public double Media()
    {
        return ((notas[0]*2) + (notas[1]*2) + (notas[2]*3) + (notas[3]*3)) / 10;
    }
    public double Media_Final()
    {

        return (Media() + prova_final) / 2;
    }
    
}