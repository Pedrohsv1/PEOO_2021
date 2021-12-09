using System; 

class URI {

    static void Main(string[] args) { 

      int A1 = int.Parse(Console.ReadLine());
      int A2 = int.Parse(Console.ReadLine());
      int A3 = int.Parse(Console.ReadLine());

      int eficiencia = A2 * 2 + A3 * 4;

      if(A1*2 + A3*2 < eficiencia)
      {
        eficiencia = A1*2 + A3*2;
      }
      if(A1*4 + A2*2 < eficiencia)
      {
        eficiencia = A1*4 + A2*2;
      }
      Console.WriteLine(eficiencia);
    } 
}