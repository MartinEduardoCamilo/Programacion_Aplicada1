using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class OrdenarCadena
    {
        public OrdenarCadena()
        {
            Console.WriteLine("Digite la cadena 1");
            String cadena1 = Console.ReadLine();
            Console.WriteLine("Digite la cadena 2");
            String cadena2 = Console.ReadLine();
            ArrayList array = new ArrayList();
            array.Add(cadena1);
            array.Add(cadena2);
            array.Sort();
            Console.WriteLine("Ordenado: ");
            foreach (String cadena in array)
            {
                Console.WriteLine("{0}", cadena);
            }

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }
    }
  }
