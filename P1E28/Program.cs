using System;

namespace P1E28
{
    class Program
    {
        /*
         * Tecnicatura Superior En Programacion
         * Laboratorio 1 Com. 2
         * 
         * Trabajo Pactico:     N° 1
         * Ejercicio:           N° 28
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
            int _contadorGalvez = 0;
            int _contadorOsde = 0;
            int _contadorSinObraSocial = 0;
            int _cantidadProducto = 0;
            int _opcionDeObraSocial = 0;
            
            decimal _totalGalvez = 0m;
            decimal _totalOsde = 0m;
            decimal _totalSinObraSocial = 0m;
            decimal _precioProducto = 0;
            decimal _subTotal = 0;
            decimal _montoDescuento = 0;
            decimal _porcentajeDescuento = 0;

            string _nuevaVenta = "S";
            bool _validacion = false;
            

            // Operaciones
            while (_nuevaVenta.ToUpper() == "S")
            {
                Console.Clear();

                _validacion = false;
                while (!_validacion)
                {
                    Console.Write("Ingrese el monto del producto: ");
                    if (decimal.TryParse(Console.ReadLine(), out _precioProducto) && _precioProducto > 0)
                    {
                        _validacion = true;

                    } // if

                } // while

                _validacion = false;
                while (!_validacion)
                {
                    Console.Write("\nIngrese la cantidad del producto: ");
                    if (int.TryParse(Console.ReadLine(), out _cantidadProducto) && _cantidadProducto > 0)
                    {
                        _validacion = true;

                    } // if

                } // while

                _validacion = false;
                while (!_validacion)
                {
                    Console.Write("\nIngrese la opcion de venta [1- GALVEZ / 2- OSDE / 3- SIN OBRA SOCIAL]:  ");
                    if (int.TryParse(Console.ReadLine(), out _opcionDeObraSocial) && _opcionDeObraSocial >0 && _opcionDeObraSocial <= 3)
                    {
                        _validacion = true;

                    } // if

                } // while

                switch (_opcionDeObraSocial)
                {
                    case 1:
                        _porcentajeDescuento = 0.20m;
                        _subTotal = (_precioProducto * _cantidadProducto);
                        _montoDescuento = (_subTotal * _porcentajeDescuento);

                        _totalGalvez += (_subTotal - _montoDescuento);
                        _contadorGalvez++;
                        break;

                    case 2:
                        _porcentajeDescuento = 0.30m;
                        _subTotal = (_precioProducto * _cantidadProducto);
                        _montoDescuento = (_subTotal * _porcentajeDescuento);

                        _totalOsde += (_subTotal - _montoDescuento);
                        _contadorOsde++;
                        break;

                    case 3:

                        _totalSinObraSocial += (_precioProducto * _cantidadProducto);
                        _contadorSinObraSocial++;
                        break;

                    default:
                        break;

                } // switch


                Console.Write("\nPara agregar mas pescado presione [S].\nPara terminar presione cualquier tecla.");
                _nuevaVenta = Console.ReadLine();
            }

            

            Console.Clear();

            Console.WriteLine($"\n\tTotal Galvez: ${_totalGalvez} - Cant. Ventas: {_contadorGalvez}");
            Console.WriteLine($"\tTotal Osde: ${_totalOsde} - Cant. Ventas: {_contadorOsde}");
            Console.WriteLine($"\tTotal Sin Obra Social: ${_totalSinObraSocial} - Cant. Ventas: {_contadorSinObraSocial}");

            
            Console.WriteLine("\nPrecione una tecla para cerrar el programa.");
            Console.ReadKey();
            
        }
    }
}
