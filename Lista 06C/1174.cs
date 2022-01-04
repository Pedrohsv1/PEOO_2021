using System; 

class URI {

    static void Main(string[] args) { 

      float[] A = new float[100];

      for (int i = 0; i < 100; i++) {

        A[i] = float.Parse(Console.ReadLine());

        if (A[i] <= 10) Console.WriteLine($"A[{i}] = {A[i]:0.0}");
      }
    }

}
//ok