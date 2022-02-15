using System;

class main
{
  public static void Main()
  {
    Pais a = new Pais {Nome = "Brasil", Ouro = 5, Prata = 2, Bronze = 5};
    Pais b = new Pais {Nome = "Japão", Ouro = 6, Prata = 4, Bronze = 1};
    Pais c = new Pais {Nome = "China", Ouro = 10, Prata = 1, Bronze = 0};
    Pais d = new Pais {Nome = "Nigeria", Ouro = 5, Prata = 2, Bronze = 5};
    Pais e = new Pais {Nome = "Alemanha", Ouro = 6, Prata = 7, Bronze = 4};

    QuadroMedalhas x = new QuadroMedalhas();

    x.Inserir(a);
    x.Inserir(b);
    x.Inserir(c);
    x.Inserir(d);
    x.Inserir(e);

    foreach (Pais p in x.Listar())
    {
      Console.WriteLine(p);
    }

    Console.WriteLine("Lista 02 =============-");

    Pais[] y = x.Listar();
    Array.Sort(y);
    foreach (Pais p in y)
    {
      Console.WriteLine(p);
    }
  }
}
class QuadroMedalhas
{
  private Pais[] Paises = new Pais[195];
  private int Qtd = 0;

  public void Inserir(Pais p)
  {
    Paises[Qtd] = p;
    Qtd++;
  }
  public Pais[] Listar()
  {
    Pais[] ArrayAux = new Pais[Qtd];
    Array.Copy(Paises, ArrayAux, Qtd);
    return ArrayAux;
  }

}
class Pais : IComparable
{
  public string Nome { set; get;}
  public int Ouro { set; get;}
  public int Prata { set; get;}
  public int Bronze { set; get;}

  public int CompareTo(object obj)
  {
    Pais x = this;
    Pais y = (Pais) obj;

    if (x.Ouro.CompareTo(y.Ouro) == -1) return 1;
    if (x.Ouro.CompareTo(y.Ouro) == 1) return -1;
    if (x.Prata.CompareTo(y.Prata) == -1) return 1;
    if (x.Prata.CompareTo(y.Prata) == 1) return -1;
    if (x.Bronze.CompareTo(y.Bronze) == -1) return 1;
    if (x.Bronze.CompareTo(y.Bronze) == 1) return -1;
    return x.Nome.CompareTo(y.Nome);
  }

  public override string ToString()
  {
    return $"Nome: {Nome, 15} - Ouro: {Ouro, 3} - Prata: {Prata, 3} - Bronze: {Bronze, 3}";
  }
}