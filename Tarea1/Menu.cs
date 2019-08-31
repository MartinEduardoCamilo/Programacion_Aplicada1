using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class Menu
    {
        public Menu()
        {
            Conversiones C = new Conversiones();
            Poligono P = new Poligono();
            Comparacion comparar = new Comparacion();

            
            //hola
            int opcion;
            Console.WriteLine("1.Imprime mi nombre y el mensaje ya creado");
            Console.WriteLine("2.Calcula el area y perimetro de un poligono");
            Console.WriteLine("3.Coversion de grados a Radianes");
            Console.WriteLine("4.Conversion de grados Celsius a Fahrenheit");
            Console.WriteLine("5.Conversion de Dolar a Euro");
            Console.WriteLine("6.Comparar si un es par o impar");
            Console.WriteLine("7.Dias de la semana");
            Console.WriteLine("8.Area y Perimetro de un Poligono");
            Console.WriteLine("9.Tabla de Multiplicar");
            Console.WriteLine("10.Potencia");
            Console.WriteLine("11.Edad promedio de un grupo de persona");
            Console.WriteLine("12.Salida");
            Console.WriteLine("\nElige una opcion: ");
            
            do
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Imprimir I = new Imprimir();
                        break;

                    case 2:
                        Console.Clear();
                        P.Perimetro();
                        break;

                    case 3:
                        Console.Clear();
                        C.GradoRadianes();
                        break;

                    case 4:
                        Console.Clear();
                        C.Temperatura();
                        break;

                    case 5:
                        Console.Clear();
                        C.Divisas();
                        break;

                    case 6:
                        Console.Clear();
                        comparar.ParImpar();
                        break;

                    case 7:
                        Console.Clear();
                        comparar.Diasemana();
                        break;

                    case 8:
                        Console.Clear();
                        P.AreayPerimetro();
                        break;

                    case 9:
                        Console.Clear();
                        TablaDeMultiplicar T = new TablaDeMultiplicar();
                        break;

                    case 10:
                        Console.Clear();
                        Potencia pot = new Potencia();
                        break;

                    case 11:
                        Console.Clear();
                        PromedioGrupoPersona media = new PromedioGrupoPersona();
                        break;

                    case 12:
                        Console.Clear();
                        int op = 0;
                        Console.WriteLine("Salida del menu presione 1 y sino quiere salir presione el dos");
                        op = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            switch (op)
                            {
                                case 1:
                                    Console.Clear();
                                    Environment.ExitCode;
                                    Console.WriteLine("Gracias por compilar este Codigo");
                                    break;

                                case 2:
                                    Console.Clear();
                                    Menu M = new Menu();
                                    break;

                                default: Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        } while (op > 0 && op < 3);
                        
                        break;

                    default:
                        Console.WriteLine("Opcion No Validad");
                        break;

                }
            } while (opcion > 0 && opcion < 12);
                Console.Clear();
                Menu m = new Menu();
        }
    }
}
