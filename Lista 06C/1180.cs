using System; 

class URI {

    static void Main(string[] args) { 

      int N = int.Parse(Console.ReadLine());
      int menor = 0;
      int pos = 0;

      string v = Console.ReadLine();
      string[] valores = v.Split(' ');

      int[] A = new int[N];

      for (int i = 0; i < N; i++) {

        A[i] = int.Parse(valores[i]);

        if (i == 0) {
          menor = A[i];
        }
        else {
          if (A[i] < menor) {
            menor = A[i];                         
            pos = i;
            }
        }

      }
      Console.WriteLine($"Menor valor: {menor}");
      Console.WriteLine($"Posicao: {pos}");
    }

}
//ok