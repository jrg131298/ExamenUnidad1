using System;

namespace MenorMayor
{
    public class Programa1
    {
        private Int16 cantidadNumeros;
        private double[] numeros;
        private double menor = 0, mayor = 0;
        private bool finProceso = false;
        public bool Proceso()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Valor menor y mayor de una sucecion S1,...,Sn");
                Console.WriteLine("Ingresa la cantidad de numeros: ");
                try
                {
                    cantidadNumeros = Convert.ToInt16(Console.ReadLine());
                    numeros = new double[cantidadNumeros];

                    for (int contador = 0; contador < cantidadNumeros; contador++)
                    {
                        Console.Write("{0}.- Ingresa un numero: ", (contador + 1));
                        numeros[contador] = Convert.ToDouble(Console.ReadLine());

                        if (contador == 0)
                        {
                            mayor = numeros[contador];
                            menor = numeros[contador];
                        }
                        else
                        {
                            if (numeros[contador] > mayor)
                            {
                                mayor = numeros[contador];
                            }
                            else { }

                            if (numeros[contador] < menor)
                            {
                                menor = numeros[contador];
                            }
                            else { }
                        }
                    }
                    Console.WriteLine("\nEl numero mas grande es {0}.", mayor);
                    Console.WriteLine("El numero mas chico es {0}.", menor);
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
