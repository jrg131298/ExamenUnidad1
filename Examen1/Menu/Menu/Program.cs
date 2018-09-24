using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenorMayor;
using SucesionInvertida;
using NumeroMenor;
using UltimaOcurrenciaDelMayor;
using PrimeraOcurrenciaDelMayor;
using OrdenamientoDeNumerosRandom;
using MayorASuPredecesor;
using Palindromo;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finPrograma = false, salir = false, finDesicion = false;
            Int16 opcion = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------MENU-----------------------");
                    Console.WriteLine("Ingresa el numero de la opcion que desee: ");
                    Console.WriteLine("0.- Salida");
                    Console.WriteLine("1.- Valor menor y mayor de una sucecion S1,...,Sn");
                    Console.WriteLine("2.- Invertir sucesion S1,...,Sn");
                    Console.WriteLine("3.- Indice de la ultima ocurrencia del elemento mas grande de una sucesion S1,...,Sn");
                    Console.WriteLine("4.- Elemento menor entre a, b y c");
                    Console.WriteLine("5.- Indice de la primera ocurrencia del elemento mas grande de una sucesion S1,...,Sn");
                    Console.WriteLine("6.- Indice del primer elemento que es mayor a si predecesor de una sucesion S1,...,Sn");
                    Console.WriteLine("7.- Ordenamiento de numeros random");
                    Console.WriteLine("8.- Palindromo");
                    Console.Write("R: ");
                    try
                    {
                        opcion = Convert.ToInt16(Console.ReadLine());
                        switch (opcion)
                        {
                            case 0:
                                finPrograma = true;
                                break;
                            case 1:
                                Programa1 p1 = new Programa1();
                                finPrograma = p1.Proceso();
                                break;
                            case 2:
                                Programa2 p2 = new Programa2();
                                finPrograma = p2.Proceso();
                                break;
                            case 3:
                                Programa3 p3 = new Programa3();
                                finPrograma = p3.Proceso();
                                break;
                            case 4:
                                Programa4 p4 = new Programa4();
                                finPrograma = p4.Proceso();
                                break;
                            case 5:
                                Programa5 p5 = new Programa5();
                                finPrograma = p5.Proceso();
                                break;
                            case 6:
                                Programa6 p6 = new Programa6();
                                finPrograma = p6.Proceso();
                                break;
                            case 7:
                                Programa7 p7 = new Programa7();
                                finPrograma = p7.Proceso();
                                break;
                            case 8:
                                Programa8 p8 = new Programa8();
                                finPrograma = p8.Proceso();
                                break;
                            default:
                                Console.WriteLine("Ingresaste un valor fuera del rango.\nPresione una tecla para continuar.");
                                Console.ReadKey();
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("A ocurrido un error, intente de nuevo.\nPresione una tecla para continuar.");
                        Console.ReadKey();
                    }
                    finally
                    { }
                } while (finPrograma == false);


                do
                {
                    Console.Clear();
                    try
                    {
                        if (opcion == 0)
                        {
                            Console.WriteLine("Esta seguro que desea salir del programa?");
                            Console.WriteLine("1.- Si");
                            Console.WriteLine("2.- No");
                        }
                        else
                        {
                            Console.WriteLine("Elige una opcion:");
                            Console.WriteLine("1.- Salir del programa");
                            Console.WriteLine("2.- Regresar al menu");
                        }
                        Console.Write("Introduzca el numero de la opcion: ");
                        opcion = Convert.ToInt16(Console.ReadLine());

                        if (opcion == 2)
                        {
                            finDesicion = true;
                        }
                        else if (opcion == 1)
                        {
                            salir = true;
                            finDesicion = true;
                        }
                        else
                        {
                            Console.WriteLine("Ingresaste un valor diferente.\nPresione una tecla para continuar.");
                            Console.ReadKey();
                            finDesicion = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("A ocurrido un error, intente de nuevo.\nPresione una tecla para continuar.");
                        Console.ReadKey();
                        finDesicion = false;
                    }
                    finally { }
                } while (finDesicion == false);
            } while (salir == false);

            
            Console.Write("Presione una tecla para finalizar el programa.");
            Console.ReadKey();
        }
    }
}