using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class promedioList
    {
        public promedioList()
        {
            ArrayList calificaciones = new ArrayList();
            float calificacion = 0;
            int i = 0;
            float promedio = 0;
            float Notamaxima = 0;
            float Notaminima = 100;
            int salida = 0;

            Console.WriteLine("Cuando Desee terminar de agregar notas , digite -1\n");
            do
            {
                Console.WriteLine("Digite la calificacion del estudiante: {0}", i + 1);
                calificacion = Convert.ToSingle(Console.ReadLine());
                
                if (Notamaxima < calificacion)
                    Notamaxima = calificacion;
                if (Notaminima > calificacion && calificacion != -1)
                    Notaminima = calificacion;
                if (calificacion == -1)
                    salida = Convert.ToInt32(calificacion);
                else
                    calificaciones.Add(calificacion);
                i++;

            } while (salida != -1);
            
            foreach (float n in calificaciones)
            {
                promedio += n;
            }
            
            Console.WriteLine("El promedio es: " + promedio / calificaciones.Count);
            Console.WriteLine("La nota Maxima es: " + Notamaxima);
            Console.WriteLine("La nota Minima es: " + Notaminima);



            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }
    }
}
