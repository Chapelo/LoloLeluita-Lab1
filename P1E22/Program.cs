using System;

namespace P1E22
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 22
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
            string _nombre = "";

            int _tipoTrabajador = 0;
            int _cantidadHijos = 0;

            decimal _tipoV = 0.10m;
            decimal _tipoG = 0.15m;
            decimal _tipoE = 0.20m;
            decimal _tipoO = 0.30m;
            decimal _sueldo = 0m;
            decimal _sueldoFinal = 0m;
            decimal _aumento = 0m;
            decimal _sueldoPorHijos = 0m;
            decimal _aumentoHijo = 5m;
            decimal _porcentajeFinal = 0m;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA DE AUMENTOS");

                Console.Write("\nIngrese su nombre: ");
                _nombre = Console.ReadLine();

                Console.Write("\nIngrese su sueldo actual: ");
                if (decimal.TryParse(Console.ReadLine(), out _sueldo))
                {
                    if (_sueldo > 0)
                    {
                        Console.Write("\nElija el numero de tipo de trabajador ( 1-V / 2-G / 3-E / 4-O ): ");
                        if (int.TryParse(Console.ReadLine(), out _tipoTrabajador) && _tipoTrabajador >= 1 && _tipoTrabajador <= 4)
                        {
                            Console.WriteLine($"\nIngrese la cantidad de hijos que tiene {_nombre}: ");
                            if (int.TryParse(Console.ReadLine(), out _cantidadHijos) && _cantidadHijos >= 0)
                            {
                                if (_tipoTrabajador == 1)
                                {
                                    _aumento = _tipoV *_sueldo;
                                    _sueldoPorHijos = ((_aumentoHijo * _cantidadHijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _cantidadHijos);
                                    _sueldoFinal = (_aumento * _sueldoPorHijos) + _sueldo;

                                }
                                else if (_tipoTrabajador == 2)
                                {
                                    _aumento =_tipoG * _sueldo;
                                    _sueldoPorHijos = ((_aumentoHijo * _cantidadHijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _cantidadHijos);
                                    _sueldoFinal = (_aumento * _sueldoPorHijos) + _sueldo;

                                }
                                else if (_tipoTrabajador == 3)
                                {
                                    _aumento = _tipoE * _sueldo;
                                    _sueldoPorHijos = ((_aumentoHijo * _cantidadHijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _cantidadHijos);
                                    _sueldoFinal = (_aumento * _sueldoPorHijos) + _sueldo;

                                }
                                else if (_tipoTrabajador == 4)
                                {
                                    _aumento = _tipoO * _sueldo;
                                    _sueldoPorHijos = ((_aumentoHijo * _cantidadHijos) / 100) + 1;
                                    _porcentajeFinal = (_aumentoHijo * _cantidadHijos);
                                    _sueldoFinal = (_aumento * _sueldoPorHijos) + _sueldo;

                                } // if

                                Console.Clear();
                                Console.WriteLine("Informacion del trabajador");

                                Console.WriteLine($"\nNombre:\t{_nombre}");
                                Console.WriteLine($"\nAumento del sueldo:\t{_aumento}");
                                Console.WriteLine($"\nAumento por hijo:\t{_porcentajeFinal}%");
                                Console.WriteLine($"\nSueldo final:\t{_sueldoFinal}");

                                Console.WriteLine();
                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                            }

                            else
                            {
                                Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                Console.WriteLine("\nPrecione una tecla para reiniciar.");

                            } // if

                        }

                        else
                        {
                            Console.WriteLine("\nERROR: Introduzca un caracter numerico valido ( 1 / 2 / 3 / 4 ).");
                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                            Console.WriteLine("\nPrecione una tecla para reiniciar.");

                        } // if
                    }

                    else if (_sueldo == 0)
                    {
                        Console.WriteLine("\nERROR: Introduzca un caracter numerico mayor que cero.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

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

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);

                } // if

            } // while
        }
    }
}
