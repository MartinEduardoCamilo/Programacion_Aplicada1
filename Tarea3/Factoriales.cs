using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Aplicada.Tarea3
{
    public class Factoriales
    {
        public double CalcularFactorial(double numero)
        {
            return numero = (numero < 2) ? numero : numero * CalcularFactorial(numero - 1);
        }
    }
}
