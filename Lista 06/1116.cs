using System; 

class URI {

    static void Main(string[] args) { 
      int N = int.Parse(Console.ReadLine());

      for(int i = 0; i < N; i++)
      {
        string[] valores = Console.ReadLine().Split();
        if(valores[1] == "0")
        {
          Console.WriteLine("divisao impossivel");
        }
        else
        {
          Console.WriteLine($"{double.Parse(valores[0])/double.Parse(valores[1]):0.0}");
        }
      }
    }

}