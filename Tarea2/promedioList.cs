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
            float calificacion = 0f;
            int i = 0;
            float promedio = 0f;
            float maxima = 0f;
            float minima = 100f;
            int salida = 0; ;

            Console.WriteLine("Cuando Desee terminar de agregar notas , digite -1\n");
            do
            {
                Console.WriteLine("Digite la calificacion del estudiante: {0}", i + 1);
                calificacion = Convert.ToSingle(Console.ReadLine());
                //Aqui determinamos la calificacion mas alta y la mas pequeña
                if (maxima < calificacion)
                    maxima = calificacion;
                if (minima > calificacion && calificacion != -1)
                    minima = calificacion;
                if (calificacion == -1)
                    salida = Convert.ToInt32(calificacion);
                else
                    calificaciones.Add(calificacion);
                i++;

            } while (salida != -1);
            //Creamos un ForEach para imprimir todos los elementos dentro del ArrayList.
            foreach (float n in calificaciones)
            {
                promedio += n;
            }
            //Aca Imprimimos los Resultados.
            Console.WriteLine("El promedio es: " + promedio / calificaciones.Count);
            Console.WriteLine("La nota Maxima es: " + maxima);
            Console.WriteLine("La nota Minima es: " + minima);
        }
    }
}
