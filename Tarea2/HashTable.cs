using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class HashTable
    {
        public HashTable()
        {
            Hashtable diccionario = new Hashtable();
            Console.WriteLine("Digite la cantidad de palabras que quiere agregar:");
            int j = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Digite la palabra: ");
                String palabra = Console.ReadLine();
                Console.WriteLine("Digite la definición ");
                String definicion = Console.ReadLine();
                diccionario.Add(palabra, definicion);
            }
           
            foreach (DictionaryEntry d in diccionario)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
    }
}
