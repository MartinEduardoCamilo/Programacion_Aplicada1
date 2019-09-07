using Ejercicio_Aplicada.Tarea1;
using Ejercicio_Aplicada.Tarea2;
using System;

namespace Ejercicio_Aplicada
{ 

    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("1.Menu de la tarea 1");
            Console.WriteLine("2.Menu de la Tarea 2");
            Console.WriteLine("\nEliga una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Menu m = new Menu();
                    break;
                case 2:
                    Console.Clear();
                    MenuTarea2 menuTarea2 = new MenuTarea2();
                    break;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
            
   
        }
    }
}