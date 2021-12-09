using System; 

class URI {

    static void Main(string[] args) { 
      
      int maior_valor = -1;
      int index = -1;
      for(int i = 0; i < 100; i++)
      {
        int valor = int.Parse(Console.ReadLine());
        if(valor > maior_valor)
        {
          maior_valor = valor;
          index = i + 1;
        }
      }
      Console.WriteLine(maior_valor);
      Console.WriteLine(index);
    }

}