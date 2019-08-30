using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class PromedioGrupoPersona
    {
        public PromedioGrupoPersona()
        {
            Console.WriteLine("Digite la cantidad de personas que contiene el grupo");
            int cantidaddePersonas = Convert.ToInt32(Console.ReadLine());
            int Mayoredad = 0;
            int Menoredad = 9999;
            int edad;
            int Acumulador = 0;
            int promedio = 0;
            for (int i = 1; i <= cantidaddePersonas; i++)
            {
                Console.WriteLine("Edad de Persona: {0}", i);
                edad = Convert.ToInt32(Console.ReadLine());

                Acumulador += edad;

                if (Mayoredad < edad)
                {
                    Mayoredad = edad;
                }
                   
                if (Menoredad > edad)
                {
                    Menoredad = edad;;
                }
                    
            }

            promedio =  Acumulador / cantidaddePersonas;
    

            Console.WriteLine("Mayor es: {0}", Mayoredad);
            Console.WriteLine("Menor es: {0}", Menoredad);
            Console.WriteLine("Promedio: {0}", promedio);

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }
    }
}
