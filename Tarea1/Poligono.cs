using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class Poligono
    {
        public Poligono() { }

    
        public void Perimetro()
        {
            int numeroLados;
            float perimetro, longitud;
            Console.WriteLine("Ingrese la logintud del lado: ");
            longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de lados: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());
            perimetro = numeroLados * longitud;
            Console.WriteLine("El perimetro es {0}: ", perimetro);
 
        }

        public void AreayPerimetro()
        {
            int opc;
            float perimetro;
            Console.WriteLine("1. Calcular Perimetro");
            Console.WriteLine("2. Calcular Area");
            Console.WriteLine("3.Volver al Menu");
            Console.WriteLine("Elija lo que desea calcular");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    float longitudLado;
                    int numeroLado;
                    Console.WriteLine("Digite la longitud del lado: ");
                    longitudLado = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad del lado: ");
                    numeroLado = Convert.ToInt32(Console.ReadLine());
                    perimetro = longitudLado * numeroLado;
                    Console.WriteLine("El perimetro es: {0}", perimetro);

                    Console.WriteLine("Presione una tecla para Volver el menu");
                    Console.ReadKey();// presione una tecla para retornar el metodo
                    Console.Clear();
                    AreayPerimetro();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite el Perimetro: ");
                    perimetro = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Digite el Apotema: ");
                    float apotema = Convert.ToSingle(Console.ReadLine());
                    float area = apotema * perimetro;
                    Console.WriteLine("El Area del poligono es: {0}", area);

                    Console.WriteLine("Presione una tecla para Volver el menu");
                    Console.ReadKey();// presione una tecla para retornar el metodo
                    Console.Clear();
                    AreayPerimetro();
                    break;

                case 3:
                    Console.WriteLine("Presione una tecla para Volver el menu");
                    Console.ReadKey();// presione una tecla para retornar al menu
                    Console.Clear();
                    Menu m = new Menu();
                    break;

                default:
                    Console.WriteLine("Opcion no Validad");
                    break;
            }
        }
    }
}
