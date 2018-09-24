using System;

namespace SucesionInvertida
{
    public class Programa2
    {
        private Int16 cantidadNumeros;
        private double[] numeros;
        private bool finProceso = false;

        public bool Proceso()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("2.- Invertir sucesion S1,...,Sn");
                Console.WriteLine("Ingresa la cantidad de numeros: ");
                try
                {
                    cantidadNumeros = Convert.ToInt16(Console.ReadLine());
                    numeros = new double[cantidadNumeros];
                    for (int contador = 0; contador < cantidadNumeros; contador++)
                    {
                        Console.Write("{0}.- Ingresa un numero: ", (contador + 1));
                        numeros[contador] = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.Clear();
                    Console.WriteLine("Sucesion invertida");
                    for (int contador = (cantidadNumeros - 1); contador >= 0; contador = contador - 1)
                    {
                        Console.WriteLine(numeros[contador]);
                    }
                    finProceso = true;
                }
                catch
                {
                    Console.WriteLine("A ocurrido un error, intente de nuevo.");
                }
                finally
                {
                    Console.Write("Gracias por utilizar el programa.\nPresione una tecla para continuar.");
                    Console.ReadKey();
                }
            } while (finProceso == false);
            return (finProceso);
        }
    }
}
