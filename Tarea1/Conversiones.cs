using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.Tarea1
{
    class Conversiones
    {
        public Conversiones() { }

        public void GradoRadianes()
        {
            double grados, radianes;
            Console.WriteLine("Ingrese los grados a convertir a radianes: ");
            grados = Convert.ToDouble(Console.ReadLine());
            radianes = grados * (Math.PI / 180);
            Console.WriteLine("La cantidad de radianes son: {0} ", radianes);

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();

        }

        public void Temperatura()
        {
            float celsius;
            Console.WriteLine("Convertir de Grado C a grado F");
            Console.WriteLine("Ingrese la temperatura Celsius");
            celsius = Convert.ToSingle(Console.ReadLine());
            celsius = (celsius * 1.8f) + 32;
            Console.WriteLine("La temperatura en grado Farenheit es: {0}", celsius);

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }

        public void Divisas()
        {
            float dolares;
            const float tasaEuro = 0.91f;
            float cambio = 0;
            Console.WriteLine("Digite la cantidad de Dolares que desea convertir a Euros");
            dolares = Convert.ToSingle(Console.ReadLine());
            cambio = dolares * tasaEuro;
            Console.WriteLine("La conversion es igual a: {0}", cambio);

            Console.WriteLine("Presione una tecla para Volver el menu");
            Console.ReadKey();// presione una tecla para retornar al menu
            Console.Clear();
            Menu m = new Menu();
        }
    }
}
