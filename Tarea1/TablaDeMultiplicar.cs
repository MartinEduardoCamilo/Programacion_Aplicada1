using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class TablaDeMultiplicar
    {
        public TablaDeMultiplicar()
        {
            Console.WriteLine("Digite el numero de la tabla que desea observar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int acum;
            for (int i = 1; i <= 10; ++i)
            {
                acum = numero * i;
                Console.WriteLine("{0} * {1} = {2}", numero, i, acum);
            }
            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }
    }
}
