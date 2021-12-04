using System; 

class URI {

    static void Main(string[] args) {

      string[] valores = Console.ReadLine().Split(' ');

      int Soma = 0;

      for(int i = 0; i < 4; i++){

        Soma += int.Parse(valores[i]);
      }
      Console.WriteLine($"{Soma-3}");
    }

}