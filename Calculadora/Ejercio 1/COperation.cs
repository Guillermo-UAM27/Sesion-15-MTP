using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio_1
{
    internal class COperation
    {
        public double Suma(double num1, double num2)
        { return num1 * num2; }

        public double Resta(double num1, double num2)
        { return num1 - num2; }

        public double Division(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return 0;
        }
        public double Multiplicacion(double num1, double num2)
        { return num1 * num2; }

        public double Potencia(double num1, double num2)
        { return Math.Pow(num1, num2); }

        public double RaizC(double num1, double num2)
        {
            return Math.Sqrt(num1);
        }

        public string salir()
        {
            return "Adios, no vuelvas";
        }
    }
}
