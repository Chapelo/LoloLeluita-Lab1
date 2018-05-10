using System;

namespace P1E4
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 4
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
            decimal _num1 = 0m;
            decimal _num2 = 0m;
            decimal _num3 = 0m;
            bool _cerrarPrograma = false;


            // Operaciones
            while (_cerrarPrograma == false) 
            {
                Console.Clear();

                Console.WriteLine("Ingrese tres numeros.");

                Console.Write("\nIngrese el primero: ");
                if (decimal.TryParse(Console.ReadLine(), out _num1))
                {
                    if (_num1 < 0)
                    {
                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                    }

                    else if (_num1 > 0)
                    {
                        Console.Write("\nIngrese el segundo: ");
                        if (decimal.TryParse(Console.ReadLine(), out _num2))
                        {
                            if (_num2 < 0)
                            {
                                Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                            }

                            else if (_num2 > 0)
                            {
                                Console.Write("\nIngrese el tercero: ");
                                if (decimal.TryParse(Console.ReadLine(), out _num3))
                                {
                                    if (_num3 < 0)
                                    {
                                        Console.WriteLine("\nERROR: Usted ingreso un numero negativo, por favor ingrese un numero positivo.");
                                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                        Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                    }

                                    else if (_num3 > 0)
                                    {
                                        if (_num1 == _num2 && _num1 == _num3)
                                        {
                                            Console.WriteLine("\nERROR: Usted ingreso 3 numeros iguales, por favor ingrese numeros distintos.");
                                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                            Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                        }

                                        else if (_num1 == _num2 && _num1 != _num3)
                                        {
                                            if (_num1 > _num3)
                                            {
                                                Console.WriteLine($"\nEl numero {_num1} es mayor que {_num3}");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                            }

                                            else
                                            {
                                                Console.WriteLine($"\nEl numero {_num3} es mayor que {_num1}");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                            } // if

                                        } // else if

                                        else if (_num2 == _num3 && _num2 != _num1)
                                        {
                                            if (_num2 > _num1)
                                            {
                                                Console.WriteLine($"\nEl numero {_num2} es mayor que {_num1}");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                            }

                                            else
                                            {
                                                Console.WriteLine($"\nEl numero {_num1} es mayor que {_num2}");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                            } // if

                                        } // else if

                                        else if (_num3 == _num1 && _num3 != _num2)
                                        {
                                            if (_num3 > _num2)
                                            {
                                                Console.WriteLine($"\nEl numero {_num3} es mayor que {_num2}");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                            }

                                            else
                                            {
                                                Console.WriteLine($"\nEl numero {_num2} es mayor que {_num3}");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                            } // if

                                        } // else if

                                        else
                                        {
                                            if (_num1 > _num2 && _num1 > _num3)
                                            {
                                                //Console.WriteLine("El primer numero ingresado es el mayor.");
                                                Console.WriteLine($"\nEl numero {_num1} es mayor que {_num2} y {_num3}.");
                                                Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                            }

                                            else
                                            {
                                                if (_num2 > _num1 && _num2 > _num3)
                                                {
                                                    //Console.WriteLine("El segundo numero ingresado es el mayor.");
                                                    Console.WriteLine($"\nEl numero {_num2} es mayor que {_num1} y {_num3}.");
                                                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                    Console.WriteLine("\nPrecione una tecla para reiniciar.");
                                                }

                                                else
                                                {
                                                    if (_num3 > _num1 && _num3 > _num2)
                                                    {
                                                        //Console.WriteLine("El tercer numero ingresado es el mayor.");
                                                        Console.WriteLine($"\nEl numero {_num3} es mayor que {_num1} y {_num2}.");
                                                        Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                                        Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                                    } // if

                                                } // if

                                            } // if

                                        } // if

                                    }
                                    

                                }

                                else
                                {
                                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
                                    Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                                    Console.WriteLine("\nPrecione una tecla para reiniciar.");

                                } //if

                            }
                            

                            
                        }

                        else
                        {
                            Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
                            Console.WriteLine("\nPresione Escape (esc) para cerrar el programa.");
                            Console.WriteLine("\nPrecione una tecla para reiniciar.");

                        } // if

                    }
                }
                
                else
                {
                    Console.WriteLine("\nERROR: Ingrese un caracter numerico valido.");
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
