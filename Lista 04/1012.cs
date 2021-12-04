//Área
using System; 

class URI {

    static void Main(string[] args) { 

      string[] Valores = Console.ReadLine().Split(' ');

      double A = double.Parse(Valores[0]);
      double B = double.Parse(Valores[1]);
      double C = double.Parse(Valores[2]);

      Console.WriteLine($"TRIANGULO: {(A*C)/2.0:0.000}
CIRCULO: {3.14159*Math.Pow(C, 2):0.000}
TRAPEZIO: {((A+B)*C)/2.0:0.000}
QUADRADO: {B*B:0.000}
RETANGULO: {A*B:0.000}");
    }

}