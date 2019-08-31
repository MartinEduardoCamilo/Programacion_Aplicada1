using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class Comparacion
    {
        public Comparacion() { }

        public void ParImpar()
        {
            Console.WriteLine("Introduzca un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es Impar");

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }

        public void Diasemana()
        {
            Console.WriteLine("Numero de semana: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("No hay un dia de la semana con el Numero: " + numero);
                    break;
            }

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }
    }
}
