using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea2
{
    class MenuTarea2
    {
        public MenuTarea2()
        {
            int opcion = 0;
            Console.WriteLine("1.Factorial");
            Console.WriteLine("2.Numero a Cadena");
            Console.WriteLine("3.Promedio de un arreglo jagged");
            Console.WriteLine("4.Menor calificación");
            Console.WriteLine("5.Mayor Calificcion");
            Console.WriteLine("6.Modificación  de las funciones de la escuela");
            Console.WriteLine("7.Paremetro Jagged");
            Console.WriteLine("8.Promedio Mayor y menor de la lsita");
            Console.WriteLine("9.Diccionario de palabra");
            Console.WriteLine("10.Agenda Telefónica");
            Console.WriteLine("11.Formato de la Hora del fin del día");
            Console.WriteLine("12.Ordenar las cadenas");

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Factorial factorial = new Factorial();
                    break;
                case 2:
                    Console.Clear();
                    NumeroCadena numeroacadena = new NumeroCadena();
                    break;
                case 3:
                    Console.Clear();
                    Promedio promedio = new Promedio();
                    break;
                case 4:
                    Console.Clear();
                    PromedioMinimo calificacionMinima = new PromedioMinimo();
                    break;
                case 5:
                    Console.Clear();
                    MayorCalificacion calificacionMayor = new MayorCalificacion();
                    break;
                case 6:
                    Console.Clear();
                    Escuela escuela = new Escuela();
                    break;
                case 7:
                    Console.Clear();
                    int[][] a = new int[2][];
                    a[0] = new int[] { 1, 2 };
                    a[1] = new int[] { 3, 4 };
                    Parametro parametro = new Parametro(a);
                    break;
                case 8:
                    Console.Clear();
                    promedioList promedioList = new promedioList();
                    break;
                case 9:
                    Console.Clear();
                    HashTable diccionario = new HashTable();
                    break;
                case 10:
                    Console.Clear();
                    AgendeTelefonica agenda = new AgendeTelefonica();
                    break;
                case 11:
                    Console.Clear();
                    FechaHora fechaHora = new FechaHora();
                    break;
                case 12:
                    Console.Clear();
                    Alfabeto cadenaorden = new Alfabeto();
                    break;

                default:
                    Console.WriteLine("Opción no Valida");
                    break;

            }
        }
    }
}
