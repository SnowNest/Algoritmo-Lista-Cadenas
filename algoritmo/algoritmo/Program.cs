using System;
using System.Collections.Generic;

namespace algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            //en lista guardaremos todos los numeros 
            List<int> lista2 = new List<int>();
            //en lista2 guardaremos nutro resulatdo final

            //crearemos un bucle para recolectar los numeros
            do
            {
                Console.WriteLine("Ingrese un numero entero: ");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
                //Add es un metodo que nos permite agregar valores
                //Convert transforma la linea introducida al tipo de variable pedido (Int32 en este caso)
                Console.WriteLine("Otro? S/N: ");
                var opcion = Console.ReadLine(); //esta variable local guardara nustra opcion
                Console.Clear(); //limpiara nuestra pantala para el proximo ciclo o para salir de el
                if (opcion == "n" || opcion == "N")
                    break; //si la opcion es N (sea mayuscula o minuscula) romprea el ciclo, de no ser asi, comparara la condicion del while y repetira el ciclo
              //se usa un do ya que queremos que el ciclo se ejecute al menos una ves  
            } while (1 == 1);
            // 1==1 solo es una condicion para repetir el bucle

            //iniciaremos con la separacion de nustras series
            for (int i = 0; i < lista.Count; i++)
            {
                //siempre comenzaremos con el primer numero de la serie, es por eso que siempre se agregara la posicion 0 de nustra lista
                if (i == 0)
                    lista2.Add(lista[i]);
                try
                {
                    if (lista[i] > lista[i + 1])
                        lista2.Add(lista[i + 1]);
                    //hasta que el numero que siga sea mayor al que esta en la posicion i no se agregara a la lista2
                }
                catch(Exception e) { }
                //el try catch nos permite cerrar la operacion cuando llege a la posicion ultima de lista
                //sin ellos al en posicionultima + 1 cerraria la aplicacion por un error
            }
            //ahora tenemos nuestros valores donde inician las series

            //mostraremos todos los valores de lista y lsita2
            Console.WriteLine("Todos los valores: ");
            foreach(int valores in lista)
            {
                Console.WriteLine(valores);
            }
            Console.WriteLine("Valores de inicio de series: ");
            foreach (int valores in lista2)
            {
                Console.WriteLine(valores);
            }
            Console.ReadKey();//pausa para que no se cierre el programa
        }
    }
}
