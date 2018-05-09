using System;

namespace P1E21
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 21
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
            decimal _pesoPescado = 0m;
            decimal _menor = 0m;
            decimal _mayor = 0m;
            
            string _nuevoPescado = "S";


            // Operaciones
            while (_nuevoPescado.ToUpper() == "S")
            {
                Console.WriteLine("PESO DEL PESCADO");

                Console.Write("\nIngrese el peso del pescado en gramos: ");
                if (decimal.TryParse(Console.ReadLine(), out _pesoPescado) && _pesoPescado >= 0)
                {
                    if (_pesoPescado > _mayor)
                    {

                        if (_mayor > _menor)
                        {
                            _menor = _mayor;
                            _mayor = _pesoPescado;
                        }

                        else
                        {
                            _mayor = _pesoPescado;

                        } // if
                    }

                    else if (_pesoPescado > _menor && _pesoPescado < _mayor)
                    {
                        _menor = _pesoPescado;

                    } // if
                }

                else
                {
                    Console.WriteLine("\nERROR: Introduzca un caracter numerico valido.");

                } // if

                Console.WriteLine("\nPara agregar mas pescado presione [S].\nPara terminar presione cualquier tecla.");
                Console.WriteLine();
                _nuevoPescado = Console.ReadLine();

            } // while

            Console.WriteLine($"\nLos pescados de {_mayor}Gr. y {_menor}Gr. son los dos mas pesados");
            Console.ReadKey();
        }
    }
}
