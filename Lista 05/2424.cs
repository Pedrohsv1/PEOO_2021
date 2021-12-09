using System; 

class URI {

    static void Main(string[] args) { 

      string[] valores = Console.ReadLine().Split();

      int x = int.Parse(valores[0]);
      int y = int.Parse(valores[1]);

      if(x < 0 || x > 432)
      {
        Console.WriteLine("fora");
      }
      else
      {
        if(y < 0 || y > 468)
        {
          Console.WriteLine("fora");
        }
        else
        {
          Console.WriteLine("dentro");
        }
      }
    }

}