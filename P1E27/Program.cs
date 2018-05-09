using System;

namespace P1E27
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 27
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
            decimal _totalVentas = 0;
            decimal _impuestos = 0.25m;
            decimal _gastos = 0;
            decimal _ganancias = 0;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();

                Console.Write("Ingrese el total de las ventas del mes: ");
                if (decimal.TryParse(Console.ReadLine(), out _totalVentas) && _totalVentas >= 0)
                {
                    _gastos = _impuestos * _totalVentas;
                    _ganancias = _totalVentas - _gastos;

                    Console.WriteLine($"\nVentas totales:\t${_totalVentas}");
                    Console.Write($"\nImpuesto mensual(25%):\t${_gastos}");
                    Console.Write($"\nGanancia mensual:\t${_ganancias}");
                }

                else if (_totalVentas == 0)
                {
                    Console.WriteLine("\nNo tuvo ninguna venta en el mes.");
                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                    Console.WriteLine("\nPrecione una tecla para reiniciar.");
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
