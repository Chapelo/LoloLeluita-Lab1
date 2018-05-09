using System;

namespace P1E13
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 13
         * 
         * Appelido y nombre:   Chiappelo Bruno
         * DNI:                 40217247
         * 
         */

        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            decimal _nota1 = 0;
            decimal _nota2 = 0;
            decimal _nota3 = 0;
            decimal _promedio = 0;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("Ingrese las 3 notas de los parciales.");

                Console.Write("\nEscriba la primera nota: ");
                if (decimal.TryParse(Console.ReadLine(), out _nota1))
                {
                    if (_nota1 > 0 && _nota1 < 11)
                    {
                        Console.Write("\nEscriba la segunda nota: ");
                        if (decimal.TryParse(Console.ReadLine(), out _nota2))
                        {
                            if (_nota2 > 0 && _nota2 < 11)
                            {
                                Console.Write("\nEscriba la tercera nota: ");
                                if (decimal.TryParse(Console.ReadLine(), out _nota3))
                                {
                                    if (_nota3 > 0 && _nota3 < 11)
                                    {
                                        _promedio = (_nota1 + _nota2 + _nota3) / 3;

                                        if (_promedio == 10)
                                        {
                                            Console.WriteLine($"\nSu promedio es {_promedio} (Exelente).");
                                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                            Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                        }

                                        else if (_promedio >= 7 && _promedio < 10)
                                        {
                                            Console.WriteLine($"\nSu promedio es {_promedio} (Muy Bueno).");
                                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                            Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                        }

                                        else if (_promedio >= 4 && _promedio < 7)
                                        {
                                            Console.WriteLine($"\nSu promedio es {_promedio} (Bueno).");
                                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                            Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                        }

                                        else
                                        {
                                            Console.WriteLine($"\nSu promedio es {_promedio} (Regular).");
                                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                            Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                        } // if
                                    }

                                    else if (_nota3 < 0)
                                    {
                                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                    } // if
                                }

                                else
                                {
                                    Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                } // if
                            }

                            else if (_nota2 < 0)
                            {
                                Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                Console.WriteLine("\nPrecione una tecla para reiniciar.");

                            } // if
                        }

                        else
                        {
                            Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                            Console.WriteLine("\nPrecione una tecla para reiniciar.");

                        } // if
                    }

                    else if (_nota1 < 0)
                    {
                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

                    } // if
                }

                else
                {
                    Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                } // if

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);

                } // if

            } // while
        }
    }
}
