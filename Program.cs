using Ejercicio_Aplicada.Tarea1;
using Ejercicio_Aplicada.Tarea2;
using Ejercicio_Aplicada.Tarea3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3;

namespace Ejercicio_Aplicada
{ 

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int opcion = 0;
            Console.WriteLine("1.Menu de la tarea 1");
            Console.WriteLine("2.Menu de la Tarea 2");
            Console.WriteLine("3.Debug en el Factorial");
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
                case 3:
                    Console.Clear();
                    Factorial factorials = new Factorial();
                    break;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        
        }
      
     
    }
}