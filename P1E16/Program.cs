using System;

namespace P1E16
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 16
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
            decimal _num1 = 0m;
            decimal _num2 = 0m;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("Ingrese dos numeros enteros.");

                Console.Write("\nIngrese el primero: ");
                if (decimal.TryParse(Console.ReadLine(), out _num1))
                {
                    if (_num1 >= 0)
                    {
                        Console.Write("\nIngrese el segundo: ");
                        if (decimal.TryParse(Console.ReadLine(), out _num2))
                        {
                            if (_num2 >= 0)
                            {
                                Console.WriteLine();

                                Console.WriteLine($"\nSuma, resta, multiplicacion y division entre {_num1} y {_num2}:");
                                Console.WriteLine($"\nSuma = {_num1 + _num2}");
                                Console.WriteLine($"\nResta = {_num1 - _num2} ({_num1} - {_num2})");
                                Console.WriteLine($"\nResta Conmutativa = {_num2 - _num1} ({_num2} - {_num1})");
                                Console.WriteLine($"\nMultiplicacion = {_num1 * _num2}");


                                try
                                {
                                    Console.WriteLine($"\nDivision = {_num1 / _num2} / Resto = {_num1 % _num2}");
                                }

                                catch (DivideByZeroException)
                                {
                                    Console.WriteLine("\nNo se puede dividir en cero.");

                                } // try
                                
                                try
                                {
                                    Console.WriteLine($"\nDivision Conmutativa = {_num2 / _num1} / Resto = {_num2 % _num1}");
                                }

                                catch (DivideByZeroException)
                                {
                                    Console.WriteLine("\nNo se puede realizar la Division Conmutativa dividiendo en cero.");

                                } // try


                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                            }

                            else if (_num2 < 0)
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

                    else if (_num1 < 0)
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
