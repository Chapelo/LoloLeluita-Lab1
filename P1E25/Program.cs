using System;

namespace P1E25
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 25
         * 
         * Appelido y nombre:   Chiappelo Bruno
         * DNI:                 40217247
         * 
         */


        /// <summary>
        /// Conversion de grados Celcius a Fahrenheit
        /// </summary>
        /// <param name="_celsius"></param>
        /// <returns></returns>
        public static decimal conversor(decimal _celsius)
        {
            // Variables
            decimal _resultado = 0;

            // Operaciones
            _resultado = _celsius * (9m / 5m) + 32;

            // Retorno
            return _resultado;

        } // funcion


        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            string _deporte = "";

            decimal _celsius = 0;
            decimal _fahrenheit = 0;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();
                Console.WriteLine("Se determinara cual es el deporte mas apropiado dependiendo de la temperatura ingresada en grados Celsius.");

                Console.Write("\nIngrese la cantidad de grados Celsius a convertir en Farenheit: ");
                if (decimal.TryParse(Console.ReadLine(), out _celsius) && _celsius >= 0)
                {
                    _fahrenheit = conversor(_celsius);

                    if (_fahrenheit > 85)
                    {
                        _deporte = "Natacion";
                    }

                    else if (_fahrenheit > 35 && _fahrenheit <= 70)
                    {
                        _deporte = "Golf";
                    }

                    else if (_fahrenheit > 32 && _fahrenheit <= 35)
                    {
                        _deporte = "Esqui";
                    }

                    else if (_fahrenheit > 70 && _fahrenheit <= 85)
                    {
                        _deporte = "Tenis";
                    }

                    else
                    {
                        _deporte = "otros deportes";

                    } // if
                    
                    Console.WriteLine($"\nLa temperatura de {_fahrenheit} grados Fahrenheit es ideal para realizar {_deporte}.");
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
