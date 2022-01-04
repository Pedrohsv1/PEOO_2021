using System; 

class URI {

    static void Main(string[] args) { 

      int[] N = new int[10];
      int X = int.Parse(Console.ReadLine());

      for (int i = 0; i < 10; i++) {

        Console.WriteLine($"N[{i}] = {X}");

        X *= 2;
        
      }
    }

}
//ok