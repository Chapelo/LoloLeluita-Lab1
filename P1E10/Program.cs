using System;

namespace P1E10
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 10
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
            int _num = 0;
            int _numMenor = int.MaxValue;
            int _numMayor = int.MinValue;

            Random _generador = new Random();
            
            Console.Clear();


            // Operaciones
            Console.WriteLine("Se determinara que numero es mayor y menor de los siguientes 20 numeros aleatorios:");

            for (int _i = 1; _i <= 20; _i++)
            {
                _num = _generador.Next(201);
                Console.WriteLine($"\n{_num}");

                _numMayor = Math.Max(_numMayor, _num);
                _numMenor = Math.Min(_numMenor, _num);

            } // for


            Console.WriteLine($"\nEl numero mayor es {_numMayor} y el menor es {_numMenor}.");

            Console.ReadKey();

        }
    }
}
