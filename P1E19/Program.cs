using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tecnicatura Superior En Programacion
 * Laboratorio 1 Com. 2
 * 
 * Trabajo Pactico:     N° 1
 * Ejercicio:           N° 19
 * 
 * Appelido y nombre:   Chiappelo Bruno
 * DNI:                 40217247
 * 
 */

namespace P1E19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Color De Consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;


            // Variables
            int _segundos = 0;
            int _minutos = 0;
            int _horas = 0;
            int _auxSegundos = 0;

            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false)
            {
                Console.Clear();

                Console.Write("Ingrese los Segundos que desea convertir a Horas - Minutos - Segundos: ");
                if (int.TryParse(Console.ReadLine(), out _segundos))
                {
                    if (_segundos > 0)
                    {
                        _horas = _segundos / 3600;
                        _minutos = ((_segundos - _horas * 3600) / 60);
                        _auxSegundos = _segundos - (_horas * 3600 + _minutos * 60);
                        Console.WriteLine($"\n {_segundos} segundos, equivale a {_horas} hora(s) ; {_minutos} minuto(s) ; {_auxSegundos} segundo(s).");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else if (_segundos < 0)
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
