﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class MayorCalificacion
    {
        public MayorCalificacion()
        {
            int cantidadestudiantes = 0;
            int cantidadsalones = 0;
            int i = 0;
            int j = 0;
            float Notamaxima = 0;


            Console.Write("\nDigite la cantidad de salones: ");
            cantidadsalones = Convert.ToInt32(Console.ReadLine());

            float[][] calificacion = new float[cantidadsalones][];

            for (i = 0; i < cantidadsalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);
                cantidadestudiantes = Convert.ToInt32(Console.ReadLine());

                calificacion[i] = new float[cantidadestudiantes];
            }

            for (i = 0; i < cantidadsalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calificacion[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    calificacion[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (i = 0; i < cantidadsalones; i++)
            {
                for (j = 0; j < calificacion[i].GetLength(0); j++)
                {
                    if (calificacion[i][j] > Notamaxima)
                    {
                        Notamaxima = calificacion[i][j];
                    }
                }
            }
            Console.WriteLine("\nLa nota mas alta es: {0}\n", Notamaxima);

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            MenuTarea2 m = new MenuTarea2();
        }
    }
}
