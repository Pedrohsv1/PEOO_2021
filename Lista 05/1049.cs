using System; 

class URI {

    static void Main(string[] args) { 

      string A = Console.ReadLine();
      string B = Console.ReadLine();
      string C = Console.ReadLine();


      if(A == "vertebrado"){
        if(B == "ave"){
            if(C == "onivoro"){
              Console.WriteLine("pomba");
            }
            else{
              Console.WriteLine("aguia");
            }
        }
        else{
            if(C == "onivoro"){
              Console.WriteLine("homen");
            }
            else{
              Console.WriteLine("vaca");
            }
        }
      }
      else{
        if(B == "insetp"){
            if(C == "hematofago"){
              Console.WriteLine("pulga");
            }
            else{
              Console.WriteLine("lagarta");
            }
        }
        else{
            if(C == "hematofago"){
              Console.WriteLine("sanguessuga");
            }
            else{
              Console.WriteLine("minhoca");
            }
        }
      }
    }

}