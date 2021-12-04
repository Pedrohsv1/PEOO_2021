using System; 

class URI {

    static void Main(string[] args) { 

      double TEMPO_GASTO = double.Parse(Console.ReadLine());
      double VELOCIDA_MEDIA = double.Parse(Console.ReadLine());

      double LITROS = (VELOCIDA_MEDIA*TEMPO_GASTO)/12.0;

      Console.WriteLine($"{LITROS:0.000}");

    }

}