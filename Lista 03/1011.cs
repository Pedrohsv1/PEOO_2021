using System; 

class URI {

    static void Main(string[] args) { 
      double PI = 3.14159;
      //Raio
      double RAIO = double.Parse(Console.ReadLine());

      double ESFERA = (4.0/3) * PI * (Math.Pow(RAIO, 3));

      Console.WriteLine($"VOLUME = {ESFERA:0.000}");
    }

}