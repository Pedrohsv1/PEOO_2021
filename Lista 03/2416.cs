//corrida
using System; 

class URI {

    static void Main(string[] args) { 

      int CORRIDA, PISTA;
      string[] valores = Console.ReadLine().Split(" ");
      CORRIDA = int.Parse(valores[0]);
      PISTA = int.Parse(valores[1]);

      int FIM = CORRIDA%PISTA;

      Console.WriteLine($"{FIM}");

    }

}