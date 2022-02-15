using System;
class MainClass 
{
    public static void Main() 
    {
        DateTime x = new DateTime(2004, 1, 21);
        
        Paciente p402 = new Paciente("Pedro", "986723004", "991030036", x);

        string idade = p402.idade();

        Console.WriteLine(idade);
        Console.WriteLine(p402);
    }
}
class Paciente 
{
    string nome;
    string cpf;
    string telefone;
    DateTime nascimento;

    public Paciente(string nome, string cpf, string telefone, DateTime nascimento)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.telefone = telefone;
        this.nascimento = nascimento;
    }

    public string idade()
    {
        int idade = 0;int meses = 0;

        DateTime y = DateTime.Now;
        idade += y.Year - nascimento.Year - 1;
        meses += y.Month - nascimento.Month;
        if (meses > 0)
        {
            idade++;
        }
        else
        {
            if( meses == 0)
            {
                if (y.Day >= nascimento.Day)
                {
                    idade++;
                }
                else
                {
                    meses = 11;
                }
            }
            else
            {
                meses += 12;
            }
        }
        return $"{idade} Anos e {meses} Meses.";
    }
    public override string ToString()
    {
        return $"{nome} {cpf} {telefone} {nascimento}";
    }
}