using System; 

class URI {

    static void Main(string[] args) { 

      double cobaia = 0, coelho = 0, rato = 0, sapo = 0;

      int quantia = int.Parse(Console.ReadLine());

      for(int i = 0; i < quantia; i++)
      {
        string[] valores = Console.ReadLine().Split();

        cobaia += double.Parse(valores[0]);

        if(valores[1] == "C")
        {
          coelho += double.Parse(valores[0]);
        }
        if(valores[1] == "R")
        {
          rato += double.Parse(valores[0]);
        }
        if(valores[1] == "S")
        {
          sapo += double.Parse(valores[0]);
        }
      }
      Console.WriteLine($"Total: {cobaia} cobaias");
      Console.WriteLine($"Total de coelhos: {coelho}");
      Console.WriteLine($"Total de ratos: {rato}");
      Console.WriteLine($"Total de sapos: {sapo}");
      Console.WriteLine($"Percentual de coelhos: {coelho/cobaia * 100:0.00} %");
      Console.WriteLine($"Percentual de ratos: {rato/cobaia * 100:0.00} %");
      Console.WriteLine($"Percentual de sapos: {sapo/cobaia * 100:0.00} %");
    }

}