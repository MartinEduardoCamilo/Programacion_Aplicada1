using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class Imprimir
    {
   
        public Imprimir()
        {
           
            Console.WriteLine("Martin E. Camilo de la Cruz");
            Console.WriteLine("Halo!");

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
           
        }
    }
}
