using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class Promedio
    {
        public Promedio()
        {
            int cantidadestudiantes = 0;
            int cantidadsalones = 0;
            float suma = 0;
            float promedio = 0;

            Console.Write("\nDigite la cantidad de salones: ");
            cantidadsalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificacion = new float[cantidadsalones][];

            for (int i = 0; i < cantidadsalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes en el salon {0}: ", i + 1);

                cantidadestudiantes = Convert.ToInt32(Console.ReadLine());

                calificacion[i] = new float[cantidadestudiantes];
            }

            for (int i = 0; i < cantidadsalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n ", i + 1);
                for (int j = 0; j < calificacion[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificación del estudiante: {0} ", 1 + j);
                    calificacion[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (int i = 0; i < cantidadsalones; i++)
            {
                for (int j = 0; j < calificacion[i].GetLength(0); j++)
                {
                    suma += calificacion[i][j];

                }
            }
            promedio = suma / (cantidadestudiantes * cantidadsalones);
            Console.WriteLine("\nEl promedio es: {0}\n", promedio);


            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }
    }
}
