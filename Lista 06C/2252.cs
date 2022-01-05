using System;
using System.Collections;

class URI 
{
  static void Main(string[] args)
  { 
    int N = 5;
    string[] StringValues = {"0.02", "0.23", "0.07"," 0.18", "0.17", "0.72", "0.48", "0.36", "0.67", "0.35"};

    float[] Values = new float[10];

    float aux; 

    for (int i = 0; i < 10; i++)
    {
      foreach (float valor in Values)
      {
      Console.WriteLine(valor);
      }
      Console.WriteLine("-----------------------------");
      if (i == 0) 
      {
        Values[0] = float.Parse(StringValues[0]);
      }
      else
      {
        if (Values[0] < float.Parse(StringValues[0]))
        {
          aux = Values[0];
          Values[0] = float.Parse(StringValues[0]);
          Values.Append(aux);
        }
      }
    }

  }
}