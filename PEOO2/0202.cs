using System;

class main 
{
    public static void Main()
    {
        double[] v = {30, 25, 69, 50};
        disciplina aluno1 = new disciplina("Carlos", 90, 90, 80, 80, 64);

        double media1 = aluno1.CalcMedia();
        double media1_final = aluno1.CalcMediaFinal();

        Console.WriteLine(media1);
        Console.WriteLine(media1_final);

    }
}

class disciplina 
{
    private string nome;
    int nota1, nota2, nota3, nota4, notaFinal;
    public disciplina(string nome, int nota1, int nota2, int nota3, int nota4, int notaFinal)
    {
        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
        this.nota4 = nota4;
        this.notaFinal = notaFinal;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetNota1(int nota1)
    {
        this.nota1 = nota1;
    }
    public void SetNota2(int nota2)
    {
        this.nota2 = nota2;
    }
    public void SetNota3(int nota3)
    {
        this.nota3 = nota3;
    }
    public void SetNota4(int nota4)
    {
        this.nota4 = nota4;
    }
    public void SetNotaFinal(int notaFinal)
    {
        this.notaFinal = notaFinal;
    }
    public string GetNome(string nome)
    {
        return nome;
    }
    public int GetNota1(int nota1)
    {
        return nota1;
    }
    public int GetNota2(int nota2)
    {
        return nota2;
    }
    public int GetNota3(int nota3)
    {
        return nota3;
    }
    public int GetNota4(int nota4)
    {
        return nota4 ;
    }
    public int GetNotaFinal(int notaFinal)
    {
        return notaFinal;
    }
    public int CalcMedia()
    {
        return ((nota1*2) + (nota2*2) + (nota3*3) + (nota4*3)) / 10;
    }
    public int CalcMediaFinal()
    {
        return (CalcMedia() + notaFinal) / 2;
    }
    
}