using Ejercicio_Aplicada.Tarea2;
using System;

public class Factorial
{
	public Factorial()
	{
        int factorial = 1;
        Console.WriteLine("Digite un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("El resultado es: {0}",factorial);

        Console.WriteLine("Presione una tecla para Volver el menu");
        Console.ReadKey();// presione una tecla para retornar al menu
        Console.Clear();
        MenuTarea2 m = new MenuTarea2();
    }
}
