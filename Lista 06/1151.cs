using System; 

class URI {

    static void Main(string[] args) { 

      int x = 0;
      int y = 1;
      int aux = 0;

      int N = int.Parse(Console.ReadLine());

      Console.Write(x + " ");
      Console.Write(y + " ");


      for(int i = 2; i < N; i ++)
      {
        aux = x + y;
        if(i == N - 1)
        {
          Console.WriteLine(aux);
        }
        else
        {
          Console.Write(aux + " ");
        }
        
        x = y;
        y = aux;
      }
    }

}