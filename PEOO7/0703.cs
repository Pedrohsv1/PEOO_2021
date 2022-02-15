using System;

class main 
{
  public static void Main()
  {
    Compromisso ReuniaoAuxiliares = new Compromisso();

    ReuniaoAuxiliares.Assunto = "Carga Horária dos Auxiliares";

    ReuniaoAuxiliares.Local = "Rua dos Piantis, 183";

    DateTime RAHorario = new DateTime( 2022, 02, 21);
    ReuniaoAuxiliares.Data = RAHorario;

    Compromisso ReuniaoProfessores = new Compromisso();

    ReuniaoProfessores.Assunto = "Pagamentos dos Professores";

    ReuniaoProfessores.Local = "Rua dos Piantis, 185";

    DateTime RPHorario = new DateTime( 2022, 02, 18);
    ReuniaoProfessores.Data = RPHorario;

    Compromisso ReuniaoDiretores = new Compromisso();

    ReuniaoDiretores.Assunto = "Pagamentos dos Diretores";

    ReuniaoDiretores.Local = "Rua dos Bambus, 185";

    DateTime RDHorario = new DateTime( 2022, 03, 17);
    ReuniaoDiretores.Data = RDHorario;

    Compromisso ReuniaoAlunos = new Compromisso();

    ReuniaoAlunos.Assunto = "Notas dos Alunos";

    ReuniaoAlunos.Local = "Rua dos Piantis, 184";

    DateTime RALHorario = new DateTime( 2022, 04, 20);
    ReuniaoAlunos.Data = RALHorario;

    Agenda x = new Agenda();
    x.Inserir(ReuniaoAuxiliares);
    x.Inserir(ReuniaoProfessores);
    x.Inserir(ReuniaoDiretores);
    x.Inserir(ReuniaoAlunos);

    x.Excluir(ReuniaoDiretores);

    foreach (Compromisso c in x.Listar())
    {
      Console.WriteLine(c);
    }
    Console.WriteLine("=======================================================================================================");
    foreach (Compromisso c in x.Pesquisar(2, 2022))
    {
      Console.WriteLine(c);
    }
  }
}

class Agenda
{
  private int k = 0;
  private Compromisso[] comps = new Compromisso[10];
  public int Qtd { get => k; }


  public void Inserir(Compromisso c)
  {
    comps[k] = c;
    k++;
  }
  public void Excluir(Compromisso c)
  {
    Compromisso[] ArrayAux = new Compromisso[k];
    int aux = 0;
    int aux1 = Qtd;
    for (int i = 0; i < aux1; i++)
    {
      if (comps[i].Assunto == c.Assunto)
      {
        k = k - 1;
      }
      else
      {
        ArrayAux[aux] = comps[i];
        aux++;
      }
    }
    Array.Copy(ArrayAux, comps, aux);
  }
  public Compromisso[] Listar()
  {
    Compromisso[] ArrayAux = new Compromisso[k];
    Array.Copy(comps, ArrayAux, k);
    return ArrayAux;
  }
  public Compromisso[] Pesquisar(int mes, int ano)
  {
    int aux = 0;
    for(int i = 0; i < k; i++)
    {
      if (comps[i].Data.Month == mes && comps[i].Data.Year == ano)
      {
        aux++;
      }
    }
    Compromisso[] ArrayAux = new Compromisso[aux];
    int aux1 = 0;
    for(int i = 0; i < k; i++)
    {
      if (comps[i].Data.Month == mes && comps[i].Data.Year == ano)
      {
        ArrayAux[aux1] = comps[i];
        aux1++;
      }
    }
    return ArrayAux;
  }
}
class Compromisso
{
  public string Assunto { get; set;}
  public string Local { get; set;}
  public DateTime Data { get; set;}


  public override string ToString()
  {
    return $"Assunto: {Assunto} || Local: {Local} || Horário: {Data}";
  }
}