using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Aplicada.tarea3
{
    class Factorial
    {
        public double CalcularFactorial(double numero)
        {
            return numero = (numero < 2) ? numero : numero * CalcularFactorial(numero - 1);
        }
    }
}
