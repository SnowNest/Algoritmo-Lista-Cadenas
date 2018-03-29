using System;
using System.Collections.Generic;

namespace algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            List<int> lista2 = new List<int>();
            do
            {
                Console.WriteLine("ingrese un numero: ");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Otro? S/N: ");
                var opcion = Console.ReadLine();
                Console.Clear();
                if (opcion == "n" || opcion == "N")
                {
                    break;
                }
            } while (1 == 1);
            for(int i = 0; i < lista.Count; i++)
            {
                if (i == 0)
                    lista2.Add(lista[i]);
                try
                {
                    if (lista[i] > lista[i + 1])
                        lista2.Add(lista[i + 1]);
                }
                catch (Exception e) { }                
            }
            Console.WriteLine("todos los valores:");
            foreach (int valores in lista)
            {
                Console.WriteLine(valores);
            }
            Console.WriteLine("valores filtrados:");
            foreach (int valores in lista2)
            {
                Console.WriteLine(valores);
            }
            Console.ReadKey();
        }
    }
}
