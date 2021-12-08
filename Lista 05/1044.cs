using System; 

class URI {

    static void Main(string[] args) {

      string[] Valores = Console.ReadLine().Split();

      int A = int.Parse(Valores[0]);
      int B = int.Parse(Valores[1]);
      int C;
      if(B > A)
      {
        C = A;
        A = B;
        B = C;
      }

      if(A%B == 0){
        Console.WriteLine("Sao Multiplos");
      }
      else{
        Console.WriteLine("Nao sao Multiplos");
      }
      
    }

}