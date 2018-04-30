using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tecnicatura Superior En Programacion
 * Laboratorio 1 Com. 2
 * 
 * Trabajo Pactico:     N° 1
 * Ejercicio:           N° 4
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */


namespace P1E4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _num1 = 0m;
            decimal _num2 = 0m;
            decimal _num3 = 0m;
            bool _bandera = false;


            // Operaciones
            while (_bandera == false) 
            {
                Console.Clear();

                Console.WriteLine("Ingrese tres numeros.");

                Console.Write("\nIngrese el primero: ");
                if (decimal.TryParse(Console.ReadLine(), out _num1))
                {
                    Console.Write("\nIngrese el segundo: ");
                    if (decimal.TryParse(Console.ReadLine(), out _num2))
                    {
                        Console.Write("\nIngrese el tercero: ");
                        if (decimal.TryParse(Console.ReadLine(), out _num3))
                        {
                            if (_num1 > _num2 && _num1 > _num3)
                            {
                                //Console.WriteLine("El primer numero ingresado es el mayor.");
                                Console.WriteLine($"\nEl numero {_num1} es mayor que {_num2} y {_num3}.");
                                Console.WriteLine("\nPresione una tecla para reiniciar");
                            }

                            else
                            {
                                if (_num2 > _num1 && _num2 > _num3)
                                {
                                    //Console.WriteLine("El segundo numero ingresado es el mayor.");
                                    Console.WriteLine($"\nEl numero {_num2} es mayor que {_num1} y {_num3}.");
                                    Console.WriteLine("\nPresione una tecla para reiniciar");
                                }

                                else
                                {
                                    if (_num3 > _num1 && _num3 > _num2)
                                    {
                                        //Console.WriteLine("El tercer numero ingresado es el mayor.");
                                        Console.WriteLine($"\nEl numero {_num3} es mayor que {_num1} y {_num2}.");
                                        Console.WriteLine("\nPresione una tecla para reiniciar");

                                    } // if

                                } // if
                                
                            } // if
                            
                        }

                        else
                        {
                            Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
                            Console.WriteLine("\nPresione una tecla para reiniciar");

                        } //if
                    }

                    else
                    {
                        Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
                        Console.WriteLine("\nPresione una tecla para reiniciar");

                    } // if

                }
                
                else
                {
                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
                    Console.WriteLine("\nPresione una tecla para reiniciar");

                } // if
                
                Console.ReadKey();

            } // while
            
            
        }
    }
}
