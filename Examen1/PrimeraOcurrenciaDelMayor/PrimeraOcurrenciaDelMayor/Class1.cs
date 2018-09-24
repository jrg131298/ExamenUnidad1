using System;

namespace PrimeraOcurrenciaDelMayor
{
    public class Programa5
    {
        private double[] numeros, vectorAuxiliar;
        private double numeroOcurrencia, valorAuxiliar;
        private int posicionOcurrencia, cantidadNumeros;
        private bool finProceso = false, ocurrencia = false;
        public bool Proceso()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("5.- Indice de la primera ocurrencia del elemento mas grande de una sucesion S1,...,Sn");
                Console.WriteLine("Ingresa la cantidad de numeros: ");
                cantidadNumeros = Convert.ToInt16(Console.ReadLine());
                numeros = new double[cantidadNumeros];
                vectorAuxiliar = new double[cantidadNumeros];
                try
                {
                    for (int contador = 0; contador < cantidadNumeros; contador++)
                    {
                        Console.Write("{0}.- Ingresa un numero: ", (contador + 1));
                        numeros[contador] = Convert.ToDouble(Console.ReadLine());
                        vectorAuxiliar[contador] = numeros[contador];
                    }

                    for (int contador = 1; contador <= cantidadNumeros; contador++)
                    {
                        for (int contador1 = 0, contador2 = 1; contador2 < cantidadNumeros; contador1++, contador2++)
                        {
                            if (vectorAuxiliar[contador1] > vectorAuxiliar[contador2])
                            {
                                valorAuxiliar = vectorAuxiliar[contador1];
                                vectorAuxiliar[contador1] = vectorAuxiliar[contador2];
                                vectorAuxiliar[contador2] = valorAuxiliar;
                            }
                            else { }
                        }
                    }

                    for (int contador1 = (cantidadNumeros - 1); contador1 >= 0; contador1 = contador1 - 1)
                    {
                        for (int contador2 = 0; contador2 <= (contador1 - 1); contador2++)
                        {
                            if (vectorAuxiliar[contador2] == vectorAuxiliar[contador1])
                            {
                                numeroOcurrencia = vectorAuxiliar[contador1];
                                ocurrencia = true;
                                break;
                            }
                            else { }
                        }

                        if (ocurrencia == true)
                        {
                            break;
                        }
                        else
                        { }
                    }

                    if (ocurrencia == true)
                    {
                        for (int contador = 0; contador < cantidadNumeros; contador++)
                        {
                            if (numeros[contador] == numeroOcurrencia)
                            {
                                posicionOcurrencia = (contador + 1);
                                break;
                            }
                            else { }
                        }
                        Console.WriteLine("El numero es {0}, y su posicion es {1}.", numeroOcurrencia, posicionOcurrencia);
                    }
                    else
                    {
                        Console.WriteLine("No existe ocurrencia.");
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
