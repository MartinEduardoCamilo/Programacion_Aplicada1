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
            factorial *= 1;
        }
        Console.WriteLine("El resultado es: ", factorial);
	}
}
