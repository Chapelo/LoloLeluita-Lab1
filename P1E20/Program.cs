using System;

namespace P1E20
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 20
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
            int _horasExtras = 0;
            int _sueldoExtra = 0;
            int _categoria = 0;
            decimal _sueldo = 0;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("PAGO DE HORAS EXTRAS");
                
                Console.Write("\nIngrese la cantidad de horas extras trabajadas: ");
                if (int.TryParse(Console.ReadLine(), out _horasExtras))
                {
                    if (_horasExtras > 0)
                    {
                        Console.Write("\nIngrese su sueldo base: ");
                        if (decimal.TryParse(Console.ReadLine(), out _sueldo))
                        {
                            if (_sueldo > 0)
                            {
                                Console.Write("Ingrese su categoria de empleado.\nEliga entre la categoria 1 / 2:  ");
                                if (int.TryParse(Console.ReadLine(), out _categoria))
                                {
                                    if (_categoria > 0 && _categoria < 3)
                                    {
                                        if (_categoria == 1)
                                        {
                                            if (_horasExtras <= 30)
                                            {
                                                _sueldoExtra = _horasExtras * 10;
                                            }

                                            else
                                            {
                                                _sueldoExtra = _horasExtras * 11;

                                            } // if
                                        }

                                        else if (_categoria == 2)
                                        {
                                            if (_horasExtras <= 30)
                                            {
                                                _sueldoExtra = _horasExtras * 14;
                                            }

                                            else
                                            {
                                                _sueldoExtra = _horasExtras * 20;

                                            } // if

                                        } // if
                                    }

                                    else if (_categoria >= 3)
                                    {

                                        Console.WriteLine("\nERROR: Usted ingreso un numero incorrecto, por favor elija entre el numero 1 o 2.");
                                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                    }

                                    else if (_categoria < 0)
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

                            else if (_sueldo < 0)
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

                    else if (_horasExtras < 0)
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
                    _cerrarPrograma = true;

                } // if

            } // while
        }
    }
}
