using System;

namespace MayorASuPredecesor
{
    public class Programa6
    {
        private double[] numeros;
        private int posicion, cantidadNumeros;
        private double numero;
        private bool finProceso = false, existeCondicion = false;
        public bool Proceso()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("6.- Indice del primer elemento que es mayor a si predecesor de una sucesion S1,...,Sn");
                try
                {
                    Console.WriteLine("Ingresa la cantidad de numeros: ");
                    cantidadNumeros = Convert.ToInt16(Console.ReadLine());
                    numeros = new double[cantidadNumeros];
                    for(int contador = 0; contador < cantidadNumeros; contador++)
                    {
                        Console.Write("{0}.- Ingresa un numero: ", (contador + 1));
                        numeros[contador] = Convert.ToDouble(Console.ReadLine());

                        if(contador == 0)
                        {

                        }
                        else
                        {
                            if(existeCondicion == false)
                            {
                                if (numeros[contador - 1] > numeros[contador])
                                {
                                    existeCondicion = true;
                                    numero = numeros[contador - 1];
                                    posicion = contador;
                                }
                                else{ }
                            }
                            else { }
                        }
                    }

                    if(existeCondicion == true)
                    {
                        Console.WriteLine("El numero mayor a su predecesor es {0} y se encuentra en la posicion {1}.", numero, posicion);
                    }
                    else
                    {
                        Console.WriteLine("0, no existe numero mayor a su predecesor.");
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