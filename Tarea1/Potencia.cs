using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class Potencia
    {
        public Potencia()
        {
            Console.WriteLine("Digite la base: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite La potencia: ");
            int potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} ^ {1} = {2:N0}", bas, potencia, (int)Math.Pow(bas, potencia));

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }
    }
}
