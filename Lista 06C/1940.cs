using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');

        string[] pontuacao = Console.ReadLine().Split(' ');
        
        int J = int.Parse(valores[0]), R = int.Parse(valores[1]);

        int[] jogadores = new int[J];

        for (int i = 0; i < J; i++)
        {

          jogadores[i] = 0;

        }

        for (int i = 0; i < R * J; i++) 
        {

          jogadores[i%J] += int.Parse(pontuacao[i]);

        }

        int maior = jogadores[0];
        int pos = 0;

        for (int i = 0; i < J; i++)
        {
          if (maior <= jogadores[i])
          {

            maior = jogadores[i];
            pos = i;

          }
        }

        Console.WriteLine(pos+1);

    }

}
//ok