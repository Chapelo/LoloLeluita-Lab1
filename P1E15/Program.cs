using System;

namespace P1E15
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 15
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
            decimal _precio = 0m;
            decimal _monto = 0m;
            decimal _vuelto = 0m;
            decimal _descuento = 0m;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE COMPRA");

                Console.Write("\nIngrese el valor total de la venta: ");
                if (decimal.TryParse(Console.ReadLine(), out _precio))
                {
                    if (_precio > 0)
                    {
                        Console.Write("\nIngrese el monto que se pago: ");
                        if (decimal.TryParse(Console.ReadLine(), out _monto))
                        {
                            if (_monto > 0)
                            {
                                if (_precio > _monto)
                                {
                                    _descuento = (100 - ((_monto * 100) / _precio));
                                    Console.WriteLine($"\nSe pago con un descuento del {_descuento}%");
                                    Console.WriteLine("\nPresione Escape (esc) para cerrar el sistema de compras.");
                                    Console.WriteLine("\nPrecione una tecla para realizar otra compra.");

                                }

                                else if (_precio < _monto)
                                {
                                    _vuelto = (_monto - _precio);
                                    Console.WriteLine($"\nEl vuelto es de ${_vuelto}");
                                    Console.WriteLine("\nPresione Escape (esc) para cerrar el sistema de compras.");
                                    Console.WriteLine("\nPrecione una tecla para realizar otra compra.");

                                } // if
                            }

                            else if (_monto < 0)
                            {
                                Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                                Console.WriteLine("\nPresione Escape (esc) para cerrar el sistema de compras.");
                                Console.WriteLine("\nPrecione una tecla para realizar otra compra.");

                            } // if
                        }

                        else
                        {
                            Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                            Console.WriteLine("\nPresione Escape (esc) para cerrar el sistema de compras.");
                            Console.WriteLine("\nPrecione una tecla para realizar otra compra.");

                        } // if
                    }
                    
                    else if (_precio < 0)
                    {
                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el sistema de compras.");
                        Console.WriteLine("\nPrecione una tecla para realizar otra compra.");

                    } // if
                }

                else
                {
                    Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el sistema de compras.");
                    Console.WriteLine("\nPrecione una tecla para realizar otra compra.");

                } // if

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);

                } // if

            } // While
        }
    }
}
