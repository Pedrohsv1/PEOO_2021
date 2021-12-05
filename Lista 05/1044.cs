using System; 

class URI {

    static void Main(string[] args) {

      string[] Valores = Console.ReadLine().Split();

      int A = int.Parse(Valores[0]);
      int B = int.Parse(Valores[1]);

      Console.WriteLine(A%B);

      if(A%B == 0 || A%B == A){
        Console.WriteLine("Sao Multiplos");
      }
      else{
        Console.WriteLine("Nao sao Multiplos");
      }
      
    }

}