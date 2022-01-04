using System; 

class URI {

    static void Main(string[] args) { 

        int COLUNAS = 12;
        int LINHAS = 12;

        string O = Console.ReadLine();

        float soma = 0, aux1 = 0;
        
        float[,] valores = new float[COLUNAS, LINHAS];

        for (int i = 0; i < LINHAS; i++) {

          for (int j = 0; j < COLUNAS; j++) {

            valores[i, j] = float.Parse(Console.ReadLine());

            if (j > aux1) {

              soma += valores[i, j];
            }
          }
          aux1++;
        }
        if (O == "S") {
           Console.WriteLine($"{soma:0.0}");
        }
        else {
           Console.WriteLine($"{soma/66.0:0.0}");
        }
         

    }

}
//ok