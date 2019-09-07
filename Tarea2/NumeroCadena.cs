using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class NumeroCadena
    {
        public NumeroCadena()
        {
            int opcion;
            Console.WriteLine("Digite un numero: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Cero");
                    break;
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    break;
                case 7:
                    Console.WriteLine("Siete");
                    break;
                case 8:
                    Console.WriteLine("Ocho");
                    break;
                case 9:
                    Console.WriteLine("Nueve");
                    break;
                default:
                    Console.WriteLine("Debe ser un numero de un digitó");
                    break;
            }
        }
    }
}
