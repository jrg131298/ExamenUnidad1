using System;

namespace Palindromo
{
    public class Programa8
    {
        private int numero;
        private string numeroDerecho, numeroInvertido = "", valorAuxiliar;
        private bool finProceso = false;

        public bool Proceso()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("8.- Palindromo");
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Ingresa un numero entero de 5 digitos: ");
                        numero = Convert.ToInt16(Console.ReadLine());
                        numeroDerecho = Convert.ToString(numero);
                        if (numeroDerecho.Length == 5)
                        {
                            for(int contador = (numeroDerecho.Length - 1); contador >= 0; contador--)
                            {
                                valorAuxiliar = numeroDerecho.Substring(contador, 1);
                                numeroInvertido = numeroInvertido + valorAuxiliar;
                            }

                            if(numeroDerecho.Equals(numeroInvertido))
                            {
                                Console.WriteLine("El numero {0} es palindromo.", numero);
                            }
                            else
                            {
                                Console.WriteLine("El numero {0} no es palindromo.", numero);
                            }
                            finProceso = true;
                        }
                        else
                        {
                            Console.WriteLine("Ingresaste un numero diferente a 5 digitos.\nPresione una tecla para continuar.");
                            Console.ReadKey();
                        }
                    } while (finProceso == false);
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
