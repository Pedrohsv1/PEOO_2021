using System; 

class URI {

    static void Main(string[] args) {

      while (true) {

        string nm = Console.ReadLine();

        if (nm == String.Empty)
        {
          break;
        }

        string[] NM = nm.Split(' ');

        int N = int.Parse(NM[0]);
        int M = int.Parse(NM[1]);

        int[,] matriz = new int[N,M];

        for (int i = 0; i < N; i++) {
          string[] coluna = Console.ReadLine().Split(' ');

          for (int j = 0; j < M; j++) {
            matriz[i, j] = int.Parse(coluna[j]);
          }
        }
        URI.Mz(matriz, N, M);
      }
    }

    public static void Mz(int[,] vetores, int X, int Y) {
      int contador = 0;

      for (int i = 0; i < X; i++) {
          for (int j = 0; j < Y; j++) {

            if (vetores[i,j] == 1) {

              Console.Write("9");

            }
            else {

              for (int q = 0; q < X; q++) {
                for (int k = 0; k < Y; k++) {

                  if (q == i + 2) {break;}

                  if(q - 1 == i || q + 1 == i || q == i) {

                    if (q != i) {
                        if (k == j)
                        {
                          if (vetores[q, k] == 1)
                          {
                            contador += 1;
                          }
                        }
                    }
                    else {

                      if (k + 1 == j || k - 1 == j) {

                        if (vetores[q, k] == 1)
                        {
                          contador += 1;
                        }

                      }

                    }

                  }
                }
              }
              Console.Write(contador);
              contador = 0;
            }

      }
      Console.WriteLine("");
    }
  }
}