using System; 

class URI {

    static void Main(string[] args) { 
      string senha = "2002";
      string tentativa = "0000";

      while(tentativa != senha)
      {
        tentativa = Console.ReadLine();
        if(tentativa != senha)
        {
          Console.WriteLine("Senha Invalida");
        }
      }
      Console.WriteLine("Acesso Permitido");
    }

}