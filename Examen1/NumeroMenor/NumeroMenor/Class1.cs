using System;

namespace NumeroMenor
{
    public class Programa4
    {
        private string[] letraNumero = new string[3];
        private int posicionMenor;
        private double numero, menor;
        private bool finProceso = false;
        public bool Proceso()
        {
            letraNumero[0] = "a";
            letraNumero[1] = "b";
            letraNumero[2] = "c";
            do
            {
                Console.Clear();
                Console.WriteLine("4.- Elemento menor entre a, b y c");
                try
                {
                    for(int contador = 0; contador < 3; contador++)
                    {
                        Console.Write("{0}.- Ingresa un numero: ", (contador + 1));
                        numero = Convert.ToDouble(Console.ReadLine());
                        if (contador == 0)
                        {
                            posicionMenor = contador;
                            menor = numero;
                        }
                        else
                        {
                            if(numero < menor)
                            {
                                posicionMenor = contador;
                                menor = numero;
                            }
                            else { }
                        }
                    }
                    Console.WriteLine("El numero {0} = {1} es el menor.", letraNumero[posicionMenor], menor);
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