using System; 

class URI {

    static void Main(string[] args) { 

      int[] X = new int[10];

      for (int i = 0; i < 10; i++) {

        int x = int.Parse(Console.ReadLine());

        if (x < 1) x = 1;

        Console.WriteLine($"X[{i}] = {x}");

      }
    }

}
//ok