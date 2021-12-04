using System; 

class URI {

    static void Main(string[] args) { 

      string[] Xs = Console.ReadLine().Split(' ');
      string[] Ys = Console.ReadLine().Split(' ');

      double X1, X2, Y1, Y2;

      X1 = double.Parse(Xs[0]);
      Y1 = double.Parse(Xs[1]);
      X2 = double.Parse(Ys[0]);
      Y2 = double.Parse(Ys[1]);

      double DISTANCIA = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
      
      Console.WriteLine($"{DISTANCIA:0.0000}");
    }

}