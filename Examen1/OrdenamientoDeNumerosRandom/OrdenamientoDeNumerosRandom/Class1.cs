using System;

namespace OrdenamientoDeNumerosRandom
{
    public class Programa7
    {
        private int[] numerosDesaordenados = new int[10]; 
        private int[] numerosOrdenados = new int[10];
        private int valorAuxiliar;
        public bool Proceso()
        {
            Console.Clear();
            Console.WriteLine("7.- Ordenamiento de numeros random");
            Random r = new Random();
            Console.WriteLine("Numeros desordenados");
            for(int contador = 0; contador < 10; contador++)
            {
                numerosDesaordenados[contador] = r.Next(0, 101);
                numerosOrdenados[contador] = numerosDesaordenados[contador];
                Console.WriteLine(numerosDesaordenados[contador]);
            }

            for (int contador = 1; contador <= 10; contador++)
            {
                for (int contador1 = 0, contador2 = 1; contador2 < 10; contador1++, contador2++)
                {
                    if (numerosOrdenados[contador1] > numerosOrdenados[contador2])
                    {
                        valorAuxiliar = numerosOrdenados[contador1];
                        numerosOrdenados[contador1] = numerosOrdenados[contador2];
                        numerosOrdenados[contador2] = valorAuxiliar;
                    }
                    else { }
                }
            }

            Console.WriteLine("\n\nNumeros desordenados");
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(numerosOrdenados[contador]);
            }

            Console.WriteLine("Gracias por utilizar el programa.\nPresione una tecla para continuar.");
            Console.ReadKey();
            return (true);
        }
    }
}
