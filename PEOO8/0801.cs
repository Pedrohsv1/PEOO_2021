using System;
using System.Collections;
class main
{
  public static void Main()
  {
    DateTime a1 = new DateTime(2004, 02, 21);
    Aluno a = new Aluno{Nome = "Carlos", Matricula = "2022001", Nascimento = a1};
    DateTime b1 = new DateTime(2005, 02, 13);
    Aluno b = new Aluno{Nome = "Andre", Matricula = "2022003", Nascimento = b1};
    DateTime c1 = new DateTime(2004, 03, 15);
    Aluno c = new Aluno{Nome = "Maria", Matricula = "2022002", Nascimento = c1};

    Aluno[] v = {a, b, c};

    Array.Sort(v);
    foreach (Aluno Al in v)
    {
      Console.WriteLine(Al);
    }
    Console.WriteLine("==================================================================");
    Array.Sort(v, new AlunoMatriculaComp());
    foreach (Aluno Al in v)
    {
      Console.WriteLine(Al);
    }
    Console.WriteLine("===================================================================");
    Array.Sort(v, new AlunoNascimentoComp());
    foreach (Aluno Al in v)
    {
      Console.WriteLine(Al);
    }
  }
}
class Aluno : IComparable
{
  public string Nome { get; set;}
  public string Matricula { get; set;}
  public DateTime Nascimento { get; set;}

  public int CompareTo(object obj)
  {
    Aluno x = this;
    Aluno y = (Aluno) obj;
    return x.Nome.CompareTo(y.Nome);
  }
  public override string ToString()
  {
    return $"Nome: {Nome} - Matricula: {Matricula} - Nascimento: {Nascimento:dd/MM/yyyy}";
  }
}
class AlunoMatriculaComp : IComparer
{
  public int Compare(object x, object y)
  {
    Aluno z = (Aluno) x;
    Aluno w = (Aluno) y;
    return z.Matricula.CompareTo(w.Matricula);
  }
}
class AlunoNascimentoComp : IComparer
{
  public int Compare(object x, object y)
  {
    Aluno z = (Aluno) x;
    Aluno w = (Aluno) y;
    if (z.Nascimento.CompareTo(w.Nascimento) == -1) return 1;
    if (z.Nascimento.CompareTo(w.Nascimento) == 1) return -1;
    return 0;
  }
}