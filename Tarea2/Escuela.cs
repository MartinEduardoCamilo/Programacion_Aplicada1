using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class Escuela
    {
        public Escuela()
        {
            int cantidadEstudiantes = 0, cantidadSalones = 0;
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.Write("\nDigite la cantidad de salones: ");
            cantidadSalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[cantidadSalones][];

            for (int i = 0; i < cantidadSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);

                cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[cantidadEstudiantes];
            }

            for (int i = 0; i < cantidadSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n ", i + 1);
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion del estudiante: {0} ", 1 + j);
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (int i = 0; i < cantidadSalones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    suma += calificaciones[i][j];

                }
            }
            promedio = suma / (cantidadEstudiantes * cantidadSalones);
            Console.WriteLine("\nEl promedio es: {0}\n", promedio);
        }
    }
}
