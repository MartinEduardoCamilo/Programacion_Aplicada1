using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class FechaHora
    {
        public FechaHora()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm tt yyyy/dd/MM"));


            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }

    }
}
