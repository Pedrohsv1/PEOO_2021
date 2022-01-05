int[] arrayNumeros = {10, 545, 1, 2, 4, 5, 6, 1456, 0, 49, 5, 6 ,8, 199998};


            int[] ordemDecrescente = arrayNumeros.OrderByDescending(x => x).ToArray();
            int[] ordemCrescente = arrayNumeros.OrderBy(x => x).ToArray();


            Console.Write("Ordem decrescente: ");
            foreach (var item in ordemDecrescente)
            {
                Console.Write(item +" ");
            }

            Console.WriteLine();
            Console.Write("Ordem crescente: ");
            foreach (var item in ordemCrescente)
            {
                Console.Write(item + " ");
            }
          
            Console.Read();