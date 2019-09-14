using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class AgendeTelefonica
    {
        public AgendeTelefonica()
        {
            Hashtable agendaHT = new Hashtable();
            Console.WriteLine("Digite la cantidad de personas que quiere agregar a la agenda:");
            int j = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Nombre de la persona: ");
                String nombre = Console.ReadLine();
                Console.WriteLine("Numero de la persona");
                int numero = Convert.ToInt32(Console.ReadLine());
                agendaHT.Add(nombre, numero);
            }

            foreach (DictionaryEntry d in agendaHT)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }
    }
}
