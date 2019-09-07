using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class Parametro
    {
        public Parametro(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.WriteLine("{0}", a[i][j]);
                }
            }

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }
    }
}
