using System; 

class URI {

    static void Main(string[] args) { 
        
        string[] Valores = Console.ReadLine().Split();

        double A = double.Parse(Valores[0]);
        double B = double.Parse(Valores[1]);
        double C = double.Parse(Valores[2]);

        double DELTA = B*B - 4.0*A*C;

        if(A == 0.0 || DELTA < 0)
        {
          Console.WriteLine("Impossivel calcular");
        }
        else
        {
          double X1 = ((-B) + Math.Sqrt(DELTA)) / (2*A);
          double X2 = ((-B) - Math.Sqrt(DELTA)) / (2*A);
          Console.WriteLine($"R1 = {X1:0.00000}\nR2 = {X2:0.00000}");
        }
        
    }

}