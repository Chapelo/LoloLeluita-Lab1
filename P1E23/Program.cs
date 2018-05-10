using System;

namespace P1E23
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 23
         * 
         * Appelido y nombre:   Chiappelo Bruno
         * DNI:                 40217247
         * 
         */

        static void Main(string[] args)
        {


            // Variables
            int _cantidadPizzas = 0;
            decimal _descuento10 = 0.10m;
            decimal _descuento15 = 0.15m;
            decimal _precioPizza = 0m;
            decimal _total = 0m;
            
            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE VENTA -Pizza Especial- DE PIZZERIA ");

                Console.Write("\nIngrese la cantidad de pizzas a vender: ");
                if (int.TryParse(Console.ReadLine(), out _cantidadPizzas) && _cantidadPizzas > 0)
                {
                    
                    Console.Write("\nIngrese el precio unitario de la pizza: $");
                    if (decimal.TryParse(Console.ReadLine(), out _precioPizza) && _precioPizza >=  35 && _precioPizza <= 45)
                    {
                        Console.WriteLine();
                        if (_cantidadPizzas < 3)
                        {
                            _total = (_cantidadPizzas * _precioPizza) - (_cantidadPizzas * _precioPizza * _descuento10 / 100);
                            Console.WriteLine($"\nSe cobran {_cantidadPizzas} pizzas con un 10% de descuento a un total de ${_total}.\n");
                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                            Console.WriteLine("\nPrecione una tecla para reiniciar.");
                        }

                        if (_cantidadPizzas > 3)
                        {
                            _total = (_cantidadPizzas * _precioPizza) - (_cantidadPizzas * _precioPizza * _descuento15 / 100);
                            Console.WriteLine($"\nSe cobran {_cantidadPizzas} pizzas con un 15% de descuento a un total de ${_total}.\n");
                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                            Console.WriteLine("\nPrecione una tecla para reiniciar.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nERROR: Introduzca un precio mayor a $35 y menor a $45.");
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
