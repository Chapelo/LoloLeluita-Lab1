using System;

namespace P1E26
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 26
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
            decimal _hsTrabajadas = 0m;
            decimal _hsExtra = 0m;
            decimal _liquidacion = 0m;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA DEL SALARIO SEMANAL DE UN OBRERO");

                Console.Write("\nIngrese las horas trabajadas durante la semana:\t");
                if (decimal.TryParse(Console.ReadLine(), out _hsTrabajadas) && _hsTrabajadas > 0)
                {
                    if (_hsTrabajadas <= 40)
                    {
                        _liquidacion = _hsTrabajadas * 20;
                    }

                    else
                    {
                        _hsExtra = _hsTrabajadas % 40;
                        _hsTrabajadas = _hsTrabajadas - _hsExtra;

                        _liquidacion = (_hsTrabajadas * 20) + (_hsExtra * 25);

                    } // if

                    Console.WriteLine($"\nHoras trabajadas:\t\t{_hsTrabajadas}hs");
                    Console.WriteLine($"Su salario semanal sera de:\t${_liquidacion}");

                    Console.WriteLine("\n\nPresione Escape (esc) para cerrar el programa.");
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
                    _cerrarPrograma = true;

                } // if

            } // while
        }
    }
}
